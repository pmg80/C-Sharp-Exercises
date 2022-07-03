using System.Drawing;
namespace Exercise12
{
    public class Chart
    {
        private string a1 = "1" ;
        private string a2 = "2" ;
        private string a3 = "3" ;
        private string a4 = "4" ;
        private string a5 = "5" ;
        private string a6 = "6" ;
        private string a7 = "7" ;
        private string a8 = "8" ;
        private string a9 = "9" ;
        
        
        private bool playerWins = false;
        
        
        private void DrawChart()
        {
            System.Console.WriteLine($"-------------");         
            System.Console.WriteLine($"| {a1} | {a2} | {a3} |");
            System.Console.WriteLine($"|---|---|---|");
            System.Console.WriteLine($"| {a4} | {a5} | {a6} |");
            System.Console.WriteLine($"|---|---|---|");
            System.Console.WriteLine($"| {a7} | {a8} | {a9} |");
            System.Console.WriteLine($"-------------");
        }
        public void Play()
        {
            int i = 0;
            while(playerWins == false )
            {
                
                DrawChart();
                int input = 0;
                bool wrongChoice = false;
                
                if(i % 2 == 0)
                {
                    System.Console.WriteLine("First players turn to input the location for O");
                    
                    input = int.Parse(Console.ReadKey().KeyChar.ToString());
                    
                    
                    switch (input)
                    {
                        case 1:
                            if(a1 == "O" || a1 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a1 = "O";
                            break;
                        case 2:
                            if(a2 == "O" || a2 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a2 = "O";
                            break;
                        case 3:
                            if(a3 == "O" || a3 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a3 = "O";
                            break;
                        case 4:
                            if(a4 == "O" || a4 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a4 = "O";
                            break;
                        case 5:
                            if(a5 == "O" || a5 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a5 = "O";
                            break;
                        case 6:
                            if(a6 == "O" || a6 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a6 = "O";
                            break;
                        case 7:
                            if(a7 == "O" || a7 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a7 = "O";
                            break;
                        case 8:
                            if(a8 == "O" || a8 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a8 = "O";
                            break;
                        case 9:
                            if(a9 == "O" || a9 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a9 = "O";
                            break;
                        default:
                            break;
                    }
                
                    
                }
                if(i % 2 == 1)
                {
                    System.Console.WriteLine("Second players turn to input the location for X");
                    
                    input = int.Parse(Console.ReadKey().KeyChar.ToString());

                    

                    switch (input)
                    {
                        case 1:
                            if(a1 == "O" || a1 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a1 = "X";
                            break;
                        case 2:
                            if(a2 == "O" || a2 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a2 = "X";
                            break;
                        case 3:
                            if(a3 == "O" || a3 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a3 = "X";
                            break;
                        case 4:
                            if(a4 == "O" || a4 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a4 = "X";
                            break;
                        case 5:
                            if(a5 == "O" || a5 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a5 = "X";
                            break;
                        case 6:
                            if(a6 == "O" || a6 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a6 = "X";
                            break;
                        case 7:
                            if(a7 == "O" || a7 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a7 = "X";
                            break;
                        case 8:
                            if(a8 == "O" || a8 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a8 = "X";
                            break;
                        case 9:
                            if(a9 == "O" || a9 == "X")
                            {
                                System.Console.WriteLine("this spot has already been taken");
                                wrongChoice = true;
                                break;
                            }
                            a9 = "X";
                            break;
                        default:
                            break;
                    }
                    
                }
                if(!wrongChoice)
                {
                    ++i;
                }
                CheckWin();
                
            }
        }
        private void CheckWin()
        {
            if( a1 == "X" && a2 == "X" && a3 == "X" ||
                a4 == "X" && a5 == "X" && a6 == "X" ||
                a7 == "X" && a8 == "X" && a9 == "X" ||
                a1 == "X" && a4 == "X" && a7 == "X" ||
                a2 == "X" && a5 == "X" && a8 == "X" ||
                a3 == "X" && a6 == "X" && a9 == "X" ||
                a1 == "X" && a5 == "X" && a9 == "X" ||
                a3 == "X" && a5 == "X" && a7 == "X" )
                {
                    playerWins = true;
                    DrawChart();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.White;
                    System.Console.Write("Player 2 Wins!!");
                    Console.ResetColor();
                }
            if( a1 == "O" && a2 == "O" && a3 == "O" ||
                a4 == "O" && a5 == "O" && a6 == "O" ||
                a7 == "O" && a8 == "O" && a9 == "O" ||
                a1 == "O" && a4 == "O" && a7 == "O" ||
                a2 == "O" && a5 == "O" && a8 == "O" ||
                a3 == "O" && a6 == "O" && a9 == "O" ||
                a1 == "O" && a5 == "O" && a9 == "O" ||
                a3 == "O" && a5 == "O" && a7 == "O" )
                {
                    playerWins = true;
                    DrawChart();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.White;
                    System.Console.Write("Player 1 Wins!!");
                    Console.ResetColor();
                }
        }
    }   
}