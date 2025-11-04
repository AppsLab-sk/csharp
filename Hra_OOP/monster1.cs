
using Hra_OOP;

public class monster

{
    private const int monsterHealth = 400;
    private const int minHealth1 = 0;

    private int currentHp1 = monsterHealth;
    private int monsterDamage = 50;
    private object name1;
    monster nepriatel = new monster();


    public bool DealDamage(MojCharacter opponent)
    {
        opponent.TakeDamage(monsterDamage);
        return true;
    }

    public void TakeDamage(int monsterDamage)
    {
        currentHp1 -= monsterDamage;
        if (currentHp1 < minHealth1) currentHp1 = minHealth1;
    }

    public int GetCurrentHp()
    {
        return currentHp1;
    }

    public override bool Equals(object? obj)
    {
        return obj is monster monster &&
               name1 == monster.name1;
    }
}
    