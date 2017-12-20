using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindBarrierReinforcement.DataModelPictures;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for PictureInfo.xaml
    /// </summary>
    public partial class PictureInfo : Window
    {
        public Picture Picture { get; set; }

        public PictureInfo(string imageSource)
        {
            Picture = new Picture()
            {
                ImageSource = imageSource
            };                        
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
