

using OOP_3_;

namespace OOP_3_
{
    public class Student
    {
        public bool student = false;
        public string Name;
    
        public bool CanDrinkAlcohol()
        {
            if (student == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal void SetName(string? studentName)
        {
            Name = studentName;
        }
    }
}





