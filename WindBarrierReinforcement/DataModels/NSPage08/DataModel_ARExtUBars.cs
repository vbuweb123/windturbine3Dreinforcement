using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage08
{
    public class DataModel_ARExtUBars : DataModel
    {
        /// <summary>
        /// Common Properties
        /// </summary>
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_AR_Ext_TopOffset
        /// </summary>
        private int topOffset;
        public int TopOffset
        {
            get { return topOffset; }
            set
            {
                topOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopOffset));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Ext_BottomOffset
        /// </summary>
        private int bottomOffset;
        public int BottomOffset
        {
            get { return bottomOffset; }
            set
            {
                bottomOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomOffset));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Ext_AxisOffset
        /// </summary>
        private int axisOffset;
        public int AxisOffset
        {
            get { return axisOffset; }
            set
            {
                axisOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.AxisOffset));
            }
        }

        /// <summary>
        /// UI_ComboBox_AR_Ext_Diameter_Ularger
        /// </summary>        
        private int selectedIndexDiameterL;
        public int SelectedIndexDiameterL
        {
            get { return selectedIndexDiameterL; }
            set
            {
                selectedIndexDiameterL = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.SelectedIndexDiameterL));
            }
        }
        
        /// <summary>
        /// UI_TextBox_AR_Ext_Diameter_Usmaller
        /// </summary>        
        private int selectedIndexDiameterS;
        public int SelectedIndexDiameterS
        {
            get { return selectedIndexDiameterS; }
            set
            {
                selectedIndexDiameterS = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.SelectedIndexDiameterS));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_Ext_HookLength_Ularger
        /// </summary>
        private int hookULarger;
        public int HookULarger
        {
            get { return hookULarger; }
            set
            {
                hookULarger = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookULarger));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Ext_HookLength_Usmaller
        /// </summary>
        private int hookUSmaller;
        public int HookUSmaller
        {
            get { return hookUSmaller; }
            set
            {
                hookUSmaller = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookUSmaller));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_TopExtraOffset
        /// </summary>
        private int topExtraOffset;
        public int TopExtraOffset
        {
            get { return topExtraOffset; }
            set
            {
                topExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopExtraOffset));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_BottomExtraOffset
        /// </summary>
        private int bottomExtraOffset;
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            set
            {
                bottomExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomExtraOffset));
            }
        }

        public DataModel_ARExtUBars(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameterL = 0;
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameterS = 0;
            });          

        }
    }
}
