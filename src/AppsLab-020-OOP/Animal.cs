namespace AppsLab_020_OOP
{
    public class Animal //Trieda
    {
        public string Name { get; set; } //Vlastnost
        public int Age { get; set; } //Vlastnost

        public void Speak() // Metóda
        {
            Console.WriteLine("The animal makes a sound.");
        }
        public void Predstavenie() // Metóda
        {
            Console.WriteLine("Volam sa:" + Name + " je mi:" + Age );
        }
    }
}
