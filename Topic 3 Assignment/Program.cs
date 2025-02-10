namespace Topic_3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String courseName, FullName;
            int roomNumber, gradYear;
            double price, radius;

            roomNumber = 29;
            gradYear = 2026;
            courseName = "Computer Science";
            price = 2.99;
            radius = 3;  //Centimeters
            FullName = "Linkin Krysa";

            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is $" + price);
            Console.WriteLine("I am learning a bit about " + courseName);
            Console.WriteLine();
            Console.WriteLine("My name is " + FullName + " and I'll graduate in " + gradYear);


        }
    }
}
