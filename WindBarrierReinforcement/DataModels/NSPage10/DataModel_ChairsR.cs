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
        /// <summary>
        /// NoOfBars
        /// </summary>
        private int tangentialSpacing;
        public int TangentialSpacing
        {
            get { return tangentialSpacing; }
            set { tangentialSpacing = value; NotifyPropertyChanged("TangentialSpacing"); }
        }
        /// <summary>
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

        private int edgeOffset;
        public int EdgeOffset
        {
            get { return edgeOffset; }
            set { edgeOffset = value; NotifyPropertyChanged("EdgeOffset"); }
        }

        private int hookLenghts;
        public int HookLengths
        {
            get { return hookLenghts; }
            set { hookLenghts = value; NotifyPropertyChanged("HookLenghts"); }
        }

        private bool chairsOverTopCirculars;
        public bool ChairsOverTopCirculars
        {
            get { return chairsOverTopCirculars; }
            set { chairsOverTopCirculars = value; NotifyPropertyChanged("ChairsOverTopCirculars"); }
        }

        private int topChairsOverlapp;
        public int TopChairsOverlapp
        {
            get { return topChairsOverlapp; }
            set { topChairsOverlapp = value; NotifyPropertyChanged("TopChairsOverlapp"); }
        }

    }
}