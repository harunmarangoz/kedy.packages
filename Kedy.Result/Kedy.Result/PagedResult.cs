namespace Kedy.Result;

public class PagedResult<T> : ListResult<T>, IPagedResult<T>
{
    public PagedResult()
    {
    }

    public PagedResult(bool hasError) : base(hasError)
    {
    }

    public PagedResult(string message, bool hasError) : base(message, hasError)
    {
    }

    public PagedResult(List<T> data, bool hasError) : base(data, hasError)
    {
    }

    public PagedResult(List<T> data, string message, bool hasError) : base(data, message, hasError)
    {
    }

    public int ItemsCount { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
}