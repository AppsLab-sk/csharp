using System.ComponentModel.Design;

Console.WriteLine("Type a number (6-1)");
string? numberReader = Console.ReadLine();
int number = int.Parse(numberReader);

if (number >= 1 && number <= 5)
{
    Console.WriteLine("You've won!");
}
else if (number == 6)
{
    Console.WriteLine("You're going again");
}
else
{ 
Console.WriteLine("Give me that cube! YAY");
}


//int number = int.Parse(numberReader); is the convertor from a string to a number.



//bool P1dead = false;

////Player 2 picks
//Console.WriteLine("Do you wanna hit, player 1?");
//string? ReadOpsionP1 = Console.ReadLine();
//if (ReadOpsionP1 == "yes")
//{
//        Console.WriteLine("Player 1's dead");
//    P1dead = true;
//}
//else if (ReadOpsionP1 == "no")
//{
//    Console.WriteLine("Okay, i guess?");
//}
//else
//{
//    Console.WriteLine("I guess not");
//}


////Player 2 picks
//if (P1dead == false)
//{
//    Console.WriteLine("Do you wanna hit, player 2?");
//    string? ReadOpsionP2 = Console.ReadLine();
//    if (ReadOpsionP2 == "yes")
//    {
//        Console.WriteLine("Player 2's dead");

//    }
//    else if (ReadOpsionP2 == "no")

//    {
//        Console.WriteLine("Okay, i guess?");
//    }
//    else
//    {
//        Console.WriteLine("I guess not");
//    }

//}












