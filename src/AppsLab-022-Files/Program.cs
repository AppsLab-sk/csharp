List<string> textList = new List<string>();

Console.WriteLine("Ukladanie do súboru:");
string? nápis = Console.ReadLine();

string FilePath = "\\\\fs1\\Data_studenti$\\2025\\cvengrosm25\\Desktop\\._\\" + nápis;

for (int i = 0; i < 1;) 
{



    Console.WriteLine("Napíš niečo... (koniec = ukončenie programu)");
    string? Text = Console.ReadLine();



    if (Text == "koniec")
    {
        i = 1;
        File.AppendAllLines(FilePath, textList);


    }
    else
    {
        textList.Add(Text);


}



