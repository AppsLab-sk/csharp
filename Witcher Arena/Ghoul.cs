internal class Ghoul : Monster
{
    private const int HP_MODIFYER = 2;


    public Ghoul(int hp, int damage) : base(hp / HP_MODIFYER, damage)
    {
    }
}
