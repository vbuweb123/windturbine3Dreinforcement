using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage12;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelCircular_ZoneBegining : DataModel, IDataModelCircularZone
    {
        public List<string> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int noOfBars;

        public int NoOfBars
        {
            get { return noOfBars; }
            private set { noOfBars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.NoOfBars)); }
        }

        private int spacingValue;

        public int SpacingValue
        {
            get { return spacingValue; }
            set { spacingValue = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SpacingValue)); }
        }

        private int selectedIndexDiameter;

        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SelectedIndexDiameter)); }
        }

        private double zoneLength;

        public double ZoneLength
        {
            get { return zoneLength; }
            private set { zoneLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneLength)); }
        }

        private int zoneInterDistance;

        public int ZoneInterDistance
        {
            get { return zoneInterDistance; }
           private  set { zoneInterDistance = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneInterDistance)); }
        }

        private double radiusGiven;

        public double RadiusGiven
        {
            get { return radiusGiven; }
            private set { radiusGiven = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven)); }
        }

        private double distanceFromBottom;

        public double DistanceFromBottom
        {
            get { return distanceFromBottom; }
            private set { distanceFromBottom = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom)); }
        }

        private double offsetFromEdge;

        public double OffsetFromEdge
        {
            get { return offsetFromEdge; }
            private set { offsetFromEdge = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.OffsetFromEdge)); }
        }

        private int distributionBars;

        public int DistributionBars
        {
            get { return distributionBars; }
            set { distributionBars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistributionBars)); }
        }

        private GlobalDataModels globalData;

        private int listIndex;
        public int ListIndex
        {
            get { return 0; }
            set { listIndex = value; NotifyPropertyChanged("ListIndex"); }
        }

        public DataModelCircular_ZoneBegining(GlobalDataModels global)
        {
            this.globalData = global;
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
                    //RadiusGiven
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.OffsetFromEdge))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven));
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SelectedIndexDiameter))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom));
                    //OffsetFromEdge
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.SelectedIndexDiameter))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.OffsetFromEdge));
                };
            });
            global.EvtHandler.Add(() => {
                global.GDMPage04.DataModelCircular_ZoneCollection.Zones[1].PropertyChanged += (o, e) =>
                {
                    //ZoneLength
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.RadiusGiven))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven));
                    //ZoneInterDistance
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.SpacingValue))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.ZoneInterDistance));
                };
            });
            global.EvtHandler.Add(() => {
                global.GDMPage04.DataModelRadial1.PropertyChanged += (o, e) => {
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelRadial1>(x => x.SelectedIndexLargeDiameter))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom));
                };
            });
            global.EvtHandler.Add(() => {
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) => {
                    //RadiusGiven
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.DFoundation))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.RadiusGiven));
                    //DistanceFromBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.BottomCover))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.DistanceFromBottom));
                    //OffsetFromEdge
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.EdgeCover))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.OffsetFromEdge));
                };
            });
            global.EvtHandler.Add(() => {
                global.GDMPage04.DataModelCircularGeneral.PropertyChanged += (o, e) => {
                    //OffsetFromEdge
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelCircularGeneral>(x => x.SelectedDiameterEdgeCirculars))
                        NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_ZoneBegining>(x => x.OffsetFromEdge));
                };
            });
        }
       

        private void Set_NoOfBars()
        {
            NoOfBars = (int)(Math.Ceiling(ZoneLength / SpacingValue));
        }
        private void Set_ZoneLength()
        {
            //keep it dynamic. Leave second zone here not in constructor
            IDataModelCircularZone SecondZone = this.globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[1];
            ZoneLength = RadiusGiven - SecondZone.RadiusGiven;
        }
        private void Set_ZoneInterDistance()
        {
            IDataModelCircularZone SecondZone = this.globalData.GDMPage04.DataModelCircular_ZoneCollection.Zones[1];
            ZoneInterDistance = Math.Min(SpacingValue, SecondZone.SpacingValue);
        }
        private void Set_RadiusGiven()
        {
            double dFoundation = (double)this.globalData.GDMPage01.DataModel_Global_Formwork.DFoundation;
            RadiusGiven = dFoundation / 2 - OffsetFromEdge;
        }
        private void Set_DistanceFromBottom()
        {
            int bottomCover = this.globalData.GDMPage01.DataModel_Global_Formwork.BottomCover;

            int radial1LargeDiamNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(this.globalData.GDMPage04.DataModelRadial1.SelectedIndexLargeDiameter);

            int diameterNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(SelectedIndexDiameter);

            DistanceFromBottom = (double)bottomCover + diameterNominalSize / 2 + radial1LargeDiamNominalSize;
        }
        private void Set_OffsetFromEdge()
        {
            int diameterNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(SelectedIndexDiameter);

            int diameterEdgeCircularNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(this.globalData.GDMPage04.DataModelCircularGeneral.SelectedDiameterEdgeCirculars);

            int EdgeCover = this.globalData.GDMPage01.DataModel_Global_Formwork.EdgeCover;

            OffsetFromEdge = (double)diameterNominalSize / 2 + diameterEdgeCircularNominalSize + EdgeCover;
        }
    }
}
