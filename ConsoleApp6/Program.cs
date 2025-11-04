
// uvod
Console.WriteLine("Vitaj v mojej prvej hre!");                                       
Console.WriteLine("Ide o to, ze bude tvoj charakter bojovat s priserami.");
Console.WriteLine("Ked nejaku zabijes tak dostanes veci v inventary ktore mozes pouzit. No vzdy si mozes vybrat len 1 vec!");
Console.WriteLine("Mozes si vybrat: Hp potion na 5 sekund ( 10% viac zivota) alebo mec (dava 5% viac damage).");
Console.WriteLine("Veci v inventari sa nepocitaju do vlasnosti postavy, ale mozes ich pouzit v boji LEN V 1. UTOKU!");
Console.WriteLine("Ak chces pouzit vec z inventara, napis jej meno presne ako je v zozname!");
Console.WriteLine($"Veci v inventari su: 'Hp potion' a 'Mec'.");
Console.WriteLine("Ak chces pokracovat bez pouzitia veci, napis 'nic'.");
//


//vlasnosti 
Console.WriteLine("Zadaj meno svojho charakteru: ");
string meno = Console.ReadLine();
int sila = 30;
int zivot = 90;
Console.WriteLine($"Tvoj charakter sa vola {meno}, ma silu {sila} a zivot {zivot}.");
Console.WriteLine("Zadaj meno nepriatela: ");
string nepriatelMeno = Console.ReadLine();
int nepriatelSila = 20;
int nepriatelZivot = 60;
Console.WriteLine($"Tvoj nepriatel sa vola {nepriatelMeno}, ma silu {nepriatelSila} a zivot {nepriatelZivot}. ");
Console.WriteLine("Takze ideme na to!");
//
Console.WriteLine("Ak chces otvorit inventar tak napis : M; a ak inventar nechces tak napis : K.");
string InvOpen3 = (Console.ReadLine());
Console.WriteLine("Inventar mas pazdny; ak chces nieco dostat tak musis vyhrat boj!");
// 



// prva arena
while (zivot > 0 && nepriatelZivot > 0)
 {
     Console.WriteLine("Stlac enter pre spustenie utoku!");
     Console.ReadLine();
     Console.WriteLine($"{nepriatelMeno} zautocil na teba a zranil ta o {nepriatelSila} zivotov.");
     zivot -= nepriatelSila;
     if (zivot < 0) zivot = 0;
     Console.WriteLine($"Tvoj zivot je teraz {zivot}. ");
     if (zivot <= 0)
     {
         Console.WriteLine("Prehral si!");
         break;
     }
     Console.WriteLine($"Stlac enter aby {meno} zautocil na {nepriatelMeno}!");
     Console.ReadLine();
     Console.WriteLine($"{meno} zautocil na {nepriatelMeno} a zranil si ho o {sila} zivotov.");
     nepriatelZivot -= sila;
     if (nepriatelZivot < 0) nepriatelZivot = 0;
     Console.WriteLine($"Zivot {nepriatelMeno} je teraz {nepriatelZivot}.");
     if (nepriatelZivot <= 0)
     {
         Console.WriteLine($"Porazil si {nepriatelMeno} a postupujes do 2. areny!");
     }
 }
//


//pouzitie inventara v 1. arene
List<string> inventar = new List<string>();
Console.WriteLine("Ak chces otvorit inventar tak napis : M; a ak inventar nechces tak napis : K.");
string InvOpen = (Console.ReadLine());
if (InvOpen.ToString().ToUpper() == "M")
{
    Console.WriteLine("Gratulujem.teraz si mozes vybrat vec z inventara.");
    Console.WriteLine("Zadaj nazov veci ktoru chces pouzit: ");
    string vec = Console.ReadLine();
    inventar.Add(vec);
}
else if (InvOpen.ToString().ToUpper() == "K")
{
    Console.WriteLine("Pokračujes bez použitia inventara.");
}
else
{
    Console.WriteLine("Zadal si zlu klavesu, skus to znova!");    
    InvOpen = (Console.ReadLine());
}




    //


    //pouzitie potionu v 1. arene
    if (inventar.Contains("Hp potion"))
{
    Console.WriteLine("Chces pouzit Hp potion? Ak ano napis : Yes; ak nie napis : No.");
    string pouzitPotion = (Console.ReadLine());
    if (pouzitPotion.ToString().ToUpper() == "Yes")
    {
        Console.WriteLine("Pouzil si Hp potion a tvoj zivot sa zvysil o 10% na 99 zivotov.");
        inventar.Remove("Hp potion");
        inventar.Add("token zivota");
    }
    else if (pouzitPotion.ToString().ToUpper() == "No")
        Console.WriteLine("Pokračujes bez použitia potionu.");
    else
        Console.WriteLine("Zadal si zle slovo, skus to znova!");
}

