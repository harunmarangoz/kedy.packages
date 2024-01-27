using Shouldly;

namespace Kedy.Result.Test.Tests;

public class ResultTest
{
    [Fact]
    public void DefaultResultTest()
    {
        var result = new Result();
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
    }

    [Fact]
    public void DefaultResultWithMessageTest()
    {
        var message = "test";
        var result = new Result(message);
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBe(message);
    }

    [Fact]
    public void DefaultResultWithErrorsTest()
    {
        var result = new Result()
        {
            Errors = new List<KeyValuePair<string, string>>()
            {
                new("test", "test"),
                new("test", "test"),
            }
        };
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Errors.Count.ShouldBe(2);
        result.Errors[0].Key.ShouldBe("test");
        result.Errors[0].Value.ShouldBe("test");
    }

    [Fact]
    public void SuccessResultTest()
    {
        var result = new SuccessResult();
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
    }

    [Fact]
    public void ErrorResultTest()
    {
        var result = new ErrorResult();
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBeNull();
    }

    [Fact]
    public void ErrorResultWithMessageTest()
    {
        var message = "test";
        var result = new ErrorResult(message);
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBe(message);
    }
}