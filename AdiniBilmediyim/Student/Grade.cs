
namespace Student
{
    internal class Grade
    {
        public string Subject { get; }
        public Degree Degree { get; }

        public Grade(string subject, Degree degree)
        {
            Subject = subject;
            Degree = degree;
        }
    }
}
