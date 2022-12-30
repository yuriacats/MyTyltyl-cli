using System.CommandLine;


var fileOption = new Option<FileInfo?>(
    name: "--file",
    description: "select file"
);

var rootCommand = new RootCommand("Sample Application");
rootCommand.AddOption(fileOption);

rootCommand.SetHandler((file) =>
{
    ReadFile(file!);
}, fileOption);
return await rootCommand.InvokeAsync(args);



static void ReadFile(FileInfo file)
{
    File.ReadLines(file.FullName).ToList()
    .ForEach(line => Console.WriteLine(line));
}
