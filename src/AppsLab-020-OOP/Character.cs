
namespace AppsLab_020_OOP
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public void Entrance()
        {
            Console.WriteLine("The character makes an entrance");
        }

    }
     public class Mage : Character
    { 
    public void Entrance()
        {
            Console.WriteLine("Enkudu shall defeat you!");
        }
    }

}

