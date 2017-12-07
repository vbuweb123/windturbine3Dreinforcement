using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;

namespace WindBarrierReinforcement.DataModels.NSPage12
{
    public class DataModelBSShapes : DataModel
    {
        /// <summary>
        /// Nominal size of bar, d, mm
        /// </summary>
        private int nominalSize;

        public int NominalSize
        {
            get { return nominalSize; }
            set { nominalSize = value; NotifyPropertyChanged("NominalSize"); }
        }
        /// <summary>
        /// Minimum radius for scheduling, r
        /// </summary>
        private int minRadiusForScheduling;

        public int MinRadiusForScheduling
        {
            get { return minRadiusForScheduling; }
            set { minRadiusForScheduling = value; NotifyPropertyChanged("MinRadiusForScheduling"); }
        }
        /// <summary>
        /// Minimum diameter of bending former, M
        /// </summary>
        private int minDiameterOfBendingFormer;

        public int MinDiameterOfBendingFormer
        {
            get { return minDiameterOfBendingFormer; }
            set { minDiameterOfBendingFormer = value;NotifyPropertyChanged("MinDiameterOfBendingFormer"); }
        }
        /// <summary>
        /// General (min 5d straight), including links where bend ≥ 150° mm
        /// </summary>
        private int generalMin5d;

        public int GeneralMin5d
        {
            get { return generalMin5d; }
            set { generalMin5d = value; NotifyPropertyChanged("GeneralMin5d"); }
        }
        /// <summary>
        /// Links where bend ≤ 150° (min 10d straight) mm
        /// </summary>
        private int linksUnder150;

        public int LinksUnder150
        {
            get { return linksUnder150; }
            set { linksUnder150 = value; NotifyPropertyChanged("LinksUnder150"); }
        }

    }
}
