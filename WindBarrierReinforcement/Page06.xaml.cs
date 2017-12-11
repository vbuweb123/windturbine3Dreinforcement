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
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage06;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page06 : Page
    {
        public DataModel_BR_D1 DataModel_BR_D1 { get; private set; }
        public DataModel_BR_D2 DataModel_BR_D2 { get; private  set; }
        public DataModel_BR_L DataModel_BR_L { get; private set; }
        public DataModel_TB_D1 DataModel_TB_D1 { get; private set; }
        public DataModel_TB_D2 DataModel_TB_D2 { get; private set; }
        public DataModel_Circular_EdgeOfL DataModel_Circular_EdgeOfL { get; private set; }
        public DataModel_Generalities DataModel_Generalities { get; private set; }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureRenamer.Rename(UI_Master_Grid);
        }

        public Page06(GlobalDataModels global)
        {

            DataModel_BR_D1 = global.GDMPage06.DataModel_BR_D1;
            DataModel_BR_D2 = global.GDMPage06.DataModel_BR_D2;
            DataModel_BR_L = global.GDMPage06.DataModel_BR_L;
            DataModel_TB_D1 = global.GDMPage06.DataModel_TB_D1;
            DataModel_TB_D2 = global.GDMPage06.DataModel_TB_D2;
            DataModel_Circular_EdgeOfL = global.GDMPage06.DataModel_Circular_EdgeOfL;
            DataModel_Generalities = global.GDMPage06.DataModel_Generalities;


            InitializeComponent();
            this.DataContext = this;
        }
    }
}
