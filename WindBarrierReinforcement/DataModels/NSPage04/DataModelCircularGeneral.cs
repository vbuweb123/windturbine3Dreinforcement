using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelCircularGeneral : DataModel
    {
        public List<string> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int overlapLength;
        [SaveKeyCode(KeyCode = "OverlapLength")]
        public int OverlapLength
        {
            get { return overlapLength; }
            set { overlapLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.OverlapLength)); }
        }

        private int maximumRebarLength;
        [SaveKeyCode(KeyCode = "MaximumRebarLength")]
        public int MaximumRebarLength
        {
            get { return maximumRebarLength; }
            set { maximumRebarLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.MaximumRebarLength)); }
        }

        private int selectedDiameterEdgeCirculars;
        [SaveKeyCode(KeyCode = "SelectedDiameterEdgeCirculars")]
        public int SelectedDiameterEdgeCirculars
        {
            get { return selectedDiameterEdgeCirculars; }
            set{ selectedDiameterEdgeCirculars = value;NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SelectedDiameterEdgeCirculars));}
        }

        private int numberEdgeCirculars;
        [SaveKeyCode(KeyCode = "NumberEdgeCirculars")]
        public int NumberEdgeCirculars
        {
            get { return numberEdgeCirculars; }
            set { numberEdgeCirculars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.NumberEdgeCirculars)); }
        }

        private int spacingEdgeCirculars;
        [SaveKeyCode(KeyCode = "SpacingEdgeCirculars")]
        public int SpacingEdgeCirculars
        {
            get { return spacingEdgeCirculars; }
            set { spacingEdgeCirculars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SpacingEdgeCirculars)); }
        }

        private int radiusCore;
        [SaveKeyCode(KeyCode = "RadiusCore")]
        public int RadiusCore
        {
            get { return radiusCore; }
            set { radiusCore = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.RadiusCore)); }
        }
    }
}
