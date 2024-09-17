namespace CommonProblems._01_Problem
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public Student(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public Student()
        {
        }

        public void AddGrade(int grade)
        {
            if (grade <= 5 && grade > 0)
            {
                Grades.Add(grade);
            }
        }
    }
}