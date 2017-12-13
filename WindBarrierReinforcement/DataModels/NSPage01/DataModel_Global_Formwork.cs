using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage01
{
    public class DataModel_Global_Formwork : DataModel
    {
        /// <summary>
        /// UI_TextBox_H_Foundation
        /// </summary>
        private int hFoundation;
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
        public int FoundationBed
        {
            get { return foundationBed; }
            set
            {
                foundationBed = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.FoundationBed));
            }
        }
        /// <summary>
        /// UI_TextBox_DiameterAnchor
        /// </summary>
        private int diameterAnchor;
        public int DiameterAnchor
        {
            get { return diameterAnchor; }
            set
            {
                diameterAnchor = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.DiameterAnchor));
            }
        }
        /// <summary>
        /// UI_TextBox_Radius_Centerline_Tower
        /// </summary>

        private int radiusCenterlineTower;
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

            global.EvtHandler.Add(() =>
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

            global.EvtHandler.Add(() =>
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
            RadiusBtc = DTowerBase / 2 - HBottom;
        }
        private void Set_RadiusCenterLineTower()
        {
            RadiusCenterLineTower = this.global.GDMPage02.DataModel_Anchor.RadiusCenterLineTower;
        }
    }
}
