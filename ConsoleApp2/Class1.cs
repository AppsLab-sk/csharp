public class citac
{
    private const string _fileName = "C:\Users\NTB\OneDrive\Počítač\prax.txt";

    public int CountWords()
    {
      string text = File.ReadAllText(_fileName);
      string[] words = text.Split(' '11);
      return words.Length;
    }
}
