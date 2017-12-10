using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage04;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage04
    {
        private static DataModelCircularGeneral dataModelCircularGeneral;
        public static DataModelCircularGeneral DataModelCircularGeneral => dataModelCircularGeneral ?? (dataModelCircularGeneral = new DataModelCircularGeneral());

        private static DataModelRadial1 dataModelRadial1;
        public static DataModelRadial1 DataModelRadial1 => dataModelRadial1 ?? (dataModelRadial1 = new DataModelRadial1());

        private static DataModelRadial2 dataModelRadial2;
        public static DataModelRadial2 DataModelRadial2 => dataModelRadial2 ?? (dataModelRadial2 = new DataModelRadial2());

        private static DataModelRadialGeneral dataModelRadialGeneral;
        public static DataModelRadialGeneral DataModelRadialGeneral => dataModelRadialGeneral ?? (dataModelRadialGeneral = new DataModelRadialGeneral());
    }
}
