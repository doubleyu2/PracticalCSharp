using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9장
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\Program Files\Microsoft Office\Office14\EXCEL.EXE";
            var directoryName = Path.GetDirectoryName(path);
            var fileName = Path.GetFileName(path);
            var extension = Path.GetExtension(path);
            var filenameWithoutExtension = Path.GetFileNameWithoutExtension(path);
            var pathRoot = Path.GetPathRoot(path);

            Console.WriteLine($"DirectoryName:{directoryName}");
            Console.WriteLine($"FileName: {fileName}");
            Console.WriteLine($"Extension: {extension}");
            Console.WriteLine($"FileNameWithoutExtension: {filenameWithoutExtension}");
            Console.WriteLine($"PathRoot: {pathRoot}");
        }
    }
}
