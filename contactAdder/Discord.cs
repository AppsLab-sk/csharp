using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactAdder
{
    internal class Discord
    {
        private bool justInCase;
        public Discord() { }

        private protected string filePath = "C:\\Users\\MexNan\\Desktop\\for-10.12.25\\Dicsords.txt";
        private string discordUsername = "";
        private string textiny = ""; 

        public void DaAddThing(string name, string text, string contact)
        {
            ReadFile(justInCase);
            AddContact(name, text,  contact);
        }
        public void ReadFile(bool justInCase)
        {
            
                try
                {
                    textiny = File.ReadAllText(filePath);
                }
                catch
                {
                    textiny = "";
                    File.WriteAllText(filePath, textiny);
                }
            
        }
        private void AddContact(string name, string text, string contact)
        {
            if (contact == "2")
            {
                discordUsername = discordUsername + name + ":\n" + text + "@gmail.com\n";
            }
            else { discordUsername = discordUsername + name + ":\n" + text + "\n"; }

            File.AppendAllText(filePath, discordUsername);
        } 
    }
}

