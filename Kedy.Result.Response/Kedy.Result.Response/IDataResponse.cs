namespace Kedy.Result.Response;

public interface IDataResponse<T> : IResponse
{
    T Data { get; }
}