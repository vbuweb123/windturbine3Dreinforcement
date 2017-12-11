using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage10
{
    public class DataModel_CHR_General : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int tangentialSpacing;
        public int TangentialSpacing
        {
            get { return tangentialSpacing; }
            set { tangentialSpacing = value; NotifyPropertyChanged("TangentialSpacing"); }
        }

        private int selectedIndexDiameter;
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        private int hookLengths;
        public int HookLengths
        {
            get => hookLengths;
            private set {
                hookLengths = value;
                NotifyPropertyChanged("HookLengths");
            }
        }

        private bool chairsOverTopCirculars;
        public bool ChairsOverTopCirculars
        {
            get { return chairsOverTopCirculars; }
            set { chairsOverTopCirculars = value; NotifyPropertyChanged("ChairsOverTopCirculars"); }
        }

        private int topChairsOverlapp;
        public int TopChairsOverlapp
        {
            get { return topChairsOverlapp; }
            set { topChairsOverlapp = value; NotifyPropertyChanged("TopChairsOverlapp"); }
        }
        public DataModel_CHR_General()
        {
            this.PropertyChanged += DataModel_CHR_General_PropertyChanged;
            GlobalPage12.DataModelShapesCollection.CollectionChanged += DataModelShapesCollection_CollectionChanged;
        }

        private void DataModelShapesCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Set_HookLengths();
        }

        private void DataModel_CHR_General_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_CHR_General>(x => x.SelectedIndexDiameter))
            {
                Set_HookLengths();
            }
        }
        private void Set_HookLengths()
        {
            EDiameters value = (EDiameters)SelectedIndexDiameter; //TODO - check this strict dependency to the index in the list. Maybe add in tag a reference?
            var BSShape = GlobalPage12.DataModelShapesCollection.Where(x => x.Reference == value).SingleOrDefault();
            if (BSShape == null) HookLengths = - 1;//NEED TO ADD THE VALUE IN GLOBAPL PAGE 12 in the list of BSShapes
            HookLengths = BSShape.NominalSize * (7 + 5);
        }
    }
}