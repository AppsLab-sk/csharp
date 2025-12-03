Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.Clear();


Console.WriteLine("Zadajte text");
string input = Console.ReadLine();
string output = "";






foreach (char letter in input)
{
    output = output + GetLetter(letter.ToString());
}

string[,] matrix = new string[50, 500];
int offset = 0;

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





string GetLetter(string imput)
{
    switch (imput)
    {

        case "A":
        case "a":
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
            return GetLetterF();
            
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
            
        case "R":
        case "r":
            return GetLetterR();
            
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
            
        case "1":
            return GetLetter1();
            
        case "2":
            return GetLetter2();
            
        case "3":
            return GetLetter3();
            
        case "4":
            return GetLetter4();
            
        case "5":
            return GetLetter5();
            
        case "6":
            return GetLetter6();
            
        case "7":
            return GetLetter7();
            
        case "8":
            return GetLetter8();
            
        case "9":
             return GetLetter9();
            
        case "0":
            return GetLetter0();
        case "w":
        case "W":
            return GetLetterW();
        default:
            return "Pismeno nepodporovane";

    }
}



        string GetLetterA()
        {
            return @"
                                 
                                 
               AAA               
              A:::A              
             A:::::A             
            A:::::::A            
           A:::::::::A           
          A:::::A:::::A          
         A:::::A A:::::A         
        A:::::A   A:::::A        
       A:::::A     A:::::A       
      A:::::AAAAAAAAA:::::A      
     A:::::::::::::::::::::A     
    A:::::AAAAAAAAAAAAA:::::A    
   A:::::A             A:::::A   
  A:::::A               A:::::A  
 A:::::A                 A:::::A 
AAAAAAA                   AAAAAAA
";
        }



        string GetLetterB()
        {
            return @"
                    
                    
BBBBBBBBBBBBBBBBB   
B::::::::::::::::B  
B::::::BBBBBB:::::B 
BB:::::B     B:::::B
  B::::B     B:::::B
  B::::B     B:::::B
  B::::BBBBBB:::::B 
  B:::::::::::::BB  
  B::::BBBBBB:::::B 
  B::::B     B:::::B
  B::::B     B:::::B
  B::::B     B:::::B
BB:::::BBBBBB::::::B
B:::::::::::::::::B 
B::::::::::::::::B  
BBBBBBBBBBBBBBBBB
";
        }



