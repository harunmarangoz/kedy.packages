namespace Kedy.Result.Response;

public interface IResponse
{
    bool HasError { get; }
    string Message { get; }
    List<KeyValuePair<string, string>> Errors { get; }
}