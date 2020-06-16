using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows";
            ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("********");
            ShowLargeFilesWitLinq(path);
        }

        private static void ShowLargeFilesWitLinq(string path)
        {
            var directoryFiles = new DirectoryInfo(path).GetFiles();
            var files = directoryFiles
                    .OrderBy(x => x.Length)
                    .Take(5);

            foreach (var file in files)
                Console.WriteLine($"{file.Name,-20} - {file.Length,10:N0}");
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            var files = directoryInfo.GetFiles();

            Array.Sort(files, new FileInfoComparer());

            for (var index = files.Length - 1; index >= files.Length - 5; index--)
            {
                var file = files[index];
                Console.WriteLine($"{file.Name,-20} - {file.Length,10:N0}");
            }
        }
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
