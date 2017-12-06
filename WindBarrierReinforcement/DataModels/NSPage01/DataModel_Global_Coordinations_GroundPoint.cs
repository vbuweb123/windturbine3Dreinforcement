using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;

namespace WindBarrierReinforcement.DataModels.NSPage01
{
    public class DataModel_Global_Coordinations_GroundPoint : DataModel
    {
        /// <summary>
        /// UI_TextBox_ARC_CenterPoint_X
        /// </summary>
        private int coordinationX;
        public int CoordinationX
        {
            get { return coordinationX; }
            set { coordinationX = value; NotifyPropertyChanged("CoordinationX"); }
        }

        /// <summary>
        /// UI_TextBox_ARC_CenterPoint_Y
        /// </summary>
        private int coordinationY;
        public int CoordinationY
        {
            get { return coordinationY; }
            set { coordinationY = value; NotifyPropertyChanged("CoordinationY"); }
        }
        /// <summary>
        /// UI_TextBox_ARC_CenterPoint_Z
        /// </summary>
        private int coordinationZ;
        public int CoordinationZ
        {
            get { return coordinationZ; }
            set { coordinationZ = value; NotifyPropertyChanged("CoordinationZ"); NotifyPropertyChanged("FoundationPointZ"); }
        }
        /// <summary>
        /// UI_TextBox_ARC_FoundationPoint_Z
        /// </summary>
        /// 
        public int FoundationPointZ
        {
            get => coordinationZ - _depthFoundation - _hBottom;
        }
        private int _depthFoundation;
        private int _hBottom;

        public DataModel_Global_Coordinations_GroundPoint()
        {

        }
        public void Update(int depthFoundation, int hBottom)
        {
            _depthFoundation = depthFoundation;
            _hBottom = hBottom;
        }               
    }
}
