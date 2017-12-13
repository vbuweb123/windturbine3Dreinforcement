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

namespace WindBarrierReinforcement.DataModels.NSPage06
{
    public class DataModel_BR_D2 : DataModel
    {
        /// <summary>
        /// UI_ComboBox_UPBR_Dir2_Diameter
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
        /// UI_ComboBox_UPBR_Dir2_Diameter
        /// </summary>
        private int selectedIndexOption;
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged("SelectedIndexOption"); NotifyPropertyChanged("SpacingEnabled"); }
        }
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));

        /// <summary>
        /// Binded to TextBox Style Trigger. Value of 0 will disagle Spacing. Value of 1 will disable NoOfBars
        /// </summary>
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
        /// UI_TextBox_UPBR_Dir2_SpacingValue
        /// </summary>
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_Dir2_NoOfBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }

        public DataModel_BR_D2(GlobalDataModels global)
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
