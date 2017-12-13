using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public interface IDataModelCircularZone : INotifyPropertyChanged
    {
        List<string> DiameterNames { get; }
        int NoOfBars { get; }
        int SpacingValue { get; }
        int SelectedIndexDiameter { get; }
        double ZoneLength { get; }
        int ZoneInterDistance { get; }
        double RadiusGiven { get; }
        double DistanceFromBottom { get; }
        double OffsetFromEdge { get; }
        int DistributionBars { get; }
        int ListIndex { get; set; }
    }
}
