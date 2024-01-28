using System.Text.Json.Serialization;
using Kedy.Result;
using IResult = Kedy.Result.IResult;

namespace Kedy.Result.Response;

public class DataResponse<T>(IDataResult<T> result) : Response(result), IDataResponse<T>
{
    public T Data => result.Data;
}