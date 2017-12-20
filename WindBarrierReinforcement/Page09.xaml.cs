using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Primitives;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindBarrierReinforcement.Common.AttachedProperties;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.DataModels;
using WindBarrierReinforcement.DataModels.NSPage09;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page9.xaml
    /// </summary>
    public partial class Page09 : Page
    {
        public DataModelUBABCollection DataModelUBABCollection { get; private set; }

        private string _zoneName = "Zona ";
        private int SelectedIndex = -1;

        public Page09(GlobalDataModels global)
        {
            DataModelUBABCollection = global.GDMPage09.DataModelUBABCollection;

            InitializeComponent();
            this.DataContext = this;

            CultureRenamer.Rename(UI_Grid_Master);

            global.EvtHandler.AddPostBuildEvents(() => {
                AddNewNDataModel();
                SetGridDataContext(0);
            });

            global.EvtHandler.AddPostBuildEvents(() => {
                DataModelUBABCollection.Collection.CollectionChanged += (o, e) => {
                    foreach (var item in DataModelUBABCollection.Collection)
                    {
                        item.AddEvents();
                        item.Set_InteriorHalfLength();
                    }
                };
            });

            global.EvtHandler.AddPopulateDataAction(() =>
            {
                AddNewNDataModel();
                AddNewNDataModel();

                DataModelUBABCollection.Collection[0].ExteriorHalfLength = 1000;
                DataModelUBABCollection.Collection[0].SmallEdge = 170;
                DataModelUBABCollection.Collection[0].DistanceFromTop = 400;
                DataModelUBABCollection.Collection[0].FreeEdgeLength = 50;
                DataModelUBABCollection.Collection[0].SelectedIndexDiameter =
                Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D16.ToString());
                DataModelUBABCollection.Collection[1].ExteriorHalfLength = 1000;
                DataModelUBABCollection.Collection[1].SmallEdge = 170;
                DataModelUBABCollection.Collection[1].DistanceFromTop = 600;
                DataModelUBABCollection.Collection[1].FreeEdgeLength = 50;
                DataModelUBABCollection.Collection[1].SelectedIndexDiameter =
                Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D18.ToString());
                DataModelUBABCollection.Collection[2].ExteriorHalfLength = 1000;
                DataModelUBABCollection.Collection[2].SmallEdge = 170;
                DataModelUBABCollection.Collection[2].DistanceFromTop = 800;
                DataModelUBABCollection.Collection[2].FreeEdgeLength = 50;
                DataModelUBABCollection.Collection[2].SelectedIndexDiameter =
                Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D20.ToString());

            });
        }

        private void AddNewNDataModel()
        {
            DataModelUBABCollection.Add();
        }

        private void RemoveLastDataModel()
        {
            DataModelUBABCollection.RemoveLast();
        }
        private void SetGridDataContext(int index)
        {
            if (index > DataModelUBABCollection.Collection.Count - 1)
                throw new ArgumentOutOfRangeException();

            UI_Grid_DataModelContent.DataContext = DataModelUBABCollection[index];
        }
        /// <summary>
        /// Event = Add new zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ui_ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddNewNDataModel();
        }
        /// <summary>
        /// Event - remove last zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ui_ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            RemoveLastDataModel();
        }
        /// <summary>
        /// Event - Click on zone button. Change data context of grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ui_ToolBarBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btnSender = (Button)sender;
            SelectedIndex  = (int)btnSender.GetValue(TagProperty);

            SetGridDataContext(SelectedIndex);
        }
    }
}
