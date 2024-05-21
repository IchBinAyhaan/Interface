

namespace User
{
    internal static class StringExtension
    {
      
        
            public static bool SetPIN(this string pin)
            {
                return pin.Length == 7 && pin == pin.ToUpper();
            }
        

    }
}
