using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WBR_Common.Common.AttachedProperties
{
    public class InfoText : DependencyObject
    {
        public static readonly DependencyProperty InfoTextProperty
            = DependencyProperty.Register("InfoText", typeof(string), typeof(InfoText));

        public static string GetInfoText(DependencyObject d) => (string)d.GetValue(InfoTextProperty);

        public static void SetInfoText(DependencyObject d, string value) => d.SetValue(InfoTextProperty, value);
    }
}
