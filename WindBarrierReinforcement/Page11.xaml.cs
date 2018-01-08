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
using WBR_Common.DataModels.NSPage11;
using WBR_Common.Resources;
using WBR_Common.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public DataModelMaterials DataModelMaterialsFoundation { get; private set; }
        public DataModelMaterials DataModelMaterialsFoundationTowerBase { get; private set; }
        public DataModelMaterials DataModelMaterialsLeanConcrete { get; private set; }
        public DataModelMaterials DataModelMaterialsEnvelopeAroundConduits { get; private set; }
        public DataModelMaterials DataModelMaterialsGrouting { get; private set; }
        public DataModelMaterials DataModelMaterialsFoundationPile { get; private set; }

        public Page11(GlobalDataModels global)
        {
            DataModelMaterialsFoundation = global.GDMPage11.DataModelMaterialsFoundation;
            DataModelMaterialsFoundationTowerBase = global.GDMPage11.DataModelMaterialsFoundationTowerBase;
            DataModelMaterialsLeanConcrete = global.GDMPage11.DataModelMaterialsLeanConcrete;
            DataModelMaterialsEnvelopeAroundConduits = global.GDMPage11.DataModelMaterialsEnvelopeAroundConduits;
            DataModelMaterialsGrouting = global.GDMPage11.DataModelMaterialsGrouting;
            DataModelMaterialsFoundationPile = global.GDMPage11.DataModelMaterialsFoundationPile;

            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_Master);
        }
    }
}
