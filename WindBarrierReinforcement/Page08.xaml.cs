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
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page8.xaml
    /// </summary>
    public partial class Page08 : Page
    {
        public DataModel_ARExtUBars DataModel_ARExtUBars => GlobalPage08.DataModel_ARExtUBars;

        public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop => GlobalPage08.DataModel_ARExteriorCircularTop;
       
        public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral => GlobalPage08.DataModel_ARExteriorCircularLateral;
       
        public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom => GlobalPage08.DataModel_ARExteriorCircularBottom;
        
        public DataModel_ARIntUBars DataModel_ARIntUBars => GlobalPage08.DataModel_ARIntUBars;
       
        public DataModel_ARIntCircularTop DataModel_ARIntCircularTop => GlobalPage08.DataModel_ARIntCircularTop;
      
        public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral => GlobalPage08.DataModel_ARIntCircularLateral;
        
        public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom => GlobalPage08.DataModel_ARIntCircularBottom;
              
        public Page08()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureRenamer.Rename(UI_Grid_Page8_Master);
        }
    }
}