else if (InvOpen.ToString().ToUpper() == "K")
    Console.WriteLine("Pokračujes bez použitia inventara.");
//


// pouzitie meca v 1. arene
if (inventar.Contains("Mec"))
{
    Console.WriteLine("Chces pouzit Mec? Ak ano napis : Yes; ak nie napis : No.");
    string pouzitMec = (Console.ReadLine());
    if (pouzitMec.ToString().ToUpper() == "Yes")
    {
        Console.WriteLine("Pouzil si Mec a tvoja sila sa zvysila o 5% na 33 sily.");
        inventar.Remove("Mec");
        inventar.Add("token sily");
    }
    else if (pouzitMec.ToString().ToUpper() == "No")
        Console.WriteLine("Pokračujes bez použitia meca.");

    //


    // vlasnosti 2. areny
    int sila1 = 30;
    int zivot1 = 90;
    Console.WriteLine($"{meno} ma silu {sila1} a zivot {zivot1}. ");
    int nepriatelSila1 = 25;
    int nepriatelZivot1 = 65;
    Console.WriteLine($"{nepriatelMeno} ma silu {nepriatelSila1} a zivot {nepriatelZivot1}. ");
    Console.WriteLine("Takze ideme na to!");
    //

    
    //pouzitie inventara v 2. arene
    List<string> inventar1 = new List<string>();
    Console.WriteLine("Ak chces otvorit inventar tak napis : M; a ak inventar nechces tak napis : K.");
    string InvOpen1 = (Console.ReadLine());
    if (InvOpen1.ToString().ToUpper() == "M")
    {
        Console.WriteLine("Gratulujem.teraz si mozes vybrat vec z inventara.");
        Console.WriteLine("Zadaj nazov veci ktoru chces pouzit: ");
        string vec = Console.ReadLine();
        inventar1.Add(vec);
    }
    else if (InvOpen1.ToString().ToUpper() == "K")
    {
        Console.WriteLine("Pokračujes bez použitia inventara.");
    }
    else
    {
        Console.WriteLine("Zadal si zlu klavesu, skus to znova!");
        InvOpen1 = (Console.ReadLine());
    }
    //
    

    // druha arena
    while (zivot1 > 0 && nepriatelZivot1 > 0)
    {
        Console.WriteLine("Stlac enter pre spustenie utoku!");
        Console.ReadLine();
        Console.WriteLine($"{nepriatelMeno} zautocil na teba a zranil ta o {nepriatelSila1} zivotov.");
        zivot1 -= nepriatelSila1;
        if (zivot1 < 0) zivot1 = 0;
        Console.WriteLine($"Tvoj zivot je teraz {zivot1}. ");
        if (zivot1 <= 0)
        {
            Console.WriteLine("Prehral si!");
            break;
        }
        Console.WriteLine($"Stlac enter aby {meno} zautocil na {nepriatelMeno}!");
        Console.ReadLine();
        Console.WriteLine($"{meno} zautocil na {nepriatelMeno} a zranil si ho o {sila1}.");
        nepriatelZivot1 -= sila1;
        if (nepriatelZivot1 < 0) nepriatelZivot1 = 0;
        Console.WriteLine($"Zivot {nepriatelMeno} je teraz {nepriatelZivot1}.");
        if (nepriatelZivot1 <= 0)
        {
            Console.WriteLine($"Porazil si {nepriatelMeno} a postupujes do 3. areny!");
        }
    }
    //


    //pouzitie potionu v 2. arene
    if (inventar.Contains("Hp potion"))
    {
        Console.WriteLine("Chces pouzit Hp potion? Ak ano napis : Yes; ak nie napis : No.");
        char pouzitPotion = char.Parse(Console.ReadLine());
        if (pouzitPotion.ToString().ToUpper() == "Yes")
        {
            Console.WriteLine("Pouzil si Hp potion a tvoj zivot sa zvysil o 10% na 99 zivotov.");
            inventar.Remove("Hp potion");
            inventar.Add("token zivota");
        }
        else if (pouzitPotion.ToString().ToUpper() == "No")
            Console.WriteLine("Pokračujes bez použitia potionu.");
        else
            Console.WriteLine("Zadal si zle slovo, skus to znova!");
    }

    else if (InvOpen.ToString().ToUpper() == "K")
        Console.WriteLine("Pokračujes bez použitia inventara.");
    //


    // pouzitie meca v 2. arene
    if (inventar.Contains("Mec"))
    {
        Console.WriteLine("Chces pouzit Mec? Ak ano napis : Yes; ak nie napis : No.");
        char pouzitMec1 = char.Parse(Console.ReadLine());
        if (pouzitMec1.ToString().ToUpper() == "Yes")
        {
            Console.WriteLine("Pouzil si Mec a tvoja sila sa zvysila o 5% na 33 sily.");
            inventar.Remove("Mec");
            inventar.Add("token sily");
        }
        else if (pouzitMec1.ToString().ToUpper() == "No")
            Console.WriteLine("Pokračujes bez použitia meca.");

        //


        // nepouzil si nic v 2. arene
        if (!inventar.Contains("Hp potion") && !inventar.Contains("Mec"))
        {
            Console.WriteLine("Pokračujes bez použitia inventara.");
        }
        //


        //pouzitie inventara v 3. arene
        List<string> inventar2 = new List<string>();
        Console.WriteLine("Ak chces otvorit inventar tak napis : M; a ak inventar nechces tak napis : K.");
        char InvOpen2 = char.Parse(Console.ReadLine());
        if (InvOpen2.ToString().ToUpper() == "M")
        {
            Console.WriteLine("Inventar mas pazdny; ak chces nieco dostat tak musis vyhrat boj!");
        }

        else if (InvOpen2.ToString().ToUpper() == "K")
        {
            Console.WriteLine("Pokračujes bez použitia inventara.");
        }
        //


        // vlasnosti 3. areny
        int sila2 = 30;
        int zivot2 = 90;
        Console.WriteLine($"{meno} ma silu {sila2} a zivot {zivot2}. ");
        int nepriatelSila2 = 28;
        int nepriatelZivot2 = 75;
        Console.WriteLine($"{nepriatelMeno} ma silu {nepriatelSila2} a zivot {nepriatelZivot2}. ");
        Console.WriteLine("Takze ideme na to!");
        //


        // tretia arena
        while (zivot2 > 0 && nepriatelZivot2 > 0)
        {
            Console.WriteLine("Stlac enter pre spustenie utoku!");
            Console.ReadLine();
            Console.WriteLine($"{nepriatelMeno} zautocil na teba a zranil ta o {nepriatelSila2} zivotov.");
            zivot2 -= nepriatelSila2;
            if (zivot2 < 0) zivot2 = 0;
            Console.WriteLine($"Tvoj zivot je teraz {zivot2}. ");
            if (zivot2 <= 0)
            {
                Console.WriteLine("Prehral si!");
                break;
            }
            Console.WriteLine($"Stlac enter aby {meno} zautocil na {nepriatelMeno}");
            Console.ReadLine();
            Console.WriteLine($"{meno} zautocil na {nepriatelMeno} a zranil si ho o {sila2} zivotov");
            nepriatelZivot2 -= sila2;
            if (nepriatelZivot2 < 0) nepriatelZivot2 = 0;
            Console.WriteLine($"Zivot {nepriatelMeno} je teraz {nepriatelZivot2}");
            if (nepriatelZivot2 <= 0)
            {
                Console.WriteLine($"Porazil si {nepriatelMeno} a vyhral si hru! Gratulujem!");
            }
        }


        // bonusova aréna 
        Console.WriteLine("Gratulujem ze si vyhral hru! Ak chces pokracovat do bonusovej areny tak napis : Y; ak nie napis : N.");
        Console.ReadLine();
        if (InvOpen2.ToString().ToUpper() == "Y")
            Console.WriteLine("Pokračujes do bonusovej arény!");
        {

            Console.WriteLine("Vitaj v bonusovej arene!");
            Console.WriteLine("Tvoj nepriatel v bonusovej arene bude matematika!");
            Console.WriteLine("Tvojou ulohou je vyriesit 3 priklady spravne aby si vyhral bonusovu arenu!");
            int score = 0;
            Console.WriteLine("Priklad 1: Kolko je 5 + 8 * 4 ?");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 37)
            {
                score++;
                Console.WriteLine("Spravne!");
            }
            else
            {
                Console.WriteLine("Nespravne!");
            }
            Console.WriteLine("Priklad 2: Kolko je (10 + 5) / 5 * 16 ?");
            int answer2 = int.Parse(Console.ReadLine());
            if (answer2 == 48)
            {
                score++;
                Console.WriteLine("Spravne!");
            }
            else
            {
                Console.WriteLine("Nespravne!");
            }
            Console.WriteLine("Priklad 3: Kolko je 18 + 2 ?");
            int answer3 = int.Parse(Console.ReadLine());
            if (answer3 == 20)
            {
                score++;
                Console.WriteLine("Spravne!");
            }
            else
            {
                Console.WriteLine("Nespravne!");
            }
            if (score == 3)
            {
                Console.WriteLine("Gratulujem! Vyriesil si vsetky priklady spravne a vyhral bonusovu arenu!");
            }
            else
            {
                Console.WriteLine($"Vyriesil si {score} z 3 prikladov spravne. Skus to znova nabuduce!");
            }
        }
    }
}
            

    

