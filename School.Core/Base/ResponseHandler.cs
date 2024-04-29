namespace School.Core.Response
{
	public class ResponseHandler
	{
		public ResponseHandler()
		{

		}
		public ResponseRepository<T> Success<T>(T entity, object Meta = null)
		{
			return new ResponseRepository<T>()
			{
				Data = entity,
				StatusCode = System.Net.HttpStatusCode.OK,
				Succeeded = true,
				Message = "Done Successfully",
				Meta = Meta
			};
		}
		public ResponseRepository<T> Deleted<T>()
		{
			return new ResponseRepository<T>()
			{
				StatusCode = System.Net.HttpStatusCode.OK,
				Succeeded = true,
				Message = "Deleted Successfully"
			};
		}
		public ResponseRepository<T> Created<T>(T entity, object Meta = null)
		{
			return new ResponseRepository<T>()
			{
				Data = entity,
				StatusCode = System.Net.HttpStatusCode.Created,
				Succeeded = true,
				Message = "Created Successfully",
				Meta = Meta
			};
		}
		public ResponseRepository<T> NotFound<T>(string message = null)
		{
			return new ResponseRepository<T>()
			{
				StatusCode = System.Net.HttpStatusCode.NotFound,
				Succeeded = false,
				Message = message == null ? "Not Found" : message
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
				Message = Message == null ? "Bad Request" : Message
			};
		}
	}
}
