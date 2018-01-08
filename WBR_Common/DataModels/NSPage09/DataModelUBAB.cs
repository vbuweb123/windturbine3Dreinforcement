using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage09
{
    public class DataModelUBAB : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int exteriorHalfLength;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "ExteriorHalfLength")]
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
        [DynGet(DynKey = "InteriorHalfLength")]
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
        [DynGet(DynKey = "SmallEdge")]
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
        [DynGet(DynKey = "DistanceFromTop")]
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
        [DynGet(DynKey = "FreeEdgeLength")]
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

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);

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

        private bool eventsAdded = false;
        //act called when new DataModelUBAB item is added into the collection
        private PropertyChangedEventHandler actionOnConstructed;

        public Action AddEvents;
        private Action RemoveEvents;

        private GlobalDataModels globalData { get; set; }

        public DataModelUBAB(GlobalDataModels global)
        {
            this.globalData = global;

            actionOnConstructed = (o, e) => {
                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelUBAB>(x => x.ExteriorHalfLength))
                    Set_InteriorHalfLength();
            };

            AddEvents = () =>
            {
                if (!eventsAdded)
                {
                    this.PropertyChanged += actionOnConstructed;
                    eventsAdded = true;
                }
            };
            RemoveEvents = () =>
            {
                this.PropertyChanged -= actionOnConstructed;
            };
        }

        public void Set_InteriorHalfLength()
        {
            InteriorHalfLength = ExteriorHalfLength;
        }

        ~DataModelUBAB() {
            RemoveEvents();
        }
    }
}
