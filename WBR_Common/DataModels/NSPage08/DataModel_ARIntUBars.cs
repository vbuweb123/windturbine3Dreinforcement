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
    public class DataModel_ARIntUBars : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_AR_Int_TopOffset
        /// </summary>
        private int topOffset;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "TopOffset")]
        public int TopOffset
        {
            get { return topOffset; }
            private set
            {
                topOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.TopOffset));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_BottomOffset
        /// </summary>
        private int bottomOffset;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "BottomOffset")]
        public int BottomOffset
        {
            get { return bottomOffset; }
            private set
            {
                bottomOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.BottomOffset));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_AxisOffset
        /// </summary>
        private int axisOffset;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "AxisOffset")]
        public int AxisOffset
        {
            get { return axisOffset; }
            private set
            {
                axisOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.AxisOffset));
            }
        }
        /// <summary>
        /// UI_ComboBox_AR_Int_Diameter_Ularger
        /// </summary>        
        private int selectedIndexDiameterL;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameterL")]
        public int SelectedIndexDiameterL
        {
            get { return selectedIndexDiameterL; }
            set
            {
                selectedIndexDiameterL = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.SelectedIndexDiameterL));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameterLarge")]
        public int RebarDiameterLarge => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameterL, this.globalData);

        /// <summary>
        /// UI_ComboBox_AR_Int_Diameter_Usmaller
        /// </summary>        
        private int selectedIndexDiameterS;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameterS")]
        public int SelectedIndexDiameterS
        {
            get { return selectedIndexDiameterS; }
            set
            {
                selectedIndexDiameterS = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.SelectedIndexDiameterS));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameterSmall")]
        public int RebarDiameterSmall => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameterL, this.globalData);

        /// <summary>
        /// UI_TextBox_AR_Int_HookLength_Ularger
        /// </summary>
        private int hookULarger;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "HookULarger")]
        public int HookULarger
        {
            get { return hookULarger; }
            private set
            {
                hookULarger = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.HookULarger));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_HookLength_Usmaller
        /// </summary>
        private int hookUSmaller;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "HookUSmaller")]
        public int HookUSmaller
        {
            get { return hookUSmaller; }
            private set
            {
                hookUSmaller = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.HookUSmaller));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_TopExtraOffset
        /// </summary>
        private int topExtraOffset;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "TopExtraOffset")]
        public int TopExtraOffset
        {
            get { return topExtraOffset; }
            private set
            {
                topExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.TopExtraOffset));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_BottomExtraOffset
        /// </summary>
        private int bottomExtraOffset;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "BottomExtraOffset")]
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            private set
            {
                bottomExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.BottomExtraOffset));
            }
        }

        private GlobalDataModels globalData { get; set; }

        public DataModel_ARIntUBars(GlobalDataModels global)
        {
            this.globalData = global;

            global.EvtHandler.AddPostBuildEvents(() => {
                global.GDMPage08.DataModel_ARExtUBars.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopOffset))
                    {
                        this.TopOffset = global.GDMPage08.DataModel_ARExtUBars.TopOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomOffset))
                    {
                        this.BottomOffset = global.GDMPage08.DataModel_ARExtUBars.BottomOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.AxisOffset))
                    {
                        this.AxisOffset = global.GDMPage08.DataModel_ARExtUBars.AxisOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookULarger))
                    {
                        this.HookULarger = global.GDMPage08.DataModel_ARExtUBars.HookULarger;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookUSmaller))
                    {
                        this.HookUSmaller = global.GDMPage08.DataModel_ARExtUBars.HookUSmaller;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopExtraOffset))
                    {
                        this.TopExtraOffset = global.GDMPage08.DataModel_ARExtUBars.TopExtraOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomExtraOffset))
                    {
                        this.BottomExtraOffset = global.GDMPage08.DataModel_ARExtUBars.BottomExtraOffset;
                    }
                };
            });
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameterL = 0;
                this.SelectedIndexDiameterS = 0;
            });
        }
    }
}
