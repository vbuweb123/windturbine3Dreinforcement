using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.DataModels.NSPage02;

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
            set { hFoundation = value; NotifyPropertyChanged("HFoundation"); NotifyPropertyChanged("DeptFoundation"); }
        }
        /// <summary>
        /// UI_TextBox_H_Foundation_Edge
        /// </summary>
        private int hFoundationEdge;
        public int HFoundationEdge
        {
            get { return hFoundationEdge; }
            set { hFoundationEdge = value; NotifyPropertyChanged("HFoundationEdge"); }
        }
        /// <summary>
        /// UI_TextBox_H_Tower_Base
        /// </summary>
        private int hTowerBase;
        public int HTowerBase
        {
            get { return hTowerBase; }
            set { hTowerBase = value; NotifyPropertyChanged("HTowerBase"); NotifyPropertyChanged("DeptFoundation"); }
        }
        /// <summary>
        /// UI_TextBox_H_Bottom"
        /// </summary>
        private int hBottom;
        public int HBottom
        {
            get { return hBottom; }
            set { hBottom = value; NotifyPropertyChanged("HBottom"); NotifyPropertyChanged("RadiusBtc"); }
        }
        /// <summary>
        /// UI_TextBox_Diameter_Foundation
        /// </summary>
        private int dFoundation;
        public int DFoundation
        {
            get { return dFoundation; }
            set { dFoundation = value; NotifyPropertyChanged("DFoundation"); }
        }
        /// <summary>
        /// UI_TextBox_Diameter_Tower_Base
        /// </summary>
        private int dTowerBase;
        public int DTowerBase
        {
            get { return dTowerBase; }
            set { dTowerBase = value; NotifyPropertyChanged("DTowerBase"); NotifyPropertyChanged("RadiusBtc"); }
        }
        /// <summary>
        /// UI_TextBox_Foundation_Bed
        /// </summary>
        private int foundationBed;
        public int FoundationBed
        {
            get { return foundationBed; }
            set { foundationBed = value; NotifyPropertyChanged("FoundationBed"); }
        }
        /// <summary>
        /// UI_TextBox_DiameterAnchor
        /// </summary>
        private int diameterAnchor;
        public int DiameterAnchor
        {
            get { return diameterAnchor; }
            set { diameterAnchor = value; NotifyPropertyChanged("DiameterAnchor"); }
        }
        /// <summary>
        /// UI_TextBox_Radius_Centerline_Tower
        /// </summary>
        private int radiusCenterlineTower;
        public int RadiusCenterlineTower
        {
            get => radiusCenterlineTower;
            set { radiusCenterlineTower = value; NotifyPropertyChanged("RadiusCenterlineTower"); }
        }
        /// <summary>
        /// UI_TextBox_Bottom_Cover
        /// </summary>
        private int bottomCover;
        public int BottomCover
        {
            get { return bottomCover; }
            set { bottomCover = value; NotifyPropertyChanged("BottomCover"); }
        }
        /// <summary>
        /// UI_TextBox_Top_Cover
        /// </summary>
        private int topCover;
        public int TopCover
        {
            get { return topCover; }
            set { topCover = value; NotifyPropertyChanged("TopCover"); }
        }

        /// <summary>
        /// UI_TextBox_Edge_Cover
        /// </summary>
        private int edgeCover;
        public int EdgeCover
        {
            get { return edgeCover; }
            set { edgeCover = value; NotifyPropertyChanged("EdgeCover"); }
        }
        /// <summary>
        /// UI_TextBox_Radius_Btc
        /// </summary>
        private int radiusBtc;
        public int RadiusBtc
        {
            get { return radiusBtc = dTowerBase/2 - hBottom; }
            set { radiusBtc = value; NotifyPropertyChanged("RadiusBtc"); }
        }     

        /// <summary>
        /// UI_TextBox_HeightAboveGround
        /// </summary>
        private int hightAboveGround;
        public int HightAboveGround
        {
            get { return hightAboveGround; }
            set { hightAboveGround = value; NotifyPropertyChanged("HightAboveGround"); NotifyPropertyChanged("DeptFoundation");
            }
        }
        /// <summary>
        /// UI_TextBox_Dept_Foundation
        /// </summary>
        private int deptFoundation;
        public int DeptFoundation
        {
            get { return deptFoundation = hFoundation + hTowerBase - hightAboveGround; }
            set { deptFoundation = value; NotifyPropertyChanged("DeptFoundation");  }
        }
    }
}
