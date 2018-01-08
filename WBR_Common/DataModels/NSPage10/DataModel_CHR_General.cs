using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage10
{
    public class DataModel_CHR_General : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int tangentialSpacing;
        [SaveKeyCode(KeyCode = "TangentialSpacing")]
        [DynGet(DynKey = "TangentialSpacing")]
        public int TangentialSpacing
        {
            get { return tangentialSpacing; }
            set
            {
                tangentialSpacing = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_General>(x => x.TangentialSpacing));
            }
        }

        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        [DynGet(DynKey = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_General>(x => x.SelectedIndexDiameter));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);

        private int hookLengths;
        //NO SAVE CODE REQUIRED
        [DynGet(DynKey = "HookLengths")]
        public int HookLengths
        {
            get => hookLengths;
            private set
            {
                hookLengths = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_General>(x => x.HookLengths));
            }
        }

        private bool chairsOverTopCirculars;
        [SaveKeyCode(KeyCode = "ChairsOverTopCirculars")]
        [DynGet(DynKey = "ChairsOverTopCirculars")]
        public bool ChairsOverTopCirculars
        {
            get { return chairsOverTopCirculars; }
            set
            {
                chairsOverTopCirculars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_General>(x => x.ChairsOverTopCirculars));
            }
        }

        private int topChairsOverlapp;
        [SaveKeyCode(KeyCode = "TopChairsOverlapp")]
        [DynGet(DynKey = "TopChairsOverlapp")]
        public int TopChairsOverlapp
        {
            get { return topChairsOverlapp; }
            set
            {
                topChairsOverlapp = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_CHR_General>(x => x.TopChairsOverlapp));
            }
        }

        private GlobalDataModels globalData;

        public DataModel_CHR_General(GlobalDataModels global)
        {
            this.globalData = global;

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_CHR_General>(x => x.SelectedIndexDiameter))
                    {
                        Set_HookLengths();
                    }
                };
            });
            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage12.DataModelShapesCollection.CollectionChanged += (o, e) =>
                {
                    Set_HookLengths();
                };
            });
            //Initializing
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
            });
        }

        private void Set_HookLengths()
        {
            EDiameters value = (EDiameters)SelectedIndexDiameter; //TODO - check this strict dependency to the index in the list. Maybe add in tag a reference?
            var BSShape = globalData.GDMPage12.DataModelShapesCollection.Where(x => x.Reference == value).SingleOrDefault();
            if (BSShape == null) HookLengths = -1;//NEED TO ADD THE VALUE IN GLOBAPL PAGE 12 in the list of BSShapes
            HookLengths = BSShape.NominalSize * (7 + 5);
        }
    }
}