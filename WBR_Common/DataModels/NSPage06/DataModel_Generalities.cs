using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Reflected;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage06
{
    public class DataModel_Generalities : DataModel
    {
        /// <summary>
        /// UI_TextBox_UPBR_BottomCover
        /// </summary>       
        private int bottomCover;
        [SaveKeyCode(KeyCode = "BottomCover")]
        [DynGet(DynKey = "BottomCover")]
        public int BottomCover
        {
            get { return bottomCover; }
            set { bottomCover = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Generalities>(x => x.BottomCover)); }
        }
        /// <summary>
        /// UI_TextBox_UPBR_HorizontalEdgeCover
        /// </summary>       
        private int horizontalEdgeCover;
        [SaveKeyCode(KeyCode = "HorizontalEdgeCover")]
        [DynGet(DynKey = "HorizontalEdgeCover")]
        public int HorizontalEdgeCover
        {
            get { return horizontalEdgeCover; }
            set { horizontalEdgeCover = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Generalities>(x => x.HorizontalEdgeCover)); }
        }
    }
}
