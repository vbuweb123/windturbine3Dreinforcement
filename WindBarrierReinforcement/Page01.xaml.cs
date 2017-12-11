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
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.DataModels.NSPage06;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{

    /// <summary>
    /// Interaction logic for Page1.xaml a
    /// </summary>
    public partial class Page01 : Page
    {

        public DataModel_Global_Formwork DataModel_Global_Formwork => GlobalPageEvts.Global.GlobalPage01.DataModel_Global_Formwork;

        public DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint => GlobalPageEvts.Global.GlobalPage01.DataModel_Global_Coordinations_GroundPoint;

        public DataModel_Global_Materials DataModel_Global_Materials => GlobalPageEvts.Global.GlobalPage01.DataModel_Global_Materials;
                
        public Page01()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureRenamer.Rename(UI_Grid_Master);                     
        }

    }
}
