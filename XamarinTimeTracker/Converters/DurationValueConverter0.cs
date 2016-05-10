using System;
using Xamarin.Forms;

namespace XamarinTimeTracker
{
    public class DurationValueConverter0 : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var durationSeconds = (int)value;

            return TimeSpan.FromSeconds(durationSeconds).ToString("c");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

