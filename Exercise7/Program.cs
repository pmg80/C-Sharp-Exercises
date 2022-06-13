
using System.Drawing;
namespace Hangman
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            string[] names = new string[]{"apple" , "banana" , "orange" , "pineapple" , "kiwi" , "plum" , "cucumber"} ;
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            string Holder = names[index];
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.Write("-----------------------Welcome to the hangman game-----------------------");
            Console.ResetColor();
            System.Console.WriteLine("\na random fruit will be chosen and you have 6 guesses to discover the fruit");
            System.Console.WriteLine($"Your word has {Holder.Length} Letters");

            string[] CorrectLetters = new string[Holder.Length];
            List<string> WrongLetters = new List<string>();
            int counter = 0; //counting how many letters are found within the word

            for (int filler = 0 ; filler < Holder.Length ; filler++) ///can be removed
            {
                CorrectLetters[filler]= "*"; //making it easier for the player to know how many letters are left
            }
            
            for(int i = 0 ; i < 6 ; )
            {   
                //getting the character
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("\nEnter the character that you want to check");
                Console.ResetColor();
                string? Guess = Console.ReadLine();
                bool IsCorrect = false;

                //the second loop is for checking the guesses
                //had to define a second loop or define the guesses inside an if statement(which wasn't allowed)
                for (int j = 0 ; j < Holder.Length ; j++ )
                {
                    string sub = Holder[j].ToString();
                
                    if (sub == Guess)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Correct");
                        IsCorrect = true;
                        if ( CorrectLetters[j] != Guess)
                        {
                            counter++;
                        }
                        CorrectLetters[j] = Guess;
                        
                    }
                    else if (IsCorrect == false & j == Holder.Length - 1) //only possible if all the characters are checked
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Wrong");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        ++i;
                        System.Console.WriteLine($"you have {6-i} guesses left");
                        Console.ResetColor();
                        WrongLetters.Add(Guess);
                    }
                }


                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine("your word is:");
                foreach(var item in CorrectLetters)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.Write(item + " ");
                }

                
                

                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("\nyour wrong guesses are:");
                foreach(var item in WrongLetters)
                {
                    System.Console.Write(item + " ");
                }
                Console.ResetColor();

                if (counter == Holder.Length)
                {
                    System.Console.WriteLine("\nyou win");
                    break;
                }


                switch (i)
                {
                    case 0:
                    System.Console.WriteLine
                    ("____\n"
                    +"   |\n");
                        break;
                    case 1:
                    System.Console.WriteLine
                    ("____\n"
                    +"   |\n"
                    +"   O");
                        break;
                    case 2:
                    System.Console.WriteLine
                    ("____\n"
                    +"   |\n"
                    +"   O\n"
                    +"   |");
                        break;
                    case 3:
                    System.Console.WriteLine
                    ("____\n"
                    +"   |\n"
                    +"   O\n"
                    +"  /|\n");
                        break;
                    case 4:
                    System.Console.WriteLine
                    ("____\n"
                    +"   |\n"
                    +"   O\n"
                   +@"  /|\" + "\n");
                        break;
                    case 5:
                    System.Console.WriteLine
                    ("____\n"
                    +"   |\n"
                    +"   O\n"
                   +@"  /|\" + "\n"
                    +"  / \n");
                        break;
                    case 6:
                    System.Console.WriteLine
                    ("____\n"
                    +"   |\n"
                    +"   O\n"
                   +@"  /|\" + "\n"
                   +@"  / \");
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write("you lost\nyour word was: ");
                    Console.ResetColor();
                    System.Console.WriteLine(Holder);
                        break;
                    default:
                        break;
                }
            }



        }
    }  
}