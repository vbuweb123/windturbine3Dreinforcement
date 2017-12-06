using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage09
{
    public class DataModelUBAB : DataModel
    {
        private int exteriorHalfLength;
        public int ExteriorHalfLength
        {
            get { return exteriorHalfLength; }
            set { exteriorHalfLength = value; NotifyPropertyChanged("ExteriorHalfLength"); NotifyPropertyChanged("InteriorHalfLength"); }
        }

        private int interiorHalfLength;
        public int InteriorHalfLength
        {
            get { return interiorHalfLength = exteriorHalfLength; }
            set { interiorHalfLength = value; NotifyPropertyChanged("InteriorHalfLength");  }
        }

        private int smallEdge;
        public int SmallEdge
        {
            get { return smallEdge; }
            set { smallEdge = value; NotifyPropertyChanged("SmallEdge"); }
        }

        private int distanceFromTop;    
        public int DistanceFromTop 
        {
            get { return distanceFromTop; }
            set { distanceFromTop = value; NotifyPropertyChanged("DistanceFromTop"); }
        }

        private int freeEdgeLength;
        public int FreeEdgeLength
        {
            get { return freeEdgeLength; }
            set { freeEdgeLength = value; NotifyPropertyChanged("FreeEdgeLength"); }
        }

        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        //private void Context_Loaded(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    SelectedIndexDiameter = 0;
        //}
    }
}
