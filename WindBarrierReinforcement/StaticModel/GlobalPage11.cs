using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage11;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalPage11
    {
        DataModelMaterials DataModelMaterialsFoundation { get; }
        DataModelMaterials DataModelMaterialsFoundationTowerBase { get; }
        DataModelMaterials DataModelMaterialsLeanConcrete { get; }
        DataModelMaterials DataModelMaterialsEnvelopeAroundConduits { get; }
        DataModelMaterials DataModelMaterialsGrouting { get; }
        DataModelMaterials DataModelMaterialsFoundationPile { get; }
    }
    public partial class Global
    {
        private class _GlobalPage11 : IGlobalPage11
        {
            public DataModelMaterials DataModelMaterialsFoundation { get; private set; }

            public DataModelMaterials DataModelMaterialsFoundationTowerBase { get; private set; }

            public DataModelMaterials DataModelMaterialsLeanConcrete { get; private set; }

            public DataModelMaterials DataModelMaterialsEnvelopeAroundConduits { get; private set; }

            public DataModelMaterials DataModelMaterialsGrouting { get; private set; }

            public DataModelMaterials DataModelMaterialsFoundationPile { get; private set; }

            public _GlobalPage11(EvtHandler evtHandler)
            {
                DataModelMaterialsFoundation = new DataModelMaterials("Foundation");

                DataModelMaterialsFoundationTowerBase = new DataModelMaterials("Foundation Tower Base");

                DataModelMaterialsLeanConcrete = new DataModelMaterials("Lean Concrete");

                DataModelMaterialsEnvelopeAroundConduits = new DataModelMaterials("Envelope Around Conduits");

                DataModelMaterialsGrouting = new DataModelMaterials("Grouting");

                DataModelMaterialsFoundationPile = new DataModelMaterials("Foundation Piles");
            }
        }
    }
}
