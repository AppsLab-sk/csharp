namespace cvicenie_objekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string name = "Dano Cipko";
            int age = 15;
            string addres = "Kysucke nove mesto";
            char sex = 'M';

            /* string name1 = "Rado";
            int age1 = 15;
            string addres1 = "Rudina";
            char sex1 = 'Z';*/

            student student1 = new student();
            student1.age = age;
            student1.addres = addres;
            student1.name = name;
            student1.sex = sex;

            student student2 = new student();
            student2.age = 15;
            student2.addres = "Rudina" ;  
            student2.name = "rado";
            student2.sex = 'Z';

            /*student starystudent = student1 ;
            student1.name = "peto";
            Console.WriteLine(starystudent.name);*/

            /* student1.addtoname("Cipko");

             Console.WriteLine(student1.name);*/


            Console.WriteLine(student1.ShowInfo());





        }
    }
}
