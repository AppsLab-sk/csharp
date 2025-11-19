public class WordReader
{
    private const string _fileName = @"\\fs1\Data_studenti$\2025\kubiszr25\Desktop.txt";
    public int Countwords()
    { 
        string text = File.ReadAllText(_fileName);
        string[] words = text.Split(' ');
        return words.Length;
    
    
    }
}
