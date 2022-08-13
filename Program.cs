namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            Console.WriteLine("-------------Welcome to Address Book Program------------ ");
            Person person = new Person("Aaradhya", "Devkar", "Hadapsar", "pune", "maharashtra", "412308", "9673683178", "jyotidhage10@gmail.com");
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            Console.Read();
            }
    }
}
