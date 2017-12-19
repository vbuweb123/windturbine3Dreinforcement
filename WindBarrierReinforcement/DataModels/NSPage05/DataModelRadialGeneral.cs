using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage05
{
    public class DataModelRadialGeneral : DataModel
    {
        private int minCore;
        [SaveKeyCode(KeyCode = "MinCore")]
        public int MinCore
        {
            get { return minCore; }
            private set { minCore = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinCore)); }
        }

        private int minSpaceField;
        [SaveKeyCode(KeyCode = "MinSpaceField")]
        public int MinSpaceField
        {
            get { return minSpaceField; }
            set { minSpaceField = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceField)); }
        }

        private int minSpaceCenter;
        [SaveKeyCode(KeyCode = "MinSpaceCenter")]
        public int MinSpaceCenter
        {
            get { return minSpaceCenter; }
            set { minSpaceCenter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceCenter)); }
        }

        private double alternativeHalfMinStartAngle; //TODO : calculated after anchor is set

        private double alternativeMinStartAngle;
        [SaveKeyCode(KeyCode = "AlternativeMinStartAngle")]
        public double AlternativeMinStartAngle
        {
            get { return alternativeMinStartAngle; }
            set { alternativeMinStartAngle = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.AlternativeMinStartAngle)); }
        }

        private GlobalDataModels global;
        public DataModelRadialGeneral(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    //Min Core
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceCenter))
                        Set_MinCore();
                };
            });

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage04.DataModelRadial2.PropertyChanged += (o, e) =>
                {
                    //Min Core
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SpacingAngle))
                        Set_MinCore();
                    return;
                };
            });

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage02.DataModel_Anchor.PropertyChanged += (o, e) =>
                {
                    //Min Core
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage02.DataModel_Anchor>(x => x.BoltDiameter) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage02.DataModel_Anchor>(x => x.RadiusCenterLineTower) ||
                        e.PropertyName == Reflected.ObjGetLastPropertyName<NSPage02.DataModel_Anchor>(x => x.DispanceBoltPairs))
                        Set_alternativeHalfMinStartAngle();
                };
            });

        }
        private void Set_MinCore()
        {
            if (global.GDMPage04.DataModelRadial2.SpacingAngle == 0)
                MinCore = 0;
            else
                MinCore =  (int)Math.Ceiling(MinSpaceCenter / (Math.Sin(global.GDMPage04.DataModelRadial2.SpacingAngle * Math.PI / 180)));
        }
        private void Set_alternativeHalfMinStartAngle()
        {
            int anchorBoltDiameter = global.GDMPage02.DataModel_Anchor.GetBoltDiameterNominalSize();
            int radiusCenterLineTower =global.GDMPage02.DataModel_Anchor.RadiusCenterLineTower;
            int distanceBoltPair = global.GDMPage02.DataModel_Anchor.DispanceBoltPairs;

            this.alternativeHalfMinStartAngle = Math.Atan(((double)anchorBoltDiameter + 50) / (radiusCenterLineTower - distanceBoltPair / 2));

            Set_AlternativeMinStartAngle();
        }
        private void Set_AlternativeMinStartAngle()
        {
            AlternativeMinStartAngle = this.alternativeHalfMinStartAngle * 2;
        }
    }
}
