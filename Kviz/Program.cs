using System;

class Question
{
    public string Text;
    public string Answer;

    public Question(string text, string answer)
    {
        Text = text;
        Answer = answer;
    }

    public bool Ask()
    {
        Console.WriteLine(Text);
        return Console.ReadLine()?.Trim().ToLower() == Answer.ToLower();
    }
}
