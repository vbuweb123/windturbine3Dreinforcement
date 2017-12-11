using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage07
{
    public class DataModel_CircularBarsExteriorSide : DataModel
    {
        public List<String> OptionNamesCBES => EnumHelpers.GetEnumDisplayText(typeof(EOptionsCBES));
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Diameter
        /// </summary>      
        /// 
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }      


        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Option
        /// </summary>
        private int selectedIndexOption;
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged("SelectedIndexOption"); NotifyPropertyChanged("SelectedOptionName"); }
        }

        private int selectedTrueFalseOption;
        public int SelectedTrueFalseOption
        {
            get { return selectedTrueFalseOption; }
            set { selectedTrueFalseOption = value; NotifyPropertyChanged("SelectedTrueFalseOption"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Overlap
        /// </summary>
        private bool useDefaultLength;
        public bool UseDefaultLength
        {
            get { return useDefaultLength; }
            set { useDefaultLength = value; NotifyPropertyChanged("UseDefaultLength"); }
        }
        //binded to Style (IsEnabled) triggers to textblocks. Styles maybe defined in XamlResources
        public string SelectedOptionName => Enum.GetName(typeof(EOptionsCBES), SelectedIndexOption);

        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_NoBars
        /// </summary>
        private int noOfBars;
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }
        
        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Spacing_CustomLength
        /// </summary>
        private int customLength;
        public int CustomLength
        {
            get { return customLength; }
            set { customLength = value; NotifyPropertyChanged("CustomLength"); }
        }
        
        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Spacing
        /// </summary>
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Offset
        /// </summary>
        private int offset;
        public int Offset
        {
            get { return offset; }
            set { offset = value; NotifyPropertyChanged("Offset"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_MaxLength
        /// </summary>
        private int maxLength;
        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; NotifyPropertyChanged("MaxLength"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Overlap
        /// </summary>
        private int overlap;
        public int Overlap
        {
            get { return overlap; }
            set { overlap = value; NotifyPropertyChanged("Overlap"); }
        }

       

        private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedIndexDiameter = 0;
        }
    }
}
