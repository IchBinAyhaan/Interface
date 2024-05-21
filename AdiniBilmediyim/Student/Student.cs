

namespace Student
{
    internal class Student
    {
        private Grade[] grades;
        private int count;

        public Student()
        {
            grades = new Grade[10];
            count = 0;
        }

        public void AddGrade(string subject, Degree degree)
        {
            if (count < grades.Length)
            {
                grades[count++] = new Grade(subject, degree);
            }
            else
            {
                Console.WriteLine("Grades array is full. Cannot add more grades.");
            }
        }

        public Grade[] GetAllGrades()
        {
            Grade[] allGrades = new Grade[count];
            Array.Copy(grades, allGrades, count);
            return allGrades;
        }
    }
}
