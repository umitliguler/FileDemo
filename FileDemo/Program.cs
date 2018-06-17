using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var filePath = @"c:\vidobu\cs_file.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            var loremText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            File.WriteAllText(filePath, loremText + Environment.NewLine);

            var strArr = new[] { "Ocak", "Şubat", "Mart" };

            //File.WriteAllLines(filePath, strArr);
            File.AppendAllLines(filePath, strArr);
            
        }
    }
}
