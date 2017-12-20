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
using WindBarrierReinforcement.DataModels.NSPAge03;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page03 : Page
    {
               
        public DataModel_ScrewPiles DataModel_ScrewPiles { get; private set; }

        public Page03(GlobalDataModels global)
        {
            DataModel_ScrewPiles = global.GDMPage03.DataModel_ScrewPile;

            InitializeComponent();

            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_Master);
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string imageSource = "Assets/Images/Piles_01.png";

            PictureInfo PictureInfo = new PictureInfo(imageSource);
            PictureInfo.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            string imageSource = "Assets/Images/Piles_02.png";

            PictureInfo PictureInfo = new PictureInfo(imageSource);
            PictureInfo.Show();
        }
    }
}
