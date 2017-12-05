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
using WindBarrierReinforcement.DataModels.NSPage10;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public DataModel_ChairsR DataModel_ChairsR { get; set; }
        public DataModel_ChairsR_Zones Z1 { get; set; }
        public DataModel_ChairsR_Zones Z2 { get; set; }
        //public DataModel_ChairsR Zone3 { get; set; }
        //public DataModel_ChairsR Zone4 { get; set; }

        public Page10()
        {
            DataModel_ChairsR = new DataModel_ChairsR(this);
            Z1 = new DataModel_ChairsR_Zones(this);
            Z2 = new DataModel_ChairsR_Zones(this);
            //Zone2 = new DataModel_ChairsR(this);
            //Zone3 = new DataModel_ChairsR(this);
            //Zone4 = new DataModel_ChairsR(this);
            this.DataContext = this;
            InitializeComponent();
        }

        //private void UI_ComboBox_Dir2_Diameters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}