using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage06
{
    public class DataModel_BR_L : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        /// <summary>
        /// UI_ComboBox_UPBR_L_Diameter
        /// </summary>
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_L>(x => x.SelectedIndexDiameter)); }
        }
        /// <summary>
        /// UI_TextBox_UPBR_Lx
        /// </summary>
        private int lx;
        [SaveKeyCode(KeyCode = "Lx")]
        public int Lx
        {
            get { return lx; }
            set { lx = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_L>(x => x.Lx)); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_Ly
        /// </summary>
        private int ly;
        [SaveKeyCode(KeyCode = "Ly")]
        public int Ly
        {
            get { return ly; }
            set { ly = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_L>(x => x.Ly)); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_L_BendAngle
        /// </summary>
        private int l_BendAngle;
        [SaveKeyCode(KeyCode = "L_BendAngle")]
        public int L_BendAngle
        {
            get { return l_BendAngle; }
            set { l_BendAngle = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_L>(x => x.L_BendAngle)); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_Dir1_L_RadialSpacing
        /// </summary>
        private double l_RadialSpacing;
        [SaveKeyCode(KeyCode = "L_RadialSpacing")]
        public double L_RadialSpacing
        {
            get { return l_RadialSpacing; }
            set { l_RadialSpacing = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_L>(x => x.L_RadialSpacing)); }
        }

        public DataModel_BR_L(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameter = 0;
            });           
        }
    }
}
