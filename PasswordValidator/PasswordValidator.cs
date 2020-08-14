using System;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
    public static class PasswordValidator
    {
        private static string _specialCharacters = @"!@#$%\^&*\(\)+=_\-{}\[\]:;\'?<>,\.""";

        public static bool ValidatePassword(string password)
        {
            // Check string to contain at least 1 lowercase, uppercase letter, digit
            // and string length (from 6 to 24 characters)
            if (!Regex.IsMatch(password, @"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(^.{6,24}$)"))
                return false;
            
            // Check string for maximum of 2 repeated characters
            if (Regex.IsMatch(password, $"([0-9a-zA-Z{_specialCharacters}])\\1{{2}}"))
                return false;
            
            // Final check to valid that all characters are allowed
            if (!Regex.IsMatch(password, $"^[0-9a-zA-Z{_specialCharacters}]+$"))
                return false;
            
            return true;
        }
    }
}
