using System;
using System.IO;
using System.Linq;


namespace Random_File
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Diagnostics.Process.Start(getRandomFile(@"F:\other\torrent"));
        }

        private static string getRandomFile(string path)
        {
            try
            {
                var extensions = new string[] { ".torrent" };

                var di = new DirectoryInfo(path);
                return (di.GetFiles("*.*")
                                    .Where(f => extensions.Contains(f.Extension.ToLower()))
                                    .OrderBy(f => Guid.NewGuid())
                                    .First()).FullName;
            }
            catch { return ""; }
        }
    }
}
