namespace Kedy.Result.Response;

public interface IPagedResponse<T> : IListResponse<T>
{
    long ItemsCount { get; }
    int PageSize { get; }
    int PageNumber { get; }
}