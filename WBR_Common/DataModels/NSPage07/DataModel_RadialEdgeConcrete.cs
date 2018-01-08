using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage07
{
    public class DataModel_RadialEdgeConcrete : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_OPTR_InteriorEdgeLength
        /// </summary>
        private int interiorEdgeLength;
        [SaveKeyCode(KeyCode = "InteriorEdgeLength")]
        [DynGet(DynKey = "InteriorEdgeLength")]
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
        [DynGet(DynKey = "BottomEdgeLength")]
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

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.global);

        /// <summary>
        /// UI_TextBox_OPTR_TowerAxisCover
        /// </summary>
        private int towerAxisCover;
        [SaveKeyCode(KeyCode = "TowerAxisCover")]
        [DynGet(DynKey = "TowerAxisCover")]
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
        [DynGet(DynKey = "TopCover")]
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
        [DynGet(DynKey = "BottomCover")]
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
        [DynGet(DynKey = "EdgeCover")]
        public int EdgeCover
        {
            get { return edgeCover; }
            set { edgeCover = value; NotifyPropertyChanged("EdgeCover"); }
        }

        private int spacingRadialDeg;
        [SaveKeyCode(KeyCode = "SpacingRadialDeg")]
        [DynGet(DynKey = "SpacingRadialDeg")]
        public int SpacingRadialDeg
        {
            get { return spacingRadialDeg; }
            set { spacingRadialDeg = value; NotifyPropertyChanged("SpacingRadialDeg"); }
        }

        private GlobalDataModels global { get; set; }

        public DataModel_RadialEdgeConcrete(GlobalDataModels global)
        {
            this.global = global;
            //initializing
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
            });
        }

    }
}
