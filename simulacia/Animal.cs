using System.ComponentModel.Design;

namespace simulacia
{
    internal class Animal
    {
        public bool bylinozravec = false;
        public void setfood(bool siBylinozravec)
        {
            bylinozravec = siBylinozravec;
        }
        public bool CanEatOtherAnimal()
        {
            if (bylinozravec)
            {
                return false;
            }
            else
            {
                return true;    
            }
    }    }
}

