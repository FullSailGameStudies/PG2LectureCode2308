namespace Day09
{
    static class Extensions
    {
        public static void ColorPrint(this ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static string Concat(string msg, int num) //post-fix
        {
            return msg + num;
        }
        static string Concat(int num, string msg) //pre-fix
        {
            return num + msg;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Gotham!");

            string univ = Concat("Spiderverse-", 800);
            univ = Concat(20, " Lives");

            Console.Write($"You have ");
            ConsoleColor.Red.ColorPrint(univ);
            Console.WriteLine("WOW!");

            Calculator t1000 = new();
            int n1 = 5, n2 = 2;
            int sum = t1000.Sum(n1,n2);
            Console.WriteLine($"{n1} + {n2} = {sum}");
            double d1 = 40, d2 = 10;
            double sumD = t1000.Sum(d1, n2);

            List<int> nums = new() { 1, 2, 3, 4 };
        }
    }

    /*  
        ╔═════════════╗ 
        ║ OVERLOADING ║ - polymorphism by changing parameters
        ╚═════════════╝ 

        You can overload a method in 3 ways:
        1) different types on the parameters
        2) different number of parameters
        3) different order of parameters


        CHALLENGE 1:
            Add a overload of the Sum method to sum 2 doubles
    */

    class Calculator
    {
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public double Sum(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}