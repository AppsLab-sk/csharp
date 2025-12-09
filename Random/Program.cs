// See https://aka.ms/new-console-template for more information

int i = 0;
while (i < 100000000000000000)
{
    Console.WriteLine("Napis text");
    string input = Console.ReadLine();
    string output = "";

    switch (input)
    {
        case "a":
        case "A":
        case "á":
        case "Á":
            output = GetLetterA();
            break;
        case "b":
        case "B":
            output = GetLetterA();
            break;
        case "c":
        case "C":
        case "č":
        case "Č":
            output = GetLetterC();
            break;
        case "d":
        case "D":
        case "ď":
        case "Ď":
            output = GetLetterD();
            break;
        case "e":
        case "E":
            output = GetLetterE();
            break;
        case "f":
        case "F":
            output = GetLetterF();
            break;
        case "g":
        case "G":
            output = GetLetterG();
            break;
        case "h":
        case "H":
            output = GetLetterH();
            break;
        case "i":
        case "I":
        case "í":
        case "Í":
            output = GetLetterI();
            break;
        case "j":
        case "J":
            output = GetLetterJ();
            break;
        case "k":
        case "K":
            output = GetLetterK();
            break;
        case "l":
        case "L":
            output = GetLetterL();
            break;
        case "m":
        case "M":
            output = GetLetterM();
            break;
        case "n":
        case "N":
            output = GetLetterN();
            break;
        case "o":
        case "O":
        case "ô":
        case "ó":
            output = GetLetterO();
            break;
        case "p":
        case "P":
            output = GetLetterP();
            break;
        case "q":
        case "Q":
            output = GetLetterQ();
            break;
        case "r":
        case "R":
            output = GetLetterR();
            break;
        case "s":
        case "S":
        case "š":
        case "Š":
            output = GetLetterS();
            break;
        case "t":
        case "T":
        case "ť":
        case "Ť":
            output = GetLetterT();
            break;
        case "u":
        case "U":
        case "ú":
        case "Ú":
            output = GetLetterU();
            break;
        case "v":
        case "V":
            output = GetLetterV();
            break;

        case "w":
        case "W":
            output = GetLetterW();
            break;

        case "x":
        case "X":
            output = GetLetterX();
            break;

        case "y":
        case "Y":
        case "ý":
        case "Ý":
            output = GetLetterY();
            break;

        case "z":
        case "Z":
        case "ž":
        case "Ž":
            output = GetLetterZ();
            break;
        case "0":
            output = GetNumber0();
            break;
        case "1":
            output = GetNumber1();
            break;
        case "2":
            output = GetNumber2();
            break;
        case "3":
            output = GetNumber3();
            break;
        case "4":
            output = GetNumber4();
            break;
        case "5":
            output = GetNumber5();
            break;
        case "6":
            output = GetNumber6();
            break;
        case "7":
            output = GetNumber7();
            break;
        case "8":
            output = GetNumber8();
            break;
        case "9":
            output = GetNumber9();
            break;
    }

    Console.WriteLine(output);

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
}