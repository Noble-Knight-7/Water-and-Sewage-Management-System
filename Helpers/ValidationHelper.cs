using System.Text.RegularExpressions;

namespace WaterSewageManagementSystem.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsValidEmail(string email)
        {
            if (IsEmpty(email)) return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidPhone(string phone)
        {
            if (IsEmpty(phone)) return false;
            return Regex.IsMatch(phone, @"^\d{10,15}$");
        }

        public static bool IsValidPassword(string password)
        {
            return !IsEmpty(password) && password.Length >= 4;
        }
    }
}
