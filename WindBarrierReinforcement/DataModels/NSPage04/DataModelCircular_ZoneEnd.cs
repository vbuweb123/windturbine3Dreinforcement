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
    public class DataModelCircular_ZoneEnd : DataModel, IDataModelCircularZone
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
            private set { spacingValue = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SpacingValue); }
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
            private set { radiusGiven = value; Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven); }
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

        private int listIndex;
        public int ListIndex
        {
            get { return listIndex; }
            set { listIndex = value; NotifyPropertyChanged("ListIndex"); }
        }

        private GlobalDataModels globalDataModels;

        public DataModelCircular_ZoneEnd(GlobalDataModels global, int listIndex)
        {
            // do not try to set nextZone and prevZOne like bellow in the ctor. It till try to access the collection that is not yet fully defined
            //IDataModelCircularZone nextZone = _globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[_listIndex + 1];
            this.ListIndex = listIndex;

            NoOfBars = 0;
            SpacingValue = 0;
            SelectedIndexDiameter = 0;
            ZoneLength = 0;
            ZoneInterDistance = 0;
            globalDataModels = global;

            global.EvtHandler.Add(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    //OffsetFromEdge
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneLength) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneInterDistance))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.OffsetFromEdge));
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.SelectedIndexDiameter))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.DistanceFromBottom));
                };
            });
            global.EvtHandler.Add(() =>
            {
                global.GDMPage04.DataModelRadial1.PropertyChanged += (o, e) =>
                {
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelRadial1>(x => x.SelectedIndexLargeDiameter))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.DistanceFromBottom));
                };
            });
            global.EvtHandler.Add(() =>
            {
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) =>
                {
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.BottomCover))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.DistanceFromBottom));
                };
            });
            global.EvtHandler.Add((Action)(() =>
            {
                IDataModelCircularZone prevZone = global.GDMPage04.DataModelCircular_ZoneCollection.Zones[(int)(this.ListIndex - 1)];
                prevZone.PropertyChanged += (o, e) =>
                {
                    //OffsetFromEdge
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.OffsetFromEdge))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.OffsetFromEdge));
                };
            }));
        }
        private void Set_RadiusGiven()
        {
            RadiusGiven = globalDataModels.GDMPage04.DataModelCircularGeneral.RadiusCore;
        }
        private void Set_DistanceFromBottom()
        {
            int bottomCover = this.globalDataModels.GDMPage01.DataModel_Global_Formwork.BottomCover;

            int radial1LargeDiamNominalSize = this.globalDataModels.GDMPage12.GetNominalDiameterSize(this.globalDataModels.GDMPage04.DataModelRadial1.SelectedIndexLargeDiameter);

            int diameterNominalSize = this.globalDataModels.GDMPage12.GetNominalDiameterSize(SelectedIndexDiameter);

            DistanceFromBottom = (double)bottomCover + diameterNominalSize / 2 + radial1LargeDiamNominalSize;
        }
        private void Set_OffsetFromEdge()
        {
            IDataModelCircularZone prevZone = globalDataModels.GDMPage04.DataModelCircular_ZoneCollection.Zones[ListIndex - 1];

            OffsetFromEdge = ZoneLength + ZoneInterDistance + prevZone.OffsetFromEdge;
        }
    }
}
