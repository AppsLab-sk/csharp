using Newtonsoft.Json;


namespace AppsLab_033_NuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "Jano", Age = 16 };

            string json = JsonConvert.SerializeObject(person, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}