string GetLetterC()
{
    return @"
                                 
                     
                     
        CCCCCCCCCCCCC
     CCC::::::::::::C
   CC:::::::::::::::C
  C:::::CCCCCCCC::::C
 C:::::C       CCCCCC
C:::::C              
C:::::C              
C:::::C              
C:::::C              
C:::::C              
C:::::C              
 C:::::C       CCCCCC
  C:::::CCCCCCCC::::C
   CC:::::::::::::::C
     CCC::::::::::::C
        CCCCCCCCCCCCC

";
}
string GetLetterD()
{
    return @"
                     
DDDDDDDDDDDDD        
D::::::::::::DDD     
D:::::::::::::::DD   
DDD:::::DDDDD:::::D  
  D:::::D    D:::::D 
  D:::::D     D:::::D
  D:::::D     D:::::D
  D:::::D     D:::::D
  D:::::D     D:::::D
  D:::::D     D:::::D
  D:::::D     D:::::D
  D:::::D    D:::::D 
DDD:::::DDDDD:::::D  
D:::::::::::::::DD   
D::::::::::::DDD     
DDDDDDDDDDDDD  
";
}
string GetLetterE()
{
    return @"
                                 
                                 
                      
EEEEEEEEEEEEEEEEEEEEEE
E::::::::::::::::::::E
E::::::::::::::::::::E
EE::::::EEEEEEEEE::::E
  E:::::E       EEEEEE
  E:::::E             
  E::::::EEEEEEEEEE   
  E:::::::::::::::E   
  E:::::::::::::::E   
  E::::::EEEEEEEEEE   
  E:::::E             
  E:::::E       EEEEEE
EE::::::EEEEEEEE:::::E
E::::::::::::::::::::E
E::::::::::::::::::::E
EEEEEEEEEEEEEEEEEEEEEE
                       
";
}
string GetLetterF()
{
    return @"
                                  
                      
FFFFFFFFFFFFFFFFFFFFFF
F::::::::::::::::::::F
F::::::::::::::::::::F
FF::::::FFFFFFFFF::::F
  F:::::F       FFFFFF
  F:::::F             
  F::::::FFFFFFFFFF   
  F:::::::::::::::F   
  F:::::::::::::::F   
  F::::::FFFFFFFFFF   
  F:::::F             
  F:::::F             
FF:::::::FF           
F::::::::FF           
F::::::::FF           
FFFFFFFFFFF 
                       
";
}
string GetLetterG()
{
    return @"
                                 
                                 
                      
        GGGGGGGGGGGGG
     GGG::::::::::::G
   GG:::::::::::::::G
  G:::::GGGGGGGG::::G
 G:::::G       GGGGGG
G:::::G              
G:::::G              
G:::::G    GGGGGGGGGG
G:::::G    G::::::::G
G:::::G    GGGGG::::G
G:::::G        G::::G
 G:::::G       G::::G
  G:::::GGGGGGGG::::G
   GG:::::::::::::::G
     GGG::::::GGG:::G
        GGGGGG   GGGG
                       
";
}
string GetLetterH()
{
    return @"
 
                       
HHHHHHHHH     HHHHHHHHH
H:::::::H     H:::::::H
H:::::::H     H:::::::H
HH::::::H     H::::::HH
  H:::::H     H:::::H  
  H:::::H     H:::::H  
  H::::::HHHHH::::::H  
  H:::::::::::::::::H  
  H:::::::::::::::::H  
  H::::::HHHHH::::::H  
  H:::::H     H:::::H  
  H:::::H     H:::::H  
HH::::::H     H::::::HH
H:::::::H     H:::::::H
H:::::::H     H:::::::H
HHHHHHHHH     HHHHHHHHH
                       
    
";
}
string GetLetterI()
{
    return @"

IIIIIIIIII
I::::::::I
I::::::::I
II::::::II
  I::::I  
  I::::I  
  I::::I  
  I::::I  
  I::::I  
  I::::I  
  I::::I  
  I::::I  
II::::::II
I::::::::I
I::::::::I
IIIIIIIIII
             
";
}
string GetLetterJ()
{
    return @"
                
          JJJJJJJJJJJ
          J:::::::::J
          J:::::::::J
          JJ:::::::JJ
            J:::::J  
            J:::::J  
            J:::::J  
            J:::::j  
            J:::::J  
JJJJJJJ     J:::::J  
J:::::J     J:::::J  
J::::::J   J::::::J  
J:::::::JJJ:::::::J  
 JJ:::::::::::::JJ   
   JJ:::::::::JJ     
     JJJJJJJJJ       
";
}
string GetLetterK()
{
    return @"
                                 
                                 
                      
                    
KKKKKKKKK    KKKKKKK
K:::::::K    K:::::K
K:::::::K    K:::::K
K:::::::K   K::::::K
KK::::::K  K:::::KKK
  K:::::K K:::::K   
  K::::::K:::::K    
  K:::::::::::K     
  K:::::::::::K     
  K::::::K:::::K    
  K:::::K K:::::K   
KK::::::K  K:::::KKK
K:::::::K   K::::::K
K:::::::K    K:::::K
K:::::::K    K:::::K
KKKKKKKKK    KKKKKKK
                     
";
}
string GetLetterL()
{
    return @"
       
LLLLLLLLLLL             
L:::::::::L             
L:::::::::L             
LL:::::::LL             
  L:::::L               
  L:::::L               
  L:::::L               
  L:::::L               
  L:::::L               
  L:::::L               
  L:::::L               
  L:::::L         LLLLLL
LL:::::::LLLLLLLLL:::::L
L::::::::::::::::::::::L
L::::::::::::::::::::::L
LLLLLLLLLLLLLLLLLLLLLLLL
   
                       
";
}
string GetLetterM()
{
    return @"
    
                               
MMMMMMMM               MMMMMMMM
M:::::::M             M:::::::M
M::::::::M           M::::::::M
M:::::::::M         M:::::::::M
M::::::::::M       M::::::::::M
M:::::::::::M     M:::::::::::M
M:::::::M::::M   M::::M:::::::M
M::::::M M::::M M::::M M::::::M
M::::::M  M::::M::::M  M::::::M
M::::::M   M:::::::M   M::::::M
M::::::M    M:::::M    M::::::M
M::::::M     MMMMM     M::::::M
M::::::M               M::::::M
M::::::M               M::::::M
M::::::M               M::::::M
MMMMMMMM               MMMMMMMM
                       
";
}
string GetLetterN()
{
    return @"
                                 
                                 
                      
                        
NNNNNNNN        NNNNNNNN
N:::::::N       N::::::N
N::::::::N      N::::::N
N:::::::::N     N::::::N
N::::::::::N    N::::::N
N:::::::::::N   N::::::N
N:::::::N::::N  N::::::N
N::::::N N::::N N::::::N
N::::::N  N::::N:::::::N
N::::::N   N:::::::::::N
N::::::N    N::::::::::N
N::::::N     N:::::::::N
N::::::N      N::::::::N
N::::::N       N:::::::N
N::::::N        N::::::N
NNNNNNNN         NNNNNNN
   
";
}
string GetLetterO()
{
    return @"
                     
                      
     OOOOOOOOO     
   OO:::::::::OO   
 OO:::::::::::::OO 
O:::::::OOO:::::::O
O::::::O   O::::::O
O:::::O     O:::::O
O:::::O     O:::::O
O:::::O     O:::::O
O:::::O     O:::::O
O:::::O     O:::::O
O:::::O     O:::::O
O::::::O   O::::::O
O:::::::OOO:::::::O
 OO:::::::::::::OO 
   OO:::::::::OO   
     OOOOOOOOO     
                       
";
}
string GetLetterP()
{
    return @"
    
                    
PPPPPPPPPPPPPPPPP   
P::::::::::::::::P  
P::::::PPPPPP:::::P 
PP:::::P     P:::::P
  P::::P     P:::::P
  P::::P     P:::::P
  P::::PPPPPP:::::P 
  P:::::::::::::PP  
  P::::PPPPPPPPP    
  P::::P            
  P::::P            
  P::::P            
PP::::::PP          
P::::::::P          
P::::::::P          
PPPPPPPPPP          
          
                       
";
}
string GetLetterR()
{
    return @"
        
                    
RRRRRRRRRRRRRRRRR   
R::::::::::::::::R  
R::::::RRRRRR:::::R 
RR:::::R     R:::::R
  R::::R     R:::::R
  R::::R     R:::::R
  R::::RRRRRR:::::R 
  R:::::::::::::RR  
  R::::RRRRRR:::::R 
  R::::R     R:::::R
  R::::R     R:::::R
  R::::R     R:::::R
RR:::::R     R:::::R
R::::::R     R:::::R
R::::::R     R:::::R
RRRRRRRR     RRRRRRR
      
";
}
string GetLetterS()
{
    return @"
                                 
                                 
                      
   SSSSSSSSSSSSSSS 
 SS:::::::::::::::S
S:::::SSSSSS::::::S
S:::::S     SSSSSSS
S:::::S            
S:::::S            
 S::::SSSS         
  SS::::::SSSSS    
    SSS::::::::SS  
       SSSSSS::::S 
            S:::::S
            S:::::S
SSSSSSS     S:::::S
S::::::SSSSSS:::::S
S:::::::::::::::SS 
 SSSSSSSSSSSSSSS   
                       
";
}
string GetLetterT()
{
    return @"
              
                      
TTTTTTTTTTTTTTTTTTTTTTT
T:::::::::::::::::::::T
T:::::::::::::::::::::T
T:::::TT:::::::TT:::::T
TTTTTT  T:::::T  TTTTTT
        T:::::T        
        T:::::T        
        T:::::T        
        T:::::T        
        T:::::T        
        T:::::T        
        T:::::T        
      TT:::::::TT      
      T:::::::::T      
      T:::::::::T      
      TTTTTTTTTTT  
                       
";
}
string GetLetterU()
{
    return @"
   
                     
UUUUUUUU     UUUUUUUU
U::::::U     U::::::U
U::::::U     U::::::U
UU:::::U     U:::::UU
 U:::::U     U:::::U 
 U:::::D     D:::::U 
 U:::::D     D:::::U 
 U:::::D     D:::::U 
 U:::::D     D:::::U 
 U:::::D     D:::::U 
 U:::::D     D:::::U 
 U::::::U   U::::::U 
 U:::::::UUU:::::::U 
  UU:::::::::::::UU  
    UU:::::::::UU    
      UUUUUUUUU 
                       
";
}
string GetLetterV()
{
    return @"
                                 
                                 
                      
VVVVVVVV           VVVVVVVV
V::::::V           V::::::V
V::::::V           V::::::V
V::::::V           V::::::V
 V:::::V           V:::::V 
  V:::::V         V:::::V  
   V:::::V       V:::::V   
    V:::::V     V:::::V    
     V:::::V   V:::::V     
      V:::::V V:::::V      
       V:::::V:::::V       
        V:::::::::V        
         V:::::::V         
          V:::::V          
           V:::V           
            VVV
                       
";
}
string GetLetterX()
{
    return @"
                                 
                                 
                      
XXXXXXX       XXXXXXX
X:::::X       X:::::X
X:::::X       X:::::X
X::::::X     X::::::X
XXX:::::X   X:::::XXX
   X:::::X X:::::X   
    X:::::X:::::X    
     X:::::::::X     
     X:::::::::X     
    X:::::X:::::X    
   X:::::X X:::::X   
XXX:::::X   X:::::XXX
X::::::X     X::::::X
X:::::X       X:::::X
X:::::X       X:::::X
XXXXXXX       XXXXXXX

                       
";
}
string GetLetterY()
{
    return @"
                                 
                                 
                      
YYYYYYY       YYYYYYY
Y:::::Y       Y:::::Y
Y:::::Y       Y:::::Y
Y::::::Y     Y::::::Y
YYY:::::Y   Y:::::YYY
   Y:::::Y Y:::::Y   
    Y:::::Y:::::Y    
     Y:::::::::Y     
      Y:::::::Y      
       Y:::::Y       
       Y:::::Y       
       Y:::::Y       
       Y:::::Y       
    YYYY:::::YYYY    
    Y:::::::::::Y    
    YYYYYYYYYYYYY 
                       
";
}
string GetLetterZ()
{
    return @"
                                 
                                 
                      
ZZZZZZZZZZZZZZZZZZZ
Z:::::::::::::::::Z
Z:::::::::::::::::Z
Z:::ZZZZZZZZ:::::Z 
ZZZZZ     Z:::::Z  
        Z:::::Z    
       Z:::::Z     
      Z:::::Z      
     Z:::::Z       
    Z:::::Z        
   Z:::::Z         
ZZZ:::::Z     ZZZZZ
Z::::::ZZZZZZZZ:::Z
Z:::::::::::::::::Z
Z:::::::::::::::::Z
ZZZZZZZZZZZZZZZZZZZ
                       
";
}



