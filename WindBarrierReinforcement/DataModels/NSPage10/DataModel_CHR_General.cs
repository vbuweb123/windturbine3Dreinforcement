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
    public class DataModel_CHR_General : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int tangentialSpacing;
        public int TangentialSpacing
        {
            get { return tangentialSpacing; }
            set { tangentialSpacing = value; NotifyPropertyChanged("TangentialSpacing"); }
        }

        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
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
        public int TopChairsOverlapp
        {
            get { return topChairsOverlapp; }
            set { topChairsOverlapp = value; NotifyPropertyChanged("TopChairsOverlapp"); }
        }




    }
}