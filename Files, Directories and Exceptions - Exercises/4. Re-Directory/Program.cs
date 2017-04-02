using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _4.Re_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDirectory = "../../../Exercises-Resource/04. Re-Directory/input";
            string outputDirectory = "../../../Exercises-Resource/04. Re-Directory/output";

            List<string> extensions = new List<string>();

            string[] files = Directory.GetFiles(inputDirectory);

            foreach (var file in files)
            {
                FileInfo currentFileInfo = new FileInfo(file);

                extensions.Add(currentFileInfo.Extension.TrimStart('.'));
            }

            Directory.CreateDirectory(outputDirectory);

            foreach (var extension in extensions)
            {
                Directory.CreateDirectory($"{outputDirectory}/{extension}s");
            }

            string[] directories = Directory.GetDirectories(outputDirectory);

            foreach (var currentDirectory in directories)
            {
                string folderExtension = currentDirectory.Split('\\').Reverse().ToArray()[0].TrimEnd('s');

                foreach (var file in files)
                {
                    FileInfo currentFileInfo = new FileInfo(file);

                    string fileName = currentFileInfo.Name;
                    string currentExtension = currentFileInfo.Extension.TrimStart('.');

                    if (currentExtension == folderExtension)
                    {
                        File.Copy(file, $"{currentDirectory}/{fileName}");
                    }
                }
            }
        }
    }
}
