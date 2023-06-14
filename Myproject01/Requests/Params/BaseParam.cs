namespace Myproject01.Requests.Params
{
    public class BaseParam<T>
    {
        public T FilterParams { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
