namespace Kedy.Result;

public class ErrorResult : Result
{
    public ErrorResult() : base(true)
    {
    }

    public ErrorResult(string message) : base(message, true)
    {
    }
}