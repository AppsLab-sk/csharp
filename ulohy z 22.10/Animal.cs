
internal class Animal
{
    public bool bylinozravec = false;
    public void setfood(bool SiBylinozravec)
    {
        bylinozravec = SiBylinozravec;
    }
    public bool CanEatOtherAnimal()
    {
        if (bylinozravec == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}