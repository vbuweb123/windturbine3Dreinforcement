using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.Writer;

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
                GDMPage02.DataModel_Anchor.WidthConcreteBed = 250;
                GDMPage02.DataModel_Anchor.WidthTopFlange = 300;
                GDMPage02.DataModel_Anchor.ThicknessBottFlange = 90;
                GDMPage02.DataModel_Anchor.WidthBottFlange = 400;
                GDMPage02.DataModel_Anchor.BoltDiameter = 36;
                GDMPage02.DataModel_Anchor.NumberSuppports = 10;


            });
            evtHandler.RegisterAll(); // hide this method to the outside world to avoind caling it from other places
            evtHandler.CallPostEvtActions();
            evtHandler.PopulateData();
        }
    }
}
