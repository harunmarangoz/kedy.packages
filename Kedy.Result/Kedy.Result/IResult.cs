namespace Kedy.Result;

public interface IResult
{
    bool HasError { get; set; }
    string Message { get; set; }
    List<KeyValuePair<string, string>> Errors { get; set; }
}