using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage01
{
    public class DataModel_Global_Materials : DataModel
    {
        /// <summary>
        /// UI_TextBox_Material_Foundation
        /// </summary>
        private string materialFoundation = "C35/37-GB";
        public string MaterialFoundation
        {
            get { return materialFoundation; }
            set
            {
                materialFoundation = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Materials>(x => x.MaterialFoundation));
            }
        }
        /// <summary>
        /// UI_TextBox_Material_Foundation_Bed
        /// </summary>
        private string materialFoundationBed = "C12/15-OB";
        public string MaterialFoundationBed
        {
            get { return materialFoundationBed; }
            set
            {
                materialFoundationBed = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Materials>(x => x.MaterialFoundationBed));
            }
        }

        /// <summary>
        /// UI_TextBox_Material_Tower_Base
        /// </summary>
        private string materialTowerBase = "C45/55-GB";
        public string MaterialTowerBase
        {
            get { return materialTowerBase; }
            set
            {
                materialTowerBase = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Materials>(x => x.MaterialTowerBase));
            }
        }
        public DataModel_Global_Materials(EvtHandler evtHandler)
        {

        }
    }
}
