using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace tp6
{
    public class EmailValidationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string email)
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.(fr)$"; // Vérifie si l'e-mail contient '@' et se termine par '.fr'
                return Regex.IsMatch(email, pattern);
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