string GetLetter1()
{
    return @"
                                 
                                 
                      
  1111111   
 1::::::1   
1:::::::1   
111:::::1   
   1::::1   
   1::::1   
   1::::1   
   1::::l   
   1::::l   
   1::::l   
   1::::l   
   1::::l   
111::::::111
1::::::::::1
1::::::::::1
111111111111
                       
";
}
string GetLetter2()
{
    return @"
                                 
                                 
                      
 222222222222222    
2:::::::::::::::22  
2::::::222222:::::2 
2222222     2:::::2 
            2:::::2 
            2:::::2 
         2222::::2  
    22222::::::22   
  22::::::::222     
 2:::::22222        
2:::::2             
2:::::2             
2:::::2       222222
2::::::2222222:::::2
2::::::::::::::::::2
22222222222222222222
                       
";
}
string GetLetter3()
{
    return @"
                                 
                                 
                      
 333333333333333   
3:::::::::::::::33 
3::::::33333::::::3
3333333     3:::::3
            3:::::3
            3:::::3
    33333333:::::3 
    3:::::::::::3  
    33333333:::::3 
            3:::::3
            3:::::3
            3:::::3
3333333     3:::::3
3::::::33333::::::3
3:::::::::::::::33 
 333333333333333  
                       
";
}
string GetLetter4()
{
    return @"
                                 
                                 
                      
     444444444  
      4::::::::4  
     4:::::::::4  
    4::::44::::4  
   4::::4 4::::4  
  4::::4  4::::4  
 4::::4   4::::4  
4::::444444::::444
4::::::::::::::::4
4444444444:::::444
          4::::4  
          4::::4  
          4::::4  
        44::::::44
        4::::::::4
        4444444444
                       
";
}
string GetLetter5()
{
    return @"
                                 
                                 
                      
555555555555555555 
5::::::::::::::::5 
5::::::::::::::::5 
5:::::555555555555 
5:::::5            
5:::::5            
5:::::5555555555   
5:::::::::::::::5  
555555555555:::::5 
            5:::::5
            5:::::5
5555555     5:::::5
5::::::55555::::::5
 55:::::::::::::55 
   55:::::::::55   
     555555555
                       
";
}
string GetLetter6()
{
    return @"
                                 
                                 
                      
        66666666   
       6::::::6    
      6::::::6     
     6::::::6      
    6::::::6       
   6::::::6        
  6::::::6         
 6::::::::66666    
6::::::::::::::66  
6::::::66666:::::6 
6:::::6     6:::::6
6:::::6     6:::::6
6::::::66666::::::6
 66:::::::::::::66 
   66:::::::::66   
     666666666
                       
";
}
string GetLetter7()
{
    return @"
                                 
                                 
                      
77777777777777777777
7::::::::::::::::::7
7::::::::::::::::::7
777777777777:::::::7
           7::::::7 
          7::::::7  
         7::::::7   
        7::::::7    
       7::::::7     
      7::::::7      
     7::::::7       
    7::::::7        
   7::::::7         
  7::::::7          
 7::::::7           
77777777   
                       
";
}
string GetLetter8()
{
    return @"
                                 
                                 
                      
     888888888     
   88:::::::::88   
 88:::::::::::::88 
8::::::88888::::::8
8:::::8     8:::::8
8:::::8     8:::::8
 8:::::88888:::::8 
  8:::::::::::::8  
 8:::::88888:::::8 
8:::::8     8:::::8
8:::::8     8:::::8
8:::::8     8:::::8
8::::::88888::::::8
 88:::::::::::::88 
   88:::::::::88   
     888888888 
                       
";
}
string GetLetter9()
{
    return @"
                                 
                                 
                      
     999999999     
   99:::::::::99   
 99:::::::::::::99 
9::::::99999::::::9
9:::::9     9:::::9
9:::::9     9:::::9
 9:::::99999::::::9
  99::::::::::::::9
    99999::::::::9 
         9::::::9  
        9::::::9   
       9::::::9    
      9::::::9     
     9::::::9      
    9::::::9       
   99999999  
                       
";
}
string GetLetter0()
{
    return @"
                                 
                                 
                      
     000000000     
   00:::::::::00   
 00:::::::::::::00 
0:::::::000:::::::0
0::::::0   0::::::0
0:::::0     0:::::0
0:::::0     0:::::0
0:::::0 000 0:::::0
0:::::0 000 0:::::0
0:::::0     0:::::0
0:::::0     0:::::0
0::::::0   0::::::0
0:::::::000:::::::0
 00:::::::::::::00 
   00:::::::::00   
     000000000 
                       
";
}
string GetLetterW()
{
    return @"
                                 
                                 
                      
                                           
WWWWWWWW                           WWWWWWWW
W::::::W                           W::::::W
W::::::W                           W::::::W
W::::::W                           W::::::W
 W:::::W           WWWWW           W:::::W 
  W:::::W         W:::::W         W:::::W  
   W:::::W       W:::::::W       W:::::W   
    W:::::W     W:::::::::W     W:::::W    
     W:::::W   W:::::W:::::W   W:::::W     
      W:::::W W:::::W W:::::W W:::::W      
       W:::::W:::::W   W:::::W:::::W       
        W:::::::::W     W:::::::::W        
         W:::::::W       W:::::::W         
          W:::::W         W:::::W          
           W:::W           W:::W           
            WWW             WWW            
                                  
                       
";
}

