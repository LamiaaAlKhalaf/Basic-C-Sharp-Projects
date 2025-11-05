using System; // Brings in basic C# features like Console input/output.

namespace LamiaAlKhalaf_EmployeeInterfaceApp // A custom namespace named after the student.
{
    // 🧩 Step 1: Build an interface that sets a rule for quitting.
    // Any class that promises to follow this interface must include a Quit() method.
    public interface IQuittable
    {
        void Quit(); // The “contract” — whoever signs it must define how to quit.
    }

    // 🧑‍💼 Step 2: Create an Employee class that agrees to follow the IQuittable interface.
    // This means the Employee class *must* have its own version of the Quit() method.
    public class Employee : IQuittable
    {
        // A few basic properties for the Employee’s identity.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 🎯 Here’s how this particular Employee “quits.”
        // You could imagine sending a resignation email, but we’ll just print a message.
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} (ID #{Id}) has officially resigned from duty!");
            Console.WriteLine("We wish them all the best in their next adventure!");
        }
    }

    // 🚀 Step 3: The Program class is where everything begins to run.
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee and fill in some details.
            Employee lamia = new Employee
            {
                Id = 305,
                FirstName = "Lamia",
                LastName = "AlKhalaf"
            };

            // 💡 Here’s the magic of polymorphism:
            // We can treat an Employee object as an IQuittable type because it implements that interface.
            IQuittable quittablePerson = lamia;

            // Now we can call the Quit() method *through the interface reference*.
            quittablePerson.Quit();

            // Just a nice pause before the console window closes.
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}
