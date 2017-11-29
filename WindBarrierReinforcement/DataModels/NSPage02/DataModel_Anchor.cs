using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;

namespace WindBarrierReinforcement.DataModels.NSPage02
{
    public class DataModel_Anchor : DataModel
    {

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
        /// UI_TextBox_DiameterAnchorINT
        /// </summary>
        private int diameterAnchorInt;
        public int DiameterAnchorInt
        {
            get { return diameterAnchorInt; }
            set { diameterAnchorInt = value; NotifyPropertyChanged("DiameterAnchorInt"); }
           
        }
        /// <summary>
        /// UI_TextBox_No_BoltPairs
        /// </summary>
        private int noOFBoltPairs;
        public int NoOfBoltPairs
        {
            get { return noOFBoltPairs; }
            set { noOFBoltPairs = value;NotifyPropertyChanged("NoOfBoltPairs"); }
        }
        /// <summary>
        /// UI_TextBox_PE_shrink_hose_heigths
        /// </summary>
        private int pe_shrink_hose_heigth;
        public int Peshrinkhoseheigth
        {
            get { return pe_shrink_hose_heigth; }
            set { pe_shrink_hose_heigth = value; NotifyPropertyChanged("Peshrinkhoseheigth"); }
        }
        /// <summary>
        /// UI_TextBox_FIlletTOP_ZONE
        /// </summary>
        private int filletTopZone;
        public int FilletTopZone
        {
            get { return filletTopZone; }
            set { filletTopZone = value; NotifyPropertyChanged("FilletTopZone"); }
        }
        /// <summary>
        /// UI_TextBox_FIlletBott_ZONE
        /// </summary>
        private int filletBottomZone;
        public int FilletBottomZone
        {
            get { return filletBottomZone; }
            set { filletBottomZone = value; NotifyPropertyChanged("FilletBottomZone"); }
        }
        /// <summary>
        /// UI_TextBox_TopAnchorNut
        /// </summary>
        private int topAnchorNut;
        public int TopAnchorNut
        {
            get { return topAnchorNut; }
            set { topAnchorNut = value; NotifyPropertyChanged("TopAnchorNut"); }
        }
        /// <summary>
        /// UI_TextBox_BottomAnchorNut
        private int bottomAnchorNut;
        public int BottomAnchorNut
        {
            get { return bottomAnchorNut; }
            set { bottomAnchorNut = value; NotifyPropertyChanged("BottomAnchorNut"); }
        }
        /// <summary>
        /// UI_TextBox_Depth_Anchor
        private int depthAnchor;
        public int DepthAnchor
        {
            get { return depthAnchor; }
            set { depthAnchor = value; NotifyPropertyChanged("DepthAnchor"); }
        }
        /// <summary>
        /// UI_TextBox_Depth_Anchor_Botttom
        private int depthAnchorBottom;
        public int DepthAnchorBottom
        {
            get { return depthAnchorBottom; }
            set { depthAnchorBottom = value; NotifyPropertyChanged("DepthAnchorBottom"); }
        }
        /// <summary>
        /// UI_TextBox_Radius_Centerline_Tower
        private int radiusCenterLineTower;
        public int RadiusCenterLineTower
        {
            get { return radiusCenterLineTower; }
            set { radiusCenterLineTower = value; NotifyPropertyChanged("RadiusCenterLineTower"); }
        }
        /// <summary>
        /// UI_TextBox_Insertion_Depth_Top_Flange
        private int insertionDepthTopFlange;
        public int InsertionDepthTopFlange
        {
            get { return insertionDepthTopFlange; }
            set { insertionDepthTopFlange = value; NotifyPropertyChanged("InsertionDepthTopFlange"); }
        }
        /// <summary>
        /// UI_TextBox_Thickness_Top_Flange
        private int thicknessTopFlange;
        public int ThicknessTopFlange
        {
            get { return thicknessTopFlange; }
            set { thicknessTopFlange = value; NotifyPropertyChanged("ThicknessTopFlange"); }
        }
        /// <summary>
        /// UI_TextBox_Width_Concrete_Bed
        private int widthConcreteBed;
        public int WidthConcreteBed
        {
            get { return widthConcreteBed; }
            set { widthConcreteBed = value; NotifyPropertyChanged("WidthConcreteBed"); }
        }       
        /// <summary>
        /// UI_TextBox_Width_Top_Flange
        private int widthTopFlange;
        public int WidthTopFlange
        {
            get { return widthTopFlange; }
            set { widthTopFlange = value; NotifyPropertyChanged("WidthTopFlange"); }
        }
        /// <summary>
        /// UI_TextBox_Depth_Conc_Bed
        private int depthConcreteBed;
        public int DepthConcreteBed
        {
            get { return depthConcreteBed; }
            set { depthConcreteBed = value; NotifyPropertyChanged("DepthConcreteBed"); }
        }
        /// <summary>
        /// UI_TextBox_DistanceBoltPair
        private int dispanceBoltPairs;
        public int DispanceBoltPairs
        {
            get { return dispanceBoltPairs; }
            set { dispanceBoltPairs = value; NotifyPropertyChanged("DispanceBoltPairs"); }
        }
        /// <summary>
        /// UI_TextBox_Thickness_Bott_Flange
        private int thicknessBottFlange;
        public int ThicknessBottFlange
        {
            get { return thicknessBottFlange; }
            set { thicknessBottFlange = value; NotifyPropertyChanged("ThicknessBottFlange"); }
        }
        /// <summary>
        /// UI_TextBox_Width_Bott_Flange
        private int widthBottFlange;
        public int WidthBottFlange
        {
            get { return widthBottFlange; }
            set { widthBottFlange = value; NotifyPropertyChanged("WidthBottFlange"); }
        }
        /// <summary>
        /// UI_TextBox_BoltDiameter
        private int boltDiameter;
        public int BoltDiameter
        {
            get { return boltDiameter; }
            set { boltDiameter = value; NotifyPropertyChanged("BoltDiameter"); }
        }
        /// <summary>
        /// UI_TextBox_MaterialGrout
        private int materialGrout;
        public int MaterialGrout
        {
            get { return materialGrout; }
            set { materialGrout = value; NotifyPropertyChanged("MaterialGrout"); }
        }
        /// <summary>
        /// UI_TextBox_NumberSuppports
        /// </summary>
        private int numberSuppports;
        public int NumberSuppports
        {
            get { return numberSuppports; }
            set { numberSuppports = value; NotifyPropertyChanged("NumberSuppports"); }
        }
        /// <summary>
        /// UI_TextBox_BoltLength
        /// </summary>
        private int boltLength;
        public int BoltLength
        {
            get { return boltLength; }
            set { boltLength = value; NotifyPropertyChanged("BoltLength"); }
        }
        /// <summary>
        /// UI_TextBox_OffsetBottFlange
        /// </summary>
        private int offsetBottFlange;
        public int OffsetBottFlange
        {
            get { return offsetBottFlange; }
            set { offsetBottFlange = value; NotifyPropertyChanged("OffsetBottFlange"); }
        }
    }
}
