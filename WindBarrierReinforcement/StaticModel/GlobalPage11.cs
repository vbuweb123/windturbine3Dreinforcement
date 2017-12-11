using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage11;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage11
    {
        private static DataModelMaterials dataModelMaterialsFoundation;
        public static DataModelMaterials DataModelMaterialsFoundation
            => dataModelMaterialsFoundation ?? (dataModelMaterialsFoundation = new DataModelMaterials("Foundation"));

        private static DataModelMaterials dataModelMaterialsFoundationTowerBase;
        public static DataModelMaterials DataModelMaterialsFoundationTowerBase
            => dataModelMaterialsFoundationTowerBase ?? (dataModelMaterialsFoundationTowerBase = new DataModelMaterials("Foundation Tower Base"));

        private static DataModelMaterials dataModelMaterialsLeanConcrete;
        public static DataModelMaterials DataModelMaterialsLeanConcrete
            => dataModelMaterialsLeanConcrete ?? (dataModelMaterialsLeanConcrete = new DataModelMaterials("Lean Concrete"));

        private static DataModelMaterials dataModelMaterialsEnvelopeAroundConduits;
        public static DataModelMaterials DataModelMaterialsEnvelopeAroundConduits
            => dataModelMaterialsEnvelopeAroundConduits ?? (dataModelMaterialsEnvelopeAroundConduits = new DataModelMaterials("Envelope Around Conduits"));

        private static DataModelMaterials dataModelMaterialsGrouting;
        public static DataModelMaterials DataModelMaterialsGrouting
            => dataModelMaterialsGrouting ?? (dataModelMaterialsGrouting = new DataModelMaterials("Grouting"));

        private static DataModelMaterials dataModelMaterialsFoundationPiles;
        public static DataModelMaterials DataModelMaterialsFoundationPile
            => dataModelMaterialsFoundationPiles ?? (dataModelMaterialsFoundationPiles = new DataModelMaterials("Foundation Piles"));
    }
}
