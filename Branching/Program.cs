using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight exceeds the limit
        if (weight > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt for package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt for package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt for package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if total dimensions exceed the limit
        double dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate volume of package
        double volume = width * height * length;

        // Calculate shipping quote
        double quote = (volume * weight) / 100;

        // Display the shipping quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}
