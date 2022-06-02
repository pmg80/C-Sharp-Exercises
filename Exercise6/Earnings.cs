namespace Exercise6
{
    public class Earnings
    {
        int Total;
        
        private int _hours;
        private int _salary;
        private string _name;
        
        
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       
       
        // public Earnings(string name , int hours , int salary)
        // {
        //     this.Hours = hours;
        //     this.Salary = salary;
        //     this.Name = name;
        // }
        public int Dastmozd()
        {
            
            if (Salary == 0)
            {
                
                System.Console.WriteLine("khali naband :)");
                
            }
            return Total = Salary * Hours;

        }
    }
    
}