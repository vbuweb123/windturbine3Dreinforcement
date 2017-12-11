using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage11;

namespace WindBarrierReinforcement.StaticModel
{
    public class GlobalPage11
    {
        private DataModelMaterials dataModelMaterialsFoundation;
        public DataModelMaterials DataModelMaterialsFoundation
            => dataModelMaterialsFoundation ?? (dataModelMaterialsFoundation = new DataModelMaterials("Foundation"));

        private DataModelMaterials dataModelMaterialsFoundationTowerBase;
        public DataModelMaterials DataModelMaterialsFoundationTowerBase
            => dataModelMaterialsFoundationTowerBase ?? (dataModelMaterialsFoundationTowerBase = new DataModelMaterials("Foundation Tower Base"));

        private DataModelMaterials dataModelMaterialsLeanConcrete;
        public DataModelMaterials DataModelMaterialsLeanConcrete
            => dataModelMaterialsLeanConcrete ?? (dataModelMaterialsLeanConcrete = new DataModelMaterials("Lean Concrete"));

        private DataModelMaterials dataModelMaterialsEnvelopeAroundConduits;
        public DataModelMaterials DataModelMaterialsEnvelopeAroundConduits
            => dataModelMaterialsEnvelopeAroundConduits ?? (dataModelMaterialsEnvelopeAroundConduits = new DataModelMaterials("Envelope Around Conduits"));

        private DataModelMaterials dataModelMaterialsGrouting;
        public DataModelMaterials DataModelMaterialsGrouting
            => dataModelMaterialsGrouting ?? (dataModelMaterialsGrouting = new DataModelMaterials("Grouting"));

        private DataModelMaterials dataModelMaterialsFoundationPiles;
        public DataModelMaterials DataModelMaterialsFoundationPile
            => dataModelMaterialsFoundationPiles ?? (dataModelMaterialsFoundationPiles = new DataModelMaterials("Foundation Piles"));
    }
}
