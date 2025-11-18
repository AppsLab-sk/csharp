
//const int Maxpoints = 100;
//const int MinAgeForDriversLicense = 17;
//const string WelcomeMessage = "Vitajte v našej hre!";
//Console.WriteLine(Maxpoints);
//Console.WriteLine(MinAgeForDriversLicense);
//Console.WriteLine(WelcomeMessage);

int number = 3;

string numberDescription = number switch
{
    1 => "jeden",
    2 => "dva",
    3 => "tri",
    _ => "nezname cislo"

};

Console.WriteLine(numberDescription);
