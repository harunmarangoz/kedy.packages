namespace Kedy.Result;

public interface IPagedResult<T> : IListResult<T>
{
    int ItemsCount { get; set; }
    int PageSize { get; set; }
    int PageNumber { get; set; }
}