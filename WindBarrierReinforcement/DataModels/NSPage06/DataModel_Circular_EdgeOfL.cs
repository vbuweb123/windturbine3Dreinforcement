using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage06
{
    public class DataModel_Circular_EdgeOfL : DataModel
    {
        /// <summary>
        /// UI_ComboBox_UPBR_C_Diameter
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
        /// UI_ComboBox_UPBR_C_Dir2_Option
        /// </summary>
        private int selectedIndexOption;
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged("SelectedIndexOption"); NotifyPropertyChanged("SpacingEnabled"); }
        }
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));

        public string SpacingEnabled
        {
            get
            {
                if (SelectedIndexOption == 0)
                    return "0";
                else
                    return "1";
            }
        }

        /// <summary>
        /// UI_TextBox_UPBR_C_NoOfBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }


        /// <summary>
        /// UI_TextBox_UPBR_C_Dir2_SpacingValue
        /// </summary>       
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_C_Dir2_SpacingValue
        /// </summary>       
        private int maxLength;
        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; NotifyPropertyChanged("MaxLength"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_C_Dir2_SpacingValue
        /// </summary>       
        private int overlapLength;
        public int OverlapLength
        {
            get { return overlapLength; }
            set { overlapLength = value; NotifyPropertyChanged("OverlapLength"); }
        }
        public DataModel_Circular_EdgeOfL(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameter = 0;
            });

            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexOption = 0;
            });
        }
    }
}
