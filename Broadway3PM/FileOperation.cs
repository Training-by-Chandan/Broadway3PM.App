using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public class FileOperation
    {
        public static void FilereadWrite()
        {
            //readDirectory
            //var directoryExists = System.IO.Directory.CreateDirectory("D:\\Projects\\Broadway\\NewDirectory");
            //System.IO.Directory.Delete("D:\\Projects\\Broadway\\NewDirectory", true);

            //var currentdir=System.IO.Directory.GetCurrentDirectory();
            var file = "D:\\Projects\\Broadway\\NewDirectory\\New Text Document - Copy (2).txt";
            var content = System.IO.File.ReadAllText(file);

            Console.WriteLine(content);

            //Console.WriteLine("Enter the text to write in the file");
            //var str = Console.ReadLine();

            //System.IO.File.AppendAllText(file, str);

            var exists = System.IO.File.Exists(file);
            var directory = System.IO.Path.GetDirectoryName(file);
            var filename = System.IO.Path.GetFileNameWithoutExtension(file);
            var extension = System.IO.Path.GetExtension(file);

            Console.WriteLine($"Exist =>{exists}\nDiectory => {directory}\nFilename => {filename}\nExtension => {extension}");
        }
    }
}