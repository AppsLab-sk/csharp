namespace Cvicenie_pravdepodobnosť
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Random random = new Random();   
            int value = random.Next(1, 100);
            if (value < 80)
            {
                Console.WriteLine("Uspech");
            }
            else
            {
                Console.WriteLine("Neuspech");
            }*/

           /* student student1 = new student("Janko", 3);
            student student2 = new student("Fero", 5);
            student student3 = new student("Misko", 2);
            student student4 = new student("Palo", 10);*/
            List<student> students = new List<student>();
            students.Add(new student("Janko", 3));
            students.Add(new student("Fero", 5));   
            students.Add(new student("Misko", 2));
            students.Add(new student ("matus", 20) ) ;     
            students.Add(new student("Dano", 7));
            List<student> ticketPool = new List<student>();
            foreach (student stud in students)
            {
                for (int i = 0; i < stud.Ticketcount; i++)
                {
                    ticketPool.Add(stud);
                }
            }
            Random random = new Random();
            int index = random.Next(0, ticketPool.Count);
            student winner = ticketPool[index];
            Console.WriteLine("Vyherca je: " + winner.Name + winner.Ticketcount);




        }
    }
}
