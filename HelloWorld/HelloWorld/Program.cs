namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string input;
            Console.Write("Add 2 numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(Add(x, y));

            Console.ReadLine();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
