using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.DataModels.NSPage07;
using WBR_Common.Writer;

namespace WBR_Common.StaticModel
{
    public interface IGlobalDataModelsPage07
    {
        DataModel_StraightBars DataModel_StraightBars_Dir1 { get; }
        DataModel_StraightBars DataModel_StraightBars_Dir2 { get; }
        DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete { get; }
        DataModel_CircularBarsTop DataModel_CircularBarsTop { get; }
        DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide { get; }
        DataModel_StraightBars_Extra DataModel_StraightBars_Extra { get; }
    }
    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage07 : IGlobalDataModelsPage07
        {
            [SaveKeyCode(KeyCode = "DataModel_StraightBars_Dir1", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "StraightBars_Dir1", AddNavKey = true)]
            public DataModel_StraightBars DataModel_StraightBars_Dir1 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_StraightBars_Dir2", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "StraightBars_Dir2", AddNavKey = true)]
            public DataModel_StraightBars DataModel_StraightBars_Dir2 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_RadialEdgeConcrete", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "RadialEdgeConcrete", AddNavKey = true)]
            public DataModel_RadialEdgeConcrete DataModel_RadialEdgeConcrete { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_CircularBarsTop", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "CircularBarsTop", AddNavKey = true)]
            public DataModel_CircularBarsTop DataModel_CircularBarsTop { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_CircularBarsExteriorSide", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "CircularBarsExteriorSide", AddNavKey = true)]
            public DataModel_CircularBarsExteriorSide DataModel_CircularBarsExteriorSide { get; private set; }

            [SaveKeyCode(KeyCode = "DataModel_StraightBars_Extra", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "StraightBars_Extra", AddNavKey = true)]
            public DataModel_StraightBars_Extra DataModel_StraightBars_Extra { get; private set; }

            public _GlobalDataModelsPage07(GlobalDataModels global)
            {
                DataModel_StraightBars_Dir1 = new DataModel_StraightBars(global);
                DataModel_StraightBars_Dir2 = new DataModel_StraightBars(global);
                DataModel_RadialEdgeConcrete = new DataModel_RadialEdgeConcrete(global);
                DataModel_CircularBarsTop = new DataModel_CircularBarsTop(global);
                DataModel_CircularBarsExteriorSide = new DataModel_CircularBarsExteriorSide(global);
                DataModel_StraightBars_Extra = new DataModel_StraightBars_Extra();
            }
        }
    }
}
