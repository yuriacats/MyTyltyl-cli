
namespace MytyltylTest;
using Mytyltyl;
using MytyltylApi;

public class UnitTest1
{
    [Fact]
    public async void GetVersionTest()
    {
        var result = (await MytyltylFetcher.FetchServerVersion()).FullVerison;
        Assert.NotEmpty(result);
        Assert.Equal("0.0.0", result);
    }
}
