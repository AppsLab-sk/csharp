
int HPBoller = 100;
int DMGBoller = 20;
int HPZombie = 100;
int DMGZombie = 10;    //pridal som HP aj DMG Zobiemu aj Bollerovi

Console.WriteLine("START GAME");
Console.WriteLine("tvoj pocet zivotov je " + HPBoller + " a tvoj pocet damege je " + DMGBoller);
Console.WriteLine("prisera oproti tebe ma " + HPZombie + " zivotov a " + DMGZombie + " damage");
Console.WriteLine("tvoja postava sa vola BOLLER a ak si ready tak sa môzes pustit do prveho suboja");
Console.WriteLine("si ready?");
Console.ReadLine();

Console.WriteLine("dobre tak ked si ready tak podme na to");
Console.WriteLine("PRVE KOLO");
Console.WriteLine("oproti tebe stoji zombie");
Console.WriteLine("das mu uder na hlavu ci do brucha");
Console.ReadLine();
if (Console.ReadLine() == brucho)
{
    Console.WriteLine("zombiemu si vyhazil dych");
    Console.WriteLine("rana do brucha mu spôsobila " + DMGBoller + " poskodenia");
}
else if (Console.ReadLine() == hlava)
{
    Console.WriteLine("zombiemu skoro odpadla hlava");
    Console.WriteLine("uder na hlavu mu spôsobilo " + DMGBoller + " Damage");
}

Console.WriteLine("pozor!Caka ta uder od zombie");
Console.WriteLine("rychlo kry sa!");
Console.WriteLine("nestihol si dostal si bolestivi uder na spanok bude ta to stat 10HP");
Console.WriteLine("neboj sa mozno budes mat vacsie stastie v dialsom kole");

Console.WriteLine("DRUHE KOLO");
Console.WriteLine("dobre zacalo druhe kolo a ty sa mozes rozhodnut ze ci ho zastrelis so zbranou alebo ho prepychnes nozom");
Console.ReadLine();
if (Console.ReadLine() == zbran)
{
    Console.WriteLine("skvele zasiahol si ho zbranov dal si mu 50HP dole");
}
else if (Console.ReadLine() == nozik)
{
    Console.WriteLine("prepychol si mu rebra dal si mu 35HP dole");
}
Console.WriteLine("ooooo bacha zombie vytahuje teleskop");
Console.WriteLine("dostal si silny uder teleskopom to ta bude stat 40HP dole");

Console.WriteLine("TRETIE KOLO");
Console.WriteLine("tvoje moznosti su vytiahnut boxer,chytit ho do kravaty alebo mu dat tornado high kick");
Console.ReadLine();
if (Console.WriteLine() == boxer)
{
    Console.WriteLine("udrel si na bradu,dal si mu 15HP dole");
}
else if (Console.ReadLine() == kravata)
{
    Console.WriteLine("chytil si ho do kravaty ale on sa rychlo z nej dostal,nedal si mu ziadne poskodenie");
}
else if (Console.ReadLine() == tornadohighkick)
{
    Console.WriteLine("zombie spadol na zem a skoro ho vyplo,dal si mu 30HP dole");
}
Console.WriteLine("ale zombie ti dal bombu do brucha a nasledne high kick na bradu");
Console.WriteLine("je mi to luto ale zombie ta vypol");
