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
    public class DataModel_TB_D1 : DataModel
    {
        /// <summary>
        /// UI_ComboBox_UPBR_TB_Dir1_Diameter
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
        /// UI_ComboBox_UPBR_TB_Dir1_Option
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
        /// UI_TextBox_UPBR_TB_OffsetFromBottom
        /// </summary>
        private int offsetFromBottom;       
        public int OffsetFromBottom
        {
            get { return offsetFromBottom; }
            set { offsetFromBottom = value; NotifyPropertyChanged("OffsetFromBottom"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_TB_RadiusOfRebars
        /// </summary>
        private int radiusOfRebars;
        public int RadiusOfRebars
        {
            get { return radiusOfRebars; }
            set { radiusOfRebars = value; NotifyPropertyChanged("RadiusOfRebars"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_TB_MinLengthRebar
        /// </summary>
        private int minLengthRebar;
        public int MinLengthRebar
        {
            get { return minLengthRebar; }
            set { minLengthRebar = value; NotifyPropertyChanged("MinLengthRebar"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_TB_Dir1_NoOfBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }


        /// <summary>
        /// UI_TextBox_UPBR_TB_Dir1_SpacingValue
        /// </summary>       
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        public DataModel_TB_D1(GlobalDataModels global)
        {
            
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameter = 0;
                this.SelectedIndexOption = 0;
            });                                 
        }
        private void Set_OffsetFromBottom()
        {
            
        }
    }
}
