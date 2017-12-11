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
using WindBarrierReinforcement.DataModels.NSPage07;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page7.xaml
    /// </summary>
    public partial class Page07 : Page
    {
        public DataModel_StraightBars DataModel_StraightBars_Dir1 => GlobalPageEvts.Global.GlobalPage07.DataModel_StraightBars_Dir1;

        public DataModel_StraightBars DataModel_StraightBars_Dir2 => GlobalPageEvts.Global.GlobalPage07.DataModel_StraightBars_Dir2;

        public DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete => GlobalPageEvts.Global.GlobalPage07.DataModel_RadialEdgeConcrete;

        public DataModel_CircularBarsTop DataModel_CircularBarsTop => GlobalPageEvts.Global.GlobalPage07.DataModel_CircularBarsTop;

        public DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide => GlobalPageEvts.Global.GlobalPage07.DataModel_CircularBarsExteriorSide;

        public DataModel_StraightBars_Extra DataModel_StraightBars_Extra => GlobalPageEvts.Global.GlobalPage07.DataModel_StraightBars_Extra;

        public Page07()
        {
            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_MasterGrid);
        }
    }
}
