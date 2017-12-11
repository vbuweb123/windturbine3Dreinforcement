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
using WindBarrierReinforcement.DataModels.NSPage04;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page04 : Page
    {
        public DataModelCircularGeneral DataModelCircularGeneral => GlobalPageEvts.Global.GlobalPage04.DataModelCircularGeneral;
        public DataModelRadial1 DataModelRadial1 => GlobalPageEvts.Global.GlobalPage04.DataModelRadial1;
        public DataModelRadial2 DataModelRadial2 => GlobalPageEvts.Global.GlobalPage04.DataModelRadial2;
        public DataModelRadialGeneral DataModelRadialGeneral => GlobalPageEvts.Global.GlobalPage04.DataModelRadialGeneral;

        public Page04()
        {
            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_MasterGrid);
        }
    }
}
