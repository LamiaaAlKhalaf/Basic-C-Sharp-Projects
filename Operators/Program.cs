using System; // Gives access to C#’s core classes like Console.

namespace LamiaAlKhalaf_OperatorOverloadDemo
{
    // 🌸 Employee class for Lamia's demo
    // This class can compare two employees based on their unique ID numbers.
    public class Employee
    {
        // 🧾 Basic details for each employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 💡 Overload the "==" operator — checks if two employees have the same Id.
        public static bool operator ==(Employee empA, Employee empB)
        {
            // Handle cases where both are null — they’re considered equal.
            if (ReferenceEquals(empA, null) && ReferenceEquals(empB, null))
                return true;

            // If one is null and the other isn’t, they’re definitely not equal.
            if (ReferenceEquals(empA, null) || ReferenceEquals(empB, null))
                return false;

            // Finally, compare by their unique IDs.
            return empA.Id == empB.Id;
        }

        // 💡 Overload the "!=" operator — must come in pairs with "=="
        public static bool operator !=(Employee empA, Employee empB)
        {
            // Just the opposite of our "==" result.
            return !(empA == empB);
        }

        // ✅ Override Equals() so the logic matches the operator overload.
        public override bool Equals(object obj)
        {
            var otherEmp = obj as Employee;
            if (otherEmp == null)
                return false;

            return this.Id == otherEmp.Id;
        }

        // ✅ Override GetHashCode() to align with Equals().
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

    // 🎬 The main program that runs our test
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects
            Employee lamia = new Employee { Id = 201, FirstName = "Lamia", LastName = "AlKhalaf" };
            Employee colleague = new Employee { Id = 202, FirstName = "Mona", LastName = "Salem" };

            // Compare them using the overloaded operators
            Console.WriteLine($"Comparing {lamia.FirstName} and {colleague.FirstName}...");
            Console.WriteLine("Are they the same employee? " + (lamia == colleague));
            Console.WriteLine("Are they different? " + (lamia != colleague));

            // Now let’s make them “equal” by giving them the same Id
            colleague.Id = 201;
            Console.WriteLine("\nAfter changing Mona’s ID to 201...");
            Console.WriteLine("Are they the same employee now? " + (lamia == colleague));

            Console.WriteLine("\nPress any key to exit the demo...");
            Console.ReadKey();
        }
    }
}
