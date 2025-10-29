
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

Console.Clear();

Console.WriteLine("zadaj text"); 
string input = Console.ReadLine();
input = input.ToLower();
string output = "";
string[,] matrix = new string[35, 130];
int offset = 0;
foreach (char letter in input)
{
    output = output + GetLetter(letter.ToString());
}


foreach (char intputletter in input)
{
    string outLetter = GetLetter(intputletter.ToString());
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
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}



string GetLetter( string input )
{
    return  input switch
    {
        "a" or "A"=> GetLetterA(),
        "b" or "B"=> GetLetterB(),
        "c" or "C"=> GetLetterC(),
        "d" or "D"=> GetLetterD(),
        "e" or "E"=> GetLetterE(),
        "f" or "F"=> GetLetterF(),
        "g" or "G"=> GetLetterG(),
        "h" or "H"=> GetLetterH(),
        "i" or "I"=> GetLetterI(),
        "j" or "J"=> GetLetterJ(),
        "k" or "K"=> GetLetterK(),
        "l" or "L"=> GetLetterL(),
        "m" or "M"=> GetLetterM(),
        "n" or "N"=> GetLetterN(),
        "o" or "O"=> GetLetterO(),
        "p" or "P"=> GetLetterP(),
        "q" or "Q"=> GetLetterQ(),
        "r" or "R"=> GetLetterR(),
        "s" or "S"=> GetLetterS(),
        "t" or "T"=> GetLetterT(),
        "u" or "U"=> GetLetterU(),
        "v" or "V"=> GetLetterV(),
        "w" or "W"=> GetLetterW(),
        "x" or "X"=> GetLetterX(),
        "y" or "Y"=> GetLetterY(),
        "z" or "Z"=> getLetterZ(),
        _ =>  "zle pismeno lil boy"

    };
}


    
string GetLetterA()
{ 
    return @"
  ___  
 / _ \ 
/ /_\ \
|  _  |
| | | |
\_| |_/
       
       ";
}
string GetLetterB()
{
    return @"
______ 
| ___ \
| |_/ /
| ___ \
| |_/ /
\____/ 
       
       ";
}
string GetLetterC()
{
    return @"
 _____ 
/  __ \
| /  \/
| |    
| \__/\
 \____/
       
       ";
}
string GetLetterD()
{
    return @"
______ 
|  _  \
| | | |
| | | |
| |/ / 
|___/  
       
       
       
";
}

string GetLetterE()
{
    return @"
 _____ 
|  ___|
| |__  
|  __| 
| |___ 
\____/ 
       
       
       
       ";
}


string GetLetterF()
{
    return @"
______ 
|  ___|
| |_   
|  _|  
| |    
\_|    
       
       ";
}
string GetLetterG()
{

    return @"
 _____ 
|  __ \
| |  \/
| | __ 
| |_\ \
 \____/
       
       ";
}
string GetLetterH()
{

    return @"
 _   _ 
| | | |
| |_| |
|  _  |
| | | |
\_| |_/
       
       
       
       ";
}
string GetLetterI()
{
    return @"
 _____ 
|_   _|
  | |  
  | |  
 _| |_ 
 \___/ 
       
       
       
       ";
}
string GetLetterJ()
{
    return @"   
    ___ 
  |_  |
    | |
    | |
/\__/ /
\____/ 
       
       ";
}
string GetLetterK()
{
    return @"
 _   __
| | / /
| |/ / 
|    \ 
| |\  \
\_| \_/
       
       ";
}
string GetLetterL()
{
    return @" 
_     
| |    
| |    
| |    
| |____
\_____/
       
       
";
}
string GetLetterM()
{
    return @"
___  ___
|  \/  |
| .  . |
| |\/| |
| |  | |
\_|  |_/
        
        ";
}
string GetLetterN()
{

    return @"
 _   _ 
| \ | |
|  \| |
| . ` |
| |\  |
\_| \_/
       
       ";
}
string GetLetterO()
{
    return @"
 _____ 
|  _  |
| | | |
| | | |
\ \_/ /
 \___/ 
       
       ";
}
string GetLetterP()
{
    return @"
______ 
| ___ \
| |_/ /
|  __/ 
| |    
\_|    
       
       ";

}
string GetLetterQ()
{
    return @"
 _____ 
|  _  |
| | | |
| | | |
\ \/' /
 \_/\_\
       
       ";
}
string GetLetterR()
{
    return @"
______ 
| ___ \
| |_/ /
|    / 
| |\ \ 
\_| \_|
       
       ";
}
 string GetLetterS()
{
    return @"
 _____ 
/  ___|
\ `--. 
 `--. \
/\__/ /
\____/ 
       
       ";
}
string GetLetterT()
{
    return @" 
 _____ 
|_   _|
  | |  
  | |  
  | |  
  \_/  
       
       ";
}
string GetLetterU()
{
    return @"
 _   _ 
| | | |
| | | |
| | | |
| |_| |
 \___/ 
       
       ";
}
string GetLetterV()
{
    return @" 
 _   _ 
| | | |
| | | |
| | | |
\ \_/ /
 \___/ 
       
       ";
}
string GetLetterW()
{
    return @" _    _ 
| |  | |
| |  | |
| |/\| |
\  /\  /
 \/  \/ 
        
        ";
}
string GetLetterX()
{
    return @"
__   __
\ \ / /
 \ V / 
 /   \ 
/ /^\ \
\/   \/
       
       ";
}
    string GetLetterY()
{
    return @"
__   __
\ \ / /
 \ V / 
  \ /  
  | |  
  \_/  
       
       ";
}
string getLetterZ()
{
    return @" 
______
|___  /
   / / 
  / /  
./ /___
\_____/
       
       ";
}