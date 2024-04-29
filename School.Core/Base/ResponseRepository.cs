using System.Net;

namespace School.Core.Response
{
	public class ResponseRepository<T>
	{
		public ResponseRepository()
		{

		}
		public ResponseRepository(T data, string message = null)
		{
			Succeeded = true;
			Message = message;
			Data = data;
		}
		public ResponseRepository(string message)
		{
			Succeeded = false;
			Message = message;
		}
		public ResponseRepository(string message, bool succeeded)
		{
			Succeeded = succeeded;
			Message = message;
		}

		public HttpStatusCode StatusCode { get; set; }
		public object Meta { get; set; }
		public bool Succeeded { get; set; }
		public string Message { get; set; }
		public List<string> Errors { get; set; }
		public T Data { get; set; }

	}
}
