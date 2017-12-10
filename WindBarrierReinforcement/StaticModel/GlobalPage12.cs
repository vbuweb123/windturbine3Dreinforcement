using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.DataModels.NSPage12;

namespace WindBarrierReinforcement.StaticModel
{
    public static class GlobalPage12
    {
        private static ObservableCollection<DataModelBSShapes> dataModelShapesCollection;
        public static ObservableCollection<DataModelBSShapes> DataModelShapesCollection
        {
            get
            {
                if (dataModelShapesCollection == null)
                {
                    dataModelShapesCollection = new ObservableCollection<DataModelBSShapes>();
                    PopulateShapes();
                    return dataModelShapesCollection;
                }
                return dataModelShapesCollection;
            }
        }
        private static void PopulateShapes()
        {
            // TODO : Get these from XML File
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 6,
                MinRadiusForScheduling = 12,
                MinDiameterOfBendingFormer = 24,
                GeneralMin5d = 110,
                LinksUnder150 = 110
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 8,
                MinRadiusForScheduling = 16,
                MinDiameterOfBendingFormer = 32,
                GeneralMin5d = 115,
                LinksUnder150 = 115
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 10,
                MinRadiusForScheduling = 20,
                MinDiameterOfBendingFormer = 40,
                GeneralMin5d = 120,
                LinksUnder150 = 130
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 12,
                MinRadiusForScheduling = 24,
                MinDiameterOfBendingFormer = 48,
                GeneralMin5d = 125,
                LinksUnder150 = 160
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 16,
                MinRadiusForScheduling = 32,
                MinDiameterOfBendingFormer = 64,
                GeneralMin5d = 300,
                LinksUnder150 = 210
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 18,
                MinRadiusForScheduling = 36,
                MinDiameterOfBendingFormer = 0,
                GeneralMin5d = 0,
                LinksUnder150 = 0
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 20,
                MinRadiusForScheduling = 70,
                MinDiameterOfBendingFormer = 140,
                GeneralMin5d = 190,
                LinksUnder150 = 290
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 25,
                MinRadiusForScheduling = 87,
                MinDiameterOfBendingFormer = 175,
                GeneralMin5d = 240,
                LinksUnder150 = 365
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 32,
                MinRadiusForScheduling = 112,
                MinDiameterOfBendingFormer = 224,
                GeneralMin5d = 305,
                LinksUnder150 = 465
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 40,
                MinRadiusForScheduling = 140,
                MinDiameterOfBendingFormer = 280,
                GeneralMin5d = 380,
                LinksUnder150 = 580
            });
            DataModelShapesCollection.Add(new DataModelBSShapes
            {
                NominalSize = 50,
                MinRadiusForScheduling = 175,
                MinDiameterOfBendingFormer = 350,
                GeneralMin5d = 475,
                LinksUnder150 = 725
            });
        }
    }
}
