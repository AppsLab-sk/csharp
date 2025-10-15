Console.WriteLine("Zadaj číslo od 1 do 7");
//int DayOfWeek = int.Parse(Console.ReadLine());

//switch (DayOfWeek)
//{
//    case 1:
//        Console.WriteLine("Pondelok");
//        break;
//    case 2:
//        Console.WriteLine("Utorok");
//        break;
//    case 3:
//        Console.WriteLine("Streda");
//        break;
//    case 4:
//        Console.WriteLine("Štvrtok");
//        break;
//    case 5:
//        Console.WriteLine("Piatok");
//        break;
//    case 6:
//        Console.WriteLine("Sobota");
//        break;
//    case 7:
//        Console.WriteLine("Nedeľa");
//        break;
//    default:
//        Console.WriteLine("Neplatný deň");
//        break;
//}

int number = 3;

string numberDescription = number switch
{
    1 => "jeden",
    2 => "dva",
    3 => "tri",
    _ => "neznáme číslo"
};
Console.WriteLine(numberDescription);