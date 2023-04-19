using System.Text.RegularExpressions;

namespace _15_08
{
    public static class Valid
    {
        public static bool IsFioValid(string fio)
        {
            if (fio.Length >= 10 && fio.Length <= 60)
                return true;

            return false;
        }

        public static bool IsAddressValid(string address)
        {
            if (address.Length >= 20 && address.Length <= 85)
                return true;

            return false;
        }

        public static bool IsEmailValid(string email)
        {
            if(Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return true;
            else
                return false;            
        }
    }
}
