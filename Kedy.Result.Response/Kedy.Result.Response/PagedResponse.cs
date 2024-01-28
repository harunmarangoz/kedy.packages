using Kedy.Result;
using IResult = Kedy.Result.IResult;

namespace Kedy.Result.Response;

public class PagedResponse<T>(IPagedResult<T> result) : ListResponse<T>(result), IPagedResponse<T>
{
    public long ItemsCount => result.ItemsCount;
    public int PageSize => result.PageSize;
    public int PageNumber => result.PageNumber;
}