using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelRadialGeneral : DataModel
    {
        private int minCore;
        public int MinCore
        {
            get { return minCore; }
            private set { minCore = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinCore)); }
        }

        private int minSpaceField;
        public int MinSpaceField
        {
            get { return minSpaceField; }
            set { minSpaceField = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceField)); }
        }

        private int minSpaceCenter;
        public int MinSpaceCenter
        {
            get { return minSpaceCenter; }
            set { minSpaceCenter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceCenter)); }
        }

        private double alternativeHalfMinStartAngle; //TODO : calculated after anchor is set

        private double alternativeMinStartAngle;
        public double AlternativeMinStartAngle
        {
            get { return alternativeMinStartAngle; }
            set { alternativeMinStartAngle = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.AlternativeMinStartAngle)); }
        }
        public static int trest = 0;
        public DataModelRadialGeneral()
        {
            trest++;
            var a = trest;
            GlobalPageEvts.Evts.Add(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    //Min Core
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceCenter))
                        Set_MinCore();
                };
            });

            GlobalPageEvts.Evts.Add(() =>
            {
                GlobalPageEvts.Global.GlobalPage04.DataModelRadial2.PropertyChanged += (o, e) =>
                {
                    //Min Core
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SpacingAngle))
                        Set_MinCore();
                    return;
                };
            });

            GlobalPageEvts.Evts.Add(() =>
            {
                GlobalPageEvts.Global.GlobalPage02.DataModel_Anchor.PropertyChanged += (o, e) =>
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
            MinCore = (int)Math.Ceiling(MinSpaceCenter / (Math.Sin(GlobalPageEvts.Global.GlobalPage04.DataModelRadial2.SpacingAngle)));
        }
        private void Set_alternativeHalfMinStartAngle()
        {
            int anchorBoltDiameter = GlobalPageEvts.Global.GlobalPage02.DataModel_Anchor.GetBoltDiameterNominalSize();
            int radiusCenterLineTower = GlobalPageEvts.Global.GlobalPage02.DataModel_Anchor.RadiusCenterLineTower;
            int distanceBoltPair = GlobalPageEvts.Global.GlobalPage02.DataModel_Anchor.DispanceBoltPairs;

            this.alternativeHalfMinStartAngle = Math.Atan((anchorBoltDiameter + 50) / (radiusCenterLineTower - distanceBoltPair / 2));

            Set_AlternativeMinStartAngle();
        }
        private void Set_AlternativeMinStartAngle()
        {
            AlternativeMinStartAngle = this.alternativeHalfMinStartAngle * 2;
        }
    }
}
