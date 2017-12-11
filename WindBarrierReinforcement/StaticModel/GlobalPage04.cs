using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage04;

namespace WindBarrierReinforcement.StaticModel
{
    public class GlobalPage04
    {
        private DataModelCircularGeneral dataModelCircularGeneral;
        public DataModelCircularGeneral DataModelCircularGeneral => dataModelCircularGeneral ?? (dataModelCircularGeneral = new DataModelCircularGeneral());

        private DataModelRadial1 dataModelRadial1;
        public DataModelRadial1 DataModelRadial1 => dataModelRadial1 ?? (dataModelRadial1 = new DataModelRadial1());

        private DataModelRadial2 dataModelRadial2;
        public DataModelRadial2 DataModelRadial2 => dataModelRadial2 ?? (dataModelRadial2 = new DataModelRadial2());

        private DataModelRadialGeneral dataModelRadialGeneral;
        public DataModelRadialGeneral DataModelRadialGeneral => dataModelRadialGeneral ?? (dataModelRadialGeneral = new DataModelRadialGeneral());

    }
}
