using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.Writer;
using WindBarrierReinforcement.Common.Eng;
namespace WindBarrierReinforcement.StaticModel
{
    public partial class GlobalDataModels
    {
        [SaveKeyCode(KeyCode = "GDMPage01", SaveDataType = SaveDataType.Navigation)]
        public IGlobalDataModelsPage01 GDMPage01 { get; private set; }

        public IGlobalDataModelsPage02 GDMPage02 { get; private set; }

        public IGlobalDataModelsPage03 GDMPage03 { get; private set; }

        public IGlobalDataModelsPage04 GDMPage04 { get; private set; }

        public IGlobalDataModelsPage05 GDMPage05 { get; private set; }

        public IGlobalDataModelsPage06 GDMPage06 { get; private set; }

        public IGlobalDataModelsPage07 GDMPage07 { get; private set; }

        public IGlobalDataModelsPage08 GDMPage08 { get; private set; }
        [SaveKeyCode(KeyCode = "GDMPage09", SaveDataType = SaveDataType.Navigation)]
        public IGlobalDataModelsPage09 GDMPage09 { get; private set; }

        public IGlobalDataModelsPage10 GDMPage10 { get; private set; }

        public IGlobalDataModelsPage11 GDMPage11 { get; private set; }

        public IGlobalDataModelsPage12 GDMPage12 { get; private set; }

        public IEvtStore EvtHandler { get; private set; }

