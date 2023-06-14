namespace Myproject01.Common.Constants
{
    public class GenericResponse
    {
        public object Data { get; set; } // dữ liệu
        public int Code { get; set; } // 100 -> 500;
        public bool Status { get; set; } // true - false
        public string Message { get; set; } // message

        public GenericResponse()
        {
        }

        public GenericResponse(bool status, int code, string message, object data) : this(status, code, message)
        {
            Data = data;
        }

        public GenericResponse(int code, string message, object data)
        {
            Status = true;
            Code = code;
            Message = message;
            Data = data;
        }

        public GenericResponse(bool status, int code, string message)
        {
            Status = status;
            Code = code;
            Message = message;
        }
    }
}
