using Shouldly;

namespace Kedy.Result.Test.Tests;

public class DataResultTest
{
    [Fact]
    public void SuccessDataResultTest()
    {
        var data = "test";
        var result = new SuccessDataResult<string>(data);
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.ShouldBe(data);
    }
    
    [Fact]
    public void ErrorDataResultTest()
    {
        var result = new ErrorDataResult<string>();
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBeNull();
        result.Data.ShouldBeNull();
    }
    
    [Fact]
    public void ErrorDataResultWithMessageTest()
    {
        var message = "test";
        var result = new ErrorDataResult<string>(message);
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBe(message);
        result.Data.ShouldBeNull();
    }
}