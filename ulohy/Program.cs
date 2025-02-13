namespace ulohy
{
    internal class rectangle
    {
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zadaj rozmery obdlznika: ");

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);

            int Result = rectangle.Calculate();
            Console.WriteLine("Obsah obdlznika je: " + Result);

            Rectangle SecondRrectangle = new Rectangle(rectangle.Width * 10, rectangle.Height * 10);
            int SecondResult = SecondRrectangle.Calculate();
            Console.WriteLine(SecondResult);
        }
    }
}
