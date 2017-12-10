using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelRadialGeneral : DataModel
    {
        private int minCore;
        public int MinCore
        {
            get { return minCore; }
            set { minCore = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinCore)); }
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
    }
}
