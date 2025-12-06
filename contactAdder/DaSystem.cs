using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using contactAdder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace contactAdder
{
    internal class DaSystem
    {
        private string filePath = "C:\\Users\\MexNan\\Desktop\\for-10.12.25\\";

        Email email = new Email();
        SMS sms = new SMS();
        Call call = new Call();
        Discord discord = new Discord();

        private List<string> daFilePathEndParts = new List<string>() { "Emails.txt", "Calls.txt", "SMS.txt", "Dicsords.txt" };
        private List<string> DaBigBossNames = new List<string>() { "email", "call", "sms", "discord" };

        public bool Choise = true;

        private string[] args;
        public void run()
        {
            TheChoises();
        }

        private void TheChoises()
        {
            while (Choise == true)
            {
                Console.WriteLine("\nPick between these 3... also, 'end' will end the program\n Add(1)\n Show all(2)\n Show spesific(3)");
                string? choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        AddContact(email, call, sms, discord);
                        break;
                    case "2":
                        ShowAllContacts();
                        break;
                    case "3":
                        ShowSpesificContact();
                        break;
                    case "end":
                        Choise = false;
                        break;
                    default:
                        Console.WriteLine(" What? Try again, bro");
                        break;
                }
            }
        }
        private void AddContact(Email email, Call call, SMS sms, Discord discord)
        {
            bool addContactLoop = true;

            while (addContactLoop == true)
            {
                Console.WriteLine("\nEnter The type of contact...btw, 'back' will send ya back\n Call/Number(1)\n Email(2)\n SMS(3)\n Discord(4)");
                string? contactType = Console.ReadLine();
                if (contactType == "back")
                {
                    addContactLoop = false;
                    break;
                }
                Console.WriteLine("\nThe persons name now...");
                string? name = Console.ReadLine();

                Console.WriteLine("\nThe persons number, discord or gmail(don't include the @gmail.com part) now...");
                string? text = Console.ReadLine();

                switch (contactType)
                {
                    case "1":
                        call.DaAddThing(name, text, contactType);
                        addContactLoop = false;
                        break;
                    case "2":
                        email.DaAddThing(name, text, contactType);
                        addContactLoop = false;
                        break;
                    case "3":
                        sms.DaAddThing(name, text, contactType);
                        addContactLoop = false;
                        break;
                    case "4":
                        discord.DaAddThing(name, text, contactType);
                        addContactLoop = false;
                        break;
                    default:
                        Console.WriteLine("\nthat doesn't exist..");
                        break;
                }
            }
        }
        private void ShowAllContacts()
        {
            int j = 0;
            for (int i = 0; i < daFilePathEndParts.Count; i++)
            {
                filePath += daFilePathEndParts[i];

                ReadFile(filePath);
                string texty = File.ReadAllText(filePath);
                Console.WriteLine("\n" + DaBigBossNames[j] + ":\n" + texty);
                j++;
                filePath = "C:\\Users\\MexNan\\Desktop\\for-10.12.25\\";
            }
        }
        private void ShowSpesificContact()
        {
            Console.WriteLine("Enter the type of Contact (email, call, sms, discord)");
            string? contactType = Console.ReadLine();
            
            string daName = "";
            string daText = "";
            bool endThis = false;
            bool nope = false;
            for (int i = 0; i < DaBigBossNames.Count; i++)
            {
                string contactTypeExister = DaBigBossNames[i];
                if (contactType == contactTypeExister)
                {
                    Console.WriteLine("Now enter their name");
                    string? name = Console.ReadLine();
                    name = name + ":";
                    ReadEveryLine(name, daName, daText);
                    nope = true;
                }
                if (i == DaBigBossNames.Count - 1 && nope == false)
                {
                    endThis = true;
                }    
                if (endThis == true)
                {
                    Console.WriteLine("You typed it wrong, bro");
                }
                    filePath = "C:\\Users\\MexNan\\Desktop\\for-10.12.25\\";
            }
        }
        private void ReadFile(string filePath)
        {
            try
            {
                string textiny = File.ReadAllText(filePath);
            }
            catch
            {
                string textiny = "";
                File.WriteAllText(filePath, textiny);
            }
        }
        private void ReadEveryLine(string name, string daName, string daText) 
        {
            for (int i = 0; i < daFilePathEndParts.Count; i++)
            {
                filePath += daFilePathEndParts[i];

                int j = 0;
                bool nextLine = false;
                try
                {
                    foreach (string line in File.ReadLines(filePath)) // from google: https://codesignal.com/learn/courses/fundamentals-of-text-data-manipulation-in-csharp/lessons/reading-text-files-line-by-line-in-csharp
                    {
                        if (name == line)
                        {
                            daName = line;
                            nextLine = true;
                        }
                        else if (nextLine == true)
                        {
                            daText = line;
                            nextLine = false;
                            i = daFilePathEndParts.Count;
                        }
                        j++;
                    }
                }
                catch
                {
                }
                filePath = "C:\\Users\\MexNan\\Desktop\\for-10.12.25\\";
            }

            if (daName != name)
            {
                Console.WriteLine("The name ain't there, bro");
            }
            else 
            { 
                Console.WriteLine($"\n{daName} {daText}"); 
            }
        }
    }
}
