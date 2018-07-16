namespace TDI2D.ServiceLayer.Models
{
    public class ServiceResult
    {
        public bool IsSuccess { get; set; }

        public ServiceResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }

    public class ServiceResult<T> : ServiceResult
        where T : class
    {
        public T Data { get; set; }

        public ServiceResult(T data) : this(true, data)
        {
        }

        public ServiceResult(bool isSuccess) : this(isSuccess, null)
        {
        }

        public ServiceResult(bool isSuccess, T data) : base(isSuccess)
        {
            Data = data;
        }
    }
}
