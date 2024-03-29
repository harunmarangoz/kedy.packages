using System.Collections.Generic;

namespace Kedy.Result;

public class SuccessListResult<T> : ListResult<T>
{
    public SuccessListResult(List<T> data) : base(data, false)
    {
    }

    public SuccessListResult(List<T> data, string message) : base(data, message, false)
    {
    }
}