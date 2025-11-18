
using System;
namespace student
{
    public class Student
    {
        public int Age = 22;
        public string name = "Rudolf";
    }
    class program
    {
        static void Main(string[] args)
        { 
            Student student = new Student();
            if (student.Age > 18)
            {
                Console.WriteLine("rudolf moze pit alkohol");
            
            }
            else
            {
                Console.WriteLine("rudolf este alkohol legane pit nemoze");
            }


        
        }
    }
}           
            






















