using System;


namespace Exercise5
{
    class program
    {
        static void Main(string[] args)
        {
            
           byte Counter = 0;

           Console.WriteLine("Enter a Big Number");
           string BigNum = Console.ReadLine();

           Console.WriteLine("Enter a digit");
           int Digit = Convert.ToInt32(Console.ReadLine());

           for(int i=0 ; i<BigNum.Length ; i++)
           {
              int sub = Convert.ToInt32(BigNum.Substring(i , 1));
              if ( sub == Digit)
              {
                  Counter++;
              }
           }
           Console.WriteLine($"Your digit has been repeated {Counter} times");
           

    }
}
}