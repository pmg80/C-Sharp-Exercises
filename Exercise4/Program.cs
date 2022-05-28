using System;


namespace Exercise4
{
    class program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a word/sentence");
            string S1 = Console.ReadLine();
            System.Console.WriteLine("Enter another word/sentence");
            string S2 = Console.ReadLine();

            for (int i = 0; i < S2.Length; i++)
            {
                
                for(int j=0 ; j < S2.Length ; j++)
                {
                    string sub = S2.Substring(i , j+1);
                            if (S1.IndexOf(sub) != -1)
                            {
                                System.Console.WriteLine($"String:{sub}   Index: {S1.IndexOf(sub)}");
                            }
                }
            }
            
        }

    }
}
