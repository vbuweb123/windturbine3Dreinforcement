using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.DataModels.NSPage12;

namespace WindBarrierReinforcement.StaticModel
{
    public interface IGlobalDataModelsPage12
    {
        ObservableCollection<DataModelBSShapes> DataModelShapesCollection { get; }
        int GetNominalDiameterSize(int selectedIndex);
    }

    public partial class GlobalDataModels
    {
        private class _GlobalDataModelsPage12 : IGlobalDataModelsPage12
        {
            public ObservableCollection<DataModelBSShapes> DataModelShapesCollection { get; private set; }

            //TODO : Helper function to be made global
            public int GetNominalDiameterSize(int selectedIndex)
            {
                EDiameters ediameter = (EDiameters)selectedIndex; //TODO : Check this dependency on index
                DataModelBSShapes shape = DataModelShapesCollection.Where(x => x.Reference == ediameter).SingleOrDefault();
                if (shape == null) throw new Exception("Selected diameter is not found in the shape collection");
                return shape.NominalSize;
            }

            private void PopulateShapes()
            {
                // TODO : Get these from XML File
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D6,
                    NominalSize = 6,
                    MinRadiusForScheduling = 12,
                    MinDiameterOfBendingFormer = 24,
                    GeneralMin5d = 110,
                    LinksUnder150 = 110
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D8,
                    NominalSize = 8,
                    MinRadiusForScheduling = 16,
                    MinDiameterOfBendingFormer = 32,
                    GeneralMin5d = 115,
                    LinksUnder150 = 115
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D10,
                    NominalSize = 10,
                    MinRadiusForScheduling = 20,
                    MinDiameterOfBendingFormer = 40,
                    GeneralMin5d = 120,
                    LinksUnder150 = 130
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D12,
                    NominalSize = 12,
                    MinRadiusForScheduling = 24,
                    MinDiameterOfBendingFormer = 48,
                    GeneralMin5d = 125,
                    LinksUnder150 = 160
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D16,
                    NominalSize = 16,
                    MinRadiusForScheduling = 32,
                    MinDiameterOfBendingFormer = 64,
                    GeneralMin5d = 300,
                    LinksUnder150 = 210
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D18,
                    NominalSize = 18,
                    MinRadiusForScheduling = 36,
                    MinDiameterOfBendingFormer = 0,
                    GeneralMin5d = 0,
                    LinksUnder150 = 0
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D20,
                    NominalSize = 20,
                    MinRadiusForScheduling = 70,
                    MinDiameterOfBendingFormer = 140,
                    GeneralMin5d = 190,
                    LinksUnder150 = 290
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D25,
                    NominalSize = 25,
                    MinRadiusForScheduling = 87,
                    MinDiameterOfBendingFormer = 175,
                    GeneralMin5d = 240,
                    LinksUnder150 = 365
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D32,
                    NominalSize = 32,
                    MinRadiusForScheduling = 112,
                    MinDiameterOfBendingFormer = 224,
                    GeneralMin5d = 305,
                    LinksUnder150 = 465
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D40,
                    NominalSize = 40,
                    MinRadiusForScheduling = 140,
                    MinDiameterOfBendingFormer = 280,
                    GeneralMin5d = 380,
                    LinksUnder150 = 580
                });
                DataModelShapesCollection.Add(new DataModelBSShapes
                {
                    Reference = Common.Eng.EDiameters.D50,
                    NominalSize = 50,
                    MinRadiusForScheduling = 175,
                    MinDiameterOfBendingFormer = 350,
                    GeneralMin5d = 475,
                    LinksUnder150 = 725
                });
            }

            public _GlobalDataModelsPage12(GlobalDataModels global)
            {
                DataModelShapesCollection = new ObservableCollection<DataModelBSShapes>();
                PopulateShapes();
            }
        }
    }
}
