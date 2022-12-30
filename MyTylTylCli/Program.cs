using System.CommandLine;


var rootCommand = new RootCommand("Sample Application");

rootCommand.SetHandler(async () =>
{
    var versionInfo = await Mytyltyl.MytyltylFetcher.FetchServerVersion();
    Console.WriteLine("CommandVersion:0.0.0");
    Console.WriteLine($"ServerVersion:{versionInfo.FullVerison}");
    Console.WriteLine($"StartedAt:{versionInfo.StartedAt}");

});
return await rootCommand.InvokeAsync(args);



