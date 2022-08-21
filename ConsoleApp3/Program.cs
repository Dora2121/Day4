namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int k;
            Console.WriteLine("Enter value for i");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for j");
            j = Convert.ToInt32(Console.ReadLine());
            k = i + j;
            Console.WriteLine("sum is"+k);
            Console.ReadLine();
            //Console.WriteLine("Hello, World!");
        }
    }
}