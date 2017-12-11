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
        public DataModelUBABCollection DataModelUBABCollection => GlobalPageEvts.Global.GlobalPage09.DataModelUBABCollection;

        private string _zoneName = "Zona ";
        public Page09()
        {
            InitializeComponent();
            this.DataContext = this;

            AddNewNDataModel();
            SetGridDataContext(0);

            CultureRenamer.Rename(UI_Grid_Master);
        }

        private void AddNewNDataModel()
        {
            DataModelUBABCollection.Add(_zoneName);
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
            int Index = (int)btnSender.GetValue(TagProperty);

            SetGridDataContext(Index);
        }
    }
}
