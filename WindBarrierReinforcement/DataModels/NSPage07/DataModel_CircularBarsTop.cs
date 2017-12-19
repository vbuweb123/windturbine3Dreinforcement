using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage07
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
        public string CurrentOption => (SelectedIndexOption == 0) ? Enum.GetName(typeof(EOption), EOption.NoOfBars) : Enum.GetName(typeof(EOption), EOption.Spacing);
        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        public string SpacingEnabled => (SelectedIndexOption == 0) ? "Disabled" : "Enabled";
        /// <summary>
        /// UI_TextBox_OPTR_CircularTop_NoBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
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
        public string Groups
        {
            get { return groups; }
            set { groups = value; NotifyPropertyChanged("Groups"); }
        }

        public DataModel_CircularBarsTop(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
                this.Groups = "";
            });
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexOption = 0;
            });
        }

    }
}
