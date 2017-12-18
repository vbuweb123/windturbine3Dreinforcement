using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage07
{
    public class DataModel_StraightBars_Extra : DataModel
    {
        private int towerAxisTopOffset;
        [SaveKeyCode(KeyCode = "TowerAxisTopOffset")]
        public int TowerAxisTopOffset
        {
            get { return towerAxisTopOffset; }
            set
            {
                towerAxisTopOffset = value;
                NotifyPropertyChanged("TowerAxisTopOffset");
            }
        }

        private int minBarLength;
        [SaveKeyCode(KeyCode = "MinBarLength")]
        public int MinBarLength
        {
            get { return minBarLength; }
            set
            {
                minBarLength = value;
                NotifyPropertyChanged("MinBarLength");
            }
        }

    }
}
