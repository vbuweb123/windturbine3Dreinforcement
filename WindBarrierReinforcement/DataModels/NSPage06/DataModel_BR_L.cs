using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage06
{
    public class DataModel_BR_L : DataModel
    {
        /// <summary>
        /// UI_ComboBox_UPBR_L_Diameter
        /// </summary>
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedIndexDiameter = 0;
        }
        /// <summary>
        /// UI_TextBox_UPBR_Lx
        /// </summary>
        private int lx;
        [KeyName(KeyName = "UPBR_Dir1_RadialSpacing")]
        public int Lx
        {
            get { return lx; }
            set { lx = value; NotifyPropertyChanged("Lx"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_Ly
        /// </summary>
        private int ly;
        [KeyName(KeyName = "UPBR_Dir1_RadialSpacing")]
        public int Ly
        {
            get { return ly; }
            set { ly = value; NotifyPropertyChanged("Ly"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_L_BendAngle
        /// </summary>
        private int l_BendAngle;
        [KeyName(KeyName = "UPBR_Dir1_BendAngle")]
        public int L_BendAngle
        {
            get { return l_BendAngle; }
            set { l_BendAngle = value; NotifyPropertyChanged("L_BendAngle"); }
        }



        /// <summary>
        /// UPBR_Dir1_L_OverEdgeExtentLength
        /// </summary>
        //private int overEdgeExtentLength;
        //[KeyName(KeyName = "UPBR_Dir1_L_OverEdgeExtentLength")]
        //public int L_OverEdgeExtentLength
        //{
        //    get { return overEdgeExtentLength; }
        //    set { overEdgeExtentLength = value; NotifyPropertyChanged("L_OverEdgeExtentLength"); }
        //}
        /// <summary>
        /// UPBR_Dir1_L_Overlap
        /// </summary>
        //private int l_Overlap;
        //[KeyName(KeyName = "UPBR_Dir1_L_Overlap")]
        //public int L_Overlap
        //{
        //    get { return l_Overlap; }
        //    set { l_Overlap = value; NotifyPropertyChanged("L_Overlap"); }
        //}

        /// <summary>
        /// UI_TextBox_UPBR_Dir1_L_RadialSpacing
        /// </summary>
        private int l_RadialSpacing;
        [KeyName(KeyName = "UPBR_Dir1_RadialSpacing")]
        public int L_RadialSpacing
        {
            get { return l_RadialSpacing; }
            set { l_RadialSpacing = value; NotifyPropertyChanged("L_RadialSpacing"); }
        }
    }
}
