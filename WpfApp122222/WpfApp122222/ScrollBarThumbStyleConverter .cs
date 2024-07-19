using System.Globalization;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp122222
{
    public class ScrollBarThumbStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tag = value as string;
            if (!string.IsNullOrEmpty(tag))
            {
                return Application.Current.Resources["VerticalScrollBarImg"];
            }
            return Application.Current.Resources["VerticalScrollBar"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
