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
    public class DataModel_CircularBarsExteriorSide : DataModel
    {
        public List<String> OptionNamesCBES => EnumHelpers.GetEnumDisplayText(typeof(EOptionsCBES));
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Diameter
        /// </summary>      
        /// 
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsExteriorSide>(x => x.SelectedIndexDiameter));

            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Option
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set
            {
                selectedIndexOption = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsExteriorSide>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsExteriorSide>(x => x.CurrentOption));
            }
        }

        //property for style triggers
        public string CurrentOption => Calculator.GetOptionNameCBES((EOptionsCBES)SelectedIndexOption) + "_" + BoolText(UseDefaultLength);

        private string BoolText(bool value)
        {
            return (value == true) ? "True" : "False";
        }
        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Overlap
        /// </summary>
        private bool useDefaultLength;
        [SaveKeyCode(KeyCode = "UseDefaultLength")]
        [DynGet(DynKey = "UseDefaultLength")]
        public bool UseDefaultLength
        {
            get { return useDefaultLength; }
            set
            {
                useDefaultLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsExteriorSide>(x => x.UseDefaultLength));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsExteriorSide>(x => x.CurrentOption));
            }
        }
        //binded to Style (IsEnabled) triggers to textblocks. Styles maybe defined in XamlResources
        [DynGet(DynKey = "SelectedOptionName")]
        public string SelectedOptionName => Calculator.GetOptionNameCBES((EOptionsCBES)SelectedIndexOption);

        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_NoBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        [DynGet(DynKey = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsExteriorSide>(x => x.NoOfBars)); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Spacing_CustomLength
        /// </summary>
        private int customLength;
        [SaveKeyCode(KeyCode = "CustomLength")]
        [DynGet(DynKey = "CustomLength")]
        public int CustomLength
        {
            get { return customLength; }
            set { customLength = value; NotifyPropertyChanged("CustomLength"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        [DynGet(DynKey = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Offset
        /// </summary>
        private int offset;
        [SaveKeyCode(KeyCode = "Offset")]
        [DynGet(DynKey = "Offset")]
        public int Offset
        {
            get { return offset; }
            set { offset = value; NotifyPropertyChanged("Offset"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_MaxLength
        /// </summary>
        private int maxLength;
        [SaveKeyCode(KeyCode = "MaxLength")]
        [DynGet(DynKey = "MaxLength")]
        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; NotifyPropertyChanged("MaxLength"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularMargin_Overlap
        /// </summary>
        private int overlap;
        [SaveKeyCode(KeyCode = "Overlap")]
        [DynGet(DynKey = "Overlap")]
        public int Overlap
        {
            get { return overlap; }
            set { overlap = value; NotifyPropertyChanged("Overlap"); }
        }

        public GlobalDataModels globalData;

        public DataModel_CircularBarsExteriorSide(GlobalDataModels global)
        {
            this.globalData = global;

            global.EvtHandler.AddPostEventsRegisterAction(() =>
            {
                this.SelectedIndexDiameter = 0;
                this.SelectedIndexOption = 0;
            });
        }    
    }
}
