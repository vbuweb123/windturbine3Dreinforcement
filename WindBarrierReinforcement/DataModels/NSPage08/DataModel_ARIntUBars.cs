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
    public class DataModel_ARIntUBars : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_AR_Int_TopOffset
        /// </summary>
        private int topOffset;
        public int TopOffset
        {
            get { return topOffset; }
            private set { topOffset = value; NotifyPropertyChanged("TopOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_BottomOffset
        /// </summary>
        private int bottomOffset;
        public int BottomOffset
        {
            get { return bottomOffset; }
            private set { bottomOffset = value; NotifyPropertyChanged("BottomOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_AxisOffset
        /// </summary>
        private int axisOffset;
        public int AxisOffset
        {
            get { return axisOffset; }
            private set { axisOffset = value; NotifyPropertyChanged("AxisOffset"); }
        }
        /// <summary>
        /// UI_ComboBox_AR_Int_Diameter_Ularger
        /// </summary>        
        private int selectedIndexDiameterL;
        public int SelectedIndexDiameterL
        {
            get { return selectedIndexDiameterL; }
            set { selectedIndexDiameterL = value; NotifyPropertyChanged("SelectedIndexDiameterL"); }
        }
       
        /// <summary>
        /// UI_ComboBox_AR_Int_Diameter_Usmaller
        /// </summary>        
        private int selectedIndexDiameterS;
        public int SelectedIndexDiameterS
        {
            get { return selectedIndexDiameterS; }
            set { selectedIndexDiameterS = value; NotifyPropertyChanged("SelectedIndexDiameterS"); }
        }

        /// <summary>
        /// UI_TextBox_AR_Int_HookLength_Ularger
        /// </summary>
        private int hookULarger;
        public int HookULarger
        {
            get { return hookULarger; }
            private set { hookULarger = value; NotifyPropertyChanged("HookULarger"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_HookLength_Usmaller
        /// </summary>
        private int hookUSmaller;
        public int HookUSmaller
        {
            get { return hookUSmaller; }
            private set { hookUSmaller = value; NotifyPropertyChanged("HookUSmaller"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_TopExtraOffset
        /// </summary>
        private int topExtraOffset;
        public int TopExtraOffset
        {
            get { return topExtraOffset; }
            private set { topExtraOffset = value; NotifyPropertyChanged("TopExtraOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_BottomExtraOffset
        /// </summary>
        private int bottomExtraOffset;
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            private set { bottomExtraOffset = value; NotifyPropertyChanged("BottomExtraOffset"); }
        }

        public DataModel_ARIntUBars(EvtHandler evtHandler)
        {
            evtHandler.Register(() => {
                GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopOffset))
                    {
                        this.TopOffset = GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.TopOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomOffset))
                    {
                        this.BottomOffset = GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.BottomOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.AxisOffset))
                    {
                        this.AxisOffset = GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.AxisOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookULarger))
                    {
                        this.HookULarger = GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.HookULarger;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookUSmaller))
                    {
                        this.HookUSmaller = GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.HookUSmaller;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopExtraOffset))
                    {
                        this.TopExtraOffset = GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.TopExtraOffset;
                    }

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomExtraOffset))
                    {
                        this.BottomExtraOffset = GlobalPageEvts.Global.GlobalPage08.DataModel_ARExtUBars.BottomExtraOffset;
                    }
                };
            });
        }
    }
}