        public GlobalDataModels()
        {
            var evtHandler = new _EvtHandler();

            EvtHandler = evtHandler;

            GDMPage01 = new _GlobalDataModelsPage01(this);
            GDMPage02 = new _GlobalDataModelsPage02(this);
            GDMPage03 = new _GlobalDataModelsPage03(this);
            GDMPage04 = new _GlobalDataModelsPage04(this);
            GDMPage05 = new _GlobalDataModelsPage05(this);
            GDMPage06 = new _GlobalDataModelsPage06(this);
            GDMPage07 = new _GlobalDataModelsPage07(this);
            GDMPage08 = new _GlobalDataModelsPage08(this);
            GDMPage09 = new _GlobalDataModelsPage09(this);
            GDMPage10 = new _GlobalDataModelsPage10(this);
            GDMPage11 = new _GlobalDataModelsPage11(this);
            GDMPage12 = new _GlobalDataModelsPage12(this);

            EvtHandler.AddPopulateDataAction(() => {

                //page 01

                GDMPage01.DataModel_Global_Formwork.HFoundation = 2000;
                GDMPage01.DataModel_Global_Formwork.HFoundationEdge = 1200;
                GDMPage01.DataModel_Global_Formwork.HTowerBase = 670;
                GDMPage01.DataModel_Global_Formwork.HBottom = 300;
                GDMPage01.DataModel_Global_Formwork.DFoundation = 18000;
                GDMPage01.DataModel_Global_Formwork.DTowerBase = 6250;
                GDMPage01.DataModel_Global_Formwork.FoundationBed = 100;
                GDMPage01.DataModel_Global_Formwork.BottomCover = 55;
                GDMPage01.DataModel_Global_Formwork.TopCover = 55;
                GDMPage01.DataModel_Global_Formwork.EdgeCover = 55;
                GDMPage01.DataModel_Global_Formwork.HightAboveGround = 200;
                GDMPage01.DataModel_Global_Coordinations_GroundPoint.CoordinationZ = 21950;

                //page02

                GDMPage02.DataModel_Anchor.DiameterAnchor = 4105;
                GDMPage02.DataModel_Anchor.DiameterAnchorInt = 3695;
                GDMPage02.DataModel_Anchor.NoOfBoltPairs = 80;
                GDMPage02.DataModel_Anchor.Peshrinkhoseheigth = 2615;
                GDMPage02.DataModel_Anchor.FilletTopZone = 260;
                GDMPage02.DataModel_Anchor.FilletBottomZone = 120;
                GDMPage02.DataModel_Anchor.TopAnchorNut = 210;
                GDMPage02.DataModel_Anchor.BottomAnchorNut = 50;
                GDMPage02.DataModel_Anchor.InsertionDepthTopFlange = 85;
                GDMPage02.DataModel_Anchor.ThicknessTopFlange = 90;
                GDMPage02.DataModel_Anchor.WidthConcreteBed = 496; //250
                GDMPage02.DataModel_Anchor.WidthTopFlange = 300;
                GDMPage02.DataModel_Anchor.DepthConcreteBed = 250;
                GDMPage02.DataModel_Anchor.ThicknessBottFlange = 90;
                GDMPage02.DataModel_Anchor.WidthBottFlange = 400;
                GDMPage02.DataModel_Anchor.BoltDiameter = 36;
                GDMPage02.DataModel_Anchor.NumberSuppports = 10;

                //page03

                GDMPage03.DataModel_ScrewPile.CircleDiameter = 16500;
                GDMPage03.DataModel_ScrewPile.NoPiles = 28;
                GDMPage03.DataModel_ScrewPile.PileDepth = -11200;
                GDMPage03.DataModel_ScrewPile.Slope = 0.125;
                GDMPage03.DataModel_ScrewPile.PR_BottomCover = 55;
                GDMPage03.DataModel_ScrewPile.PR_TopCover = 55;
                GDMPage03.DataModel_ScrewPile.PR_StirrupRadius_Layer1 = 200;
                GDMPage03.DataModel_ScrewPile.PR_Spacing_Layer1 = 300;
                GDMPage03.DataModel_ScrewPile.PR_StirrupRebarDiam_Layer1 = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage03.DataModel_ScrewPile.PR_NoOfLongRebars = 8;
                GDMPage03.DataModel_ScrewPile.PR_LongRebarDiam = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage03.DataModel_ScrewPile.PR_TopLongExtension = 890;
                GDMPage03.DataModel_ScrewPile.PR_Spacing_Layer2 = 300;
                GDMPage03.DataModel_ScrewPile.PR_StirrupRebarDiam_Layer2 = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage03.DataModel_ScrewPile.PR_Ureinforcement_RebarDiam = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());

                //page04

                //Radia 1
                GDMPage04.DataModelRadial1.LargeDiamNoOfBars = 80;
                GDMPage04.DataModelRadial1.SelectedIndexLargeDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage04.DataModelRadial1.SmallDiamNoOfBars = 80;
                GDMPage04.DataModelRadial1.SelectedIndexSmallDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage04.DataModelRadial1.ThirdDiamNoOfBars = 160;
                GDMPage04.DataModelRadial1.SelectedIndexThirdDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage04.DataModelRadial1.UnreinforcedCore = 750;
                GDMPage04.DataModelRadial1.OverlappLargeDiameter = 1200;
                GDMPage04.DataModelRadial1.OverlappSmallDiameter = 1200;
                GDMPage04.DataModelRadial1.Overlapp3rdDiameter = 900;
                GDMPage04.DataModelRadial1.MaximumLength = 12000;

                //Radial 2

                GDMPage04.DataModelRadial2.LargeDiamNoOfBars = 80;
                GDMPage04.DataModelRadial2.SelectedIndexLargeDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage04.DataModelRadial2.SmallDiamNoOfBars = 80;
                GDMPage04.DataModelRadial2.SelectedIndexSmallDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage04.DataModelRadial2.ThirdDiamNoOfBars = 160;
                GDMPage04.DataModelRadial2.SelectedIndexThirdDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage04.DataModelRadial2.UnreinforcedCore = 750;                
                GDMPage04.DataModelRadial2.MaximumLength = 12000;

                //Radial General
                GDMPage04.DataModelRadialGeneral.MinSpaceCenter = 50;
                GDMPage04.DataModelRadialGeneral.MinSpaceField = 100;

                //Circular General
                GDMPage04.DataModelCircularGeneral.OverlapLength = 1800;
                GDMPage04.DataModelCircularGeneral.MaximumRebarLength = 8500;
                GDMPage04.DataModelCircularGeneral.SelectedDiameterEdgeCirculars = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage04.DataModelCircularGeneral.SpacingEdgeCirculars = 200;


                //page05

                //Radia 1
                GDMPage05.DataModelRadial1.LargeDiamNoOfBars = 80;
                GDMPage05.DataModelRadial1.SelectedIndexLargeDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage05.DataModelRadial1.SmallDiamNoOfBars = 80;
                GDMPage05.DataModelRadial1.SelectedIndexSmallDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage05.DataModelRadial1.ThirdDiamNoOfBars = 160;
                GDMPage05.DataModelRadial1.SelectedIndexThirdDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                
                GDMPage05.DataModelRadial1.OverlappLargeDiameter = 1600;
                GDMPage05.DataModelRadial1.OverlappSmallDiameter = 1600;
                GDMPage05.DataModelRadial1.Overlapp3rdDiameter = 1200;
                GDMPage05.DataModelRadial1.MaximumLength = 12000;

                //Radial 2

                GDMPage05.DataModelRadial2.LargeDiamNoOfBars = 80;
                GDMPage05.DataModelRadial2.SelectedIndexLargeDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage05.DataModelRadial2.SmallDiamNoOfBars = 80;
                GDMPage05.DataModelRadial2.SelectedIndexSmallDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage05.DataModelRadial2.ThirdDiamNoOfBars = 160;
                GDMPage05.DataModelRadial2.SelectedIndexThirdDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage05.DataModelRadial2.MaximumLength = 12000;

                GDMPage05.DataModelRadialGeneral.MinSpaceCenter = 50;
                GDMPage05.DataModelRadialGeneral.MinSpaceField = 100;





                //page 06

                GDMPage06.DataModel_BR_D1.Spacing = 150;
                GDMPage06.DataModel_BR_D1.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D16.ToString());
                GDMPage06.DataModel_BR_D1.NoOfBars = 10;

                GDMPage06.DataModel_BR_D2.Spacing = 150;
                GDMPage06.DataModel_BR_D2.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D16.ToString());
                GDMPage06.DataModel_BR_D2.NoOfBars = 10;

