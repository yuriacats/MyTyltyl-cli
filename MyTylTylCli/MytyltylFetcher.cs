namespace Mytyltyl;
using System.Net.Http;
using MytyltylApi;
public static class MytyltylFetcher
{
    static readonly string UrlBase = "http://mytyltyl.yuchiki.net/";
    static readonly HttpClient client = new HttpClient();
    static async Task<T> FromPath<T>(string path)
    {
        try
        {
            using HttpResponseMessage response = await client.GetAsync(UrlBase + path);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsAsync<T>();
            return responseBody;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nRxception Caught:");
            Console.WriteLine("Mwssage:{0}", e.Message);
            throw;
        }
    }
    static public async Task<VersionResponse> FetchServerVersion() =>
    await FromPath<VersionResponse>("version");
}
