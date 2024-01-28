using Shouldly;

namespace Kedy.Result.Response.Test.Tests;

public class ResponseTests
{
    [Fact]
    public void ResponseTest()
    {
        var result = new SuccessResult();
        var response = new Response(result);
        response.HasError.ShouldBeFalse();
        response.Message.ShouldBeNull();
    }

    [Fact]
    public void ResponseWithErrorsTest()
    {
        var message = "message";
        var errors = new List<KeyValuePair<string, string>>()
        {
            new("test", "test"),
            new("test", "test")
        };
        var result = new ErrorResult(message)
        {
            Errors = errors
        };
        var response = new Response(result);
        response.HasError.ShouldBeTrue();
        response.Message.ShouldBe(message);
        response.Errors.Count.ShouldBe(2);
        response.Errors[0].Key.ShouldBe("test");
        response.Errors[0].Value.ShouldBe("test");
    }

    [Fact]
    public void DataResponseTest()
    {
        var data = "test";
        var result = new SuccessDataResult<string>(data);
        var response = new DataResponse<string>(result);
        response.HasError.ShouldBeFalse();
        response.Message.ShouldBeNull();
        response.Data.ShouldBe(data);
    }

    [Fact]
    public void ListResponseTest()
    {
        var data = new List<string>
            { "test1", "test2", "test3", "test4", "test5", "test6", "test7", "test8", "test9", "test10" };
        var result = new SuccessListResult<string>(data);
        var response = new ListResponse<string>(result);
        response.HasError.ShouldBeFalse();
        response.Message.ShouldBeNull();
        response.Data.Count.ShouldBe(10);
    }

    [Fact]
    public void PagedResponseTest()
    {
        var data = new List<string>
            { "test1", "test2", "test3", "test4", "test5", "test6", "test7", "test8", "test9", "test10" };
        var result = new SuccessPagedResult<string>(data)
        {
            ItemsCount = 614,
            PageSize = 10,
            PageNumber = 1
        };
        var response = new PagedResponse<string>(result);
        response.HasError.ShouldBeFalse();
        response.Message.ShouldBeNull();
        response.Data.Count.ShouldBe(10);
        response.ItemsCount.ShouldBe(614);
        response.PageSize.ShouldBe(10);
        response.PageNumber.ShouldBe(1);
    }
}