                GDMPage06.DataModel_BR_L.Lx = 600;
                GDMPage06.DataModel_BR_L.Ly = 600;
                GDMPage06.DataModel_BR_L.L_BendAngle = 135;
                GDMPage06.DataModel_BR_L.L_RadialSpacing = 4.5;
                GDMPage06.DataModel_BR_L.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D16.ToString());
                GDMPage06.DataModel_BR_L.L_RadialSpacing = 4.5;

                GDMPage06.DataModel_TB_D1.RadiusOfRebars = 3000;
                GDMPage06.DataModel_TB_D1.MinLengthRebar = 500;
                GDMPage06.DataModel_TB_D1.Spacing = 100;
                GDMPage06.DataModel_TB_D1.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage06.DataModel_TB_D1.NoOfBars = 10;

                GDMPage06.DataModel_TB_D2.Spacing = 100;
                GDMPage06.DataModel_TB_D2.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage06.DataModel_TB_D2.NoOfBars = 10;

                GDMPage06.DataModel_Circular_EdgeOfL.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D16.ToString());
                GDMPage06.DataModel_Circular_EdgeOfL.NoOfBars = 4;
                GDMPage06.DataModel_Circular_EdgeOfL.Spacing = 150;
                GDMPage06.DataModel_Circular_EdgeOfL.MaxLength = 8000;
                GDMPage06.DataModel_Circular_EdgeOfL.OverlapLength = 1000;

                GDMPage06.DataModel_Generalities.BottomCover = 55;
                GDMPage06.DataModel_Generalities.HorizontalEdgeCover = 55;

                GDMPage07.DataModel_StraightBars_Dir1.Spacing = 100;
                GDMPage07.DataModel_StraightBars_Dir1.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage07.DataModel_StraightBars_Dir1.EdgeCover = 55;
                GDMPage07.DataModel_StraightBars_Dir1.NoOfBars = 10;
                GDMPage07.DataModel_StraightBars_Dir1.Lx = 750;
                GDMPage07.DataModel_StraightBars_Dir1.Ly = 750;               
                GDMPage07.DataModel_StraightBars_Dir2.Spacing = 100;
                GDMPage07.DataModel_StraightBars_Dir2.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage07.DataModel_StraightBars_Dir2.EdgeCover = 55;
                GDMPage07.DataModel_StraightBars_Dir2.NoOfBars = 10;
                GDMPage07.DataModel_StraightBars_Dir2.Lx = 750;
                GDMPage07.DataModel_StraightBars_Dir2.Ly = 750;

                GDMPage07.DataModel_StraightBars_Extra.TowerAxisTopOffset = 300;
                GDMPage07.DataModel_StraightBars_Extra.MinBarLength = 500;

                GDMPage07.DataModel_RadialEdgeConcrete.InteriorEdgeLength = 200;
                GDMPage07.DataModel_RadialEdgeConcrete.BottomEdgeLength = 1200;
                GDMPage07.DataModel_RadialEdgeConcrete.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage07.DataModel_RadialEdgeConcrete.TowerAxisCover = 200;
                GDMPage07.DataModel_RadialEdgeConcrete.TopCover = 55;
                GDMPage07.DataModel_RadialEdgeConcrete.BottomCover = 100;
                GDMPage07.DataModel_RadialEdgeConcrete.EdgeCover = 55;
                GDMPage07.DataModel_RadialEdgeConcrete.SpacingRadialDeg = 3;

                GDMPage07.DataModel_CircularBarsTop.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage07.DataModel_CircularBarsTop.NoOfBars = 7;
                GDMPage07.DataModel_CircularBarsTop.Spacing = 100;
                GDMPage07.DataModel_CircularBarsTop.MaxLength = 8000;
                GDMPage07.DataModel_CircularBarsTop.Overlap = 500;

                GDMPage07.DataModel_CircularBarsExteriorSide.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());
                GDMPage07.DataModel_CircularBarsExteriorSide.NoOfBars = 8;
                GDMPage07.DataModel_CircularBarsExteriorSide.Spacing = 100;
                GDMPage07.DataModel_CircularBarsExteriorSide.CustomLength = 1000;
                GDMPage07.DataModel_CircularBarsExteriorSide.Offset = 0;
                GDMPage07.DataModel_CircularBarsExteriorSide.MaxLength = 8000;
                GDMPage07.DataModel_CircularBarsExteriorSide.Overlap = 500;

                GDMPage08.DataModel_ARExtUBars.TopOffset = 150;
                GDMPage08.DataModel_ARExtUBars.BottomOffset = 100;
                GDMPage08.DataModel_ARExtUBars.AxisOffset = 100;
                GDMPage08.DataModel_ARExtUBars.SelectedIndexDiameterL = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D32.ToString());
                GDMPage08.DataModel_ARExtUBars.SelectedIndexDiameterS = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage08.DataModel_ARExtUBars.HookULarger = 200;
                GDMPage08.DataModel_ARExtUBars.HookUSmaller = 200;

                GDMPage08.DataModel_ARExteriorCircularTop.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D12.ToString());
                GDMPage08.DataModel_ARExteriorCircularTop.Spacing = 100;
                GDMPage08.DataModel_ARExteriorCircularTop.MinBarLength = 500;
                GDMPage08.DataModel_ARExteriorCircularTop.MaxBarLength = 8000;
                GDMPage08.DataModel_ARExteriorCircularTop.StartExtraOffset = 20;

                GDMPage08.DataModel_ARExteriorCircularLateral.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D12.ToString());
                GDMPage08.DataModel_ARExteriorCircularLateral.Spacing = 100;
                GDMPage08.DataModel_ARExteriorCircularLateral.NoOfBars = 10;
                GDMPage08.DataModel_ARExteriorCircularLateral.MinBarLength = 500;
                GDMPage08.DataModel_ARExteriorCircularLateral.MaxBarLength = 8000;
                GDMPage08.DataModel_ARExteriorCircularLateral.TopExtraOffset = 100;
                GDMPage08.DataModel_ARExteriorCircularLateral.BottomExtraOffset = 100;

                GDMPage08.DataModel_ARExteriorCircularBottom.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D12.ToString());
                GDMPage08.DataModel_ARExteriorCircularBottom.Spacing = 100;
                GDMPage08.DataModel_ARExteriorCircularBottom.MinBarLength = 500;
                GDMPage08.DataModel_ARExteriorCircularBottom.MaxBarLength = 8000;
                GDMPage08.DataModel_ARExteriorCircularBottom.StartExtraOffset = 20;

                GDMPage08.DataModel_ARIntCircularTop.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D12.ToString());
                GDMPage08.DataModel_ARIntCircularTop.Spacing = 100;
                GDMPage08.DataModel_ARIntCircularTop.SelectedIndexDiameter = 12;
                GDMPage08.DataModel_ARIntCircularTop.MinBarLength = 500;
                GDMPage08.DataModel_ARIntCircularTop.MaxBarLength = 8000;
                GDMPage08.DataModel_ARIntCircularTop.StartExtraOffset = 20;

                GDMPage08.DataModel_ARIntCircularLateral.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D12.ToString());
                GDMPage08.DataModel_ARIntCircularLateral.Spacing = 100;
                GDMPage08.DataModel_ARIntCircularLateral.NoOfBars = 10;
                GDMPage08.DataModel_ARIntCircularLateral.MinBarLength = 500;
                GDMPage08.DataModel_ARIntCircularLateral.MaxBarLength = 8000;
                GDMPage08.DataModel_ARIntCircularLateral.TopExtraOffset = 100;
                GDMPage08.DataModel_ARIntCircularLateral.BottomExtraOffset = 100;

                GDMPage08.DataModel_ARIntCircularBottom.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D12.ToString());
                GDMPage08.DataModel_ARIntCircularBottom.Spacing = 100;
                GDMPage08.DataModel_ARIntCircularBottom.MinBarLength = 500;
                GDMPage08.DataModel_ARIntCircularBottom.MaxBarLength = 8000;
                GDMPage08.DataModel_ARIntCircularBottom.StartExtraOffset = 20;

                GDMPage10.DataModel_CHR_General.TangentialSpacing = 500;
                GDMPage10.DataModel_CHR_General.SelectedIndexDiameter = Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                GDMPage10.DataModel_CHR_General.TopChairsOverlapp = 850;
                GDMPage10.DataModel_CHR_General.ChairsOverTopCirculars = true;

                GDMPage10.DataModel_CHR_Zones.SpacingValueRadial1 = 300;
                GDMPage10.DataModel_CHR_Zones.SpacingValueRadial2 = 500;
                GDMPage10.DataModel_CHR_Zones.ZoneLength1 = 2700;
                GDMPage10.DataModel_CHR_Zones.EdgeOffset1 = 300;
                GDMPage10.DataModel_CHR_Zones.EdgeOffset2 = 1000;
            });
            evtHandler.RegisterAll(); // hide this method to the outside world to avoind caling it from other places
            evtHandler.CallPostEvtActions();
            //evtHandler.PopulateData(); // called from MainWindows.cs because PopulateData maycontain functions defined in Pages. Pages are loaded after Global Has finished loading.
        }
    }
}
