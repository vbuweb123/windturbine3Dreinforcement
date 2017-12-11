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
            set { topOffset = value; NotifyPropertyChanged("TopOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_BottomOffset
        /// </summary>
        private int bottomOffset;
        public int BottomOffset
        {
            get { return bottomOffset; }
            set { bottomOffset = value; NotifyPropertyChanged("BottomOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_AxisOffset
        /// </summary>
        private int axisOffset;
        public int AxisOffset
        {
            get { return axisOffset; }
            set { axisOffset = value; NotifyPropertyChanged("AxisOffset"); }
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
            set { hookULarger = value; NotifyPropertyChanged("HookULarger"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_HookLength_Usmaller
        /// </summary>
        private int hookUSmaller;
        public int HookUSmaller
        {
            get { return hookUSmaller; }
            set { hookUSmaller = value; NotifyPropertyChanged("HookUSmaller"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_TopExtraOffset
        /// </summary>
        private int topExtraOffset;
        public int TopExtraOffset
        {
            get { return topExtraOffset; }
            set { topExtraOffset = value; NotifyPropertyChanged("TopExtraOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Int_BottomExtraOffset
        /// </summary>
        private int bottomExtraOffset;
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            set { bottomExtraOffset = value; NotifyPropertyChanged("BottomExtraOffset"); }
        }

        
        public DataModel_ARIntUBars()
        {
            GlobalPage08.DataModel_ARExtUBars.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopOffset))
                {
                    this.TopOffset = GlobalPage08.DataModel_ARExtUBars.TopOffset;
                    NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.TopOffset));
                }

                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomOffset))
                {
                    this.BottomOffset = GlobalPage08.DataModel_ARExtUBars.BottomOffset;
                    NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.BottomOffset));
                }

                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.AxisOffset))
                {
                    this.AxisOffset = GlobalPage08.DataModel_ARExtUBars.AxisOffset;
                    NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.AxisOffset));
                }

                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookULarger))
                {
                    this.HookULarger = GlobalPage08.DataModel_ARExtUBars.HookULarger;
                    NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.HookULarger));
                }

                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.HookUSmaller))
                {
                    this.HookUSmaller = GlobalPage08.DataModel_ARExtUBars.HookUSmaller;
                    NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.HookUSmaller));
                }

                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.TopExtraOffset))
                {
                    this.TopExtraOffset = GlobalPage08.DataModel_ARExtUBars.TopExtraOffset;
                    NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.TopExtraOffset));
                }

                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ARExtUBars>(x => x.BottomExtraOffset))
                {
                    this.BottomExtraOffset = GlobalPage08.DataModel_ARExtUBars.BottomExtraOffset;
                    NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntUBars>(x => x.BottomExtraOffset));
                }
            };
        }
        private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedIndexDiameterL = 0;
        }
    }
}
