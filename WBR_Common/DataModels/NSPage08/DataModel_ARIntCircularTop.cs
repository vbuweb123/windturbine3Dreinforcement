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

namespace WBR_Common.DataModels.NSPage08
{
    public class DataModel_ARIntCircularTop : DataModel
    {
        /// <summary>
        /// Common Data
        /// </summary>
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_ComboBox_AR_ICT_Diameter
        /// </summary>        
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularTop>(x => x.SelectedIndexDiameter));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);

        /// <summary>
        /// UI_TextBox_AR_ICT_Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        [DynGet(DynKey = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set
            {
                spacing = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularTop>(x => x.Spacing));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ICT_MinBarLength
        /// </summary>
        private int minbarLength;
        [SaveKeyCode(KeyCode = "MinBarLength")]
        [DynGet(DynKey = "MinBarLength")]
        public int MinBarLength
        {
            get { return minbarLength; }
            set
            {
                minbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularTop>(x => x.MinBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ICT_MaxBarLength
        /// </summary>
        private int maxbarLength;
        [SaveKeyCode(KeyCode = "MaxBarLength")]
        [DynGet(DynKey = "MaxBarLength")]
        public int MaxBarLength
        {
            get { return maxbarLength; }
            set
            {
                maxbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularTop>(x => x.MaxBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ICT_StartExtraOffset
        /// </summary>
        private int startExtraOffset;
        [SaveKeyCode(KeyCode = "StartExtraOffset")]
        [DynGet(DynKey = "StartExtraOffset")]
        public int StartExtraOffset
        {
            get { return startExtraOffset; }
            set
            {
                startExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularTop>(x => x.StartExtraOffset));
            }
        }

        private GlobalDataModels globalData { get; set; }


        public DataModel_ARIntCircularTop(GlobalDataModels global)
        {
            this.globalData = global;

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
            });
        }
    }
}
