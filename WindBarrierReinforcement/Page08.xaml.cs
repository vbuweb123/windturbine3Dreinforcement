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
using WindBarrierReinforcement.DataModels.NSPage08;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page8.xaml
    /// </summary>
    public partial class Page08 : Page
    {
        public DataModel_ARExtUBars DataModel_ARExtUBars { get; set; }
        public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop { get; set; }
        public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral { get; set; }
        public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom { get; set; }
        public DataModel_ARIntUBars DataModel_ARIntUBars { get; set; }
        public DataModel_ARIntCircularTop DataModel_ARIntCircularTop { get; set; }
        public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom { get; set; }
        public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral { get; set; }

        public Page08()
        {
            DataModel_ARExtUBars = new DataModel_ARExtUBars();
            DataModel_ARExteriorCircularTop = new DataModel_ARExteriorCircularTop();
            DataModel_ARExteriorCircularLateral = new DataModel_ARExteriorCircularLateral();
            DataModel_ARExteriorCircularBottom = new DataModel_ARExteriorCircularBottom();
            DataModel_ARIntUBars = new DataModel_ARIntUBars();
            DataModel_ARIntCircularTop = new DataModel_ARIntCircularTop();
            DataModel_ARIntCircularBottom = new DataModel_ARIntCircularBottom();
            DataModel_ARIntCircularLateral = new DataModel_ARIntCircularLateral();

            InitializeComponent();
            this.DataContext = this;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
