using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage07
{
    public class DataModel_StraightBars_Extra : DataModel
    {
        private int towerAxisTopOffset;
        [SaveKeyCode(KeyCode = "TowerAxisTopOffset")]
        [DynGet(DynKey = "TowerAxisTopOffset")]
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
        [DynGet(DynKey = "MinBarLength")]
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
