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

namespace WBR_Common.DataModels.NSPage06
{
    public class DataModel_Circular_EdgeOfL : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));
        /// <summary>
        /// UI_ComboBox_UPBR_C_Diameter
        /// </summary>
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.SelectedIndexDiameter)); }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);
        /// <summary>
        /// UI_ComboBox_UPBR_C_Dir2_Option
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.CurrentOption));
            }
        }

        [DynGet(DynKey = "CurrentOption")]
        public string CurrentOption => Calculator.GetOptionName((EOption)SelectedIndexOption);

        /// <summary>
        /// UI_TextBox_UPBR_C_NoOfBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        [DynGet(DynKey = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.NoOfBars)); }
        }


        /// <summary>
        /// UI_TextBox_UPBR_C_Dir2_SpacingValue
        /// </summary>       
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        [DynGet(DynKey = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.Spacing)); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_C_Dir2_SpacingValue
        /// </summary>       
        private int maxLength;
        [SaveKeyCode(KeyCode = "MaxLength")]
        [DynGet(DynKey = "MaxLength")]
        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.MaxLength)); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_C_Dir2_SpacingValue
        /// </summary>       
        private int overlapLength;
        [SaveKeyCode(KeyCode = "OverlapLength")]
        [DynGet(DynKey = "OverlapLength")]
        public int OverlapLength
        {
            get { return overlapLength; }
            set { overlapLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.OverlapLength)); }
        }

        private GlobalDataModels globalData;

        public DataModel_Circular_EdgeOfL(GlobalDataModels global)
        {
            this.globalData = global;

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
                this.SelectedIndexOption = 0;
            });
        }
    }
}
