namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Rectangle rect = new Rectangle(2,9);
            Console.WriteLine($"The area is: {rect.CalArea(2, 9)}");
            Console.WriteLine($"The perimter is: {rect.CalPerimeter(2, 9)}");


        }
    }
}
