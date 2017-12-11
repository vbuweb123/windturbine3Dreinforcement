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
using WindBarrierReinforcement.DataModels.NSPage05;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page05 : Page
    {
        public DataModel_Top_Reinforcement DataModel_Top_Reinforcement1 { get; private set; }
        public DataModel_Top_Reinforcement DataModel_Top_Reinforcement2 { get; private set; }

        public Page05(GlobalDataModels global)
        {
            DataModel_Top_Reinforcement1 = global.GDMPage05.DataModel_Top_Reinforcement1;
            DataModel_Top_Reinforcement2 = global.GDMPage05.DataModel_Top_Reinforcement2;

            InitializeComponent();
            this.DataContext = this;
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureRenamer.Rename(UI_Grid_Master);
        }        
    }
}
