namespace Student
{
    public enum Degree
    {
        A,
        B,
        C,
        D,
        E
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.AddGrade("Math", Degree.A);
            student.AddGrade("Physics", Degree.B);
            student.AddGrade("Biology", Degree.C);

            Grade[] allGrades = student.GetAllGrades();
            Console.WriteLine("All Grades:");
            foreach (var grade in allGrades)
            {
                Console.WriteLine($"Subject: {grade.Subject}, Degree: {grade.Degree}");
            }
        }
    }
}