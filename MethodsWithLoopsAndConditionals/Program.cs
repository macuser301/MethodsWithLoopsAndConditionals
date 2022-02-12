using System;


namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
        }
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        
        
        

            PrintRange(10, -2);
        }
        public static void PrintRange(int ceiling, int floor)
        {

            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }






            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);


            }

            Console.WriteLine(counterTwo(2, 8));
        }
        public static bool counterTwo(int a, int b)
        { 
            var check = (a == b) ? true : false;
            
                return check;
           
            

             








        }
    }
}
