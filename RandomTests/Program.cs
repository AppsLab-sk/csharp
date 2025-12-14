using System.Diagnostics.CodeAnalysis;

Console.WriteLine("n/*/r/f/rf/fe/se/list");
string chose = Console.ReadLine();
if (chose == "n")
{
    //the starter number
    int i = 0;

    //it loops
    while (i < 5)
    {

        //it prints the number
        Console.WriteLine(i);

        //this basicly adds +1... and whitout it, it's a infite loop
        i++;

    }
}
    else if (chose == "*")

{
    // this writes * one more every line
    string i = "*";

    while (i.Length < 5)
    {
        Console.WriteLine(i);
        //same as before but we use this to rite a extra something for strings
        i = i + "*";
    }
    
}
if (chose == "r")
{
    // this does a + of the table
    int[] numbers = new int[5] { 1, 2, 3, 4 , 5};

    int i = 0;
    int sucet = 0;

    //loop for some reasone
   while (i < numbers.Length) 
    {
        //math stuff... sucet + table basicly
        sucet += numbers[i];
        i++;
     
     
    }
    Console.WriteLine(sucet);
    
    

}
else if (chose == "f")
{
    for (int i = 0; i < 5; i++)
        //like while but in one line
    {
        Console.WriteLine(i); 
    }
}    
else if (chose == "rf")
{
    
    int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
    int sucet = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        sucet += numbers[i];
    }
    Console.WriteLine(sucet);

}    
else if (chose == "fe")
{
    string[] names = { "Cupik", "fafaj", "holaaa" };

    foreach (string name in names) 
    {
    Console.WriteLine($"Hello {name}");
    }

}    
else if (chose == "se")
{
    string[] words = { "I", "am", "pretty", "good", "today." };

    foreach (string word in words)
    {
        Console.Write($" {word}" );
    }
}
else if (chose == "list")
{
    List<int> numbers = new List<int>();
    numbers.Add(5);

}