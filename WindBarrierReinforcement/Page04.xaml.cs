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
        public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }
        public DataModelRadial1 DataModelRadial1 { get; private set; }
        public DataModelRadial2 DataModelRadial2 { get; private set; }
        public DataModelRadialGeneral DataModelRadialGeneral { get; private set; }

        public Page04(GlobalDataModels global)
        {
            DataModelCircularGeneral = global.GDMPage04.DataModelCircularGeneral;
            DataModelRadial1 = global.GDMPage04.DataModelRadial1;
            DataModelRadial2 = global.GDMPage04.DataModelRadial2;
            DataModelRadialGeneral = global.GDMPage04.DataModelRadialGeneral;

            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_MasterGrid);
        }
    }
}
