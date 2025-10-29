
namespace meno_vek
{
    internal class Clovek
    {
        int vek;
        public void SetName(string? meno)
        {
            Pname = meno;

        }
        internal void SetAge(int vekInput)
        {
            vek = vekInput;
          
        }


        string Pname = "";

        public bool MozesPit()
        {
            if (vek >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}

