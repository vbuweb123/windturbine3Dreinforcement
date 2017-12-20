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

namespace WindBarrierReinforcement.DataModels.NSPage08
{
    public class DataModel_ARExteriorCircularLateral : DataModel
    {
        /// <summary>
        /// Common Data
        /// </summary>
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));

        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        /// <summary>
        /// UI_ComboBox_AR_ECL_Diameter
        /// </summary>        
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.SelectedIndexDiameter));
            }
        }

        /// <summary>
        /// UI_ComboBox_AR_ECL_Option
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set
            {
                selectedIndexOption = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.CurrentOption));
            }
        }

        public string CurrentOption => (SelectedIndexOption == 0) ? Enum.GetName(typeof(EOption), EOption.NoOfBars) : Enum.GetName(typeof(EOption), EOption.Spacing);

        /// <summary>
        /// UI_TextBox_AR_ECL_Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set
            {
                spacing = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.Spacing));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_ECL_NoOfBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set
            {
                noOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.NoOfBars));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_ECL_MinBarLength
        /// </summary>
        private int minbarLength;
        [SaveKeyCode(KeyCode = "MinBarLength")]
        public int MinBarLength
        {
            get { return minbarLength; }
            set
            {
                minbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.MinBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_MaxBarLength
        /// </summary>
        private int maxbarLength;
        [SaveKeyCode(KeyCode = "MaxBarLength")]
        public int MaxBarLength
        {
            get { return maxbarLength; }
            set
            {
                maxbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.MaxBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_TopExtraOffset
        /// </summary>
        private int topExtraOffset;
        [SaveKeyCode(KeyCode = "TopExtraOffset")]
        public int TopExtraOffset
        {
            get { return topExtraOffset; }
            set
            {
                topExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.TopExtraOffset));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_MaxBarLength
        /// </summary>
        private int bottomExtraOffset;
        [SaveKeyCode(KeyCode = "BottomExtraOffset")]
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            set
            {
                bottomExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularLateral>(x => x.BottomExtraOffset));
            }
        }
        public DataModel_ARExteriorCircularLateral(GlobalDataModels global)
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
