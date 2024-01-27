using Kedy.Result;
using Shouldly;

namespace Kedy.Result.Test.Tests;

public class ListResultTest
{
    [Fact]
    public void DefaultListResultTest()
    {
        var result = new ListResult<string>();
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.ShouldBeNull();
    }

    [Fact]
    public void DefaultListResultWithDataTest()
    {
        var data = new List<string> { "test" };
        var result = new ListResult<string>(data);
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.Count.ShouldBe(1);
    }

    [Fact]
    public void DefaultListResultWithMessageAndDataTest()
    {
        var data = new List<string> { "test" };
        var message = "test";
        var result = new ListResult<string>(data, message);
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBe(message);
        result.Data.Count.ShouldBe(1);
    }

    [Fact]
    public void DefaultSuccessListResultTest()
    {
        var result = new SuccessListResult<string>(new List<string>());
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.Count.ShouldBe(0);
    }

    [Fact]
    public void SuccessListResultWithDataTest()
    {
        var data = new List<string> { "test" };
        var result = new SuccessListResult<string>(data);
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.Count.ShouldBe(1);
    }

    [Fact]
    public void SuccessListResultWithMessageTest()
    {
        var message = "test";
        var result = new SuccessListResult<string>(new List<string>(), message);
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBe(message);
        result.Data.Count.ShouldBe(0);
    }

    [Fact]
    public void SuccessListResultWithDataAndMessageTest()
    {
        var data = new List<string> { "test" };
        var message = "test";
        var result = new SuccessListResult<string>(data, message);
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBe(message);
        result.Data.Count.ShouldBe(1);
    }

    [Fact]
    public void ErrorListResultWithoutMessageTest()
    {
        var result = new ErrorListResult<string>();
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBe(null);
        result.Data.ShouldBeNull();
    }

    [Fact]
    public void ErrorListResultWithMessageTest()
    {
        var message = "test";
        var result = new ErrorListResult<string>(message);
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBe(message);
        result.Data.ShouldBeNull();
    }
}