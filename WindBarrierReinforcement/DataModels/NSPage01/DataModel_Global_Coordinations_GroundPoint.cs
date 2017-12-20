using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage01
{
    public class DataModel_Global_Coordinations_GroundPoint : DataModel
    {
        /// <summary>
        /// UI_TextBox_ARC_CenterPoint_X
        /// </summary>
        private int coordinationX;
        [SaveKeyCode(KeyCode = "CoordinationX", SaveDataType = SaveDataType.Default)]
        public int CoordinationX
        {
            get { return coordinationX; }
            set { coordinationX = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Coordinations_GroundPoint>(x => x.CoordinationX)); }
        }

        /// <summary>
        /// UI_TextBox_ARC_CenterPoint_Y
        /// </summary>
        private int coordinationY;
        [SaveKeyCode(KeyCode = "CoordinationY", SaveDataType = SaveDataType.Default)]
        public int CoordinationY
        {
            get { return coordinationY; }
            set { coordinationY = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Coordinations_GroundPoint>(x => x.CoordinationY)); }
        }
        /// <summary>
        /// UI_TextBox_ARC_CenterPoint_Z
        /// </summary>
        private int coordinationZ;
        [SaveKeyCode(KeyCode = "CoordinationZ", SaveDataType = SaveDataType.Default)]
        public int CoordinationZ
        {
            get { return coordinationZ; }
            set { coordinationZ = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Coordinations_GroundPoint>(x => x.CoordinationZ)); }
        }
        /// <summary>
        /// UI_TextBox_ARC_FoundationPoint_Z
        /// </summary>
        /// 
        private int foundationPointZ;
        //NO SAVE CODE REQUIRED
        public int FoundationPointZ
        {
            get { return foundationPointZ; }
            private set
            {
                foundationPointZ = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Coordinations_GroundPoint>(x => x.FoundationPointZ));
            }
        }
        private GlobalDataModels global;

        public DataModel_Global_Coordinations_GroundPoint(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.AddPostBuildEvents(() => {
                this.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Coordinations_GroundPoint>(x => x.CoordinationZ))
                        Set_FoundationPointZ();
                };
            });
            global.EvtHandler.AddPostBuildEvents(() => {
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.DeptFoundation)
                        || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HBottom))
                        Set_FoundationPointZ();
                };
            });
        }
              
        private void Set_FoundationPointZ()
        {
            FoundationPointZ = CoordinationZ - this.global.GDMPage01.DataModel_Global_Formwork.DeptFoundation - this.global.GDMPage01.DataModel_Global_Formwork.HBottom;
        }
    }
}
