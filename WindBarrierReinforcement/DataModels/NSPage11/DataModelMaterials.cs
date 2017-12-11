using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;

namespace WindBarrierReinforcement.DataModels.NSPage11
{
    public class DataModelMaterials : DataModel
    {
        //Common Data
        public List<string> ConcreteQualityNames => EnumHelpers.GetEnumDisplayText(typeof(EConcreteQuality));
        public List<string> ExposureClassNames => EnumHelpers.GetEnumDisplayText(typeof(EExposureClass));
        public List<string> ConsistenceToleranceNames => EnumHelpers.GetEnumDisplayText(typeof(EConsistenceTolerance));
        /// <summary>
        /// properties
        /// </summary>
        public string Name { get; private set; }

        private int selectedIndexConcreteQuality;
        public int SelectedIndexConcreteQuality
        {
            get => selectedIndexConcreteQuality;
            set
            {
                selectedIndexConcreteQuality = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConcreteQuality));
            }
        }

        private int selectedIndexExposureClass;
        public int SelectedIndexExposureClass
        {
            get => selectedIndexExposureClass;
            set
            {
                selectedIndexExposureClass = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexExposureClass));
            }
        }

        private int selectedIndexConsistenceTolerance;
        public int SelectedIndexConsistenceTolerance
        {
            get => selectedIndexConsistenceTolerance;
            set
            {
                selectedIndexConsistenceTolerance = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConsistenceTolerance));
            }
        }
        private int maximumGranulesSize;

        public int MaximumGranulesSize
        {
            get { return maximumGranulesSize; }
            set
            {
                maximumGranulesSize = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.MaximumGranulesSize));
            }
        }

        private string additionalInformation;
        public string AdditionalInformation
        {
            get => additionalInformation;
            set
            {
                additionalInformation = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.AdditionalInformation));
            }
        }

        private int concreteCover;
        public int ConcreteCover
        {
            get => concreteCover;
            set
            {
                concreteCover = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.ConcreteCover));
            }
        }
        public DataModelMaterials(string destinationName)
        {
            this.Name = destinationName;
            AdditionalInformation = "";
        }
    }
}
