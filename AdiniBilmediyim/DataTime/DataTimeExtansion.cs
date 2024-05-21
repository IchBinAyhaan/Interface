
namespace DataTime
{
    internal static class DataTimeExtansion
    {
        public static int GetAge(this DateTime birthDate)
        {
            int today = DateTime.Today.Year;
            int age = today - birthDate.Year;

            if (birthDate.Date > DateTime.Today.AddYears(-age))
                age--;

            return age;

        }
    }
}
