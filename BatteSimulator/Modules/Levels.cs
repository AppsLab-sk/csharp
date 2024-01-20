using BatteSimulator.functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class Levels
    {
        List<string> pList = new List<string>();

        public void GetPlayers()
        {
            string assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(assemblyDirectory, "../../../PlayerData");
            string[] files = Directory.GetFiles(filePath);

            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                //Console.WriteLine(fileName);
                pList.Add(fileName);
                //Console.WriteLine(pList[0]);
            }
        }

        public void SetPlayer()
        {
            pList.Clear();
            GetPlayers();
            if (pList.Count == 0)
            {
                Console.WriteLine("No players in list. Create new one.");
                NewPlayer();
            }
            else
            {
                Console.WriteLine("1. Choose from existing players \n2. Create new player");
                int action =  int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    Console.WriteLine("Choose player:");
                    for (int i = 0; i < pList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {pList[i]}");
                    }

                    int pIndex = int.Parse(Console.ReadLine()) - 1;

                    var player = pList[pIndex];

                    Console.WriteLine(player);
                }
                else { NewPlayer(); }
            }
        }
        public void NewPlayer()
        {
            pList.Clear();
            var print = new Print();

            Console.WriteLine("Set your player name:");

            print.Input();
            string pName = Console.ReadLine();

            string assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(assemblyDirectory, "../../../PlayerData");
            string fileName = $"{pName}.txt";
            string filePath = Path.Combine(path, fileName);

            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(pName);
            }
            GetPlayers();
            SetPlayer();
        }
    }
}
