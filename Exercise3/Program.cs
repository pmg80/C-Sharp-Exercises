namespace Exercise3
{
    class program
    {
          static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a number");
            int MaxNum =Convert.ToInt32(Console.ReadLine());
            for (int i=1 ; i<=MaxNum ; i++)
            {
                 if (i % 2 == 1)
                   {
                    sum += i;
                   }   
            }
            Console.WriteLine(sum);
            
        }

      

    }
}