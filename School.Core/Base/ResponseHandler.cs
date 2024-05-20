using Microsoft.Extensions.Localization;
using School.Core.SharedResource;

namespace School.Core.Response
{
	public class ResponseHandler
	{
		private readonly IStringLocalizer _localizer;

		public ResponseHandler(IStringLocalizer localizer)
		{
			_localizer = localizer;
		}
		public ResponseRepository<T> Success<T>(T entity, object Meta = null)
		{
			return new ResponseRepository<T>()
			{
				Data = entity,
				StatusCode = System.Net.HttpStatusCode.OK,
				Succeeded = true,
				Message = _localizer[LocalizationKeys.Success],
				Meta = Meta
			};
		}
		public ResponseRepository<T> Deleted<T>()
		{
			return new ResponseRepository<T>()
			{
				StatusCode = System.Net.HttpStatusCode.OK,
				Succeeded = true,
				Message = _localizer[LocalizationKeys.Deleted]
			};
		}
		public ResponseRepository<T> Created<T>(T entity, object Meta = null)
		{
			return new ResponseRepository<T>()
			{
				Data = entity,
				StatusCode = System.Net.HttpStatusCode.Created,
				Succeeded = true,
				Message = _localizer[LocalizationKeys.Created],
				Meta = Meta
			};
		}
		public ResponseRepository<T> AlreadyExist<T>()
		{
			return new ResponseRepository<T>()
			{
				StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
				Succeeded = false,
				Message = _localizer[LocalizationKeys.Exist]
			};
		}
		public ResponseRepository<T> NotFound<T>()
		{
			return new ResponseRepository<T>()
			{
				StatusCode = System.Net.HttpStatusCode.NotFound,
				Succeeded = false,
				Message = _localizer[LocalizationKeys.NotFound]
			};
		}
		public ResponseRepository<T> Unauthorized<T>()
		{
			return new ResponseRepository<T>()
			{
				StatusCode = System.Net.HttpStatusCode.Unauthorized,
				Succeeded = true,
				Message = "UnAuthorized"
			};
		}
		public ResponseRepository<T> BadRequest<T>(string Message = null)
		{
			return new ResponseRepository<T>()
			{
				StatusCode = System.Net.HttpStatusCode.BadRequest,
				Succeeded = false,
				Message = _localizer[LocalizationKeys.BadRequest]
			};
		}
	}
}
