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
using WindBarrierReinforcement.DataModels.NSPage10;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    public partial class Page10 : Page
    {
        public DataModel_CHR_General DataModel_CHR_General => GlobalPage10.DataModel_CHR_General;
        public DataModel_CHR_Zones DataModel_CHR_Zones => GlobalPage10.DataModel_CHR_Zones;

        public Page10()
        {
            this.DataContext = this;
            InitializeComponent();

            CultureRenamer.Rename(UI_Grid_Master);
        }
    }
}