namespace Kedy.Result;

public class ErrorListResult<T> : ListResult<T>
{
    public ErrorListResult() : base(true)
    {
    }

    public ErrorListResult(string message) : base(message, true)
    {
    }
}