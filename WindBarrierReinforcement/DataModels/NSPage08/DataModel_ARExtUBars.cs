using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage08
{
    public class DataModel_ARExtUBars : DataModel
    {
        /// <summary>
        /// UI_TextBox_AR_Ext_TopOffset
        /// </summary>
        private int topOffset;
        public int TopOffset
        {
            get { return topOffset; }
            set { topOffset = value; NotifyPropertyChanged("TopOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Ext_BottomOffset
        /// </summary>
        private int bottomOffset;
        public int BottomOffset
        {
            get { return bottomOffset; }
            set { bottomOffset = value; NotifyPropertyChanged("BottomOffset"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Ext_AxisOffset
        /// </summary>
        private int axisOffset;
        public int AxisOffset
        {
            get { return axisOffset; }
            set { axisOffset = value; NotifyPropertyChanged("AxisOffset"); }
        }
        /// <summary>
        /// UI_ComboBox_AR_Ext_Diameter_Ularger
        /// </summary>        
        private int selectedIndexDiameterL;
        public int SelectedIndexDiameterL
        {
            get { return selectedIndexDiameterL; }
            set { selectedIndexDiameterL = value; NotifyPropertyChanged("SelectedIndexDiameterL"); }
        }

        public List<String> DiameterNamesL => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedIndexDiameterL = 0;
        }
        /// <summary>
        /// UI_TextBox_AR_Ext_Diameter_Usmaller
        /// </summary>        
        private int selectedIndexDiameterS;
        public int SelectedIndexDiameterS
        {
            get { return selectedIndexDiameterS; }
            set { selectedIndexDiameterS = value; NotifyPropertyChanged("SelectedIndexDiameterS"); }
        }

        public List<String> DiameterNamesS => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        /// <summary>
        /// UI_TextBox_AR_Ext_HookLength_Ularger
        /// </summary>
        private int hookULarger;
        public int HookULarger
        {
            get { return hookULarger; }
            set { hookULarger = value; NotifyPropertyChanged("HookULarger"); }
        }
        /// <summary>
        /// UI_TextBox_AR_Ext_HookLength_Usmaller
        /// </summary>
        private int hookUSmaller;
        public int HookUSmaller
        {
            get { return hookUSmaller; }
            set { hookUSmaller = value; NotifyPropertyChanged("HookUSmaller"); }
        }


    }
}
