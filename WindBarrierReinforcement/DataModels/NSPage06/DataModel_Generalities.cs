using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;

namespace WindBarrierReinforcement.DataModels.NSPage06
{
    public class DataModel_Generalities : DataModel
    {
        /// <summary>
        /// UI_TextBox_UPBR_BottomCover
        /// </summary>       
        private int bottomCover;
        public int BottomCover
        {
            get { return bottomCover; }
            set { bottomCover = value; NotifyPropertyChanged("BottomCover"); }
        }
        /// <summary>
        /// UI_TextBox_UPBR_HorizontalEdgeCover
        /// </summary>       
        private int horizontalEdgeCover;
        public int HorizontalEdgeCover
        {
            get { return horizontalEdgeCover; }
            set { horizontalEdgeCover = value; NotifyPropertyChanged("HorizontalEdgeCover"); }
        }
    }
}
