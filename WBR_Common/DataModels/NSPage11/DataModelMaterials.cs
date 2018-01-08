using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage11
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
        [DynGet(DynKey = "Name")]
        public string Name { get; private set; }

        private int selectedIndexConcreteQuality;
        [SaveKeyCode(KeyCode = "SelectedIndexConcreteQuality")]
        public int SelectedIndexConcreteQuality
        {
            get => selectedIndexConcreteQuality;
            set
            {
                selectedIndexConcreteQuality = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConcreteQuality));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "ConcreteQuality")]
        public string DynConcreteQuality => Calculator.GetConcreteQualityName((EConcreteQuality)SelectedIndexConcreteQuality);

        private int selectedIndexExposureClass;
        [SaveKeyCode(KeyCode = "SelectedIndexExposureClass")]
        public int SelectedIndexExposureClass
        {
            get => selectedIndexExposureClass;
            set
            {
                selectedIndexExposureClass = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexExposureClass));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "ExposureClass")]
        public string DynExposureClass => Calculator.GetExposureName((EExposureClass)SelectedIndexExposureClass);

        private int selectedIndexConsistenceTolerance;
        [SaveKeyCode(KeyCode = "SelectedIndexConsistenceTolerance")]
        public int SelectedIndexConsistenceTolerance
        {
            get => selectedIndexConsistenceTolerance;
            set
            {
                selectedIndexConsistenceTolerance = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConsistenceTolerance));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "ConsistenceTolerance")]
        public string DynConsistenceTolerance => Calculator.GetConsistenceToleranceName((EConsistenceTolerance)SelectedIndexConsistenceTolerance);

        private int maximumGranulesSize;
        [SaveKeyCode(KeyCode = "MaximumGranulesSize")]
        [DynGet(DynKey = "MaximumGranulesSize")]
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
        [SaveKeyCode(KeyCode = "AdditionalInformation")]
        [DynGet(DynKey = "AdditionalInformation")]
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
        [SaveKeyCode(KeyCode = "ConcreteCover")]
        [DynGet(DynKey = "ConcreteCover")]
        public int ConcreteCover
        {
            get => concreteCover;
            set
            {
                concreteCover = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.ConcreteCover));
            }
        }
        public DataModelMaterials(GlobalDataModels global, string destinationName)
        {
            this.Name = destinationName;
            AdditionalInformation = "";

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexConcreteQuality = 2;
            });

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexExposureClass = 0;
            });
                   

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexConsistenceTolerance = 0;
            });
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.AdditionalInformation ="";
            });

        }
        
    }
}
