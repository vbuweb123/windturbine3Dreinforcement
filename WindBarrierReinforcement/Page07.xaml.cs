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
        public DataModel_StraightBars DataModel_StraightBars_Dir1 { get; private set; }

        public DataModel_StraightBars DataModel_StraightBars_Dir2 { get; private set; }

        public DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete { get; private set; }

        public DataModel_CircularBarsTop DataModel_CircularBarsTop { get; private set; }

        public DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide { get; private set; }

        public DataModel_StraightBars_Extra DataModel_StraightBars_Extra { get; private set; }

        public Page07(GlobalDataModels global)
        {
            DataModel_StraightBars_Dir1 = global.GDMPage07.DataModel_StraightBars_Dir1;
            DataModel_StraightBars_Dir2 = global.GDMPage07.DataModel_StraightBars_Dir2;
            DataModel_RadialEdgeConcrete = global.GDMPage07.DataModel_RadialEdgeConcrete;
            DataModel_CircularBarsTop = global.GDMPage07.DataModel_CircularBarsTop;
            DataModel_CircularBarsExteriorSide = global.GDMPage07.DataModel_CircularBarsExteriorSide;
            DataModel_StraightBars_Extra = global.GDMPage07.DataModel_StraightBars_Extra;
            
            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_MasterGrid);
        }
    }
}
