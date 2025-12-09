
/*

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

List<string> Films = new List<string>();


const string FilePath = @"C:\Temp\Films.txt";


if (File.Exists(FilePath))
{
    var text = File.ReadAllText(FilePath);
    var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
    Films.AddRange(lines);
    Console.WriteLine($"Loaded {Films.Count} films from {FilePath}.");
}

for (int i = 0; i < 1000000; i++)
{
    Console.WriteLine("Choose from these ones: ( AddMovies(1),FindMovie(2), ShowMovies(3), DeleteMovie(4), EndProgram(5) )");
    string Choice = Console.ReadLine();

    if (Choice == "1")
    {
        AddFilm();
    }
    else if (Choice == "2")
    {
        FindFilm();
    }
    else if (Choice == "3")
    {
        ShowFilms();
    }
    else if (Choice == "4")
    {
        DeleteFilm();
    }
    else if (Choice == "5")
    {
        
        var contents = string.Join(Environment.NewLine, Films);
        File.WriteAllText(FilePath, contents);
        Console.WriteLine($"Saved {Films.Count} films to {FilePath}.");
        Console.WriteLine("You've ended the program");
        i = 1000000;
    }
    else
    {
        Console.WriteLine("Wrong choice");
    }

    string AddFilm()
    {
        Console.WriteLine("Write the name of the film you want to add:");
        string filmName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filmName))
        {
            Console.WriteLine("Film name cannot be empty.");
            return null;
        }

        bool alreadyExists = Films.Any(f => f.Equals(filmName, StringComparison.OrdinalIgnoreCase));

        if (alreadyExists)
        {
            Console.WriteLine($"\"{filmName}\" is already in the list.");
        }
        else
        {
            Films.Add(filmName);
            Console.WriteLine($"\"{filmName}\" has been added.");
        }

        return filmName;
    }

    string FindFilm()
    {
        Console.WriteLine("Write the name of the film you want to find:");
        string filmName = Console.ReadLine();

        foreach (string film in Films)
        {
            if (film.Equals(filmName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"The film \"{filmName}\" is in the list.");
                return filmName;
            }
        }

        Console.WriteLine($"The film \"{filmName}\" is not in the list.");
        return filmName;
    }

    string ShowFilms()
    {
        Console.WriteLine("The films in the list are:");
        foreach (string film in Films)
        {
            Console.WriteLine(film);
        }
        return "";
    }

    string DeleteFilm()
    {
        Console.WriteLine("Write the name of the film you want to delete:");
        string filmName = Console.ReadLine();

        for (int j = 0; j < Films.Count; j++)
        {
            if (Films[j].Equals(filmName, StringComparison.OrdinalIgnoreCase))
            {
                Films.RemoveAt(j);
                Console.WriteLine($"The film \"{filmName}\" has been deleted from the list.");
                return filmName;
            }
        }

        Console.WriteLine($"The film \"{filmName}\" is not in the list.");
        return filmName;
    }
}
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

List<string> Films = new List<string>();


const string FilePath = @"C:\Temp\Films.txt";


if (File.Exists(FilePath))
{
    var text = File.ReadAllText(FilePath);
    var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
    Films.AddRange(lines);
    Console.WriteLine($"Loaded {Films.Count} films from {FilePath}.");
}

for (int i = 0; i < 1000000; i++)
{
    bool endProgram = false;
    Console.WriteLine("Choose from these ones: ( AddMovies(1),FindMovie(2), ShowMovies(3), DeleteMovie(4), EndProgram(5) )");
    string Choice = Console.ReadLine();

    if (Choice == "1")
    {
        AddFilm();
    }
    else if (Choice == "2")
    {
        FindFilm();
    }
    else if (Choice == "3")
    {
        ShowFilms();
    }
    else if (Choice == "4")
    {
        DeleteFilm();
    }
    else if (Choice == "5")
    {

        var contents = string.Join(Environment.NewLine, Films);
        File.WriteAllText(FilePath, contents);
        Console.WriteLine($"Saved {Films.Count} films to {FilePath}.");
        Console.WriteLine("You've ended the program");
        endProgram = true;
    }
    else
    {
        Console.WriteLine("Wrong choice");
    }

    string AddFilm()
    {
        Console.WriteLine("Write the name of the film you want to add:");
        string filmName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filmName))
        {
            Console.WriteLine("Film name cannot be empty.");
            return null;
        }

        bool alreadyExists = Films.Any(f => f.Equals(filmName, StringComparison.OrdinalIgnoreCase));

        if (alreadyExists)
        {
            Console.WriteLine($"\"{filmName}\" is already in the list.");
        }
        else
        {
            Films.Add(filmName);
            Console.WriteLine($"\"{filmName}\" has been added.");
        }

        return filmName;
    }

    string FindFilm()
    {
        Console.WriteLine("Write the name of the film you want to find:");
        string filmName = Console.ReadLine();

        foreach (string film in Films)
        {
            if (film.Equals(filmName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"The film \"{filmName}\" is in the list.");
                return filmName;
            }
        }

        Console.WriteLine($"The film \"{filmName}\" is not in the list.");
        return filmName;
    }

    string ShowFilms()
    {
        Console.WriteLine("The films in the list are:");
        foreach (string film in Films)
        {
            Console.WriteLine(film);
        }
        return "";
    }

    string DeleteFilm()
    {
        Console.WriteLine("Write the name of the film you want to delete:");
        string filmName = Console.ReadLine();

        for (int j = 0; j < Films.Count; j++)
        {
            if (Films[j].Equals(filmName, StringComparison.OrdinalIgnoreCase))
            {
                Films.RemoveAt(j);
                Console.WriteLine($"The film \"{filmName}\" has been deleted from the list.");
                return filmName;
            }
        }

        Console.WriteLine($"The film \"{filmName}\" is not in the list.");
        return filmName;
    }
    if (endProgram == false)
    {
        i = 1;
        Console.WriteLine(i);
    }
    else if (endProgram == true)
    {
        i = 1000000;
    }
}




