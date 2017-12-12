using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.StaticModel;

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
            //B2
            get { return diameterAnchor; }
            set
            {
                diameterAnchor = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DiameterAnchor));
            }
        }

        /// <summary>
        /// UI_TextBox_DiameterAnchorINT
        /// </summary>
        private int diameterAnchorInt;
        public int DiameterAnchorInt
        {
            //B3
            get { return diameterAnchorInt; }
            set { diameterAnchorInt = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DiameterAnchorInt)); }
        }
        /// <summary>
        /// UI_TextBox_No_BoltPairs
        /// </summary>
        private int noOFBoltPairs;
        public int NoOfBoltPairs
        {

            get { return noOFBoltPairs; }
            set { noOFBoltPairs = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.NoOfBoltPairs)); }
        }
        /// <summary>
        /// UI_TextBox_PE_shrink_hose_heigths
        /// </summary>
        private int pe_shrink_hose_heigth;
        public int Peshrinkhoseheigth
        {
            get { return pe_shrink_hose_heigth; }
            set { pe_shrink_hose_heigth = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.Peshrinkhoseheigth)); }
        }
        /// <summary>
        /// UI_TextBox_FIlletTOP_ZONE
        /// </summary>
        private int filletTopZone;
        public int FilletTopZone
        {
            get { return filletTopZone; }
            set { filletTopZone = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.FilletTopZone)); }
        }
        /// <summary>
        /// UI_TextBox_FIlletBott_ZONE
        /// </summary>
        private int filletBottomZone;
        public int FilletBottomZone
        {
            get { return filletBottomZone; }
            set { filletBottomZone = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.FilletBottomZone)); }
        }
        /// <summary>
        /// UI_TextBox_TopAnchorNut
        /// </summary>
        private int topAnchorNut;
        public int TopAnchorNut
        {
            get { return topAnchorNut; }
            set { topAnchorNut = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.TopAnchorNut)); }
        }
        /// <summary>
        /// UI_TextBox_BottomAnchorNut
        private int bottomAnchorNut;
        public int BottomAnchorNut
        {
            get { return bottomAnchorNut; }
            set { bottomAnchorNut = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.BottomAnchorNut)); }
        }
        /// <summary>
        /// UI_TextBox_Depth_Anchor
        private int depthAnchor;
        public int DepthAnchor
        {
            get => depthAnchor;
            private set { depthAnchor = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DepthAnchor)); }
        }
        /// <summary>
        /// UI_TextBox_Depth_Anchor_Botttom
        private int depthAnchorBottom;
        public int DepthAnchorBottom
        {
            get => depthAnchorBottom;
            private set { depthAnchorBottom = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DepthAnchorBottom)); }
        }
        /// <summary>
        /// UI_TextBox_Radius_Centerline_Tower
        private int radiusCenterLineTower;
        public int RadiusCenterLineTower
        {
            get => radiusCenterLineTower;
            private set { radiusCenterLineTower = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.RadiusCenterLineTower)); }
        }
        /// <summary>
        /// UI_TextBox_Insertion_Depth_Top_Flange
        private int insertionDepthTopFlange;
        public int InsertionDepthTopFlange
        {
            get { return insertionDepthTopFlange; }
            set { insertionDepthTopFlange = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.InsertionDepthTopFlange)); }
        }
        /// <summary>
        /// UI_TextBox_Thickness_Top_Flange
        private int thicknessTopFlange;
        public int ThicknessTopFlange
        {
            get { return thicknessTopFlange; }
            set { thicknessTopFlange = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.ThicknessTopFlange)); }
        }
        /// <summary>
        /// UI_TextBox_Width_Concrete_Bed
        private int widthConcreteBed;
        public int WidthConcreteBed
        {
            get { return widthConcreteBed; }
            set { widthConcreteBed = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.WidthConcreteBed)); }
        }
        /// <summary>
        /// UI_TextBox_Width_Top_Flange
        private int widthTopFlange;
        public int WidthTopFlange
        {
            get { return widthTopFlange; }
            set { widthTopFlange = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.WidthTopFlange)); }
        }
        /// <summary>
        /// UI_TextBox_Depth_Conc_Bed
        private int depthConcreteBed;
        public int DepthConcreteBed
        {
            get { return depthConcreteBed; }
            set { depthConcreteBed = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DepthConcreteBed)); }
        }
        /// <summary>
        /// UI_TextBox_DistanceBoltPair
        private int dispanceBoltPairs;
        public int DispanceBoltPairs
        {   
            get { return dispanceBoltPairs; }
            private set { dispanceBoltPairs = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DispanceBoltPairs)); }
        }
        /// <summary>
        /// UI_TextBox_Thickness_Bott_Flange
        private int thicknessBottFlange;
        public int ThicknessBottFlange
        {
            get { return thicknessBottFlange; }
            set { thicknessBottFlange = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.ThicknessBottFlange)); }
        }
        /// <summary>
        /// UI_TextBox_Width_Bott_Flange
        private int widthBottFlange;
        public int WidthBottFlange
        {
            get { return widthBottFlange; }
            set { widthBottFlange = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.WidthBottFlange)); }
        }
        /// <summary>
        /// UI_TextBox_BoltDiameter
        private int boltDiameter;
        public int BoltDiameter
        {
            get { return boltDiameter; }
            set { boltDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.BoltDiameter)); }
        }
        /// <summary>
        /// UI_TextBox_MaterialGrout
        private string materialGrout;
        public string MaterialGrout
        {
            get { return materialGrout; }
            private set { materialGrout = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.MaterialGrout)); }
        }
        /// <summary>
        /// UI_TextBox_NumberSuppports
        /// </summary>
        private int numberSuppports;
        public int NumberSuppports
        {
            get { return numberSuppports; }
            set { numberSuppports = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.NumberSuppports)); }
        }
        /// <summary>
        /// UI_TextBox_BoltLength
        /// </summary>
        private int boltLength;
        public int BoltLength
        {
            get { return boltLength; }
            private set { boltLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.BoltLength)); }
        }

        /// <summary>
        /// UI_TextBox_OffsetBottFlange
        /// </summary>
        private int offsetBottFlange;
        public int OffsetBottFlange
        {
            get { return offsetBottFlange; }
            private set { offsetBottFlange = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.OffsetBottFlange)); }
        }
        private GlobalDataModels global;

        public DataModel_Anchor(GlobalDataModels global)
        {

            this.global = global;
            global.EvtHandler.Add(() => {
                this.PropertyChanged += (o, e) => {
                    //Depth Anchor
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.Peshrinkhoseheigth)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.FilletBottomZone)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.FilletTopZone)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.TopAnchorNut)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.BottomAnchorNut)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.ThicknessBottFlange))
                        Set_DepthAnchor();
                    //DepthAnchorBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.OffsetBottFlange))
                        Set_DepthAnchorBottom();
                    //RadiusCenterLineTower
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DiameterAnchor)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DispanceBoltPairs))
                        Set_RadiusCenterLineTower();
                    //DistanceBoltPairs
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DiameterAnchor)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DiameterAnchorInt))
                        Set_DistanceBoltPairs();
                    //BoltLength
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.ThicknessBottFlange)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DepthAnchor))
                        Set_BoltLength();
                    //OffsetBotFlange
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DepthAnchor))
                        Set_OffsetBotFlange();
                };
            });

            global.EvtHandler.Add(() => {
                this.global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) => {
                    //DepthAnchorBottom
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HBottom))
                        Set_DepthAnchorBottom();
                    //OffsetBotFlange
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HFoundation)
                         || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HTowerBase))
                        Set_OffsetBotFlange();
                };
            });

            global.EvtHandler.Add(() => {
                global.GDMPage11.DataModelMaterialsGrouting.PropertyChanged += (o, e) => {
                    //MaterialGrout
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModels.NSPage11.DataModelMaterials>(x => x.SelectedIndexConcreteQuality))
                        Set_MaterialGrout();
                };
            });
        }
        
        //helper function that encapsulates a functionality which may be further extended
        public int GetBoltDiameterNominalSize()
        {
            return BoltDiameter;
        }

        private void Set_DepthAnchor()
        {
            DepthAnchor = Peshrinkhoseheigth + FilletBottomZone + FilletTopZone - TopAnchorNut - BottomAnchorNut - ThicknessBottFlange;
        }
        private void Set_DepthAnchorBottom()
        {
            DepthAnchorBottom = global.GDMPage01.DataModel_Global_Formwork.HBottom + OffsetBottFlange;
        }
        private void Set_RadiusCenterLineTower()
        {
            RadiusCenterLineTower = DiameterAnchor / 2 - DispanceBoltPairs / 2;
        }
        private void Set_DistanceBoltPairs()
        {
            DispanceBoltPairs = (DiameterAnchor - DiameterAnchorInt) / 2;
        }
        private void Set_BoltLength()
        {
            BoltLength = ThicknessBottFlange + DepthAnchor;
        }
        private void Set_OffsetBotFlange()
        {
            OffsetBottFlange = global.GDMPage01.DataModel_Global_Formwork.HFoundation + global.GDMPage01.DataModel_Global_Formwork.HTowerBase - DepthAnchor;
        }
        private void Set_MaterialGrout()
        {
            MaterialGrout = global.GDMPage11.DataModelMaterialsGrouting.ConcreteQualityNames[global.GDMPage11.DataModelMaterialsGrouting.SelectedIndexConcreteQuality];
        }
    }
}
