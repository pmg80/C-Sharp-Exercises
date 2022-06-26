using System;
namespace Exercise11
{
    
    class Program
    {
        

        public static void Main(string[] Args)
        {
            var obj = new Register();
            obj.TheEvent1 += obj.FuncForEvent1;
            obj.TheEvent2 += obj.FuncForEvent2;
            obj.GetName();
        }
    }
}
