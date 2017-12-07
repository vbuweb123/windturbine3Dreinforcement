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
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        /// <summary>
        /// UI_TextBox_AR_ICT_Spacing
        /// </summary>
        private int spacing;
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        /// <summary>
        /// UI_TextBox_AR_ICT_MinBarLength
        /// </summary>
        private int minbarLength;
        public int MinBarLength
        {
            get { return minbarLength; }
            set { minbarLength = value; NotifyPropertyChanged("MinBarLength"); }
        }

        /// <summary>
        /// UI_TextBox_AR_ICT_MaxBarLength
        /// </summary>
        private int maxbarLength;
        public int MaxBarLength
        {
            get { return maxbarLength; }
            set { maxbarLength = value; NotifyPropertyChanged("MaxBarLength"); }
        }

        /// <summary>
        /// UI_TextBox_AR_ICT_StartExtraOffset
        /// </summary>
        private int startExtraOffset;
        public int StartExtraOffset
        {
            get { return startExtraOffset; }
            set { startExtraOffset = value; NotifyPropertyChanged("StartExtraOffset"); }
        }

        private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedIndexDiameter = 0;
        }
    }
}
