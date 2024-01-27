namespace Kedy.Result;

public interface IDataResult<T> : IResult
{
    T Data { get; set; }
}