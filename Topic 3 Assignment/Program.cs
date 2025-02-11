using Microsoft.VisualBasic;

namespace Topic_3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String courseName, FullName;
            int roomNumber, gradYear, length, width, perimeter;
            double price, radius, pie, area;

            roomNumber = 29;
            gradYear = 2026;
            length = 6;
            width = 11;
            perimeter = (2 * (length + width));
            courseName = "Computer Science";
            price = 2.99;
            pie = 3.14;  //Number to calulate radius
            radius = 5;  //Centimeters
            area = 3.14 * (radius * radius);  //Place holder number, Centimeters
            FullName = "Linkin Krysa";

            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is $" + price);
            Console.WriteLine("I am learning a bit about " + courseName);
            Console.WriteLine();
            Console.WriteLine("My name is " + FullName + " and I'll graduate in " + gradYear);
            Console.WriteLine();
            Console.WriteLine("To find the area of a circle," + " You will want to multiply " + pie + " by " + radius + " and radius is multiplied by itself then multiplied to pie " + "and that will give you the area.");
            Console.WriteLine("When we multiply " + pie + " by " + radius + ", " + "You will get " + area);
            Console.WriteLine();
            Console.WriteLine("My favourite mathmatical formula is finding the perimeter of a rectangle. " + "If we take " + length + " and multiply it by " + width + " We get " + perimeter);

        }
    }
}
