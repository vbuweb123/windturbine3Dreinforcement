using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage10
{
    public class DataModel_CHR_Zones : DataModel
    {
        //TODO: Definition of zone in excel are not clear. Hardcoding zones for now
        private int zoneLength1;
        public int ZoneLength1
        {
            get { return zoneLength1; }
            set { zoneLength1 = value; NotifyPropertyChanged("ZoneLength1"); }
        }
        private int spacingValueRadial1;
        public int SpacingValueRadial1
        {
            get { return spacingValueRadial1; }
            set { spacingValueRadial1 = value; NotifyPropertyChanged("SpacingValueRadial1"); }
        }

        private int edgeOffset1;
        public int EdgeOffset1 //Edge Offset for secon zone needs to be calculated
        {
            get { return edgeOffset1; }
            set { edgeOffset1 = value; NotifyPropertyChanged("EdgeOffset1"); }
        }

        private int zoneLength2;
        public int ZoneLength2 // TODO : this needs to be calculated
        {
            get { return zoneLength2; }
            set { zoneLength2 = value; NotifyPropertyChanged("ZoneLength2"); }
        }
        private int spacingValueRadial2;
        public int SpacingValueRadial2
        {
            get { return spacingValueRadial2; }
            set { spacingValueRadial2 = value; NotifyPropertyChanged("SpacingValueRadial2"); }
        }

        private int edgeOffset2;
        public int EdgeOffset2 //Edge Offset for secon zone needs to be calculated
        {
            get { return edgeOffset2; }
            set { edgeOffset2 = value; NotifyPropertyChanged("EdgeOffset2"); }
        }

    }
}
