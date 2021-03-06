﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage06
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
        public string CurrentOption => (SelectedIndexOption == 0) ? Enum.GetName(typeof(EOption), EOption.NoOfBars) : Enum.GetName(typeof(EOption), EOption.Spacing);

        /// <summary>
        /// UI_TextBox_UPBR_C_NoOfBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
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
        public int OverlapLength
        {
            get { return overlapLength; }
            set { overlapLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Circular_EdgeOfL>(x => x.OverlapLength)); }
        }

        public DataModel_Circular_EdgeOfL(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
            });

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexOption = 0;
            });
        }
    }
}
