
using Cvicenie_Vynimky;
using System.Data;

namespace Cvicenia_vynimky
{
    internal class Program
    {
        static void Main(string[] args)
        { //nacitavanie so subora studenti.cvs a vytvorenie studentov
             var date = File.ReadAllLines("studenti.csv");
            var studenti = new List<Student>();
            foreach (var row in date.Skip(1))
            {
                var splits = row.Split(',');
                var newStudent = new Student(splits[1], splits[2], Int32.Parse(splits[3]), "1.AI");
                studenti.Add(newStudent);
            }

            //Priklad na vynimku pri deleni nulou a nespravnym indexom
            /*try
            {
                int[] deviders = { 1, 2, 3 };
                int value = deviders[0];
                int result = 5 / value;
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException ex)
            { Console.WriteLine("Chyba: Pristup mimo rozsah pola."); }
            catch (DivideByZeroException ex)
            { Console.WriteLine("Chyba: Delenie nulou nie je povolene."); }

            /*var date = File.ReadAllLines("studenti.csv");
            var studenti = new List<Student>();
            foreach (var row in date.Skip(1))
            {
                var splits = row.Split(',');
                try
                {
                    var newStudent = new Student(splits[0], splits[1], splits[2], Int32.Parse(splits[3]), "1.AI", splits[4]);
                    studenti.Add(newStudent);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "" + row);*/
                }
            }
        }
    
