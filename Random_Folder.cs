using System;
using System.IO;

namespace Random_Folder
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo[] subDirs; //Directory Array
            DirectoryInfo root = new DirectoryInfo(@"F:\Music"); //Directory path
            subDirs = root.GetDirectories(); //Get Directories
            Random random = new Random();
            int directory = random.Next(subDirs.Length); //Random index of Directory Array
            DirectoryInfo randomDirectory = subDirs[directory]; //Get Random Directory
            string path = @"F:\Music\" + randomDirectory.ToString(); //Random Directory Path
            System.Diagnostics.Process.Start(path); //Open Folder
        }
    }
}
