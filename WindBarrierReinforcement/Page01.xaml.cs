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
using WindBarrierReinforcement.DataModels.NSPage06;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page01 : Page
    {
        public DataModel_Global_Formwork DataModel_Global_Formwork { get; set; }
        public DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint { get; set; }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        public Page01()
        {
            DataModel_Global_Formwork = new DataModel_Global_Formwork();
            DataModel_Global_Coordinations_GroundPoint = new DataModel_Global_Coordinations_GroundPoint();

            InitializeComponent();
            this.DataContext = this;
        }
    }
}
