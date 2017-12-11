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
using WindBarrierReinforcement.DataModels.NSPage11;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public DataModelMaterials DataModelMaterialsFoundation => GlobalPageEvts.Global.GlobalPage11.DataModelMaterialsFoundation;
        public DataModelMaterials DataModelMaterialsFoundationTowerBase => GlobalPageEvts.Global.GlobalPage11.DataModelMaterialsFoundationTowerBase;
        public DataModelMaterials DataModelMaterialsLeanConcrete => GlobalPageEvts.Global.GlobalPage11.DataModelMaterialsLeanConcrete;
        public DataModelMaterials DataModelMaterialsEnvelopeAroundConduits => GlobalPageEvts.Global.GlobalPage11.DataModelMaterialsEnvelopeAroundConduits;
        public DataModelMaterials DataModelMaterialsGrouting => GlobalPageEvts.Global.GlobalPage11.DataModelMaterialsGrouting;
        public DataModelMaterials DataModelMaterialsFoundationPile => GlobalPageEvts.Global.GlobalPage11.DataModelMaterialsFoundationPile;

        public Page11()
        {
            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_Master);
        }
    }
}
