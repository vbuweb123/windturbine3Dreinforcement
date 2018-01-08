using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.StaticModel;

namespace WBR_Common.Common.Eng
{
    public static class Calculator
    {
        public static int GetNominalSize(EDiameters eDiameters, GlobalDataModels global)
        {
            var BSShape = global.GDMPage12.DataModelShapesCollection
                .Where(x => x.Reference == eDiameters)
                .SingleOrDefault();
            if (BSShape == null)
                throw new Exception("Diameter " + Enum.GetName(typeof(EDiameters), eDiameters) + " not found");
            return BSShape.NominalSize;
        }
        public static string GetHookTypeName(EHookTypes eHookType) => Enum.GetName(typeof(EHookTypes), eHookType);

        public static string GetOptionName(EOption eOption) => Enum.GetName(typeof(EOption), eOption);

        public static string GetOptionNameCBES(EOptionsCBES eOptionsCBES) => Enum.GetName(typeof(EOptionsCBES), eOptionsCBES);

        public static string GetConsistenceToleranceName(EConsistenceTolerance eConsistenceTolerance) => Enum.GetName(typeof(EConsistenceTolerance), eConsistenceTolerance);

        public static string GetConcreteQualityName(EConcreteQuality eConcreteQuality) => Enum.GetName(typeof(EConcreteQuality), eConcreteQuality);

        public static string GetExposureName(EExposureClass eExposureClass) => Enum.GetName(typeof(EExposureClass), eExposureClass);
    }
}
