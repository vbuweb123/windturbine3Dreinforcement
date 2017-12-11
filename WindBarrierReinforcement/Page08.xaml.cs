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
        public DataModel_ARExtUBars DataModel_ARExtUBars => GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars;

        public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop => GlobalPageEvts.Global.GlobalPage08.DataModel_ARExteriorCircularTop;
       
        public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral => GlobalPageEvts.Global.GlobalPage08.DataModel_ARExteriorCircularLateral;
       
        public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom => GlobalPageEvts.Global.GlobalPage08.DataModel_ARExteriorCircularBottom;
        
        public DataModel_ARIntUBars DataModel_ARIntUBars => GlobalPageEvts.Global.GlobalPage08.DataModel_ARIntUBars;
       
        public DataModel_ARIntCircularTop DataModel_ARIntCircularTop => GlobalPageEvts.Global.GlobalPage08.DataModel_ARIntCircularTop;
      
        public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral => GlobalPageEvts.Global.GlobalPage08.DataModel_ARIntCircularLateral;
        
        public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom => GlobalPageEvts.Global.GlobalPage08.DataModel_ARIntCircularBottom;
              
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
