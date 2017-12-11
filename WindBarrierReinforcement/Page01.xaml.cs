using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.DataModels.NSPage06;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{

    /// <summary>
    /// Interaction logic for Page1.xaml a
    /// </summary>
    public partial class Page01 : Page
    {

        public DataModel_Global_Formwork DataModel_Global_Formwork
        {
            get => Global.DataModel_Global_Formwork;
            set => Global.DataModel_Global_Formwork = value;
        }
        public DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint
        {
            get => Global.DataModel_Global_Coordinations_GroundPoint;
            set => Global.DataModel_Global_Coordinations_GroundPoint = value;
        }
        public DataModel_Global_Materials DataModel_Global_Materials
        {
            get => Global.DataModel_Global_Materials;
            set => Global.DataModel_Global_Materials = value;
        }

        public Page01()
        {

            DataModel_Global_Coordinations_GroundPoint.Update(DataModel_Global_Formwork.DeptFoundation, DataModel_Global_Formwork.HBottom);

            DataModel_Global_Formwork.PropertyChanged += delegate (object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                if (e.PropertyName == "HBottom" || e.PropertyName == "DeptFoundation")
                {
                    //update
                    DataModel_Global_Coordinations_GroundPoint.Update(DataModel_Global_Formwork.DeptFoundation, DataModel_Global_Formwork.HBottom);
                    DataModel_Global_Coordinations_GroundPoint.NotifyPropertyChanged("FoundationPointZ");
                }
            };
            Global.DataModel_Anchor.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x=>x.RadiusCenterLineTower))
                {
                    DataModel_Global_Formwork.UpdateA(Global.DataModel_Anchor.RadiusCenterLineTower);
                }
            };

            InitializeComponent();

            this.DataContext = this;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureRenamer.Rename(UI_Grid_Master);
                     
        }

    }
}
