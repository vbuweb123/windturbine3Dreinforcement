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

namespace WindBarrierReinforcement.DataModels.NSPage08
{
    public class DataModel_ARExteriorCircularBottom : DataModel
    {
        /// <summary>
        /// Common Data
        /// </summary>
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_ComboBox_AR_ECB_Diameter
        /// </summary>        
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularBottom>(x => x.SelectedIndexDiameter));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECB_Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set
            {
                spacing = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularBottom>(x => x.Spacing));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECB_MinBarLength
        /// </summary>
        private int minbarLength;
        [SaveKeyCode(KeyCode = "MinBarLength")]
        public int MinBarLength
        {
            get { return minbarLength; }
            set
            {
                minbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularBottom>(x => x.MinBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECB_MaxBarLength
        /// </summary>
        private int maxbarLength;
        [SaveKeyCode(KeyCode = "MaxBarLength")]
        public int MaxBarLength
        {
            get { return maxbarLength; }
            set
            {
                maxbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularBottom>(x => x.MaxBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECB_StartExtraOffset
        /// </summary>
        private int startExtraOffset;
        [SaveKeyCode(KeyCode = "StartExtraOffset")]
        public int StartExtraOffset
        {
            get { return startExtraOffset; }
            set
            {
                startExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExteriorCircularBottom>(x => x.StartExtraOffset));
            }
        }

        public DataModel_ARExteriorCircularBottom(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
            });
        }        
    }
}
