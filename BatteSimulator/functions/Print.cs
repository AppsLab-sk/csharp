using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.functions
{
    public class Print
    {
        public void Intro()
        {
            string text = @"

 ██████╗ ██████╗ ███╗   ██╗███████╗ ██████╗ ██╗     ███████╗██████╗ ██████╗  ██████╗ 
██╔════╝██╔═══██╗████╗  ██║██╔════╝██╔═══██╗██║     ██╔════╝██╔══██╗██╔══██╗██╔════╝ 
██║     ██║   ██║██╔██╗ ██║███████╗██║   ██║██║     █████╗  ██████╔╝██████╔╝██║  ███╗
██║     ██║   ██║██║╚██╗██║╚════██║██║   ██║██║     ██╔══╝  ██╔══██╗██╔═══╝ ██║   ██║
╚██████╗╚██████╔╝██║ ╚████║███████║╚██████╔╝███████╗███████╗██║  ██║██║     ╚██████╔╝
 ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝      ╚═════╝ 
                                                                                 DEMO
                                                                         by Martas_SK

";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void Soon() { Console.WriteLine("Comming soon..."); }
    }
}
