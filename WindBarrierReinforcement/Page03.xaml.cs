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

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page03 : Page
    {

        public DataModel_ScrewPiles  DataModel_ScrewPile_SP{ get; set; }
        public Page03()
        {
            DataModel_ScrewPile_SP =  new DataModel_ScrewPiles();
              this.DataContext = this;
            InitializeComponent();
            CultureRenamer.Rename(UI_Grid_Master);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
