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
        public DataModelMaterials DataModelMaterialsFoundation => GlobalPage11.DataModelMaterialsFoundation;
        public DataModelMaterials DataModelMaterialsFoundationTowerBase => GlobalPage11.DataModelMaterialsFoundationTowerBase;
        public DataModelMaterials DataModelMaterialsLeanConcrete => GlobalPage11.DataModelMaterialsLeanConcrete;
        public DataModelMaterials DataModelMaterialsEnvelopeAroundConduits => GlobalPage11.DataModelMaterialsEnvelopeAroundConduits;
        public DataModelMaterials DataModelMaterialsGrouting => GlobalPage11.DataModelMaterialsGrouting;
        public DataModelMaterials DataModelMaterialsFoundationPile => GlobalPage11.DataModelMaterialsFoundationPile;

        public Page11()
        {
            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_Master);
        }
    }
}
