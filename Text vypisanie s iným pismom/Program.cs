
Console.WriteLine("Type some text here");
string input = Console.ReadLine();
string output = "";
string[,] matrix = new string[20, 120];
int offset = 0;

foreach (char inputLetter in input)
{
    string outLetter = GetLetter(inputLetter.ToString());
    string[] lines = outLetter.Split(Environment.NewLine);
    int letterWidth = 0;

    for (int j = 0; j < lines.Length; j++)
    {
        string character = lines[j];
        letterWidth = Math.Max(character.Length, letterWidth);

        for (int k = 0; k < character.Length; k++)
        {
            matrix[j, k + offset] = character[k].ToString();
        }
    }
    offset += letterWidth;
}

for (int k = 0; k < matrix.GetLength(0); k++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[k, j] ?? " "); // Use null-coalescing operator to handle null values
    }
    Console.WriteLine();
}

string GetLetter(string input)

    {
        switch (input)
        {
            case "a":
            case "A":
            case "á":
            case "Á":
                return GetLetterA();
            case "b":
            case "B":
                return GetLetterB();
            case "c":
            case "C":
            case "č":
            case "Č":
                return GetLetterC();
            case "d":
            case "D":
            case "ď":
            case "Ď":
                return GetLetterD();

            case "e":
            case "E":
                return GetLetterE();
            case "f":
            case "F":
                return GetLetterF();
            case "g":
            case "G":
                return GetLetterG();
            case "h":
            case "H":
                return GetLetterH();
            case "i":
            case "I":
            case "í":
            case "Í":
                return GetLetterI();
            case "j":
            case "J":
                return GetLetterJ();
            case "k":
            case "K":
                return GetLetterK();
            case "l":
            case "L":
                return GetLetterL();
            case "m":
            case "M":
                return GetLetterM();
            case "n":
            case "N":
                return GetLetterN();
            case "o":
            case "O":
            case "ô":
            case "ó":
                return GetLetterO();
            case "p":
            case "P":
                return GetLetterP();
            case "q":
            case "Q":
                return GetLetterQ();
            case "r":
            case "R":
                return GetLetterR();
            case "s":
            case "S":
            case "š":
            case "Š":
                return GetLetterS();
            case "t":
            case "T":
            case "ť":
            case "Ť":
                return GetLetterT();
            case "u":
            case "U":
            case "ú":
            case "Ú":
                return GetLetterU();
            case "v":
            case "V":
                return GetLetterV();
            case "w":
            case "W":
                return GetLetterW();
            case "x":
            case "X":
                return GetLetterX();
            case "y":
            case "Y":
            case "ý":
            case "Ý":
                return GetLetterY();
            case "z":
            case "Z":
            case "ž":
            case "Ž":
                return GetLetterZ();
            case "0":
                return GetNumber0();
            case "1":
                return GetNumber1();
            case "2":
                return GetNumber2();
            case "3":
                return GetNumber3();
            case "4":
                return GetNumber4();
            case "5":
                return GetNumber5();
            case "6":
                return GetNumber6();
            case "7":
                return GetNumber7();
            case "8":
                return GetNumber8();
            case "9":
                return GetNumber9();
            default:
                return "Písmeno nie je podporované.";
        }
    }


    string GetLetterA()
    {
        return @"
_____      
\__  \     
 / __ \_  
(____  /   
     \/ ";
    }


    string GetLetterB()
    {
        return @"
___.
\_ |__
 | __ \
 | \_\ \
 |___  /
     \/ ";
    }


    string GetLetterC()
    {
        return @"    
  ____  
_/ ___\
\  \___
 \___  >
     \/ ";
    }

    string GetLetterD()
    {
        return @"    
    .___
  __| _/
 / __ |
/ /_/ |
\____ |
     \/  ";
    }

    string GetLetterE()
    {
        return @"        
  ____  
_/ __ \
\  ___/
 \___  >
     \/  ";
    }

    string GetLetterF()
    {
        return @"    
  _____
_/ ____\
\   __\
 |  |  
 |__|  
        ";
    }

    string GetLetterG()
    {
        return @"      
   ____  
  / ___\
 / /_/  >
 \___  /
/_____/  ";
    }


    string GetLetterH()
    {
        return @"    
.__    
|  |__  
|  |  \
|   Y  \
|___|  /
     \/ ";
    }



    string GetLetterI()
    {
        return @"    
.__
|__|
|  |
|  |
|__|
    ";
    }


    string GetLetterJ()
    {
        return @"    
     __
    |__|
    |  |
    |  |
/\__|  |
\______|";
    }

    string GetLetterK()
    {
        return @"    
 __    
|  | __
|  |/ /
|    <
|__|_ \
     \/";
    }

    string GetLetterL()
    {
        return @"    
.__  
|  |  
|  |  
|  |__
|____/
      ";
    }

    string GetLetterM()
    {
        return @"        
  _____  
 /     \  
|  Y Y  \
|__|_|  /
      \/  ";
    }

    string GetLetterN()
    {
        return @"    
       
  ____  
 /    \
|   |  \
|___|  /
     \/ ";
    }

    string GetLetterO()
    {
        return @"          
  ____  
 /  _ \
(  <_> )
 \____/
        ";
    }

    string GetLetterP()
    {
        return @"    
______  
\____ \
|  |_> >
|   __/
|__|    ";
    }

    string GetLetterQ()
    {
        return @"    
  ______
 / ____/
< <_|  |
 \__   |
    |__|";
    }

    string GetLetterR()
    {
        return @"        
_______
\_  __ \
 |  | \/
 |__|  
        ";
    }

    string GetLetterS()
    {
        return @"      
  ______
 /  ___/
 \___ \
/____  >
     \/ ";
    }

    string GetLetterT()
    {
        return @"    
  __  
_/  |_
\   __\
 |  |  
 |__|  
       ";
    }

    string GetLetterU()
    {
        return @"    
       
 __ __
|  |  \
|  |  /
|____/
       ";
    }

    string GetLetterV()
    {
        return @"      
___  __
\  \/ /
 \   /
  \_/  
       ";
    }


    string GetLetterW()
    {
        return @"          
__  _  __
\ \/ \/ /
 \     /
  \/\_/  
         ";
    }


    string GetLetterX()
    {
        return @"    
___  ___
\  \/  /
 >    <
/__/\_ \
      \/";
    }




    string GetLetterY()
    {
        return @"      
 ___.__.
<   |  |
 \___  |
 / ____|
 \/     ";
    }




    string GetLetterZ()
    {
        return @"          
________
\___   /
 /    /
/_____ \
      \/";
    }
    string GetNumber1()
    {
        return @"          
 ____
/_   |
 |   |
 |   |
 |___|
      ";
    }
    string GetNumber2()
    {
        return @"          
________  
\_____  \
 /  ____/
/       \
\_______ \
        \/";
    }
    string GetNumber3()
    {
        return @"          
________  
\_____  \
  _(__  <
 /       \
/______  /
       \/ ";
    }
    string GetNumber4()
    {
        return @"          
   _____  
  /  |  |
 /   |  |_
/    ^   /
\____   |
     |__| ";
    }
    string GetNumber5()
    {
        return @"          
 .________
 |   ____/
 |____  \
 /       \
/______  /
       \/ ";
    }
    string GetNumber6()
    {
        return @"          
  ________
 /  _____/
/   __  \
\  |__\  \
 \_____  /
       \/ ";
    }
    string GetNumber7()
    {
        return @"          
_________
\______  \
    /    /
   /    /
  /____/  ";
    }
    string GetNumber8()
    {
        return @"
  ______  
 /  __  \
 >      <
/   --   \
\______  /
       \/ ";
    }
    string GetNumber9()
    {
        return @"          
 ________
/   __   \
\____    /
   /    /
  /____/  
          ";
    }
    string GetNumber0()
    {
        return @"          
_______  
\   _  \  
/  /_\  \
\  \_/   \
 \_____  /
       \/ ";
    }
