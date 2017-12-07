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

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page7.xaml
    /// </summary>
    public partial class Page07 : Page
    {
        public DataModel_StraightBars DataModel_StraightBars_Dir1 { get; set; }
        public DataModel_StraightBars DataModel_StraightBars_Dir2 { get; set; }
        public DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete { get; set; }
        public DataModel_CircularBarsTop DataModel_CircularBarsTop { get; set; }
        public DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide { get; set; }

        public Page07()
        {
            //initializing data models
            DataModel_StraightBars_Dir1 = new DataModel_StraightBars(this);
            DataModel_StraightBars_Dir2 = new DataModel_StraightBars(this);
            DataModel_RadialEdgeConcrete = new DataModel_RadialEdgeConcrete();
            DataModel_CircularBarsTop = new DataModel_CircularBarsTop();
            DataModel_CircularBarsExteriorSide = new DataModel_CircularBarsExteriorSide();

            //starting page
            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.RenameTextBlock(UI_TextBlock_Title);

        }
    }
}
