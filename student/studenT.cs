
namespace student
{
    internal class studenT
    {
        private string NameStud;
        public int ageStud = 18;


        public bool CanDrinkAlcohol()
        {
            return ageStud == 18;

        }   
        internal void setName(string name)
        {
            NameStud = name;
        }
    }
}
