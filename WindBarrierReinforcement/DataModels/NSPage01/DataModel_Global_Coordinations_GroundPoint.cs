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
    }
}
