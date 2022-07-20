namespace Exercise14
{
    namespace Exercise14
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                int[] arr1 = {1 , 5 , 8};
                int[] arr2 = {1 , 5 , 8};
                string[] arr3 = {"1" , "5" , "8"};
                string[] arr4 = {"1" , "5" , "7"};
                System.Console.WriteLine(IsEqual(arr1 , arr2));
                System.Console.WriteLine(IsEqual(arr4 , arr3));
            }


            public static bool IsEqual<T>(T[] arr1 , T[] arr2)
            {
                if(arr1.SequenceEqual(arr2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    

    }
}
