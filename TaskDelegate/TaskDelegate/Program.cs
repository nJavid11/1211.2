using System;

namespace TaskDelegate
{
    class Program
    {
        public delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate sum = new MyDelegate(Sum);
            MyDelegate substraction = new MyDelegate(Substraction);
            MyDelegate multiplication = new MyDelegate(Multiplication);
            MyDelegate division = new MyDelegate(Division);

            Console.WriteLine("Sum = "+ sum(6, 3));
            Console.WriteLine("Substraction = " + substraction(6, 3));
            Console.WriteLine("Multiplication = " + multiplication(6, 3));
            Console.WriteLine("Division = " + division(6, 3));
        }

        public static int Sum(int a,int b) {
            return a + b;
        }
        public static int Substraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
    }
}
