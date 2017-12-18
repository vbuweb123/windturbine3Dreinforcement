using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage12;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage05
{
    public class DataModelCircular_Zone : DataModel, IDataModelCircularZone
    {
        public List<string> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.NoOfBars)); }
        }

        private int spacingValue;
        [SaveKeyCode(KeyCode = "SpacingValue")]
        public int SpacingValue
        {
            get { return spacingValue; }
            set { spacingValue = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SpacingValue)); }
        }

        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SelectedIndexDiameter)); }
        }

        private double zoneLength;
        [SaveKeyCode(KeyCode = "ZoneLength")]
        public double ZoneLength
        {
            get { return zoneLength; }
            set { zoneLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.ZoneLength)); }
        }

        private int zoneInterDistance;
        [SaveKeyCode(KeyCode = "ZoneInterDistance")]
        public int ZoneInterDistance
        {
            get { return zoneInterDistance; }
            set { zoneInterDistance = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.ZoneInterDistance)); }
        }

        private double radiusGiven;
        [SaveKeyCode(KeyCode = "RadiusGiven")]
        public double RadiusGiven
        {
            get { return radiusGiven; }
            set { radiusGiven = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.RadiusGiven)); }
        }

        private double distanceFromBottom; //distancefromTop
        [SaveKeyCode(KeyCode = "DistanceFromBottom")]
        public double DistanceFromBottom
        {
            get { return distanceFromBottom; }
            set { distanceFromBottom = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.DistanceFromBottom)); }
        }

        private double offsetFromEdge;
        [SaveKeyCode(KeyCode = "OffsetFromEdge")]
        public double OffsetFromEdge
        {
            get { return offsetFromEdge; }
            set { offsetFromEdge = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.OffsetFromEdge)); }
        }

        private int distributionBars;
        [SaveKeyCode(KeyCode = "DistributionBars")]
        public int DistributionBars
        {
            get { return distributionBars; }
            set { distributionBars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.DistributionBars)); }
        }

        private GlobalDataModels globalData;

        private int listIndex;
        public int ListIndex
        {
            get { return listIndex; }
            set { listIndex = value; NotifyPropertyChanged("ListIndex"); }
        }

        public EZonePosition Position { get; set; }

        Action addEvents;
        Action removeEvents;

        private PropertyChangedEventHandler action_this_propertyChanged;
        private PropertyChangedEventHandler action_this2_propertyChanged;
        private PropertyChangedEventHandler action_page01_formwork_propertyChanged;
        private PropertyChangedEventHandler action_page04_radial1;
        private PropertyChangedEventHandler action_page04_circulargeneral;

        public DataModelCircular_Zone(GlobalDataModels global)
        {
            this.globalData = global;

            action_this_propertyChanged = (o, e) =>
            {
                switch (Position)
                {
                    case EZonePosition.Start:
                        //NoOfBars -- OK
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.ZoneLength) ||
                            e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SpacingValue))
                            Set_NoOfBars();
                        //ZoneLength
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.RadiusGiven))
                            Set_ZoneLength();
                        //ZoneInterDistance
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SpacingValue))
                            Set_ZoneInterDistance();
                        //RadiusGiven
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.OffsetFromEdge))
                            Set_RadiusGiven();
                        //DistanceFromBottom
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SelectedIndexDiameter))
                            Set_DistanceFromTop();
                        //OffsetFromEdge
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SelectedIndexDiameter))
                            Set_OffsetFromEdge();
                        break;
                    case EZonePosition.Middle:
                        //NoOfBars -- OK
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.ZoneLength) ||
                            e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SpacingValue))
                            Set_NoOfBars();
                        //ZoneLength
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.RadiusGiven))
                            Set_ZoneLength();
                        //ZoneInterDistance
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SpacingValue))
                            Set_ZoneInterDistance();
                        //DistanceFromBottom
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircular_Zone>(x => x.SelectedIndexDiameter))
                            Set_DistanceFromTop();
                        break;
                    case EZonePosition.End:
                        //OffsetFromEdge
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneLength) ||
                            e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneInterDistance))
                            Set_OffsetFromEdge();
                        //DistanceFromBottom
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.SelectedIndexDiameter))
                            Set_DistanceFromTop();
                        break;
                }
            };
            action_this2_propertyChanged = (o, e) =>
            {
                //middle zone OffsetFromEdge depends on previous zone ZoneLength ZoneInterDistance and OffsetFromEdge
                if (Position != EZonePosition.End)
                {
                    //next index should not be last . 1->2, 2->3, 3 -x 4
                    if ((ListIndex + 1) < globalData.GDMPage04.DataModelCircular_ZoneCollection.Count - 1)
                    {
                        //If current properties change - notify next position but not the last one
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneLength) ||
                            e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.ZoneInterDistance) ||
                            e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.OffsetFromEdge))
                            global.GDMPage04.DataModelCircular_ZoneCollection.Get(ListIndex + 1).Set_OffsetFromEdge();
                    }
                    if ((ListIndex + 1) == globalData.GDMPage04.DataModelCircular_ZoneCollection.Count - 1)
                    {
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.OffsetFromEdge))
                            global.GDMPage04.DataModelCircular_ZoneCollection.Get(ListIndex + 1).Set_OffsetFromEdge();
                    }
                }
                //middle ZoneLength and ZoneInterDistance depends of next (+1) zone
                if (Position == EZonePosition.Middle || Position == EZonePosition.End)
                {
                    //ZoneLength
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.RadiusGiven))
                        global.GDMPage04.DataModelCircular_ZoneCollection.Get(ListIndex - 1).Set_ZoneLength();
                    //ZoneInterDistance
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<IDataModelCircularZone>(x => x.SpacingValue))
                        global.GDMPage04.DataModelCircular_ZoneCollection.Get(ListIndex - 1).Set_ZoneInterDistance();
                }

            };
            action_page01_formwork_propertyChanged = (o, e) =>
            {
                //DistanceFromBottom
                if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.TopCover))
                    Set_DistanceFromTop();

                switch (Position)
                {
                    case EZonePosition.Start:
                        //RadiusGiven
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.DFoundation))
                            Set_RadiusGiven();
                        //OffsetFromEdge
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.EdgeCover))
                            Set_OffsetFromEdge();
                        break;
                }
            };
            action_page04_radial1 = (o, e) =>
            {
                //DistanceFromBottom
                if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelRadial1>(x => x.SelectedIndexLargeDiameter))
                    Set_DistanceFromTop();
            };
            action_page04_circulargeneral = (o, e) =>
            {
                switch (Position)
                {
                    case EZonePosition.Start:
                        //OffsetFromEdge
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelCircularGeneral>(x => x.SelectedDiameterEdgeCirculars))
                            Set_OffsetFromEdge();
                        break;
                    case EZonePosition.End:
                        if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelCircularGeneral>(x => x.RadiusCore))
                            Set_RadiusGiven();
                        break;
                }
            };

            addEvents = () =>
            {
                this.PropertyChanged += action_this_propertyChanged;
                this.PropertyChanged += action_this2_propertyChanged;
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += action_page01_formwork_propertyChanged;
                global.GDMPage04.DataModelRadial1.PropertyChanged += action_page04_radial1;
                global.GDMPage04.DataModelCircularGeneral.PropertyChanged += action_page04_circulargeneral;
            };
            removeEvents = () =>
            {
                this.PropertyChanged -= action_this_propertyChanged;
                this.PropertyChanged -= action_this2_propertyChanged;
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged -= action_page01_formwork_propertyChanged;
                global.GDMPage04.DataModelRadial1.PropertyChanged -= action_page04_radial1;
                global.GDMPage04.DataModelCircularGeneral.PropertyChanged -= action_page04_circulargeneral;
            };
            addEvents();
        }

        ~DataModelCircular_Zone()
        {
            removeEvents();
        }
        public void Set_NoOfBars()
        {
            if (SpacingValue == 0)
                NoOfBars = 0;
            else
                switch (Position)
                {
                    case EZonePosition.Start:
                        NoOfBars = (int)(Math.Ceiling(ZoneLength / SpacingValue));
                        break;
                    case EZonePosition.Middle:
                        NoOfBars = (int)(Math.Ceiling(ZoneLength / SpacingValue));
                        break;
                    case EZonePosition.End:
                        NoOfBars = 0;
                        break;
                }
        }

        public void Set_ZoneLength()
        {
            switch (Position)
            {
                case EZonePosition.Start:
                    //keep it dynamic. Leave second zone here not in constructor
                    IDataModelCircularZone SecondZone = globalData.GDMPage05.DataModelCircular_ZoneCollection.Get(1);
                    ZoneLength = RadiusGiven - SecondZone.RadiusGiven;
                    break;
                case EZonePosition.Middle:
                    // do not 
                    IDataModelCircularZone nextZone = globalData.GDMPage05.DataModelCircular_ZoneCollection.Get(ListIndex + 1);
                    ZoneLength = RadiusGiven - nextZone.RadiusGiven;
                    break;
                case EZonePosition.End:
                    ZoneLength = 0;
                    break;
            }
        }

        public void Set_ZoneInterDistance()
        {
            switch (Position)
            {
                case EZonePosition.Start:
                    IDataModelCircularZone SecondZone = globalData.GDMPage05.DataModelCircular_ZoneCollection.Get(1);
                    ZoneInterDistance = Math.Min(SpacingValue, SecondZone.SpacingValue);
                    break;
                case EZonePosition.Middle:
                    IDataModelCircularZone nextZone = globalData.GDMPage05.DataModelCircular_ZoneCollection.Get(ListIndex + 1);
                    ZoneInterDistance = Math.Min(SpacingValue, nextZone.SpacingValue);
                    break;
                case EZonePosition.End:
                    ZoneInterDistance = 0;
                    break;
            }
        }

        public void Set_RadiusGiven()
        {
            switch (Position)
            {
                case EZonePosition.Start:
                    double dFoundation = (double)this.globalData.GDMPage01.DataModel_Global_Formwork.DFoundation;
                    RadiusGiven = dFoundation / 2 - OffsetFromEdge;
                    break;
                case EZonePosition.End:
                    RadiusGiven = globalData.GDMPage04.DataModelCircularGeneral.RadiusCore;
                    break;
            }
        }

        public void Set_DistanceFromTop()
        {
            int bottomCover = this.globalData.GDMPage01.DataModel_Global_Formwork.TopCover;
            int radial1LargeDiamNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(this.globalData.GDMPage04.DataModelRadial1.SelectedIndexLargeDiameter);
            int diameterNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(SelectedIndexDiameter);

            switch (Position)
            {
                case EZonePosition.End:
                    DistanceFromBottom = (double)bottomCover + radial1LargeDiamNominalSize;
                    break;
                default:
                    
                    DistanceFromBottom = (double)bottomCover + (double)diameterNominalSize / 2 + radial1LargeDiamNominalSize;
                    break;
            }
        }

        public void Set_OffsetFromEdge()
        {
            switch (Position)
            {
                case EZonePosition.Start:
                    int diameterNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(SelectedIndexDiameter);
                    int diameterEdgeCircularNominalSize = this.globalData.GDMPage12.GetNominalDiameterSize(this.globalData.GDMPage04.DataModelCircularGeneral.SelectedDiameterEdgeCirculars);
                    int EdgeCover = this.globalData.GDMPage01.DataModel_Global_Formwork.EdgeCover;
                    OffsetFromEdge = (double)diameterNominalSize / 2 + diameterEdgeCircularNominalSize + EdgeCover;
                    break;
                case EZonePosition.Middle:
                    IDataModelCircularZone prevZone = globalData.GDMPage05.DataModelCircular_ZoneCollection.Get(ListIndex - 1);
                    OffsetFromEdge = prevZone.ZoneLength + prevZone.ZoneInterDistance + prevZone.OffsetFromEdge;
                    break;
                case EZonePosition.End:
                    IDataModelCircularZone prevZone_e = globalData.GDMPage05.DataModelCircular_ZoneCollection.Get(ListIndex - 1);
                    OffsetFromEdge = ZoneLength + ZoneInterDistance + prevZone_e.OffsetFromEdge;
                    break;
            }
        }
    }
}
