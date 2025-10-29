int cislo = 10;
string text = "test1";
char znak = 'a';
bool mojahodnota = true; 
decimal test = 10.5m;
DateTime dnesnydatum = DateTime.Now;
int sucet = cislo + 67;
float  desatinne  = 1.23f;
var meno = "Alex";
Console.WriteLine($"cislo JE {cislo.ToString("000")} T" +
    $"TEXT JE {text} znak je {znak} hodnota bool je {mojahodnota} decimal je {test} dnesny datum je {dnesnydatum.ToString("yyyy-MM-dd")} sucet cisla {cislo} a 67 je : {sucet} Desatinne cislo je {desatinne} meno je {meno}");