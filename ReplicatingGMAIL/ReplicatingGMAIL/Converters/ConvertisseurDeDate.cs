using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ReplicatingGMAIL.Converters
{
    
/// <summary>
/// Une bonne pratique UX consiste à utiliser un format d'heure relative au lieu d'afficher les dates en utilisant des formats de date normaux. Il aide l'utilisateur à avoir une idée rapide du délai sans avoir à calculer exactement quand cela s'est produit, et offre également une meilleure apparence à votre application.
///Vous pouvez voir cela couramment utilisé dans des applications comme Facebook, Instagram, Gmail, etc.Parce qu'il est plus facile de lire "il y a 2 minutes" que "9:23 2/3/18".
///Une excellente façon de le faire dans Xamarin Forms consiste à utiliser des convertisseurs.
/// </summary>
    public class ConvertisseurDeDate : IValueConverter
    {
        const int SECOND = 1;
        const int MINUTE = 60 * SECOND;
        const int HOUR = 60 * MINUTE;
        const int DAY = 24 * HOUR;
        const int MONTH = 30 * DAY;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return string.Empty;

            var current_day = DateTime.Today;
            var postedData = (DateTime)value;

            var ts = new TimeSpan(DateTime.Now.Ticks - postedData.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
            {
                if (ts.Seconds < 0)
                {
                    return "il y a quelque temps";
                }
                return ts.Seconds == 1 ? "1s." : ts.Seconds + "s.";
            }

            if (delta < 2 * MINUTE)
                return postedData;

            if (delta < 45 * MINUTE)
            {
                if (ts.Seconds < 0)
                {
                    return "il y a quelque temps";
                }
                return ts.Minutes + "min.";
            }

            if (delta <= 90 * MINUTE)
                return "1h.";

            if (delta < 24 * HOUR)
            {
                if (ts.Hours < 0)
                {
                    return "il y a quelque temps";
                }

                if (ts.Hours == 1)
                    return "1h.";

                return ts.Hours + "h.";
            }

            if (delta < 48 * HOUR)
                return $"hier à {postedData.ToString("t")}";

            if (delta < 30 * DAY)
            {
                if (ts.Days == 1)
                    return "1 jour";

                return ts.Days + " jours";
            }


            if (delta < 12 * MONTH)
            {
                int months = (int)(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? " 1 mois." : months + " mois.";
            }
            else
            {
                int years = (int)(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "1 year" : years + " years";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

