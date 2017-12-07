using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindBarrierReinforcement.Common.AttachedProperties
{
    public class CultureKey : DependencyObject
    {
        public static readonly DependencyProperty CultureResKey =
            DependencyProperty.Register("CultureRes", typeof(string), typeof(CultureKey), new PropertyMetadata());

        public static string GetCultureRes(DependencyObject d) => (string)d.GetValue(CultureResKey);

        public static void SetCultureRes(DependencyObject d, string value) => d.SetValue(CultureResKey, value);
    }
}
