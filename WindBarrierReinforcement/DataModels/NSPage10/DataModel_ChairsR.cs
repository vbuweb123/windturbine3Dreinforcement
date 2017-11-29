using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage10
{
    public class DataModel_ChairsR : DataModel
    {
        private Page10 page10;

        public DataModel_ChairsR(Page10 page10)
        {
            this.page10 = page10;
        }
        
        
        ///   <summary>
        /// UI_TextBox_CHR_Diameter_1
        /// </summary>
        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int zoneLength; //TODO : ALTA CLASA
        public int ZoneLength
        {
            get { return zoneLength; }
            set { zoneLength = value; NotifyPropertyChanged("ZoneLength"); }
        }


        private int spacingValueRadial;//TODO : ALTA CLASA
        public int SpacingValueRadial
        {
            get { return spacingValueRadial; }
            set { spacingValueRadial = value; NotifyPropertyChanged("SpacingValueRadial"); }
        }
    }
}