
namespace ClassCsharp
{


    class program 
    {
        
        static void Main(string[] args)
        {
        System.Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();
        int i = 0;
        
        System.Console.WriteLine(Recursive(i , word ));

        }
        
        public static bool Recursive(int i , string word )
        {
            
            if (word.Length % 2 == 1)
            {
                if (i < word.Length )
                {
                    if(word[i]==word[word.Length-1-i])
                    {
                        if(word.Length/2 == i )
                        {
                            return true;
                        }
                        else
                        {
                            return Recursive(i+1 , word);
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            } 
        }
    }
}
