using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage08
{
    public class DataModel_ARExteriorCircularLateral : DataModel
    {
        /// <summary>
        /// Common Data
        /// </summary>
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));

        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        /// <summary>
        /// UI_ComboBox_AR_ECL_Diameter
        /// </summary>        
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        /// <summary>
        /// UI_ComboBox_AR_ECL_Option
        /// </summary>
        private int selectedIndexOption;
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged("SelectedIndexOption"); NotifyPropertyChanged("SpacingEnabled"); }
        }

        public string SpacingEnabled => (SelectedIndexOption == 0) ? "Disabled" : "Enabled";
  
        /// <summary>
        /// UI_TextBox_AR_ECL_Spacing
        /// </summary>
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }
        /// <summary>
        /// UI_TextBox_AR_ECL_NoOfBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }
        /// <summary>
        /// UI_TextBox_AR_ECL_MinBarLength
        /// </summary>
        private int minbarLength;
        public int MinBarLength
        {
            get { return minbarLength; }
            set { minbarLength = value; NotifyPropertyChanged("MinBarLength"); }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_MaxBarLength
        /// </summary>
        private int maxbarLength;
        public int MaxBarLength
        {
            get { return maxbarLength; }
            set { maxbarLength = value; NotifyPropertyChanged("MaxBarLength"); }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_TopExtraOffset
        /// </summary>
        private int topExtraOffset;
        public int TopExtraOffset
        {
            get { return topExtraOffset; }
            set { topExtraOffset = value; NotifyPropertyChanged("TopExtraOffset"); }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_MaxBarLength
        /// </summary>
        private int bottomExtraOffset;
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            set { bottomExtraOffset = value; NotifyPropertyChanged("BottomExtraOffset"); }
        }
    }
}
