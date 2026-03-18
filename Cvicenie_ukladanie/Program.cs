namespace Cvicenie_ukladanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napis co treba:");
            string subor = "osoba.txt";
            string command = Console.ReadLine();
            if (command=="write")
            {
                osoba osoba1 = new osoba(meno:"igor",vek:45    );
                string line0s = osoba1.udajeodelenelenciarkou();
                File.WriteAllText(subor, line0s);
            }
            if (command== "read")
            {
                string[] read = File.ReadAllText(subor);
                string[] dataArr = read.Split(',');
                string name = dataArr[0];
                int vek = int.Parse(dataArr[1]);
                osoba nacitania = new osoba(name,vek);

            }

            /*
            osoba osoba1 = new osoba(meno: "igor", vek: 17);
            osoba osoba2 = new osoba(meno: "riso", vek: 16);
            osoba osoba3 = new osoba(meno: "kastrol", vek: 15);
            string line = osoba1.udajeodelenelenciarkou();
            string subor = "osoba.txt";
            
            List<string> list = new List<string>();
            string line1 = osoba1.udajeodelenelenciarkou();
            list.Add(line1);
            list.Add(osoba2.udajeodelenelenciarkou());
            list.Add(osoba3.udajeodelenelenciarkou());
            
            
            // File.WriteAllText(subor,line);
            */
        }
    }
}
