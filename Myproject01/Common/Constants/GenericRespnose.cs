namespace Myproject01.Common.Constants
{
    public class GenericRespnose
    {
        public object Data { get; set; } // dữ liệu
        public int Code { get; set; } // 100 -> 500;
        public bool Status { get; set; } // true - false
        public string Message { get; set; } // message

        public GenericRespnose()
        {
        }

        public GenericRespnose(bool status, int code, string message, object data) : this(status, code, message)
        {
            Data = data;
        }

        public GenericRespnose(int code, string message, object data)
        {
            Status = true;
            Code = code;
            Message = message;
            Data = data;
        }

        public GenericRespnose(bool status, int code, string message)
        {
            Status = status;
            Code = code;
            Message = message;
        }
    }
}
