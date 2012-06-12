using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceText
{
    class Program
    {
        protected enum ReplaceMode{
            ToGeneric,
            FromGeneric
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Title: Replace Text Program");
            Console.WriteLine("Author: Jared Mahan");
            Console.WriteLine("Description: Copies and Replaces text based on input");
            Console.WriteLine("added to dictionaries found in the code below.");
            Console.WriteLine("***********************************************************");
            ReplaceText();
            Console.WriteLine("Please press any key to exit...");
            Console.ReadKey();
        }
        static void ReplaceText()
        {
            // Change this flag to go to and from generics
            ReplaceMode rm = ReplaceMode.FromGeneric;
            string sourcePath = "SourcePath";
            string targetPath = "TargetPath";
            string fileType = "*.sql";

            // Create directory if it does not exist
            new FileInfo(targetPath).Directory.Create();

            Dictionary<string, string> rd = new Dictionary<string, string>();
            rd.Add(rm == ReplaceMode.FromGeneric ? "Pattern1" : "PatternSourceText1", "ReplaceText1");
            rd.Add(rm == ReplaceMode.FromGeneric ? "Pattern2" : "PatternSourceText2", "ReplaceText2");
            
            Console.WriteLine(string.Empty);
            Console.WriteLine(String.Format("Source Path: {0}", sourcePath));
            Console.WriteLine(String.Format("Target Path: {0}", targetPath));
            Console.WriteLine(String.Format("Replace Mode: {0}", rm.ToString()));
            Console.WriteLine(string.Empty);

            Console.WriteLine("Copying and Replacing Text in:");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (string file in Directory.GetFiles(sourcePath, fileType)) {
                Console.WriteLine(new FileInfo(file).Name);
                string targetFile = Path.Combine(targetPath, new FileInfo(file).Name);

                File.Copy(
                    Path.Combine(sourcePath, file),
                    targetFile, true
                    );

                foreach (KeyValuePair<string, string> kvp in rd) {
                    if (rm == ReplaceMode.FromGeneric) {
                        File.WriteAllText(
                            targetFile,
                            Regex.Replace(File.ReadAllText(targetFile), kvp.Key, kvp.Value, RegexOptions.Multiline)
                            );
                    } else {
                        File.WriteAllText(
                            targetFile,
                            Regex.Replace(File.ReadAllText(targetFile), kvp.Value, kvp.Key)
                            );
                    }
                }
            }
        }
    }
}
