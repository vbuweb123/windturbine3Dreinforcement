using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

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

        private int maximumGranulesSize;
        [SaveKeyCode(KeyCode = "MaximumGranulesSize")]
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

            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexConcreteQuality = 2;
            });

            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexExposureClass = 0;
            });
                   

            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexConsistenceTolerance = 0;
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.AdditionalInformation ="";
            });

        }
        
    }
}
