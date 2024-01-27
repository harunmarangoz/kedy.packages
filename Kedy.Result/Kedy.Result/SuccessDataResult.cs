namespace Kedy.Result;

public class SuccessDataResult<T>(T data) : DataResult<T>(data, false);