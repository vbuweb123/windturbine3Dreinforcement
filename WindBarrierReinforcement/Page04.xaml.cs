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
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.DataModels.NSPage04;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page04 : Page
    {
        public DataModel_BR_Radial1 Prop_DataModel_BR_Radial1
        {
            get => GlobalDataModelsPage04.DataModel_BR_Radial1;
            set => GlobalDataModelsPage04.DataModel_BR_Radial1 = value;
        }
        public DataModel_BR_Radial2 Prop_DataModel_BR_Radial2
        {
            get => GlobalDataModelsPage04.DataModel_BR_Radial2;
            set => GlobalDataModelsPage04.DataModel_BR_Radial2 = value;
        }
        //public DataModel_BR_Circular DataModel_BR_Circular
        //{
        //    get => Global..; set; }

        // public DataModel_BR_Circular DataModel_BR_Circular_abcd { get; set; }

        public Page04()
        {


            //DataModel_BR_Circular = new DataModel_BR_Circular();
            //GlobalDataModelsPage04.DataModel_BR_Radial1.PropertyChanged += delegate (object sender, System.ComponentModel.PropertyChangedEventArgs e)
            //{
            //    if (e.PropertyName == "OverlappLargeDiameter")
            //    {
            //        GlobalDataModelsPage04.DataModel_BR_Radial2.NotifyPropertyChanged("OverlappLargeDiameter");
            //    }
            //    if (e.PropertyName == "OverlappSmallDiameter")
            //    {
            //        GlobalDataModelsPage04.DataModel_BR_Radial2.NotifyPropertyChanged("OverlappSmallDiameter");
            //    }
            //    if (e.PropertyName == "3rdDiameterOffsetFromCenter")
            //    {
            //        GlobalDataModelsPage04.DataModel_BR_Radial2.NotifyPropertyChanged("3rdDiameterOffsetFromCenter");
            //    }
            //};

            //Global.DataModel_Anchor.PropertyChanged += (o, e) =>
            //{
            //    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.DiameterAnchor))
            //    {
            //        DataModel_BR_Radial2.UpdateSmallDiameterOFC(Global.DataModel_Anchor.DiameterAnchor);
            //    }
            //};
            InitializeComponent();
            this.DataContext = this;
        
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
