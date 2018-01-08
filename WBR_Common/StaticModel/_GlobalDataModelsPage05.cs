﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.DataModels.NSPage05;
using WBR_Common.Writer;

namespace WBR_Common.StaticModel
{
    public interface IGlobalDataModelsPage05
    {
        DataModelCircularGeneral DataModelCircularGeneral { get; }
        DataModelRadial1 DataModelRadial1 { get; }
        DataModelRadial2 DataModelRadial2 { get; }
        DataModelRadialGeneral DataModelRadialGeneral { get; }
        DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; }
    }
    public partial class GlobalDataModels {

        private class _GlobalDataModelsPage05 : IGlobalDataModelsPage05
        {
            [SaveKeyCode(KeyCode = "DataModelCircularGeneral", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "CircularGeneral", AddNavKey = true)]
            public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelRadial1", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "Radial1", AddNavKey = true)]
            public DataModelRadial1 DataModelRadial1 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelRadial2", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "Radial2", AddNavKey = true)]
            public DataModelRadial2 DataModelRadial2 { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelRadialGeneral", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "RadialGeneral", AddNavKey = true)]
            public DataModelRadialGeneral DataModelRadialGeneral { get; private set; }

            [SaveKeyCode(KeyCode = "DataModelCircular_ZoneCollection", SaveDataType = SaveDataType.Class)]
            [DynNav(Key = "Collection", AddNavKey = true)]
            public DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; private set; }

            public _GlobalDataModelsPage05(GlobalDataModels global)
            {
                DataModelCircularGeneral = new DataModelCircularGeneral(global);
                DataModelRadial1 = new DataModelRadial1(global);
                DataModelRadial2 = new DataModelRadial2(global);
                DataModelRadialGeneral = new DataModelRadialGeneral(global);
                DataModelCircular_ZoneCollection = new DataModelCircular_ZoneCollection(global);
            }
        }
    }
    
}