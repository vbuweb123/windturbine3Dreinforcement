using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.DataModels.NSPage11;
using WBR_Common.Writer;

namespace WBR_Common.StaticModel
{
    public interface IGlobalDataModelsPage11
    {
        DataModelMaterials DataModelMaterialsFoundation { get; }
        DataModelMaterials DataModelMaterialsFoundationTowerBase { get; }
        DataModelMaterials DataModelMaterialsLeanConcrete { get; }
        DataModelMaterials DataModelMaterialsEnvelopeAroundConduits { get; }
        DataModelMaterials DataModelMaterialsGrouting { get; }
        DataModelMaterials DataModelMaterialsFoundationPile { get; }
    }
    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage11 : IGlobalDataModelsPage11
        {
            [SaveKeyCode(KeyCode = "DataModelMaterialsFoundation", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "MaterialsFoundation", AddNavKey = true)]
            public DataModelMaterials DataModelMaterialsFoundation { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelMaterialsFoundationTowerBase", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "FoundationTowerBase", AddNavKey = true)]
            public DataModelMaterials DataModelMaterialsFoundationTowerBase { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelMaterialsLeanConcrete", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "LeanConcrete", AddNavKey = true)]
            public DataModelMaterials DataModelMaterialsLeanConcrete { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelMaterialsEnvelopeAroundConduits", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "EnvelopeAroundConduits", AddNavKey = true)]
            public DataModelMaterials DataModelMaterialsEnvelopeAroundConduits { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelMaterialsGrouting", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "Grouting", AddNavKey = true)]
            public DataModelMaterials DataModelMaterialsGrouting { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelMaterialsFoundationPile", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "FoundationPile", AddNavKey = true)]
            public DataModelMaterials DataModelMaterialsFoundationPile { get; private set; }

            public _GlobalDataModelsPage11(GlobalDataModels global)
            {
                DataModelMaterialsFoundation = new DataModelMaterials(global,"Foundation");                

                DataModelMaterialsFoundationTowerBase = new DataModelMaterials(global, "Foundation Tower Base");

                DataModelMaterialsLeanConcrete = new DataModelMaterials(global, "Lean Concrete");

                DataModelMaterialsEnvelopeAroundConduits = new DataModelMaterials(global, "Envelope Around Conduits");

                DataModelMaterialsGrouting = new DataModelMaterials(global, "Grouting");

                DataModelMaterialsFoundationPile = new DataModelMaterials(global, "Foundation Piles");

            }
        }
    }
}
