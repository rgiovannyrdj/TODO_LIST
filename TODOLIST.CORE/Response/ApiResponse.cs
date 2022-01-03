using TODOLIST.CORE.Enumerations;

namespace TODOLIST.CORE.Response
{
    public class ApiResponse<T>
    {
        public ApiResponse()
        {
            IsValid = false;
            StatusResponse = StatusResponse.Fail;
            Message = string.Empty;
        }
        public T? Data { get; set; }
        public bool IsValid { get; set; }
        public StatusResponse StatusResponse { get; set; }
        public string Message { get; set; }
        public Exception? Exception { get; set; }
        public void SetException(Exception exepction)
        {
            IsValid = false;
            StatusResponse = StatusResponse.Exception;
            Message = exepction.Message;
            Exception = exepction;
        }
        public void SetFail(string message)
        {
            IsValid = false;
            StatusResponse = StatusResponse.Fail;
            Message = message;
        }
        public void SetSuccess()
        {
            IsValid = true;
            StatusResponse = StatusResponse.Success;
        }
    }
}
