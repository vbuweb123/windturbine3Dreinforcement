using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.DataModels.NSPage12;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage10
{
    public class DataModel_CHR_Zones : DataModel
    {
        //TODO: Definition of zone in excel are not clear. Hardcoding zones for now
        private int zoneLength1;
        [SaveKeyCode(KeyCode = "ZoneLength1")]
        [DynGet(DynKey = "ZoneLength1")]
        public int ZoneLength1
        {
            get { return zoneLength1; }
            set
            {
                zoneLength1 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.ZoneLength1));
            }
        }
        private int spacingValueRadial1;
        [SaveKeyCode(KeyCode = "SpacingValueRadial1")]
        [DynGet(DynKey = "SpacingValueRadial1")]
        public int SpacingValueRadial1
        {
            get { return spacingValueRadial1; }
            set
            {
                spacingValueRadial1 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.SpacingValueRadial1));
            }
        }

        private int edgeOffset1;
        [SaveKeyCode(KeyCode = "EdgeOffset1")]
        [DynGet(DynKey = "EdgeOffset1")]
        public int EdgeOffset1 //Edge Offset for secon zone needs to be calculated
        {
            get { return edgeOffset1; }
            set
            {
                edgeOffset1 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.EdgeOffset1));
            }
        }

        private int zoneLength2;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "ZoneLength2")]
        public int ZoneLength2 // TODO : this needs to be calculated
        {
            get { return zoneLength2; }
            private set
            {
                zoneLength2 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.ZoneLength2));
            }
        }
        private int spacingValueRadial2;
        [SaveKeyCode(KeyCode = "SpacingValueRadial2")]
        [DynGet(DynKey = "SpacingValueRadial2")]
        public int SpacingValueRadial2
        {
            get { return spacingValueRadial2; }
            set
            {
                spacingValueRadial2 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.SpacingValueRadial2));
            }
        }

        private int edgeOffset2;
        [SaveKeyCode(KeyCode = "EdgeOffset2")]
        [DynGet(DynKey = "EdgeOffset2")]
        public int EdgeOffset2 //Edge Offset for secon zone needs to be calculated
        {
            get { return edgeOffset2; }
            set
            {
                edgeOffset2 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.EdgeOffset2));
            }
        }

        private GlobalDataModels global;

        public DataModel_CHR_Zones(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.EdgeOffset2) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_CHR_Zones>(x => x.ZoneLength1))
                        Set_ZoneLength2();
                };
            });

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.DFoundation) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.DTowerBase) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage01.DataModel_Global_Formwork>(x => x.EdgeCover))
                        Set_ZoneLength2();
                };

            });
            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage04.DataModelRadial1.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelRadial1>(x => x.SelectedIndexLargeDiameter))
                        Set_ZoneLength2();
                };
            });
            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage04.DataModelCircularGeneral.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage04.DataModelCircularGeneral>(x => x.SelectedDiameterEdgeCirculars))
                        Set_ZoneLength2();
                };
            });
            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage12.DataModelShapesCollection.CollectionChanged += (o, e) =>
                {
                    Set_ZoneLength2();
                };
            });

        }
        private void Set_ZoneLength2()
        {
            //getting large diameter
            //TODO - check this strict dependency to the index in the list. Maybe add in tag a reference?
            EDiameters valueLD = (EDiameters)global.GDMPage04.DataModelRadial1.SelectedIndexLargeDiameter; 
            int nominalSizeLargeDiameter = Calculator.GetNominalSize(valueLD, global);

            //getting edge circular diameter
            //TODO : check this strict dependency to the index in the list. Maybe add in tag a reference?
            EDiameters valueEC = (EDiameters)global.GDMPage04.DataModelCircularGeneral.SelectedDiameterEdgeCirculars; 
            int nominalSizeEdgeCircular = Calculator.GetNominalSize(valueEC, global);

            //TODO : Alex - simplify formula???
            ZoneLength2 = global.GDMPage01.DataModel_Global_Formwork.DFoundation / 2 - EdgeOffset2
                - (global.GDMPage01.DataModel_Global_Formwork.DTowerBase / 2 - global.GDMPage01.DataModel_Global_Formwork.EdgeCover)
                - nominalSizeLargeDiameter - nominalSizeEdgeCircular - ZoneLength1;
        }
    }
}
