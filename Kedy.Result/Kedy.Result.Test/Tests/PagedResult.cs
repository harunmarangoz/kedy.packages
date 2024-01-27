using Shouldly;

namespace Kedy.Result.Test.Tests;

public class PagedResult
{
    [Fact]
    public void DefaultPagedResultTest()
    {
        var result = new PagedResult<string>
        {
            ItemsCount = 614,
            PageSize = 10,
            PageNumber = 1
        };
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.ShouldBeNull();
        result.ItemsCount.ShouldBe(614);
        result.PageSize.ShouldBe(10);
        result.PageNumber.ShouldBe(1);
    }

    [Fact]
    public void SuccessPagedResultWithDefaultConstructorTest()
    {
        var data = new List<string>
            { "test1", "test2", "test3", "test4", "test5", "test6", "test7", "test8", "test9", "test10" };
        var result = new SuccessPagedResult<string>()
        {
            Data = data,
            ItemsCount = 614,
            PageSize = 10,
            PageNumber = 1
        };
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.Count.ShouldBe(10);
        result.ItemsCount.ShouldBe(614);
        result.PageSize.ShouldBe(10);
        result.PageNumber.ShouldBe(1);
    }

    [Fact]
    public void SuccessPagedResultWithDataConstructorTest()
    {
        var data = new List<string>
            { "test1", "test2", "test3", "test4", "test5", "test6", "test7", "test8", "test9", "test10" };
        var result = new SuccessPagedResult<string>(data)
        {
            ItemsCount = 614,
            PageSize = 10,
            PageNumber = 1
        };
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBeNull();
        result.Data.Count.ShouldBe(10);
        result.ItemsCount.ShouldBe(614);
        result.PageSize.ShouldBe(10);
        result.PageNumber.ShouldBe(1);
    }

    [Fact]
    public void SuccessPagedResultWithDataConstructorAndMessageTest()
    {
        var data = new List<string>
            { "test1", "test2", "test3", "test4", "test5", "test6", "test7", "test8", "test9", "test10" };
        var message = "test";
        var result = new SuccessPagedResult<string>(data, message)
        {
            ItemsCount = 614,
            PageSize = 10,
            PageNumber = 1
        };
        result.HasError.ShouldBeFalse();
        result.Message.ShouldBe(message);
        result.Data.Count.ShouldBe(10);
        result.ItemsCount.ShouldBe(614);
        result.PageSize.ShouldBe(10);
        result.PageNumber.ShouldBe(1);
    }
    
    [Fact]
    public void ErrorPagedResultTest()
    {
        var result = new ErrorPagedResult<string>();
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBeNull();
        result.Data.ShouldBeNull();
        result.ItemsCount.ShouldBe(0);
        result.PageSize.ShouldBe(0);
        result.PageNumber.ShouldBe(0);
    }
    
    [Fact]
    public void ErrorPagedResultWithMessageTest()
    {
        var message = "test";
        var result = new ErrorPagedResult<string>(message);
        result.HasError.ShouldBeTrue();
        result.Message.ShouldBe(message);
        result.Data.ShouldBeNull();
        result.ItemsCount.ShouldBe(0);
        result.PageSize.ShouldBe(0);
        result.PageNumber.ShouldBe(0);
    }
}