using Demo.Fifa;
using System.Runtime.InteropServices;

namespace Demo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Generic Collection Hashtable [Dictionary]
            // Dictionary is a generic collection that stores key-value pairs.
            // It is a collection of keys and values.

            //Dictionary<string, int> PhoneBook = new Dictionary<string, int>();

            //PhoneBook.Add("John", 1234567890);
            //PhoneBook.Add("Jane", 1876543210);
            //PhoneBook.Add("Doe", 67891230);

            //PhoneBook.Add("John", 1234567890); // Duplicate key is not allowed
            //// exception: An item with the same key has already been added.
            ////unsafe 
            //// keys must be unique

            //PhoneBook["John"] = 5555; // Update value indexer as setter
            //Console.WriteLine(PhoneBook["John"]); // 5555 // indexer as getter

            //PhoneBook["Jojo"] = 5555; // addm new key-value pair using indexer
            //// preferred method to add/update key-value pair

            //if(!PhoneBook.ContainsKey("Jianna")) // check if key exists
            //{
            //    PhoneBook.Add("Jianna", 1234567890);
            //}
            //else
            //{
            //    PhoneBook["Jianna"] = 1234567890; // update value
            //}

            //if(!PhoneBook.TryAdd("Jianna", 1234567890))
            //    PhoneBook["Jianna"] = 1234567890; // update value


            //bool result = PhoneBook.TryAdd("Jianna", 1234567890); // TryAdd method
            //// returns false if key already exists

            //Console.WriteLine(PhoneBook["Yasmine"]); // exception: KeyNotFoundException
            //// unsafe code

            //Console.WriteLine(PhoneBook.TryGetValue("Yasmine", out int value)); // false

            //Console.WriteLine(value); // 0



            //foreach (KeyValuePair<string, int> entry in PhoneBook)
            //{
            //    //Console.WriteLine(entry);
            //    Console.WriteLine(entry.Key + " : " + entry.Value);
            //}
            #endregion

            #region Generic Collections HashSet

            //HashSet<int> numbers = new HashSet<int>();
            //// HashSet is a generic collection that stores unique elements.

            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //// returns true

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Add(1); // duplicate element is not allowed
            // no exception is thrown
            // returns false

            // Sorted Dictionary
            // Sorted List
            // Sorted Set

            #endregion

            #region Implicitly Typed Local Variable [var, dynaminc]

            #region Var
            // var Name = "John"; // implicit type
            // Compiler will detect the type of the variable at compile time
            //based on the value assigned to it.

            //var X; // error: cannot infer type (Var must be initialzied)
            //Name = null; // invalid Var cannot be initialized with null
            //Name = 123; // error: cannot convert int to string

            // Name = "Mai"; // valid as Name is of type string 
            #endregion

            #region dynamic

            // dynamic Data = "Ali";
            // dynamic type
            // CLR determines the type of the variable at runtime
            // based on the last value assigned to it.

            // Data = 123; // valid

            // can declare variable with dynamic without initializing it
            // dynamic X;

            // dynamic U = null; // valid
            // dynamic can be initialized with null
            // dynamic can be assigned any value of any type

            // dynamic is not type safe
            // dynamic is not recommended to use


            #endregion

            
            #region Extension Method

            //int X = 12345;

            //int Y = IntExtension.Reverse(X);

            //Console.WriteLine(Y);



            #endregion

            #endregion

            #region Anonymous Type
            //Employee employee = new Employee
            //{
            //    Id = 10,
            //    Name = "John",
            //    Salary = 1000
            //};

            //object employee = new
            //{
            //    Id = 10,
            //    Name = "John",
            //    Salary = 1000
            //};

            //Console.WriteLine(employee.Name); // invalid

            var Employee = new
            {
                Id = 10,
                Name = "John",
                Salary = 1000
            };
            // object thta will be created from anonymous type is an immutable object

            //Employee.Salary = 90; // invalid

            Console.WriteLine(Employee.GetType().Name); // AnonymousType03

            var Empoyee2 = new
            {
                Id = Employee.Id,
                Name = Employee.Name,
                Salary = 2000
            };

            var Employee3 = Empoyee2 with { Salary = 3000 }; // with expression

            // // the same anonymous type can be created multiple times as long as
            // // 1. the properties have the same name
            // // 2. the properties have the same Order

            var employee4 = new
            {
                Salary = 1000,
                Id = 10,
                Name = "John"
            }; // new anonymous type

            var employee5 = new
            {
               id = 10,
                name = "John",
                salary = 1000
            }; // new anonymous type




            #endregion

              #region Event Handling

            Ball ball = new Ball() { Id = 1 };

            Player P01 = new Player() { Name = "John", Team = "A" };
            Player P02 = new Player() { Name = "Jane", Team = "A" };
            Player P03 = new Player() { Name = "messi", Team = "B" };
            Player P04 = new Player() { Name = "Ronaldo", Team = "B" };

            Refree Ref01 = new Refree() { Name = "Refree 1" };

            ball.Location = new Location() { X = 10, Y = 20, Z = 30 };

            ball.BallLocationChange += P01.Run;
            ball.BallLocationChange += P02.Run;
            ball.BallLocationChange += P03.Run;
            ball.BallLocationChange += P04.Run;
            ball.BallLocationChange += Ref01.Look;

            ball.Location = new Location() { X = 11, Y = 22, Z = 33 };
            

            #endregion
        }
    }
}
