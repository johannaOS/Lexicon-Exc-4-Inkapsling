namespace Exc_4_Inkapsling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //ÖVNING 1
            var lines = 5;
            var persons = new List<Person>(); 
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2])); persons.Add(person);
            }
            persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
            */

            //ÖVNING 2
            var lines = 5; 
            var persons = new List<Person>();
            /* var person = new Person(
                 "Ida" , "Svensson", 65, 2200m
                 );
             persons.Add(person);*/
            Console.WriteLine("Enter 5 people:");
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split(); 
                var person = new Person(
                cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]
                ));
                persons.Add(person);
            }
            
            Console.WriteLine("Enter bonus in %:");
            var bonus = decimal.Parse(Console.ReadLine())/100; 
            persons.ForEach(p => p.IncreaseSalary(bonus)); persons.ForEach(p => Console.WriteLine(p.ToString()));

        }

        public class Person(string firstname, string lastname, int age, decimal sal)
        {
            // Setters: code that runs when property is assigned value.
            public string FirstName { get; set; } = firstname;
            public string LastName { get; set; } = lastname;
            public int Age { get; set; } = age;
            public decimal Salary { get; set;  } = sal;

            public override string ToString()
            {
               // return $"{FirstName} {LastName} is {Age} years old."; Övning 1
                return $"{FirstName} {LastName} receives {Salary} dollars.";
            }
            public void IncreaseSalary(decimal percentage)
            {
                if (Age < 30)
                    Salary *= 1 + percentage / 2;
                else
                    Salary *= 1 + percentage;
            }
        }
    }
}
