using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace RegexImpl
{
    internal class RegexI
    {
        public static bool ValidateName(string name)
        {
            string namePattern = "^[A-Za-z]+$";
            Regex nameRegex = new Regex(namePattern);
            return nameRegex.IsMatch(name);
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string phonePattern = "^[0-9]{2}s[0-9]{10}$";
            Regex phoneRegex = new Regex(phonePattern);
            return phoneRegex.IsMatch(phoneNumber);
        }

       
    }
}
