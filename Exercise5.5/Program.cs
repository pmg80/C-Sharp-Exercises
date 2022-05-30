using System;


namespace Exercise5_5
{
    class program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter your file's path");
            string FilePath = Console.ReadLine();

            do {

            Console.WriteLine("Enter your files name:");
            string FileName = Console.ReadLine();
            
            string path = FilePath + @"\" + FileName + @".txt";
            
            Console.WriteLine("Enter your text");
            string Text = Console.ReadLine();
            
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(Text);

            } 

            Console.WriteLine("Do you want to add more text files to this directory?(Yes or no)");
            
        
            } while (Console.ReadLine().ToLower() == "yes");
        }
    }
}