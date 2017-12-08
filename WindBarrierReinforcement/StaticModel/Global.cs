using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.DataModels.NSPage04;

namespace WindBarrierReinforcement.StaticModel
{
 
    public static class GlobalDataModelsPage04
    {
        //PAge 04
        private static DataModel_BR_Radial1 dataModel_BR_Radial1;
        public static DataModel_BR_Radial1 DataModel_BR_Radial1
        {
            get => dataModel_BR_Radial1 ?? (dataModel_BR_Radial1 = new DataModel_BR_Radial1());
            set => dataModel_BR_Radial1 = value;
        }

        private static DataModel_BR_Radial2 dataModel_BR_Radial2;
        public static DataModel_BR_Radial2 DataModel_BR_Radial2
        {
            get => dataModel_BR_Radial2 ?? (dataModel_BR_Radial2 = new DataModel_BR_Radial2());
            set => dataModel_BR_Radial2 = value;
        }
    }
    public static class Global
    {
        //Page 01
        private static DataModel_Global_Formwork dataModel_Global_Formwork;
        public static DataModel_Global_Formwork DataModel_Global_Formwork
        {
            get => dataModel_Global_Formwork ?? (dataModel_Global_Formwork = new DataModel_Global_Formwork());
            set => dataModel_Global_Formwork = value;
        }
        private static DataModel_Global_Coordinations_GroundPoint dataModel_Global_Coordinations_GroundPoint;
        public static DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint
        {
            get => dataModel_Global_Coordinations_GroundPoint ?? new DataModel_Global_Coordinations_GroundPoint();
            set => dataModel_Global_Coordinations_GroundPoint = value;
        }
        private static DataModel_Global_Materials dataModel_Global_Materials;
        public static DataModel_Global_Materials DataModel_Global_Materials
        {
            get => dataModel_Global_Materials ?? new DataModel_Global_Materials();
            set => dataModel_Global_Materials = value;
        }
        //Page 02
        private static DataModel_Anchor dataModel_Anchor;
        public static DataModel_Anchor DataModel_Anchor
        {
            get => dataModel_Anchor ?? (dataModel_Anchor = new DataModel_Anchor());
            set => dataModel_Anchor = value;
        }

        static Global()
        {
           
        }
    }
}
