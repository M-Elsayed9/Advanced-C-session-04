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

            HashSet<int> numbers = new HashSet<int>();
            // HashSet is a generic collection that stores unique elements.

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            // returns true

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Add(1); // duplicate element is not allowed
            // no exception is thrown
            // returns false

            // Sorted Dictionary
            // Sorted List
            // Sorted Set

            #endregion
        }
    }
}
