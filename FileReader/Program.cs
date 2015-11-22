using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
               StreamReader reader = new StreamReader("..\\..\\Sample.txt");
            //auto closes StreamReader. Dont have to put reader.Close();
               using (reader)
           {
                int lineNumber = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }

            }
        }
    }
}
