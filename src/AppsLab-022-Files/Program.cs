
class program
{
    static void Main()
    {
        string road = @"\\fs1\Data_studenti$\2025\kubiszr25\Desktop\mnamka.txt";
        Console.WriteLine("pis text (napis 'koniec' pre ukoncenie):");
        StreamWriter subor = new StreamWriter(road);
        string riadok = "";

        while (riadok != "koniec")
        {
            riadok = Console.ReadLine();
            if (riadok != "koniec")
            { 
            subor.WriteLine(riadok);
            }
        }

       subor.Close();
        Console.WriteLine("hotovo! text bol ulozenz do suboru.");







    }   
}
