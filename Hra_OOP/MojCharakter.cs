

using Hra_OOP;

public class MojCharacter

{
    private const int characterHealth = 500;
    private const int minHealth = 0;

    private int currentHp = characterHealth;
    private int characterDamage = 100;
    private object name;
    MojCharacter hrac = new MojCharacter();


    public bool DealDamage(monster opponent)
    {
        opponent.TakeDamage(characterDamage);
        return true;
    }


    public void TakeDamage(int characterDamage)
    {
        currentHp -= characterDamage;
        if (currentHp < minHealth) currentHp = minHealth;
    }

    public int GetCurrentHp()
    {
        return currentHp;
    }

    public override bool Equals(object? obj)
    {
        return obj is MojCharacter character &&
               name == character.name;
    }
}
