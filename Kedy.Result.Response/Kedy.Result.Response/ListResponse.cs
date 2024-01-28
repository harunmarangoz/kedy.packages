using Kedy.Result;
using IResult = Kedy.Result.IResult;

namespace Kedy.Result.Response;

public class ListResponse<T>(IListResult<T> result) : DataResponse<List<T>>(result), IListResponse<T>;