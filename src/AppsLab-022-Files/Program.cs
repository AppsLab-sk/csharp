
List<string> textList = new List<string>();

Console.WriteLine("What .txt?");
string? TextTextName = Console.ReadLine();

string FilePath = "\\\\fs1\\Data_studenti$\\2025\\mahutm25\\Desktop\\fafafela\\" + TextTextName;

for (int i = 0; i < 1;) 
{

    

    Console.WriteLine("Text? (end = ...well, ending the program)");
    string? Text = Console.ReadLine();


    

    if (Text == "end")
    {
        i = 1;
        File.AppendAllLines(FilePath, textList);


    }
    else
    {
        textList.Add(Text);
    }

    string text = File.ReadAllText(FilePath);

    Console.WriteLine("\n" + text + $"{Text}");

}








//https://github.com/AppsLab-sk/csharp/blob/main/lekcie/AppsLab-022-Files.md