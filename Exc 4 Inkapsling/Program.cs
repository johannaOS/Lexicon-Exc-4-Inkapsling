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
            /*
            //ÖVNING 2
            var lines = 5;
            var persons = new List<Person>();
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
            persons.ForEach(p => p.IncreaseSalary(bonus)); persons.ForEach(p => Console.WriteLine(p.ToString()));*/

            // Övning 3
            var lines = 5;
            var persons = new List<Person>();
            Console.WriteLine("Enter 5 people:");
            
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(
                    cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]
                    ));
                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            
            Console.WriteLine("Enter bonus in %:");
            var bonus = decimal.Parse(Console.ReadLine()) / 100;
            persons.ForEach(p => p.IncreaseSalary(bonus)); persons.ForEach(p => Console.WriteLine(p.ToString()));

                 }

        public class Person 
        {
            //Private fields
            private string _firstname;
            private string _lastname;
            private int _age;
            private decimal _salary;
            // Properties
            // Setters: code that runs when property is assigned a value.
            public string FirstName
            {
                get { return _firstname; }
                set
                {
                    if (value.Trim().Length <  3)
                    {
                        throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                    }
                    _firstname = value.Trim();


                }
            }
            public string LastName
            {
                get { return _lastname; }
                set
                {
                    if (value.Trim().Length < 3)
                    {
                        throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                    }
                    _lastname = value.Trim();


                }
            }
            public int Age
            {
                get { return _age; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Age cannot be zero or negative!");
                    }
                    _age = value;
                }
            }
            public decimal Salary {
                get { return _salary; }
                set 
                {
                    if (value < 460)
                        throw new ArgumentException("Salary cannot be less than 460 dollars!.");
                    _salary = value;
                }  
            }
            //Construct
            public Person(string firstname, string lastname, int age, decimal sal)
            {
                FirstName = firstname; LastName = lastname; Age = age; Salary = sal;
            }

            //Methods
            public override string ToString()
            {
                //Övning 1
               // return $"{FirstName} {LastName} is {Age} years old."; 
               //Övning 2
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
