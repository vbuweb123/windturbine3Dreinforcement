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
        [SaveKeyCode(KeyCode = "TopOffset")]
        [DynGet(DynKey = "TopOffset")]
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
        [SaveKeyCode(KeyCode = "BottomOffset")]
        [DynGet(DynKey = "BottomOffset")]
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
        [SaveKeyCode(KeyCode = "AxisOffset")]
        [DynGet(DynKey = "AxisOffset")]
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
        [SaveKeyCode(KeyCode = "SelectedIndexDiameterL")]
        public int SelectedIndexDiameterL
        {
            get { return selectedIndexDiameterL; }
            set
            {
                selectedIndexDiameterL = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.SelectedIndexDiameterL));
            }
        }
        
        //property for dynamo only
        [DynGet(DynKey = "RebarDiameterLarge")]
        public int RebarDiameterLarge => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameterL, this.globalData);

        /// <summary>
        /// UI_TextBox_AR_Ext_Diameter_Usmaller
        /// </summary>        
        private int selectedIndexDiameterS;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameterS")]
        public int SelectedIndexDiameterS
        {
            get { return selectedIndexDiameterS; }
            set
            {
                selectedIndexDiameterS = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.SelectedIndexDiameterS));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameterSmall")]
        public int RebarDiameterSmall => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameterS, this.globalData);

        /// <summary>
        /// UI_TextBox_AR_Ext_HookLength_Ularger
        /// </summary>
        private int hookULarger;
        [SaveKeyCode(KeyCode = "HookULarger")]
        [DynGet(DynKey = "HookULarger")]
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
        [SaveKeyCode(KeyCode = "HookUSmaller")]
        [DynGet(DynKey = "HookUSmaller")]
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
        [SaveKeyCode(KeyCode = "TopExtraOffset")]
        [DynGet(DynKey = "TopExtraOffset")]
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
        [SaveKeyCode(KeyCode = "BottomExtraOffset")]
        [DynGet(DynKey = "BottomExtraOffset")]
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            set
            {
                bottomExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomExtraOffset));
            }
        }

        private GlobalDataModels globalData { get; set; }

        public DataModel_ARExtUBars(GlobalDataModels global)
        {
            this.globalData = global;
            //initializing
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameterL = 0;
                this.SelectedIndexDiameterS = 0;
            });
        }
    }
}
