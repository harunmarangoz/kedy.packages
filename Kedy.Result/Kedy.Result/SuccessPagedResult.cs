namespace Kedy.Result;

public class SuccessPagedResult<T> : PagedResult<T>
{
    public SuccessPagedResult() : base(false)
    {
    }

    public SuccessPagedResult(List<T> data) : base(data, false)
    {
    }

    public SuccessPagedResult(List<T> data, string message) : base(data, message, false)
    {
    }
}