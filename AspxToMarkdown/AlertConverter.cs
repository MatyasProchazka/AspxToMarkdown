using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AspxToMarkdown
{
    internal class AlertConverter
    {
        private List<string> linesList;
        private List<(string, string)> alertstypesList;

        public AlertConverter(string? text)
        {
            linesList = new List<string>(text.Split('\n'));
            alertstypesList = new List<(string, string)>();

            AlertsNamesInitialization();
        }

        private void AlertsNamesInitialization()
        {
            alertstypesList.Add((("Note:", "> [!NOTE]")));
            alertstypesList.Add((("Caution:", "> [!CAUTION]")));
            alertstypesList.Add((("Tip:", "> [!TIP]")));
        }

        public string ConvertAlerts()
        {
            foreach ((var alertNameFrom, var alertNameTo) in alertstypesList)
            {
                Convert(alertNameFrom, alertNameTo);
            }

            string pageWithAlerts = "";

            foreach (string line in linesList)
            {
                pageWithAlerts += line + "\n";
            }

            return pageWithAlerts;
        }

        private void Convert(string nameFrom, string nameTo)
        {
            List<int> linesToReplace = new List<int>();
            List<int> linesToRemove = new List<int>();
            List<int> linesToSplit = new List<int>();
            List<int> linesToAddSpace = new List<int>();

            // Find all alerts that are in an incorrect syntax
            for (int i = 0; i < linesList.Count - 1; i++)
            {
                if (linesList[i].TrimStart().Contains(nameFrom))
                {
                    if (linesList[i] != nameFrom + "\r")
                    {
                        linesToSplit.Add(i);
                    }
                }
            }

            // Replace alerts with correct syntax
            for (int i = linesToSplit.Count - 1; i >= 0; i--)
            {
                int index = linesToSplit[i];
                if (index >= 0 && index < linesList.Count)
                {
                    string[] splittedAlert = linesList[index].Split(": ");
                    if (splittedAlert.Length > 1)
                    {
                        linesList.RemoveAt(index);
                        linesList.Insert(index, nameFrom + "\r");
                        linesList.Insert(index + 1, "");
                        linesList.Insert(index + 2, splittedAlert[1]);
                        linesList.Insert(index + 3, "");
                    }
                    
                }
            }

            // Find all alerts to be replaced
            for (int i = 0; i < linesList.Count - 2; i++)
            {
                if (linesList[i].TrimStart().Contains(nameFrom))
                {
                    linesToReplace.Add(i);
                    if (i + 1 < linesList.Count) { linesToRemove.Add(i + 1); }

                }
            }

            // Replace alerts with correct syntax
            foreach (int index in linesToReplace)
            {
                if (linesList[index].TrimStart() == nameFrom + "\r")
                {
                    linesList[index] = Regex.Replace(linesList[index], nameFrom, nameTo).TrimStart();
                    linesList[index + 2] = "> " + linesList[index + 2].TrimStart();
                }

            }

            // Remove the empty line between alert header and content
            for (int i = linesToRemove.Count - 1; i >= 0; i--)
            {
                int index = linesToRemove[i];
                if (index >= 0 && index < linesList.Count)
                {
                    linesList.RemoveAt(index);
                }
            }

            // Add a line after alerts, if there isn't
            for (int i = linesList.Count - 1; i >= 0; i--)
            {
                if (linesList[i].TrimStart().StartsWith("> ") && !linesList[i].TrimStart().StartsWith("> ["))
                {
                    if (i + 1 < linesList.Count)
                    {
                        if (linesList[i + 1] != "" && linesList[i + 1] != "\n" && linesList[i + 1] != "\r")
                        {
                            linesList.Insert(i + 1, "");
                        }
                    }
                }
            }

        }
}
}
