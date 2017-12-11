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
               
        public DataModel_ScrewPiles DataModel_ScrewPiles => GlobalPage03.DataModel_ScrewPile;

        public Page03()
        {          
            this.DataContext = this;
            InitializeComponent();
            CultureRenamer.Rename(UI_Grid_Master);
        }
               
    }
}
