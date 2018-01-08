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
using WBR_Common.DataModels.NSPage08;
using WBR_Common.Resources;
using WBR_Common.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page8.xaml
    /// </summary>
    public partial class Page08 : Page
    {
        public DataModel_ARExtUBars DataModel_ARExtUBars { get; private set; }

        public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop { get; private set; }

        public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral { get; private set; }

        public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom { get; private set; }

        public DataModel_ARIntUBars DataModel_ARIntUBars { get; private set; }

        public DataModel_ARIntCircularTop DataModel_ARIntCircularTop { get; private set; }

        public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral { get; private set; }

        public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom { get; private set; }

        public Page08(GlobalDataModels global)
        {
            DataModel_ARExtUBars = global.GDMPage08.DataModel_ARExtUBars;
            DataModel_ARExteriorCircularTop = global.GDMPage08.DataModel_ARExteriorCircularTop;
            DataModel_ARExteriorCircularLateral = global.GDMPage08.DataModel_ARExteriorCircularLateral;
            DataModel_ARExteriorCircularBottom = global.GDMPage08.DataModel_ARExteriorCircularBottom;
            DataModel_ARIntUBars = global.GDMPage08.DataModel_ARIntUBars;
            DataModel_ARIntCircularTop = global.GDMPage08.DataModel_ARIntCircularTop;
            DataModel_ARIntCircularLateral = global.GDMPage08.DataModel_ARIntCircularLateral;
            DataModel_ARIntCircularBottom = global.GDMPage08.DataModel_ARIntCircularBottom;

            InitializeComponent();
            this.DataContext = this;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureRenamer.Rename(UI_Grid_Page8_Master);
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string imageSource = "Assets/Images/AR_01.png";

            PictureInfo PictureInfo = new PictureInfo(imageSource);
            PictureInfo.Show();
        }
    }
}
