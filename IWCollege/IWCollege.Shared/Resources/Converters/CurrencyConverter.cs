﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IWCollege.Resources.Converters
{
    class CurrencyConverter : Windows.UI.Xaml.Data.IValueConverter
    {
        //#region IValueConverter Members

        // Define the Convert method to change a DateTime object to 
        // a month string.
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            // value is the data from the source object.

            double price = double.Parse(value.ToString());
            price = price * 0.64;
            string output = "£" + price.ToString();

            // Return the value to pass to the target.
            return output;

        }

        // ConvertBack is not implemented for a OneWay binding.
        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            throw new NotImplementedException();
        }

        //#endregion
    }
}
