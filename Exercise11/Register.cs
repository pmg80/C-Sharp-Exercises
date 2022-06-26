using System.Globalization;
namespace Exercise11
{
    public class Register
    {
        public string Name { get; set; }
        
        
        public event EventHandler TheEvent1;
        public event EventHandler TheEvent2;
        string[] Banned = {"ali alii" , "navid mohamadzade" , "javad mosavi"};
        string[] Registered = {"pejman mesri" , "javad kazemi" , "mosa mohamadi"};

        public void GetName()
        {
            System.Console.Write("Enter your first name and last name: ");
            string? name = Console.ReadLine().ToLower();
            this.Name = name;
            byte result = 0;

            foreach(var item in Banned)
            {
                bool isBanned = (item.SequenceEqual(name))? true : false;
                if(isBanned)
                {
                    result++;
                    TheEvent1.Invoke(this , EventArgs.Empty);
                }
            }
            foreach(var item in Registered)
            {
                bool isRegistered = (item.SequenceEqual(name))? true : false;
                if(isRegistered)
                {
                    result++;
                    TheEvent2.Invoke(this , EventArgs.Empty);
                }
            }
            
            if(result == 0)
            {
                System.Console.WriteLine("Hello Mr/Ms " + Name);
            }
        }
        
        public void FuncForEvent1(object sender , EventArgs e)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            System.Console.WriteLine("You are banned Mr " + Name);
            Console.ResetColor();
        }
        public void FuncForEvent2(object sender , EventArgs e)
        {
            System.Console.WriteLine("Welcome back Mr " + Name );
        }
    }
} 