using Aspose;
using CommandLine;
using Html2Markdown;
using ReverseMarkdown;

namespace AspxToMarkdown
{
    class Options
    {
        [Option('p', "path", Required = true, HelpText = "Path to the documentation folder")]
        public string? PathToDocumentation { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(options =>
            {
                if (options.PathToDocumentation == null) { System.Environment.Exit(1); }

                string folderPath = options.PathToDocumentation;

                var aspxFiles = FileManager.GetAllAspxFiles(folderPath);


                PageConverter converter = new PageConverter();

                Console.WriteLine("Converting pages from aspx to markdown...");
                foreach (var aspxFile in aspxFiles)
                {
                    converter.ConvertFormAspxToMarkdown(aspxFile, folderPath);
                }
                Console.WriteLine("Markdown pages have been saved into a folder:" + FileManager.GetSavingFolderPath(folderPath));
            });
        }
    }
}