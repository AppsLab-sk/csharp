class TestClass
{
    static void Main(string[] args)
    {
        List<string> listOfNames = new List<string>();
        while (true)
        {
            Console.WriteLine("Napiš meno:");
            var name = Console.ReadLine();
            Console.Clear();
            if (name == "Martin")
            {
                break;
            }
            else
            {
                  listOfNames.Add(name);
            }
            Console.WriteLine("List mien");
            foreach (var item in listOfNames)
            {
                Console.WriteLine(item);
            }
        }
    }
} 