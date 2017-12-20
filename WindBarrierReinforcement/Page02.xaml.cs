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
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    /// 
    public partial class Page02 : Page
    {
        public DataModel_Anchor DataModel_Anchor { get; private set; }

        public Page02(GlobalDataModels global)
        {
            DataModel_Anchor = global.GDMPage02.DataModel_Anchor;

            InitializeComponent();

            this.DataContext = this;
            
            CultureRenamer.Rename(UI_Grid_Master);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imageSource = "Assets/Images/Anchor_01.png";

            PictureInfo PictureInfo = new PictureInfo(imageSource);
            PictureInfo.Show();
        }
    }
}
