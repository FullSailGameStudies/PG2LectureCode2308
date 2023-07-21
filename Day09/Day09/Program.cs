namespace Day09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Gotham!");

            Calculator t1000 = new();
            int n1 = 5, n2 = 2;
            int sum = t1000.Sum(n1,n2);
            Console.WriteLine($"{n1} + {n2} = {sum}");
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
    }
}