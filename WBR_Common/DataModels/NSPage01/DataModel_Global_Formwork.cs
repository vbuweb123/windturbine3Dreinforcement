using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Reflected;
using WBR_Common.DataModels.NSPage02;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage01
{
    public class DataModel_Global_Formwork : DataModel
    {
        /// <summary>
        /// UI_TextBox_H_Foundation
        /// </summary>
        
        private int hFoundation;
        [SaveKeyCode(KeyCode = "HFoundation")]
        [DynGet(DynKey = "Hfoundation")]
        public int HFoundation
        {
            get { return hFoundation; }
            set
            {
                hFoundation = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HFoundation));
            }
        }
        /// <summary>
        /// UI_TextBox_H_Foundation_Edge
        /// </summary>
        private int hFoundationEdge;
        [SaveKeyCode(KeyCode = "HFoundationEdge")]
        [DynGet(DynKey = "HFoundationEdge")]
        public int HFoundationEdge
        {
            get { return hFoundationEdge; }
            set
            {
                hFoundationEdge = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HFoundationEdge));
            }
        }
        /// <summary>
        /// UI_TextBox_H_Tower_Base
        /// </summary>
        private int hTowerBase;
        [SaveKeyCode(KeyCode = "HTowerBase")]
        [DynGet(DynKey = "HTowerBase")]
        public int HTowerBase
        {
            get { return hTowerBase; }
            set
            {
                hTowerBase = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HTowerBase));
            }
        }
        /// <summary>
        /// UI_TextBox_H_Bottom"
        /// </summary>
        private int hBottom;
        [SaveKeyCode(KeyCode = "HBottom")]
        [DynGet(DynKey = "HBottom")]
        public int HBottom
        {
            get { return hBottom; }
            set
            {
                hBottom = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HBottom));
            }
        }
        /// <summary>
        /// UI_TextBox_Diameter_Foundation
        /// </summary>
        private int dFoundation;
        [SaveKeyCode(KeyCode = "DFoundation")]
        [DynGet(DynKey = "DFoundation")]
        public int DFoundation
        {
            get { return dFoundation; }
            set
            {
                dFoundation = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.DFoundation));
            }
        }
        /// <summary>
        /// UI_TextBox_Diameter_Tower_Base
        /// </summary>
        private int dTowerBase;
        [SaveKeyCode(KeyCode = "DTowerBase")]
        [DynGet(DynKey = "DTowerBase")]
        public int DTowerBase
        {
            get { return dTowerBase; }
            set
            {
                dTowerBase = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.DTowerBase));
            }
        }
        /// <summary>
        /// UI_TextBox_Foundation_Bed
        /// </summary>
        private int foundationBed;
        [SaveKeyCode(KeyCode = "FoundationBed")]
        [DynGet(DynKey = "FoundationBed")]
        public int FoundationBed
        {
            get { return foundationBed; }
            set
            {
                foundationBed = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.FoundationBed));
            }
        }

        private int radiusCenterlineTower;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "RadiusCenterLineTower")]
        public int RadiusCenterLineTower
        {
            get { return radiusCenterlineTower; }
            private set
            {
                radiusCenterlineTower = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.RadiusCenterLineTower));
            }

        }

        /// <summary>
        /// UI_TextBox_Bottom_Cover
        /// </summary>
        private int bottomCover;
        [SaveKeyCode(KeyCode = "BottomCover")]
        [DynGet(DynKey = "BottomCover")]
        public int BottomCover
        {
            get { return bottomCover; }
            set
            {
                bottomCover = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.BottomCover));
            }
        }
        /// <summary>
        /// UI_TextBox_Top_Cover
        /// </summary>
        private int topCover;
        [SaveKeyCode(KeyCode = "TopCover")]
        [DynGet(DynKey = "TopCover")]
        public int TopCover
        {
            get { return topCover; }
            set
            {
                topCover = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.TopCover));
            }
        }

        /// <summary>
        /// UI_TextBox_Edge_Cover
        /// </summary>
        private int edgeCover;
        [SaveKeyCode(KeyCode = "EdgeCover")]
        [DynGet(DynKey = "EdgeCover")]
        public int EdgeCover
        {
            get { return edgeCover; }
            set
            {
                edgeCover = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.EdgeCover));
            }
        }
        /// <summary>
        /// UI_TextBox_Radius_Btc
        /// </summary>
        private int radiusBtc;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "RadiusBtc")]
        public int RadiusBtc
        {
            get { return radiusBtc; }
            private set
            {
                radiusBtc = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.RadiusBtc));
            }
        }

        /// <summary>
        /// UI_TextBox_HeightAboveGround
        /// </summary>
        private int hightAboveGround;
        [SaveKeyCode(KeyCode = "HightAboveGround")]
        [DynGet(DynKey = "HightAboveGround")]
        public int HightAboveGround
        {
            get { return hightAboveGround; }
            set
            {
                hightAboveGround = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HightAboveGround));
            }
        }
        /// <summary>
        /// UI_TextBox_Dept_Foundation
        /// </summary>
        private int deptFoundation;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "DepthFoundation")]
        public int DeptFoundation
        {
            get { return deptFoundation; }
            private set
            {
                deptFoundation = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.DeptFoundation));
            }
        }
        private GlobalDataModels global;

        public DataModel_Global_Formwork(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    //Depth Foundation
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HFoundation)
                        || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HTowerBase)
                        || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HightAboveGround))
                        Set_DeptFoundation();
                    //Radius Btc
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.DTowerBase)
                    || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HBottom))
                        Set_RadiusBtc();
                };
            });

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage02.DataModel_Anchor.PropertyChanged += (o, e) =>
                {
                    //Radius Centerline Tower
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.RadiusCenterLineTower))
                        Set_RadiusCenterLineTower();
                };
            });
        }

        private void Set_DeptFoundation()
        {
            DeptFoundation = HFoundation + HTowerBase - HightAboveGround;
        }
        private void Set_RadiusBtc()
        {
            RadiusBtc = (int)Math.Round((double)DTowerBase / 2 - (double)HBottom, 0);
        }
        private void Set_RadiusCenterLineTower()
        {
            RadiusCenterLineTower = this.global.GDMPage02.DataModel_Anchor.RadiusCenterLineTower;
        }

      
    }
}
