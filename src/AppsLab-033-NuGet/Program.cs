using Newtonsoft.Json;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "Jano", Age = 25 };

            string json = JsonConvert.SerializeObject(person, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}