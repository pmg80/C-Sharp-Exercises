using System.Linq;
using System.Collections.Generic;

namespace Exercise10
{

    class program
    {
        static void Main(string[] args)
        {
            List<Movie1> lst1 = new List<Movie1>()
                {
                    new Movie1 {ID = 1 , Name = "Harry Potter" },
                    new Movie1 {ID = 2 , Name = "Avengers"}
                };

            List<Movie2> lst2 = new List<Movie2>()
                {
                    new Movie2 {ID = 1 , Name = " 1" },
                    new Movie2 {ID = 1 , Name = " 2" },
                    new Movie2 {ID = 1 , Name = " 3" },
                    new Movie2 {ID = 2 , Name = " Age Of Ultron"},
                    new Movie2 {ID = 2 , Name = " Infinity War"},
                    new Movie2 {ID = 2 , Name = " Endgame"}
                };

            lst1.Join(lst2, movie1 => movie1.ID, movie2 => movie2.ID, (Movie1, Movie2) => new
            {
                ID = Movie1.ID,
                NewName = Movie1.Name + Movie2.Name
            }).ToList().ForEach(x => Console.WriteLine(x.NewName));


        }
    }
    public class Movie1
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Movie2
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
