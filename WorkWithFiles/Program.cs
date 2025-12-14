using System.Security.Principal;
using WorkWithFiles;

DaLogic logic = new();

int numbersOfWords = logic.ReadingTheFile();
Console.WriteLine(numbersOfWords);