

namespace User
{
    internal class User
    {
        public string Name { get; }
        public string Surname { get; }
        public RegistrationMonth RegistrationMonth { get; }
        private string Pin;

        public string PIN
        {
            get { return Pin; }
            set
            {
                if (value.Length == 7 && value == value.ToUpper())
                {
                    Pin = value;
                }
                else
                {
                    Console.WriteLine("PİN kodunun uzunluğu 7 simvol ve bütün simvollar böyük herf olmalıdır.");
                }
            }
        }

        public User(string name, string surname, RegistrationMonth registrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = registrationMonth;
            SetPIN(pin); 
        }

        private void SetPIN(string pin)
        {
            if (pin.Length == 7 && pin == pin.ToUpper())
            {
                Pin = pin;
            }
            else
            {
                Console.WriteLine("PİN kodunun uzunluğu 7 simvol ve bütün simvollar böyük herf olmalıdır.");
            }
        }

        public string GetDetails()
        {
            return $"Name: {Name}, Surname: {Surname}, Registration Month: {RegistrationMonth}, PIN: {PIN}";
        }
    }

}

