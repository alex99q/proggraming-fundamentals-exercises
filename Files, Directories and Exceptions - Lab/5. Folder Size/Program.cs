using System.IO;

namespace _5.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("../../../Resources/05. Folder Size/TestFolder");

            double sumSize = 0;

            foreach (var file in fileNames)
            {
                FileInfo currentFileInfo = new FileInfo(file);

                sumSize += currentFileInfo.Length;
            }

            string sumSizeinMB = (sumSize / 1024 / 1024).ToString();

            File.WriteAllText("../../../Resources/05. Folder Size/TestFolder/Size Of TestFolder.txt", sumSizeinMB);
        }
    }
}
