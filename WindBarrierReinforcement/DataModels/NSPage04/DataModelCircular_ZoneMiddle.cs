using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelCircular_ZoneMiddle : DataModel, IDataModelCircularZone
    {
        public List<string> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int noOfBars;

        public int NoOfBars
        {
            get { return noOfBars; }
            private set { noOfBars = value; }
        }

        private int spacingValue;

        public int SpacingValue
        {
            get { return spacingValue; }
            set { spacingValue = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SpacingValue); }
        }

        private int selectedIndexDiameter;

        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SelectedIndexDiameter); }
        }

        private double zoneLength;

        public double ZoneLength
        {
            get { return zoneLength; }
            private set { zoneLength = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneLength); }
        }

        private int zoneInterDistance;

        public int ZoneInterDistance
        {
            get { return zoneInterDistance; }
            private set { zoneInterDistance = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneInterDistance); }
        }

        private double radiusGiven;

        public double RadiusGiven
        {
            get { return radiusGiven; }
            set { radiusGiven = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven); }
        }

        private double distanceFromBottom;

        public double DistanceFromBottom
        {
            get { return distanceFromBottom; }
            private set { distanceFromBottom = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom); }
        }

        private double offsetFromEdge;

        public double OffsetFromEdge
        {
            get { return offsetFromEdge; }
            private set { offsetFromEdge = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.OffsetFromEdge); }
        }

        private int distributionBars;

        public int DistributionBars
        {
            get { return distributionBars; }
            set { distributionBars = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistributionBars); }
        }
        private GlobalDataModels _globalData;

        private int listIndex;
        public int ListIndex
        {
            get { return listIndex; }
            set { listIndex = value; NotifyPropertyChanged("ListIndex"); }
        }

        public DataModelCircular_ZoneMiddle(GlobalDataModels global)
        {
            this._globalData = global;
            // do not try to set nextZone and prevZOne like bellow in the ctor. It till try to access the collection that is not yet fully defined
            //also because we want them to be dynamic. Always check prev or next item in the collection
            //IDataModelCircularZone nextZone = _globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[_listIndex + 1];
            global.EvtHandler.Add(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    //NoOfBars
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneLength) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SpacingValue))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.NoOfBars));
                    //ZoneLength
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneLength));
                    //ZoneInterDistance
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SpacingValue))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneInterDistance));
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SelectedIndexDiameter))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom));

                };
            });
            global.EvtHandler.Add(() =>
            {
                _globalData.GDMPage04.DataModelCircular_ZoneCollection.Get(ListIndex - 1).PropertyChanged += (o, e) =>
                {
                    //OffsetFromEdge
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneLength) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneInterDistance) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.OffsetFromEdge))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.OffsetFromEdge));
                };
            });
            global.EvtHandler.Add(() =>
            {
                _globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[ListIndex +1].PropertyChanged += (o, e) =>
                {
                    //ZoneLength
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.RadiusGiven))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven));
                    //ZoneInterDistance
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.SpacingValue))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneInterDistance));
                };
            });
            global.EvtHandler.Add(() =>
            {
                global.GDMPage04.DataModelRadial1.PropertyChanged += (o, e) =>
                {
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelRadial1>(x => x.SelectedIndexLargeDiameter))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom));
                };
            });
            global.EvtHandler.Add(() =>
            {
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) =>
                {
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.BottomCover))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom));
                };
            });
        }
        private void Set_NoOfBars()
        {
            NoOfBars = (int)(Math.Ceiling(ZoneLength / SpacingValue));
        }
        private void Set_ZoneLength()
        {
            // do not 
            IDataModelCircularZone nextZone = _globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[ListIndex + 1];
            ZoneLength = RadiusGiven - nextZone.RadiusGiven;
        }
        private void Set_ZoneInterDistance()
        {
            IDataModelCircularZone nextZone = _globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[ListIndex + 1];
            ZoneInterDistance = Math.Min(SpacingValue, nextZone.SpacingValue);
        }
        private void Set_DistanceFromBottom()
        {
            int bottomCover = this._globalData.GDMPage01.DataModel_Global_Formwork.BottomCover;

            int radial1LargeDiamNominalSize = this._globalData.GDMPage12.GetNominalDiameterSize(this._globalData.GDMPage04.DataModelRadial1.SelectedIndexLargeDiameter);

            int diameterNominalSize = this._globalData.GDMPage12.GetNominalDiameterSize(SelectedIndexDiameter);

            DistanceFromBottom = (double)bottomCover + diameterNominalSize / 2 + radial1LargeDiamNominalSize;
        }
        private void Set_OffsetFromEdge()
        {
            IDataModelCircularZone prevZone = _globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[ListIndex - 1];
            IDataModelCircularZone nextZone = _globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[ListIndex + 1];
            OffsetFromEdge = prevZone.ZoneLength + prevZone.ZoneInterDistance + nextZone.OffsetFromEdge;
        }
    }
}
