namespace RecursiveReverse
{
    public class Program
    {

        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your word: ");
            string word = Console.ReadLine();
            int i = 0;
            string[] arr = new string[word.Length];
            Reversed(word, i , arr);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Your reversed word is: ");
            Console.ResetColor();
            foreach (var item in arr)
            {
                Console.Write(item);
            }


        }

        public static string[] Reversed(string word , int i , string[] arr)
        {
            
            
            if (i < word.Length)
            {
    
                string holder = word.Substring(word.Length - i - 1 , 1);
                arr[i] = holder;
                return Reversed(word , i + 1 , arr);
            }
            else
            {
                return arr;
            }
        }
    }
}