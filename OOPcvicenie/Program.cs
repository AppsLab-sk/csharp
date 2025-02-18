using OOPcvicenie;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle mercedesbenz = new Vehicle();
            {
                mercedesbenz.EvidencecisloAuta = "BA158BS";
                mercedesbenz.RokVyroby = 2020;
                mercedesbenz.JePlatnaTK = true;
                mercedesbenz.PriemernaSpotreba = 5.1;
                mercedesbenz.TypMotora = 'E';
            }
            Vehicle Audi = new Vehicle();
            {
                Audi.EvidencecisloAuta = "ZA148BS";
                Audi.RokVyroby = 2010;
                Audi.JePlatnaTK = true;
                Audi.PriemernaSpotreba = 4.1;
                Audi.TypMotora = 'E';
            }

            Vehicle toyotaCorolla = new Vehicle("CA641YA", 2010, false, 5.6, 'B');

            Console.WriteLine("Info o mojom aute:" + mercedesbenz.EvidencecisloAuta);
            Console.WriteLine("Info o mojom aute:" + mercedesbenz.VypisAuta(true));
            Console.WriteLine("Info o mojom aute:" + toyotaCorolla.VypisAuta(false));


            List<Vehicle> list = new List<Vehicle>();   
            list.Add(toyotaCorolla);    
            list.Add(mercedesbenz);
            list.Add(Audi);
            foreach (Vehicle vehicle in list)
            {
                Console.WriteLine(vehicle.VypisAuta(true));
            }


        }
    }  
}    