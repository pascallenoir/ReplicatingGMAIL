﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace VRPApplicationCERG.Helpers.Converters
{
    public class ReplicatingGMAIL : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
            {
                throw new InvalidOperationException("The target must be a boolean");
            }

            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}