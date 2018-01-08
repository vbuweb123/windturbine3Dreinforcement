using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Reflected;
using WBR_Common.DataModels.NSPage11;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage01
{
    public class DataModel_Global_Materials : DataModel
    {
        /// <summary>
        /// UI_TextBox_Material_Foundation
        /// </summary>
        private string materialFoundation;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "MaterialFoundation")]
        public string MaterialFoundation
        {
            get { return materialFoundation; }
            private set
            {
                materialFoundation = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Materials>(x => x.MaterialFoundation));
            }
        }
        /// <summary>
        /// UI_TextBox_Material_Foundation_Bed
        /// </summary>
        private string materialFoundationBed;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "MaterialFoundationBed")]
        public string MaterialFoundationBed
        {
            get { return materialFoundationBed; }
            private set
            {
                materialFoundationBed = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Materials>(x => x.MaterialFoundationBed));
            }
        }

        /// <summary>
        /// UI_TextBox_Material_Tower_Base
        /// </summary>
        private string materialTowerBase;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "MaterialTowerBase")]
        public string MaterialTowerBase
        {
            get { return materialTowerBase; }
            private set
            {
                materialTowerBase = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Materials>(x => x.MaterialTowerBase));
            }
        }
        
        private GlobalDataModels global;

        public DataModel_Global_Materials(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage11.DataModelMaterialsFoundation.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConcreteQuality))
                        Set_MaterialFoundation();                    
                };
            });
            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage11.DataModelMaterialsLeanConcrete.PropertyChanged += (o, e) =>
                {                  
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConcreteQuality))
                        Set_MaterialFoundationBed();
                };
            });

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage11.DataModelMaterialsFoundationTowerBase.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConcreteQuality))
                        Set_MaterialTowerBase();
                };
            });                         
        }
        
        private void Set_MaterialFoundation()
        {
            // int selectedIndex = this.global.GDMPage11.DataModelMaterialsFoundationPile.SelectedIndexConcreteQuality;

            MaterialFoundation = this.global.GDMPage11.DataModelMaterialsFoundation.ConcreteQualityNames[this.global.GDMPage11.DataModelMaterialsFoundation.SelectedIndexConcreteQuality];
        }

        private void Set_MaterialFoundationBed()
        {
            // int selectedIndex = this.global.GDMPage11.DataModelMaterialsFoundationPile.SelectedIndexConcreteQuality;

            MaterialFoundationBed = this.global.GDMPage11.DataModelMaterialsLeanConcrete.ConcreteQualityNames[this.global.GDMPage11.DataModelMaterialsLeanConcrete.SelectedIndexConcreteQuality];
        }

        private void Set_MaterialTowerBase()
        {
            // int selectedIndex = this.global.GDMPage11.DataModelMaterialsFoundationPile.SelectedIndexConcreteQuality;

            MaterialTowerBase = this.global.GDMPage11.DataModelMaterialsFoundationTowerBase.ConcreteQualityNames[this.global.GDMPage11.DataModelMaterialsFoundationTowerBase.SelectedIndexConcreteQuality];
        }
    }
}
