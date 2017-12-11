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

namespace WindBarrierReinforcement.DataModels.NSPage10
{
    public class DataModel_CHR_Zones : DataModel
    {
        //TODO: Definition of zone in excel are not clear. Hardcoding zones for now
        private int zoneLength1;
        public int ZoneLength1
        {
            get { return zoneLength1; }
            set { zoneLength1 = value; NotifyPropertyChanged("ZoneLength1"); }
        }
        private int spacingValueRadial1;
        public int SpacingValueRadial1
        {
            get { return spacingValueRadial1; }
            set { spacingValueRadial1 = value; NotifyPropertyChanged("SpacingValueRadial1"); }
        }

        private int edgeOffset1;
        public int EdgeOffset1 //Edge Offset for secon zone needs to be calculated
        {
            get { return edgeOffset1; }
            set { edgeOffset1 = value; NotifyPropertyChanged("EdgeOffset1"); }
        }

        private int zoneLength2;
        public int ZoneLength2 // TODO : this needs to be calculated
        {
            get { return zoneLength2; }
            private set { zoneLength2 = value; NotifyPropertyChanged("ZoneLength2"); }
        }
        private int spacingValueRadial2;
        public int SpacingValueRadial2
        {
            get { return spacingValueRadial2; }
            set { spacingValueRadial2 = value; NotifyPropertyChanged("SpacingValueRadial2"); }
        }

        private int edgeOffset2;
        public int EdgeOffset2 //Edge Offset for secon zone needs to be calculated
        {
            get { return edgeOffset2; }
            set { edgeOffset2 = value; NotifyPropertyChanged("EdgeOffset2"); }
        }
        public DataModel_CHR_Zones(EvtHandler eventHandler)
        {
            eventHandler.Register(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.EdgeOffset2) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.ZoneLength1))
                        Set_ZoneLength2();
                };
            });

            eventHandler.Register(() =>
            {
                GlobalPageEvts.Global.GlobalPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.DFoundation) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.DTowerBase) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.EdgeCover))
                        Set_ZoneLength2();
                };

            });
            eventHandler.Register(() =>
            {
                GlobalPageEvts.Global.GlobalPage04.DataModelRadial1.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelRadial1>(x => x.SelectedIndexLargeDiameter))
                        Set_ZoneLength2();
                };
            });
            eventHandler.Register(() =>
            {
                GlobalPageEvts.Global.GlobalPage04.DataModelCircularGeneral.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelCircularGeneral>(x => x.SelectedDiameterEdgeCirculars))
                        Set_ZoneLength2();
                };
            });
            eventHandler.Register(() =>
            {
                GlobalPageEvts.Global.GlobalPage12.DataModelShapesCollection.CollectionChanged += (o, e) =>
                {
                    Set_ZoneLength2();
                };
            });

        }
        private void Set_ZoneLength2()
        {
            //getting large diameter
            EDiameters valueLD = (EDiameters)GlobalPageEvts.Global.GlobalPage04.DataModelRadial1.SelectedIndexLargeDiameter; //TODO - check this strict dependency to the index in the list. Maybe add in tag a reference?
            var BSShapeLD = GlobalPageEvts.Global.GlobalPage12.DataModelShapesCollection.Where(x => x.Reference == valueLD).SingleOrDefault();
            if (BSShapeLD == null)
                throw new Exception("Diameter Value " + Enum.GetName(typeof(EDiameters), valueLD) + " is not added in DataModelShapesCollection");
            int nominalSizeLargeDiameter = BSShapeLD.NominalSize;

            //getting edge circular diameter
            EDiameters valueEC = (EDiameters)GlobalPageEvts.Global.GlobalPage04.DataModelCircularGeneral.SelectedDiameterEdgeCirculars; //TODO - check this strict dependency to the index in the list. Maybe add in tag a reference?
            DataModelBSShapes BSShapeEC = GlobalPageEvts.Global.GlobalPage12.DataModelShapesCollection.Where(x => x.Reference == valueEC).SingleOrDefault();
            if (BSShapeEC == null)
                throw new Exception("Diameter Value " + Enum.GetName(typeof(EDiameters), valueEC) + " is not added in DataModelShapesCollection");
            int nominalSizeEdgeCircular = BSShapeEC.NominalSize;

            //TODO : Alex - simplify formula???
            ZoneLength2 = GlobalPageEvts.Global.GlobalPage01.DataModel_Global_Formwork.DFoundation / 2 - EdgeOffset2
                - (GlobalPageEvts.Global.GlobalPage01.DataModel_Global_Formwork.DTowerBase / 2 - GlobalPageEvts.Global.GlobalPage01.DataModel_Global_Formwork.EdgeCover)
                - nominalSizeLargeDiameter - nominalSizeEdgeCircular - ZoneLength1;
        }
    }
}
