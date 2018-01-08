using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WBR_Common.Common.AttachedProperties
{
    public class ImageSourcePath : DependencyObject
    {
        public static readonly DependencyProperty ImageSourcePathProperty
             = DependencyProperty.Register("ImageSourcePath", typeof(string), typeof(ImageSourcePath));

        public string GetImageSourcePath(DependencyObject d) => (string)d.GetValue(ImageSourcePathProperty);

        public static void SetImageSourcePath(DependencyObject d, string value) => d.SetValue(ImageSourcePathProperty, value);
    }
}
