namespace Kedy.Result;

public class ErrorPagedResult<T> : PagedResult<T>
{
    public ErrorPagedResult() : base(true)
    {
    }

    public ErrorPagedResult(string message) : base(message, true)
    {
    }
}