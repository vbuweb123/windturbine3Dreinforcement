using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage09
{
    public class DataModelUBAB : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int exteriorHalfLength;
        public int ExteriorHalfLength
        {
            get { return exteriorHalfLength; }
            set
            {
                exteriorHalfLength = value;
                NotifyPropertyChanged("ExteriorHalfLength");
            }
        }

        private int interiorHalfLength;
        public int InteriorHalfLength
        {
            get => interiorHalfLength;
            private set { interiorHalfLength = value; NotifyPropertyChanged("InteriorHalfLength"); }
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
        
        /// <summary>
        /// Property related to button name in toolbar
        /// </summary>
        private string zoneName;

        public string ZoneName
        {
            get => zoneName;
            set { zoneName = value; NotifyPropertyChanged("ZoneName"); }
        }
        /// <summary>
        /// Property related to Tag Content of the Button in ToolBar
        /// </summary>
        public int IndexInList { get; private set; }

        public DataModelUBAB(string zoneName, int index)
        {
            ZoneName = zoneName;

            this.IndexInList = index;

            GlobalPageEvts.Evts.Add(() => {
                this.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.ExteriorHalfLength))
                        Set_InteriorHalfLength();
                };
            });
            
        }
        private void Set_InteriorHalfLength()
        {
            InteriorHalfLength = ExteriorHalfLength;
        }
    }
}
