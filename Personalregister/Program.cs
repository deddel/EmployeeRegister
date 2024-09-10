using System.ComponentModel;

namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create empty list of employees
            var employees = new List<Employee>();
            
            string answer = "j";

            //Add employees
            while (answer == "j")
            {
                Console.Write("Namn: ");
                string name = Console.ReadLine()!;
                Console.Write("Lön: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Employee empl = new(name, salary);
                employees.Add(empl); 
                Console.WriteLine("Om du vill fortsätta svara j annars svara n.");
                answer = Console.ReadLine()!;
            }
            
            //Print the employee register
            Console.WriteLine("\nNamn\t\tLön");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Name}\t\t{emp.Wage}");
            }
        }
    }
}
