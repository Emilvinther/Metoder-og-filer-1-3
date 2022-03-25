using System;
using System.IO;

namespace Metoder_og_filer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            WriteToFile();
            string contents = ReadFile();
            Console.WriteLine(contents);
            DeleteFile();



            Console.ReadKey();
        }

       public static void WriteToFile()
       {

            File.WriteAllText(@".\StarWars.txt", "Han skød først");

       }

        public static string ReadFile()
        {
           string contents = File.ReadAllText(@".\StarWars.txt");

            return contents;
        }

        public static void DeleteFile()
        {
            File.Delete(@".\StarWars.txt");
        }
            

    }
}
