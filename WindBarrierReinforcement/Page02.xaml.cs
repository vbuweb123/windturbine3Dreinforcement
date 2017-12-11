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
        public DataModel_Anchor DataModel_Anchor => GlobalPageEvts.Global.GlobalPage02.DataModel_Anchor;

        public Page02()
        {
            InitializeComponent();

            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_Master);
        }      
    }
}
