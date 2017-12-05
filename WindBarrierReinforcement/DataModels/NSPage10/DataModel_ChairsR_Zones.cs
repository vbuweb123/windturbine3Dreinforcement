using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;

namespace WindBarrierReinforcement.DataModels.NSPage10
{
    public class DataModel_ChairsR_Zones : DataModel
    {
        private Page10 page10;
        public DataModel_ChairsR_Zones(Page10 page10)
        {
            this.page10 = page10;
        }
        private int tangentialSpacing;
        public int TangentialSpacing
        {
            get { return tangentialSpacing; }
            set { tangentialSpacing = value; NotifyPropertyChanged("TangentialSpacing"); }
        }
        /// <summary>
        /// UI_TextBox_CHR_Diameter_1
        /// </summary>

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
            set { hookLenghts = value; NotifyPropertyChanged("HookLengths"); }
        }

        private bool chairsOverTopCirculars;
        public bool ChairsOverTopCirculars
        {
            get { return chairsOverTopCirculars; }
            set { chairsOverTopCirculars = value; NotifyPropertyChanged("ChairsOverTopCirculars"); }
        }

        private int topChairsOverlapp;
        public  int TopChairsOverlapp
        {
            get { return topChairsOverlapp; }
            set { topChairsOverlapp = value; NotifyPropertyChanged("TopChairsOverlapp"); }
        }
   }
}
