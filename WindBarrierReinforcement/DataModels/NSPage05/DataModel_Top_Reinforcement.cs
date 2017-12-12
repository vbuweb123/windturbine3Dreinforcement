using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage05
{
    public class DataModel_Top_Reinforcement : DataModel
    {
        /// <summary>
        /// UI_TextBox_TR_No_LargeDiameter
        /// </summary>
        private int noLargeDiameter;
        public int NoLargeDiameter
        {
            get { return noLargeDiameter; }
            set { noLargeDiameter = value; NotifyPropertyChanged("NoLargeDiameter"); }
        }
        /// <summary>
        /// UI_ComboBox_TR_LargeDiameter
        /// </summary>
        private int selectedIndexDiameterL;
        public int SelectedIndexDiameterL
        {
            get { return selectedIndexDiameterL; }
            set { selectedIndexDiameterL = value; NotifyPropertyChanged("SelectedIndexDiameterL"); }
        }

        public List<String> DiameterNamesL => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        /// <summary>
        /// UI_TextBox_TR_No.SmallDiameter
        /// </summary>
        private int noSmallDiameter;
        public int NoSmallDiameter
        {
            get { return noSmallDiameter; }
            set { noSmallDiameter = value; NotifyPropertyChanged("NoSmallDiameter"); }
        }
        /// <summary>
        /// UI_ComboBox_TR_SmallDiameter
        /// </summary>
        private int selectedIndexDiameterS;
        public int SelectedIndexDiameterS
        {
            get { return selectedIndexDiameterS; }
            set { selectedIndexDiameterS = value; NotifyPropertyChanged("SelectedIndexDiameterS"); }
        }

        public List<String> DiameterNamesS => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_TR_No.3rdDiameter
        /// </summary>
        private int threeDiameter;
        public int ThreeDiameter
        {
            get { return threeDiameter; }
            set { threeDiameter = value; NotifyPropertyChanged("ThreeDiameter"); }
        }

        /// <summary>
        /// UI_ComboBox_TR_SmallDiameter
        /// </summary>
        private int selectedIndexDiameterT;
        public int SelectedIndexDiameterT
        {
            get { return selectedIndexDiameterT; }
            set { selectedIndexDiameterT = value; NotifyPropertyChanged("SelectedIndexDiameterT"); }
        }

        public List<String> DiameterNamesT => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private double spacingAngle;
        public double SpacingAngle
        {
            get { return spacingAngle; }
            set { spacingAngle = value; NotifyPropertyChanged("SpacingAngle"); }
        }

        private int largeDiameterOffset;
        public int LargeDiameterOffset
        {
            get { return largeDiameterOffset; }
            set { largeDiameterOffset = value; NotifyPropertyChanged("LargeDiameterOffset"); }
        }

        private int smallDiameterOffset;
        public int SmallDiameterOffset
        {
            get { return smallDiameterOffset; }
            set { smallDiameterOffset = value; NotifyPropertyChanged("SmallDiameterOffset"); }
        }

        private int threeDiameterOffset;
        public int ThreeDiameterOffset
        {
            get { return threeDiameterOffset; }
            set { threeDiameterOffset = value; NotifyPropertyChanged("ThreeDiameterOffset"); }
        }
        private string hookType = "B";
        public string HookType
        {
            get { return hookType; }
            set { hookType = value; NotifyPropertyChanged("HookType"); }
        }
        private int overlapLargeDiameter;
        public int OverlapLargeDiameter
        {
            get { return overlapLargeDiameter; }
            set { overlapLargeDiameter = value; NotifyPropertyChanged("OverlapLargeDiameter"); }
        }
        private int overlapSmallDiameter;
        public int OverlapSmallDiameter
        {
            get { return overlapSmallDiameter; }
            set { overlapSmallDiameter = value; NotifyPropertyChanged("OverlapSmallDiameter"); }
        }
        private int overlapthreeDiameter;
        public int OverlapthreeDiameter
        {
            get { return overlapthreeDiameter; }
            set { overlapthreeDiameter = value; NotifyPropertyChanged("OverlapthreeDiameter"); }
        }
        private double spacingThreeDiameterAngle;
        public double SpacingThreeDiameterAngle
        {
            get { return spacingThreeDiameterAngle; }
            set { spacingThreeDiameterAngle = value; NotifyPropertyChanged("SpacingThreeDiameterAngle"); }
        }
        private double startOffsetAngle;
        public double StartOffsetAngle
        {
            get { return startOffsetAngle; }
            set { startOffsetAngle = value; NotifyPropertyChanged("StartOffsetAngle"); }
        }
        private int maximumLength;
        public int MaximumLength
        {
            get { return maximumLength; }
            set { maximumLength = value; NotifyPropertyChanged("MaximumLength"); }
        }
    }
}
