using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage09
{
    public class DataModelUBAB : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int exteriorHalfLength;
        [SaveKeyCode(KeyCode = "ExteriorHalfLength")]
        public int ExteriorHalfLength
        {
            get { return exteriorHalfLength; }
            set
            {
                exteriorHalfLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.ExteriorHalfLength));
            }
        }

        private int interiorHalfLength;
        [SaveKeyCode(KeyCode = "InteriorHalfLength")]
        public int InteriorHalfLength
        {
            get => interiorHalfLength;
            private set
            {
                interiorHalfLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.InteriorHalfLength));
            }
        }
       
        private int smallEdge;
        [SaveKeyCode(KeyCode = "SmallEdge")]
        public int SmallEdge
        {
            get { return smallEdge; }
            set
            {
                smallEdge = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.SmallEdge));
            }
        }

        private int distanceFromTop;
        [SaveKeyCode(KeyCode = "DistanceFromTop")]
        public int DistanceFromTop
        {
            get { return distanceFromTop; }
            set
            {
                distanceFromTop = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.DistanceFromTop));
            }
        }

        private int freeEdgeLength;
        [SaveKeyCode(KeyCode = "FreeEdgeLength")]
        public int FreeEdgeLength
        {
            get { return freeEdgeLength; }
            set
            {
                freeEdgeLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.FreeEdgeLength));
            }
        }

        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.SelectedIndexDiameter));
            }
        }
        
        /// <summary>
        /// Property related to button name in toolbar
        /// </summary>
        private string zoneName;
        [SaveKeyCode(KeyCode = "ZoneName")]
        public string ZoneName
        {
            get => zoneName;
            set
            {
                zoneName = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.ZoneName));
            }
        }
        /// <summary>
        /// Property related to Tag Content of the Button in ToolBar
        /// </summary>
        [SaveKeyCode(KeyCode = "IndexInList")]
        public int IndexInList { get; set; }

        public DataModelUBAB(GlobalDataModels global)
        {
            global.EvtHandler.Add(() => {
                this.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.ExteriorHalfLength))
                        Set_InteriorHalfLength();
                };
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameter = 0;
            });
        }

        private void Set_InteriorHalfLength()
        {
            InteriorHalfLength = ExteriorHalfLength;
        }
    }
}
