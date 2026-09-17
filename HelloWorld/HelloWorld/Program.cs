using System.Net.NetworkInformation;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string input;
            Console.Write("Write 2 numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(Add(x, y));
            Console.WriteLine(Subtract(x, y));
            Console.WriteLine(Multiply(x, y));
            Console.ReadLine();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y) { 
            return x - y;
        }

        public static int Multiply(int x, int y) { 
            return x * y;
        }
    }
}
