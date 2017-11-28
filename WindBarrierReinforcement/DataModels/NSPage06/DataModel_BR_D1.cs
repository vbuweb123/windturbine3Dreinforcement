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
   public class DataModel_BR_D1 : DataModel
    {

        /// <summary>
        /// UI_ComboBox_UPBR_Dir1_Diameter
        /// </summary>       
        [KeyName(KeyName = "UPBR_Dir1_Diameter")]
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
        /// UI_ComboBox_UPBR_Dir1_Diameter
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
        /// UI_TextBox_UPBR_Dir1_SpacingValue
        /// </summary>
        [KeyName(KeyName = "UPBR_Dir1_Spacing")]
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_Dir1_NoOfBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }
               

        /// <summary>
        /// UPBR_Dir1_MarginConver
        /// </summary>
        //private int marginCover;

        //[KeyName(KeyName = "UPBR_Dir1_MarginCover")]
        //public int MarginCover
        //{
        //    get { return marginCover; }

        //    set { marginCover = value; NotifyPropertyChanged("MarginCover"); }
        //}
       
       
       

    }
}
