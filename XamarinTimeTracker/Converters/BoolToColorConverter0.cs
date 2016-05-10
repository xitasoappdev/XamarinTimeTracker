using System;
using Xamarin.Forms;

namespace XamarinTimeTracker
{
    public class BoolToColorConverter0 : IValueConverter
    {

        public Color TrueColor { set; get; }

        public Color FalseColor { set; get; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool))
                return TrueColor;

            return (bool)value ? TrueColor : FalseColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

