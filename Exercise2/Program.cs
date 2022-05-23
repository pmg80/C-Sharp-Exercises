namespace A123454321
{
    class program
    {
          static void Main(string[] args)
        {
            
            for (int i=1 ; i<=5; i++ )
            {
                for (int Spaces=5 ; Spaces>i ; Spaces--)
                {
                    System.Console.Write(" ");
                }
                for (int j=1 ; j<=i ; j++)
                {
                    
                    System.Console.Write(j);
                }
                for (int k=i-1 ; k>=1 ; k--)
                {
                    System.Console.Write(k);
                }
                System.Console.WriteLine("");
                
            }
        
        }

      

    }
}