using System.Text.Json.Serialization;
using IResult = Kedy.Result.IResult;

namespace Kedy.Result.Response;

public class Response(IResult result) : IResponse
{
    public bool HasError => result.HasError;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Message => result.Message;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<KeyValuePair<string, string>> Errors => result.Errors;
}