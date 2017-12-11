using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WindBarrierReinforcement.DataModels.NSPage12;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        public ObservableCollection<DataModelBSShapes> DataModelShapesCollection { get; private set; }

        public Page12(GlobalDataModels global)
        {
            DataModelShapesCollection = global.GDMPage12.DataModelShapesCollection;

            InitializeComponent();
            this.DataContext = this;
        }
        
    }
}
