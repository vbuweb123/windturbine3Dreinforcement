using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage07
{
    public class DataModel_RadialEdgeConcrete : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_OPTR_InteriorEdgeLength
        /// </summary>
        private int interiorEdgeLength;
        public int InteriorEdgeLength
        {
            get { return interiorEdgeLength; }
            set { interiorEdgeLength = value; NotifyPropertyChanged("InteriorEdgeLength"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_BottomEdgeLength
        /// </summary>
        private int bottomEdgeLength;
        public int BottomEdgeLength
        {
            get { return bottomEdgeLength; }
            set { bottomEdgeLength = value; NotifyPropertyChanged("BottomEdgeLength"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_RadialBarDiameter
        /// </summary>        
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

       
        /// <summary>
        /// UI_TextBox_OPTR_TowerAxisCover
        /// </summary>
        private int towerAxisCover;
        public int TowerAxisCover
        {
            get { return towerAxisCover; }
            set { towerAxisCover = value; NotifyPropertyChanged("TowerAxisCover"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_TopCover
        /// </summary>
        private int topCover;
        public int TopCover
        {
            get { return topCover; }
            set { topCover = value; NotifyPropertyChanged("TopCover"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_BottomCover
        /// </summary>
        private int bottomCover;
        public int BottomCover
        {
            get { return bottomCover; }
            set { bottomCover = value; NotifyPropertyChanged("BottomCover"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_EdgeCover
        /// </summary>
        private int edgeCover;
        public int EdgeCover
        {
            get { return edgeCover; }
            set { edgeCover = value; NotifyPropertyChanged("EdgeCover"); }
        }

    }
}
