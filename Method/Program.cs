using System; // Gives access to Console and basic functionality.

namespace LamiaAlKhalaf_MethodDemo
{
    // 📚 A simple class to show how methods can take parameters and do math.
    public class MathHelper
    {
        // 🧠 A method that takes two numbers, performs a calculation,
        // and displays both results to the console.
        public void ProcessNumbers(int firstNum, int secondNum)
        {
            // Perform a math operation (example: add 10 to the first number)
            int result = firstNum + 10;

            // Display what happened
            Console.WriteLine($"When we add 10 to {firstNum}, we get: {result}");
            Console.WriteLine($"The second number is: {secondNum}");
        }
    }

    // 🚀 Main entry point for the app
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathHelper class
            MathHelper helper = new MathHelper();

            // 🧩 Call the method normally with two numbers
            helper.ProcessNumbers(5, 12);

            // 🧩 Call the same method but this time use named parameters
            helper.ProcessNumbers(firstNum: 9, secondNum: 3);

            // Wait for the user before closing the app
            Console.WriteLine("\nPress any key to finish...");
            Console.ReadKey();
        }
    }
}
