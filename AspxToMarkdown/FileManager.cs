using ReverseMarkdown.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspxToMarkdown
{
    internal class FileManager
    {
        public static List<string> GetAllAspxFiles(string path)
        {
            Console.WriteLine("Finding all .aspx files...");
            List<string> files = new List<string>();
            foreach (string file in Directory.EnumerateFiles(path, "*.aspx", SearchOption.AllDirectories))
            {
                files.Add(file);
            }
            Console.WriteLine("Found " + files.Count + " files");
            return files;
        }

        private static string GetFileName(string path)
        {
            string fileName = Path.GetFileName(path);
            fileName = fileName.Replace(".aspx", "");
            return fileName;
        }

        public static string GetSavingFolderPath(string folderPath)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            string folderName = Path.GetFileName(folderPath);

            return projectDirectory + "\\" + folderName;
        }

        public static void SaveFileAsMarkdown(string text, string filePath, string docFolderPath)
        {
            string fileName = GetFileName(filePath) ;
            string folderPath = GetSavingFolderPath(docFolderPath);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fullPath = folderPath + "\\" + fileName + ".md";

            File.WriteAllText(fullPath, text);
        }
    }
}
