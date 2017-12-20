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
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage06
{
   public class DataModel_BR_D1 : DataModel
    {
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        /// <summary>
        /// UI_ComboBox_UPBR_Dir1_Diameter
        /// </summary>       
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_D1>(x => x.SelectedIndexDiameter)); }
        }
        /// <summary>
        /// UI_TextBox_UPBR_Dir1_SpacingValue
        /// </summary>
        [SaveKeyCode(KeyCode = "Spacing")]
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_D1>(x => x.Spacing)); }
        }

        /// <summary>
        /// UI_TextBox_UPBR_Dir1_NoOfBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_D1>(x => x.NoOfBars)); }
        }

        /// <summary>
        /// UI_ComboBox_UPBR_Dir1_Diameter
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_D1>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_BR_D1>(x => x.CurrentOption));
            }
        }

        public string CurrentOption => (SelectedIndexOption == 0) ? Enum.GetName(typeof(EOption), EOption.NoOfBars) : Enum.GetName(typeof(EOption), EOption.Spacing);

        
        public DataModel_BR_D1(GlobalDataModels global)
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
