using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfBinding.Converters
{
    class MyFontFamilyConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int index = Convert.ToInt32(value);

            InstalledFontCollection collection = new InstalledFontCollection();
            try
            {
                return new FontFamily(collection.Families[index].Name);
            }
            catch
            {
                return new FontFamily("Comic Sans MS");
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return value;
        }
    }
}
