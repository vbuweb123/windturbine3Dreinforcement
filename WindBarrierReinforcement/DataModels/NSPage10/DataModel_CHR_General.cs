using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage10
{
    public class DataModel_CHR_General : DataModel
    {
        private int edgeOffset;
        public int EdgeOffset
        {
            get { return edgeOffset; }
            set { edgeOffset = value; NotifyPropertyChanged("EdgeOffset"); }
        }

        private int zoneLength;
        public int ZoneLength
        {
            get { return zoneLength; }
            set { zoneLength = value; NotifyPropertyChanged("ZoneLength"); }
        }

        private int spacingValueRadial;
        public int SpacingValueRadial
        {
            get { return spacingValueRadial; }
            set { spacingValueRadial = value; NotifyPropertyChanged("SpacingValueRadial"); }
        }
    }
}