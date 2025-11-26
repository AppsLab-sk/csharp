Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine("Zadajte text");
string input = Console.ReadLine();
string output = "";
string[,] matrix = new string[100, 100];
int offset = 0;

foreach (char inputletter in input)
{
    string outletter = Getletter(inputletter.ToString());
    string[] lines = outletter.Split(Environment.NewLine);
    int letterWight = 0;
    for (int i = 0; i < lines.Length; i++)
    {
        string charakter = lines[i];
        letterWight = Math.Max(lines[i].Length, letterWight);

        for (int j = 0; j < charakter.Length; j++)
        {
            matrix[i, j + offset] = charakter[j].ToString();
        }
    }
    offset = offset + letterWight;
}
for (int i = 0;i < matrix.GetLength(0);i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}

  
string Getletter (string input)
{
    switch (input)
    {
          case "a":
    case "A":
    case "á":
    case "Á":
            return GetletterA();
        case "b":
        case "B":
            return GetletterB();
        case "c":
        case "C":
        case "č":
        case "Č":
           return   GetletterC();
        case "d":
        case "ď":
        case "D":
        case "Ď":
           return GetletterD();
        case "e":
        case "é":
        case "E":
        case "É":
            return GetletterE();
        case "f":
        case "F":
          return  GetletterF();
        case "g":
        case "G":
           return GetletterG();
        case "h":
        case "H":
            return GetletterH();
        case "i":
        case "í":
        case "I":
        case "Í":
           return GetletterI();
        case "j":
        case "J":
            return GetletterJ();
        case "k":
        case "K":
           return GetletterK();
        case "l":
        case "ĺ":
        case "ľ":
        case "L":
        case "Ĺ":
        case "Ľ":
           return GetletterL();
        case "m":
        case "M":
            return GetletterM();
        case "n":
        case "N":
            return GetletterN();
        case "o":
        case "ó":
        case "O":
        case "Ó":
            return GetletterO();
        case "p":
        case "P":
            return GetletterP();
        case "q":
        case "Q":
            return GetletterQ();
        case "r":
        case "ŕ":
        case "R":
        case "Ŕ":
            return GetletterR();
        case "s":
        case "š":
        case "S":
        case "Š":
            return GetletterS();
        case "t":
        case "ť":
        case "T":
        case "Ť":
            return GetletterT();
        case "u":
        case "ú":
        case "U":
        case "Ú":
            return GetletterU();
        case "v":
        case "V":
            return GetletterV();
        case "w":
        case "W":
            return GetletterW();
        case "x":
        case "X":
            return GetletterX();
        case "y":
        case "ý":
        case "Y":
        case "Ý":
            return GetletterY();
        case "z":
        case "Z":
        case "ž":
        case "Ž":
            return GetletterZ();
        default: 
            return "Písmeno nieje podporované";

    }
}

Console.WriteLine(output);
string GetletterA()
{
    return @"
.------.
|A.--. |
| (\/) |
| :\/: |
| '--'A|
`------'";
}


Console.WriteLine(output);
string GetletterB()
{
    return @"
.------.
|B.--. |
| :(): |
| ()() |
| '--'B|
`------'";

}


        Console.WriteLine(output);
string GetletterC()
{
    return @"
.------.
|C.--. |
| :/\: |
| :\/: |
| '--'C|
`------'";
}


Console.WriteLine(output);
string GetletterD()

{
    return @"
.------.
|D.--. |
| :/\: |
| (__) |
| '--'D|
`------'";
}



Console.WriteLine(output);
string GetletterE()
{
    return @"
.------.
|E.--. |
| (\/) |
| :\/: |
| '--'E|
`------'";
}


Console.WriteLine(output);
string GetletterF()
{
    return @"
.------.
|F.--. |
| :(): |
| ()() |
| '--'F|
`------'";
}



Console.WriteLine(output);
string GetletterG()
{
    return @"
.------.
|G.--. |
| :/\: |
| :\/: |
| '--'G|
`------'";
}



Console.WriteLine(output);
string GetletterH()
{
    return @"
.------.
|H.--. |
| :/\: |
| (__) |
| '--'H|
`------'";
}



Console.WriteLine(output);
string GetletterI()
{
    return @"
.------.
|I.--. |
| (\/) |
| :\/: |
| '--'I|
`------'";
}



Console.WriteLine(output);
string GetletterJ()
{
    return @"
.------.
|J.--. |
| :(): |
| ()() |
| '--'J|
`------'";
}


Console.WriteLine(output);
string GetletterK()
{
    return @"
.------.
|K.--. |
| :/\: |
| :\/: |
| '--'K|
`------'";
}


Console.WriteLine(output);
string GetletterL()
{
    return @"
.------.
|L.--. |
| :/\: |
| (__) |
| '--'L|
`------'";
}


Console.WriteLine(output);
string GetletterM()
{
    return @"
.------.
|M.--. |
| (\/) |
| :\/: |
| '--'M|
`------'";
}


Console.WriteLine(output);
string GetletterN()
{
    return @"
.------.
|N.--. |
| :(): |
| ()() |
| '--'N|
`------'";
}

Console.WriteLine(output);
string GetletterO()
{
    return @"
.------.
|O.--. |
| :/\: |
| :\/: |
| '--'O|
`------'";
}

Console.WriteLine(output);
string GetletterP()
{
    return @"
.------.
|P.--. |
| :/\: |
| (__) |
| '--'P|
`------'";
}
    

Console.WriteLine(output);
string GetletterQ()
{
    return @"
.------.
|Q.--. |
| (\/) |
| :\/: |
| '--'Q|
`------'";
  
}


Console.WriteLine(output);
string GetletterR()
{
    return @"
.------.
|R.--. |
| :(): |
| ()() |
| '--'R|
`------'";
}

Console.WriteLine(output);
string GetletterS()
{
    return @"
.------.
|S.--. |
| :/\: |
| :\/: |
| '--'S|
`------'";
}

    Console.WriteLine(output);
string GetletterT()
    {
        return @"
.------.
|T.--. |
| :/\: |
| (__) |
| '--'T|
`------'";
    }

Console.WriteLine(output);
string GetletterU()
{
    return @"
.------.
|U.--. |
| (\/) |
| :\/: |
| '--'U|
`------'";
    
}

Console.WriteLine(output);
string GetletterV()
{
    return @"
.------.
|V.--. |
| :(): |
| ()() |
| '--'V|
`------'";
}

Console.WriteLine(output);
string GetletterW()
{
    return @"
.------.
|W.--. |
| :/\: |
| :\/: |
| '--'W|
`------'";
}

Console.WriteLine(output);
string GetletterX()
{
    return @"
.------.
|X.--. |
| :/\: |
| (__) |
| '--'X|
`------'";
}

Console.WriteLine(output);
string GetletterY()
{
    return @"
.------.
|Y.--. |
| (\/) |
| :\/: |
| '--'Y|
`------'";
}

Console.WriteLine(output);
string GetletterZ()
{
    return @"
.------.
|Z.--. |
| :(): |
| ()() |
| '--'Z|
`------'";
}