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
using WindBarrierReinforcement.DataModels.NSPage04;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page04 : Page
    {
        public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }
        public DataModelRadial1 DataModelRadial1 { get; private set; }
        public DataModelRadial2 DataModelRadial2 { get; private set; }
        public DataModelRadialGeneral DataModelRadialGeneral { get; private set; }
        public DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; private set;}

        public Page04(GlobalDataModels global)
        {
            DataModelCircularGeneral = global.GDMPage04.DataModelCircularGeneral;
            DataModelRadial1 = global.GDMPage04.DataModelRadial1;
            DataModelRadial2 = global.GDMPage04.DataModelRadial2;
            DataModelRadialGeneral = global.GDMPage04.DataModelRadialGeneral;
            DataModelCircular_ZoneCollection = global.GDMPage04.DataModelCircular_ZoneCollection;

            InitializeComponent();
            this.DataContext = this;

            SolveCollection();

            CultureRenamer.Rename(UI_Grid_MasterGrid);
        }

        private void SolveCollection()
        {
            UI_Grid_Col1.DataContext = DataModelCircular_ZoneCollection.Zones[0];
            UI_Grid_ColEnd.DataContext = DataModelCircular_ZoneCollection.Zones[DataModelCircular_ZoneCollection.Zones.Count - 1];
            //
            if (DataModelCircular_ZoneCollection.Zones.Count > 2)
            {
                for (var i = 1; i < DataModelCircular_ZoneCollection.Zones.Count - 1; i++)
                {
                    int zoneIndex = i ;
                    MoveEndGridForward(zoneIndex);
                   
                }
            }
        }

        private TextBox CloneTextBox(TextBox textBox)
        {
            TextBox tb = new TextBox
            {
                HorizontalAlignment = textBox.HorizontalAlignment,
                VerticalAlignment = textBox.VerticalAlignment,
                TextWrapping = textBox.TextWrapping,
                Height = textBox.Height,
                Width = textBox.Width,
                Margin = textBox.Margin
            };
            tb.SetValue(TemplateProperty, textBox.GetValue(TemplateProperty));
            if (textBox.Name == "Exception")
            {
                tb.IsEnabled = true;
                BindingExpression be = textBox.GetBindingExpression(TextBox.TextProperty);
                Binding textBind = new Binding { Mode = BindingMode.TwoWay, Path = be.ParentBinding.Path, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged };

                tb.SetBinding(TextBox.TextProperty, textBind);
            }
            else
            {
                BindingExpression be = textBox.GetBindingExpression(TextBox.TextProperty);
                Binding bind = new Binding
                {
                    Mode = be.ParentBinding.Mode,
                    Path = be.ParentBinding.Path,
                    UpdateSourceTrigger = be.ParentBinding.UpdateSourceTrigger
                };
                tb.IsEnabled = textBox.IsEnabled;
                tb.SetBinding(TextBox.TextProperty, bind);
            }
            return tb;
        }
        private TextBox CloneTextBlock(TextBlock textBox)
        {
            TextBox tb = new TextBox
            {
                HorizontalAlignment = textBox.HorizontalAlignment,
                VerticalAlignment = textBox.VerticalAlignment,
                TextWrapping = textBox.TextWrapping,
                Height = textBox.Height,
                Width = textBox.Width,
                Margin = textBox.Margin
            };
           
            BindingExpression be = textBox.GetBindingExpression(TextBlock.TextProperty);
            Binding bind = new Binding
            {
                Mode = be.ParentBinding.Mode,
                Path = be.ParentBinding.Path,
                UpdateSourceTrigger = be.ParentBinding.UpdateSourceTrigger
            };
            tb.IsEnabled = textBox.IsEnabled;
            tb.SetBinding(TextBox.TextProperty, bind);
            
            return tb;
        }

        private ComboBox CloneComboBox(ComboBox comboBox)
        {
            ComboBox cb = new ComboBox
            {
                HorizontalAlignment = comboBox.HorizontalAlignment,
                VerticalAlignment = comboBox.VerticalAlignment,
                Height = comboBox.Height,
                Width = comboBox.Width,
                Margin = comboBox.Margin
            };
            BindingExpression ItemsSourceExpr = comboBox.GetBindingExpression(ComboBox.ItemsSourceProperty);
            Binding bindItemsSource = new Binding
            {
                Mode = ItemsSourceExpr.ParentBinding.Mode,
                Path = ItemsSourceExpr.ParentBinding.Path,
                UpdateSourceTrigger = ItemsSourceExpr.ParentBinding.UpdateSourceTrigger
            };
            cb.SetBinding(ComboBox.ItemsSourceProperty, bindItemsSource);

            BindingExpression SelectedIndexExpr = comboBox.GetBindingExpression(ComboBox.SelectedIndexProperty);
            Binding SelectedIndexBind = new Binding
            {
                Mode = SelectedIndexExpr.ParentBinding.Mode,
                Path = SelectedIndexExpr.ParentBinding.Path,
                UpdateSourceTrigger = SelectedIndexExpr.ParentBinding.UpdateSourceTrigger
            };
            cb.SetBinding(ComboBox.SelectedIndexProperty, SelectedIndexBind);
            return cb;
        }

        private Grid CloneFirstGridChild()
        {
            UIElementCollection collection = UI_Grid_Col1.Children;
            Grid grid = new Grid();

            foreach (var element in collection)
            {
                if (element is TextBox)
                    grid.Children.Add(CloneTextBox((TextBox)element));
                if (element is ComboBox)
                    grid.Children.Add(CloneComboBox((ComboBox)element));
                if (element is TextBlock)
                    grid.Children.Add(CloneTextBlock((TextBlock)element));
            }
            return grid;
        }

        private void MoveEndGridForward(int zoneIndex)
        { 
            //first move the grid positioned there and create new Column Def
            ColumnDefinition columnDefinition = new ColumnDefinition { Width = new GridLength() };
            UI_Grid_CircularZones.ColumnDefinitions.Add(columnDefinition);

            UI_Grid_ColEnd.SetValue(Grid.ColumnProperty, UI_Grid_CircularZones.ColumnDefinitions.Count - 1);
            //now get last count
            int LastColumnDef = UI_Grid_CircularZones.ColumnDefinitions.Count - 1;
            //add before last
            Grid newGrid = CloneFirstGridChild();
            newGrid.SetValue(Grid.ColumnProperty, LastColumnDef - 1);

            UI_Grid_CircularZones.Children.Insert(LastColumnDef - 1, newGrid);

            //set up context for newly inserted item
            Grid currentGrid = (Grid)UI_Grid_CircularZones.Children[1 + zoneIndex];
            currentGrid.DataContext = DataModelCircular_ZoneCollection.Zones[zoneIndex];
            //reset context for last inserted item
            ((Grid)UI_Grid_CircularZones.Children[UI_Grid_CircularZones.Children.Count - 1]).DataContext = DataModelCircular_ZoneCollection.Zones[DataModelCircular_ZoneCollection.Zones.Count - 1];
        }

        private void MoveEndGridBackwards()
        {
            if (UI_Grid_CircularZones.Children.Count > 3)
            {
                UI_Grid_CircularZones.ColumnDefinitions.RemoveAt(UI_Grid_CircularZones.ColumnDefinitions.Count - 1);
                UI_Grid_CircularZones.Children.RemoveAt(UI_Grid_CircularZones.Children.Count - 2);
                UI_Grid_ColEnd.SetValue(Grid.ColumnProperty, UI_Grid_CircularZones.ColumnDefinitions.Count - 1);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //first move the grid positioned there and create new Column Def
            this.DataModelCircular_ZoneCollection.Add();
            int zoneIndex = this.DataModelCircular_ZoneCollection.Zones.Count - 2;//before last
           
            MoveEndGridForward(zoneIndex);
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            MoveEndGridBackwards();
        }
    }
}
