Console.ForegroundColor = ConsoleColor.Magenta;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Zadajte pismeno:");
string input  = Console.ReadLine();;
string output = "";
string[,] matrix = new string[35, 120];
int offset = 0;


foreach (char inputletter in input)
{
    string outLetter = GetLetter (inputletter.ToString());
    string[] lines = outLetter.Split(Environment.NewLine);
    int letterWidth = 0;
    for (int i = 0; i < lines.Length; i++)
    {
        string character = lines[i];
        letterWidth = Math.Max(lines[i].Length, letterWidth);
        for (int j = 0; j < character.Length; j++)
        {
            matrix[i, j + offset] = character[j].ToString();
        } 
       
    }
       
    offset = offset + letterWidth;
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{ 
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}




Console.WriteLine (output);
string GetLetter(string input)
{
    switch (input)
    {
        case "a":
        case "A":
            return GetLetterA();
        case "B":
        case "b":
            return GetLetterB();
        case "C":
            case "c":
            return GetLetterC();
        case "D":
            case "d":
            return GetLetterD();
        case "E":
            case "e":
            return GetLetterE();
        case "F":
            case "f":
            return GetletterF();
        case "G":
            case "g":
            return GetLetterG();
        case "H":
            case "h":
            return GetLetterH();
        case "I":
            case "i":
            return GetLetterI();
        case "J":
            case "j":
            return GetLetterJ();
        case "K":
        case "k":
            return GetLetterK();
        case "L":
            case "l":
            return GetLetterL();
        case "M":
            case "m":
            return GetLetterM();
            case "N":
            case "n":
            return GetLetterN();
            case "O":
            case "o":
            return GetLetterO();
            case "P":
            case "p":
            return GetLetterP();
        case "Q":
            case "q":
            return GetLetterQ();
            case "R":
            case "r":
            return GetLetteR();
            case "S":
            case "s":
            return GetLetterS();
            case "T":
            case "t":
            return GetLetterT();
            case "U":
            case "u":
            return GetLetterU();
            case "V":
            case "v":
            return GetLetterV();
            case "X":
        case "x":
            return GetLetterX();
            case "Y":
            case "y":
            return GetLetterY();
            case "Z":
            case "z":
            return GetLetterZ();


        default: return  "nepodporovane pismenko";
    }
}



string GetLetterA()
{
    return @"
 ____ 
/  _ \
| / \|
| |-||
\_/ \| ";
      
      
}


string GetLetterB()
{ 

    return @";
    ____
/ _ \
| | //
| | _\\
\____ / ";

}

string GetLetterC()
{
    return @"
 ____ 
/   _\
|  /  
|  \_ 
\____/ "
;
}

string GetLetterD()
{
return @";

 ____
/ _ \
| | \|
| | _ /|
\____ /  ";

}


string GetLetterE()
{
    return @";
 _____
/  __/
|  \  
|  /_ 
\____\ ";
      
}

string GetletterF()
{
    return @";
 _____
/    /
|  __\
| |   
\_/   ";
      

}

string GetLetterG()
{
    return @":
 _____
/  __/
| |  _
| |_//
\____\ ";
      

}

string GetLetterH()
{
    return @"
 _    
/ \ /|
| |_||
| | ||
\_/ \| ";
      
}

string GetLetterI()
{
    return @":
 _ 
/ \
| |
| |
\_/ ";
   

}

string GetLetterJ()
{
    return @":
    _ 
   / |
   | |
/\_| |
\____/ ";
      
}

string GetLetterK()
{
    return @":
 _  __
/ |/ /
|   / 
|   \ 
\_|\_\ ";
      
}

string GetLetterL()
{
    return @":
 _    
/ \   
| |   
| |_/\
\____/ ";
      

}

string GetLetterM()
{
    return @":
 _     
/ \__/|
| |\/||
| |  ||
\_/  \| ";
       

}

string GetLetterN()
{
    return @":
 _     
/ \  /|
| |\ ||
| | \||
\_/  \| ";
       

}

string GetLetterO()
{
    return @":
 ____ 
/  _ \
| / \|
| \_/|
\____/ ";
      
}

string GetLetterP()
{
    return @":
 ____ 
/  __\
|  \/|
|  __/
\_/  "; 
      
}

string GetLetterQ()
{
    return @":
 ____ 
/  _ \
| / \|
| \_\|
\____\";
      
}

string GetLetteR()
{
    return @":
 ____ 
/  __\
|  \/|
|    /
\_/\_\ ";
      
}

string GetLetterS()
{
    return @":
 ____ 
/ ___\
|    \
\___ |
\____/ ";
      
}

string GetLetterT()
{
    return @":
 _____ 
/__ __\
  / \  
  | |  
  \_/ "; 
       
}

string GetLetterU()
{
    return @":
 _    
/ \ /\
| | ||
| \_/|
\____/ ";
      
}

string GetLetterV()
{
    return @":
 _    
/ \ |\
| | //
| \// 
\__/  ";

}

string GetLetterW()
{
    return @":
 _     
/ \  /|
| |  ||
| |/\||
\_/  \| ";
       

}

string GetLetterX()
{
    return @":
___  _
\  \//
 \  / 
 /  \ 
/__/\\ ";
      

}

string GetLetterY()
{
    return @":
___  _
\  \//
 \  / 
 / /  
/_/  ";
      

}

string GetLetterZ()
{
    return @":
 ____ 
/_   \
 /   /
/   /_
\____/ ";
      
}