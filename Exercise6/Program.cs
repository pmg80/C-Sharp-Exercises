using System;
using System.Collections.Generic; 

namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Earnings> Hoghogh = new List<Earnings>();
            for (int i = 0 ; i < 5 ; i++)
            {
                System.Console.WriteLine("Enter the name of the employee: ");

                var name =Console.ReadLine();

                System.Console.WriteLine("Enter the employee's salary: ");

                int hours = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("Enter how many hours your employee works:");
                
                int salary = Convert.ToInt32(Console.ReadLine());

                Hoghogh.Add(new Earnings{Name = name , Hours = hours , Salary = salary});


                if (Hoghogh[i].Salary == 0)
                {
                    System.Console.WriteLine("Chizi az arzeshash kam nemikone :)");
                }
                
                
            }

            foreach (var item in Hoghogh)
                {
                    System.Console.WriteLine($"Name = {item.Name} , Salary = {item.Salary} , Working Hours = {item.Hours}");
                }

        }
    }
}