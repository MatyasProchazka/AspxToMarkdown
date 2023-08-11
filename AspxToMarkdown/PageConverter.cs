using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ReverseMarkdown;

namespace AspxToMarkdown
{
    internal class PageConverter
    {
        Converter? converter;
        public PageConverter() 
        {
            this.converter = new ReverseMarkdown.Converter();
        }

        private string RemoveUnwantedTags(string path)
        {
            string[] textLines = File.ReadAllLines(path, Encoding.UTF8);

            textLines = textLines.Where(x => !x.Contains("<asp:") && !x.Contains("</asp:") && !x.Contains("<%") && !x.Contains("<o:") && !x.Contains("</o:")).ToArray();
            string htmlPage = "";
            foreach (string line in textLines)
            {
                htmlPage += line + "\n";
            }
            return htmlPage;
        }

        public void ConvertFormAspxToMarkdown(string filePath, string folderPath)
        {
            string htmlPage = RemoveUnwantedTags(filePath);

            var markdownPage = converter.Convert(htmlPage);

            AlertConverter alertConverter = new AlertConverter(markdownPage);

            string markdownPageWithAlerts = alertConverter.ConvertAlerts();

            FileManager.SaveFileAsMarkdown(markdownPageWithAlerts, filePath, folderPath);
        }
    }
}
