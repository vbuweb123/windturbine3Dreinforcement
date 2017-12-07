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
        public DataModel_ARExtUBars DataModel_ARExtUBars
        {
            get => GlobalDataModelsPage08.DataModel_ARExtUBars;
            set => GlobalDataModelsPage08.DataModel_ARExtUBars = value;
        }

        public DataModel_ARExteriorCircularTop DataModel_ARExteriorCircularTop
        {
            get => GlobalDataModelsPage08.DataModel_ARExteriorCircularTop;
            set => GlobalDataModelsPage08.DataModel_ARExteriorCircularTop = value;
        }

        public DataModel_ARExteriorCircularLateral DataModel_ARExteriorCircularLateral
        {
            get => GlobalDataModelsPage08.DataModel_ARExteriorCircularLateral;
            set => GlobalDataModelsPage08.DataModel_ARExteriorCircularLateral = value;
        }

        public DataModel_ARExteriorCircularBottom DataModel_ARExteriorCircularBottom
        {
            get => GlobalDataModelsPage08.DataModel_ARExteriorCircularBottom;
            set => GlobalDataModelsPage08.DataModel_ARExteriorCircularBottom = value;
        }

        public DataModel_ARIntUBars DataModel_ARIntUBars
        {
            get => GlobalDataModelsPage08.DataModel_ARIntUBars;
            set => GlobalDataModelsPage08.DataModel_ARIntUBars = value;
        }
        public DataModel_ARIntCircularTop DataModel_ARIntCircularTop
        {
            get => GlobalDataModelsPage08.DataModel_ARIntCircularTop;
            set => GlobalDataModelsPage08.DataModel_ARIntCircularTop = value;
        }
        public DataModel_ARIntCircularLateral DataModel_ARIntCircularLateral
        {
            get => GlobalDataModelsPage08.DataModel_ARIntCircularLateral;
            set => GlobalDataModelsPage08.DataModel_ARIntCircularLateral = value;
        }

        public DataModel_ARIntCircularBottom DataModel_ARIntCircularBottom
        {
            get => GlobalDataModelsPage08.DataModel_ARIntCircularBottom;
            set => GlobalDataModelsPage08.DataModel_ARIntCircularBottom = value;
        }
        
        public Page08()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureRenamer.RenameCollection(UI_Grid_ArExtU.Children);
            CultureRenamer.RenameTextBlock(UI_TextBlock_Title);
            CultureRenamer.RenameCollection(UI_Grid_AR_ECT.Children);
            CultureRenamer.RenameCollection(UI_Grid_AR_ECL.Children);
            CultureRenamer.RenameCollection(UI_Grid_AR_ECB.Children);
            CultureRenamer.RenameCollection(UI_Grid_Ar_Int.Children);
            CultureRenamer.RenameCollection(UI_Grid_AR_ICT.Children);
            CultureRenamer.RenameCollection(UI_Grid_AR_ICL.Children);
            CultureRenamer.RenameCollection(UI_Grid_AR_ICB.Children);
        }
    }
}
