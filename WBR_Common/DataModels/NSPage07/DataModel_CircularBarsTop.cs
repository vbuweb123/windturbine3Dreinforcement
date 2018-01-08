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
    public class DataModel_CircularBarsTop : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));
        /// <summary>
        /// UI_TextBox_OPTR_CircularBarDiam
        /// </summary>        
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);
        /// <summary>
        /// OPTR_CircularTop_Option
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set
            {
                selectedIndexOption = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsTop>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CircularBarsTop>(x => x.CurrentOption));
            }
        }
        [DynGet(DynKey = "CurrentOption")]
        public string CurrentOption => Calculator.GetOptionName((EOption)SelectedIndexOption);
        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        [DynGet(DynKey = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }
        [DynGet(DynKey = "SpacingEnabled")]
        public string SpacingEnabled => (SelectedIndexOption == 0) ? "Disabled" : "Enabled";
        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_NoBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        [DynGet(DynKey = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }

        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_MaxLength
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
        /// UI_TextBox_OPTR_CircularTop_Overlap
        /// </summary>
        private int overlap;
        [SaveKeyCode(KeyCode = "Overlap")]
        [DynGet(DynKey = "Overlap")]
        public int Overlap
        {
            get { return overlap; }
            set { overlap = value; NotifyPropertyChanged("Overlap"); }
        }
        /// <summary>
        /// UI_TextBox_OPTR_Groups
        /// </summary>
        private string groups;
        [SaveKeyCode(KeyCode = "Groups")]
        [DynGet(DynKey = "Groups")]
        public string Groups
        {
            get { return groups; }
            set { groups = value; NotifyPropertyChanged("Groups"); }
        }

        private GlobalDataModels globalData { get; set; }

        public DataModel_CircularBarsTop(GlobalDataModels global)
        {
            this.globalData = global;
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
                this.Groups = "";
                this.SelectedIndexOption = 0;
            });
        }

    }
}
