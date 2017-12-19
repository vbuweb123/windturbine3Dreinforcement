using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage07
{
    public class DataModel_RadialEdgeConcrete : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_OPTR_InteriorEdgeLength
        /// </summary>
        private int interiorEdgeLength;
        [SaveKeyCode(KeyCode = "InteriorEdgeLength")]
        public int InteriorEdgeLength
        {
            get { return interiorEdgeLength; }
            set { interiorEdgeLength = value; NotifyPropertyChanged("InteriorEdgeLength"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_BottomEdgeLength
        /// </summary>
        private int bottomEdgeLength;
        [SaveKeyCode(KeyCode = "BottomEdgeLength")]
        public int BottomEdgeLength
        {
            get { return bottomEdgeLength; }
            set { bottomEdgeLength = value; NotifyPropertyChanged("BottomEdgeLength"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_RadialBarDiameter
        /// </summary>        
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

       
        /// <summary>
        /// UI_TextBox_OPTR_TowerAxisCover
        /// </summary>
        private int towerAxisCover;
        [SaveKeyCode(KeyCode = "TowerAxisCover")]
        public int TowerAxisCover
        {
            get { return towerAxisCover; }
            set { towerAxisCover = value; NotifyPropertyChanged("TowerAxisCover"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_TopCover
        /// </summary>
        private int topCover;
        [SaveKeyCode(KeyCode = "TopCover")]
        public int TopCover
        {
            get { return topCover; }
            set { topCover = value; NotifyPropertyChanged("TopCover"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_BottomCover
        /// </summary>
        private int bottomCover;
        [SaveKeyCode(KeyCode = "BottomCover")]
        public int BottomCover
        {
            get { return bottomCover; }
            set { bottomCover = value; NotifyPropertyChanged("BottomCover"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_EdgeCover
        /// </summary>
        private int edgeCover;
        [SaveKeyCode(KeyCode = "EdgeCover")]
        public int EdgeCover
        {
            get { return edgeCover; }
            set { edgeCover = value; NotifyPropertyChanged("EdgeCover"); }
        }

        private int spacingRadialDeg;
        [SaveKeyCode(KeyCode = "SpacingRadialDeg")]
        public int SpacingRadialDeg
        {
            get { return spacingRadialDeg; }
            set { spacingRadialDeg = value; NotifyPropertyChanged("SpacingRadialDeg"); }
        }

        public DataModel_RadialEdgeConcrete(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameter = 0;
            });
        }

    }
}
