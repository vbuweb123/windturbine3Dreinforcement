using System;
using System.Collections;
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
using WBR_Common.Common.Eng;
using WBR_Common.DataModels.NSPage04;
using WBR_Common.Resources;
using WBR_Common.StaticModel;

namespace WindBarrierReinforcement
{

    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    /// Important Functionality preserved. Minimum amount is 2. If count is 3, then second is deleted and data from 1 and 3 are kept and made 1 and 2
    /// Is count is 4 then data from 4 is move to 3 (end position) while 1 and 2 are not modified
    public partial class Page04 : Page
    {
        public DataModelCircularGeneral DataModelCircularGeneral { get; private set; }
        public DataModelRadial1 DataModelRadial1 { get; private set; }
        public DataModelRadial2 DataModelRadial2 { get; private set; }
        public DataModelRadialGeneral DataModelRadialGeneral { get; private set; }
        public DataModelCircular_ZoneCollection DataModelCircular_ZoneCollection { get; private set; }
        private Grid TemplateGrid;
        private GlobalDataModels globalDataModels;

        public Page04(GlobalDataModels global)
        {
            this.globalDataModels = global;

            DataModelCircularGeneral = global.GDMPage04.DataModelCircularGeneral;
            DataModelRadial1 = global.GDMPage04.DataModelRadial1;
            DataModelRadial2 = global.GDMPage04.DataModelRadial2;
            DataModelRadialGeneral = global.GDMPage04.DataModelRadialGeneral;
            DataModelCircular_ZoneCollection = global.GDMPage04.DataModelCircular_ZoneCollection;

            InitializeComponent();
            this.DataContext = this;

            TemplateGrid = CloneAndRemoveTemplateGrid();

            //if not set in AddPopulateDataAction it will not register 
            global.EvtHandler.AddPopulateDataAction(() =>
            {
                DataModelCircular_ZoneCollection.Zones.CollectionChanged += (o, e)
                =>
                {
                    RecalculateGridSetup();
                    EvaluateUIEnabled();
                };
            });


            CultureRenamer.Rename(UI_Grid_MasterGrid);


            global.EvtHandler.AddPopulateDataAction(() =>
            {
                Button_Click(null, null);
                Button_Click(null, null);

                DataModelCircular_ZoneCollection.Zones[0].SpacingValue = 200;
                DataModelCircular_ZoneCollection.Zones[0].SelectedIndexDiameter =
                Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());

                DataModelCircular_ZoneCollection.Zones[1].SpacingValue = 150;
                DataModelCircular_ZoneCollection.Zones[1].SelectedIndexDiameter =
                Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                DataModelCircular_ZoneCollection.Zones[1].RadiusGiven = 8250;

                DataModelCircular_ZoneCollection.Zones[2].SpacingValue = 125;
                DataModelCircular_ZoneCollection.Zones[2].SelectedIndexDiameter =
                Enum.GetNames(typeof(EDiameters)).ToList().IndexOf(EDiameters.D25.ToString());
                DataModelCircular_ZoneCollection.Zones[2].RadiusGiven = 6540;

                DataModelCircular_ZoneCollection.Zones[3].SpacingValue = 0;

            });
        }

        private TextBox CloneTextBox(TextBox textBox, bool enabled)
        {
            TextBox tb = new TextBox
            {
                HorizontalAlignment = textBox.HorizontalAlignment,
                VerticalAlignment = textBox.VerticalAlignment,
                TextWrapping = textBox.TextWrapping,
                Height = textBox.Height,
                Width = textBox.Width,
                Margin = textBox.Margin,
                Name = textBox.Name
            };
            tb.SetValue(TemplateProperty, textBox.GetValue(TemplateProperty));
            BindingExpression be = textBox.GetBindingExpression(TextBox.TextProperty);
            if (enabled == false)
            {
                tb.IsEnabled = false;

                Binding textBind = new Binding { Mode = BindingMode.OneWay, Path = be.ParentBinding.Path, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged };
                tb.SetBinding(TextBox.TextProperty, textBind);
            }
            else
            {
                tb.IsEnabled = true;
                Binding textBind = new Binding { Mode = BindingMode.TwoWay, Path = be.ParentBinding.Path, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged };
                tb.SetBinding(TextBox.TextProperty, textBind);
            }
            return tb;
        }

        private TextBlock CloneTextBlock(TextBlock textblock)
        {
            TextBlock tb = new TextBlock
            {
                HorizontalAlignment = textblock.HorizontalAlignment,
                VerticalAlignment = textblock.VerticalAlignment,
                TextWrapping = textblock.TextWrapping,
                Height = textblock.Height,
                Width = textblock.Width,
                Margin = textblock.Margin,
                Name = textblock.Name
            };

            BindingExpression be = textblock.GetBindingExpression(TextBlock.TextProperty);
            Binding bind = new Binding
            {
                Mode = be.ParentBinding.Mode,
                Path = be.ParentBinding.Path,
                UpdateSourceTrigger = be.ParentBinding.UpdateSourceTrigger
            };
            tb.IsEnabled = textblock.IsEnabled;
            tb.SetBinding(TextBlock.TextProperty, bind);

            return tb;
        }

        private ComboBox CloneComboBox(ComboBox comboBox, bool enabled)
        {
            ComboBox cb = new ComboBox
            {
                HorizontalAlignment = comboBox.HorizontalAlignment,
                VerticalAlignment = comboBox.VerticalAlignment,
                Height = comboBox.Height,
                Width = comboBox.Width,
                Margin = comboBox.Margin,
                Name = comboBox.Name
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
            if (!enabled) cb.IsEnabled = false;
            return cb;
        }

        private Grid CloneAndRemoveTemplateGrid()
        {
            IEnumerator enumerator = UI_Grid_ZonesContainer.Children.GetEnumerator();
            enumerator.MoveNext();

            Grid sourceGrid = (Grid)enumerator.Current;

            Grid grid = new Grid();

            foreach (var element in sourceGrid.Children)
            {
                if (element is TextBox)
                    grid.Children.Add(CloneTextBox((TextBox)element, true));
                if (element is ComboBox)
                    grid.Children.Add(CloneComboBox((ComboBox)element, true));
                if (element is TextBlock)
                    grid.Children.Add(CloneTextBlock((TextBlock)element));
            }
            UI_Grid_ZonesContainer.Children.RemoveAt(0);
            UI_Grid_ZonesContainer.ColumnDefinitions.RemoveAt(0);
            return grid;
        }

        private Grid CloneGrid(Grid Grid)
        {
            UIElementCollection collection = Grid.Children;
            Grid grid = new Grid();

            foreach (var element in collection)
            {
                if (element is TextBox)
                    grid.Children.Add(CloneTextBox((TextBox)element, true));
                if (element is ComboBox)
                    grid.Children.Add(CloneComboBox((ComboBox)element, true));
                if (element is TextBlock)
                    grid.Children.Add(CloneTextBlock((TextBlock)element));
            }
            return grid;
        }

        private void RecalculateGridSetup()
        {
            int gridCount = UI_Grid_ZonesContainer.Children.Count;
            int modelCount = DataModelCircular_ZoneCollection.Count;
            Grid Container = UI_Grid_ZonesContainer;
            //setting grid columns
            if (gridCount < modelCount)
            {
                int dif = modelCount - gridCount;
                for (var i = 0; i < dif; i++)
                {
                    ColumnDefinition columnDefinition = new ColumnDefinition();
                    Container.ColumnDefinitions.Add(columnDefinition);
                    var template = CloneGrid(TemplateGrid);
                    Container.Children.Add(template);
                }
            }
            else if (gridCount > modelCount)
            {
                int dif = gridCount - modelCount;
                for (var i = 0; i < dif; i++)
                {
                    Container.ColumnDefinitions.RemoveAt(Container.ColumnDefinitions.Count - 1);
                    Container.Children.RemoveAt(Container.Children.Count - 1);
                }
            }
            //setting data contexts and column definition pos
            for (var i = 0; i < Container.Children.Count; i++)
            {
                Grid current = (Grid)Container.Children[i];
                current.DataContext = DataModelCircular_ZoneCollection.Zones[i];
                current.SetValue(Grid.ColumnProperty, i);
            }
        }

        public void EvaluateUIEnabled()
        {
            for (var i = 0; i < UI_Grid_ZonesContainer.Children.Count; i++)
            {
                if (i == 0)
                {
                    Grid grid = (Grid)UI_Grid_ZonesContainer.Children[i];
                    foreach (FrameworkElement element in grid.Children)
                    {
                        switch (element.Name)
                        {
                            case "ZoneOfBars":
                                element.IsEnabled = false;
                                break;
                            case "SpacingValue":
                                element.IsEnabled = true;
                                break;
                            case "Diameter":
                                element.IsEnabled = true;
                                break;
                            case "ZoneLength":
                                element.IsEnabled = false;
                                break;
                            case "ZoneInterDistance":
                                element.IsEnabled = false;
                                break;
                            case "RadiusGiven":
                                element.IsEnabled = false;
                                break;
                            case "DistanceFromBottom":
                                element.IsEnabled = false;
                                break;
                            case "OffsetFromEdge":
                                element.IsEnabled = false;
                                break;
                            case "DistributionBars":
                                element.IsEnabled = true;
                                break;
                        }
                    }
                }
                else if (i == UI_Grid_ZonesContainer.Children.Count - 1)
                {
                    Grid grid = (Grid)UI_Grid_ZonesContainer.Children[i];
                    foreach (FrameworkElement element in grid.Children)
                    {
                        switch (element.Name)
                        {
                            case "DistributionBars":
                                element.IsEnabled = true;
                                break;
                            default:
                                element.IsEnabled = false;
                                break;
                        }
                    }
                }
                else
                {
                    Grid grid = (Grid)UI_Grid_ZonesContainer.Children[i];
                    foreach (FrameworkElement element in grid.Children)
                    {
                        switch (element.Name)
                        {
                            case "ZoneOfBars":
                                element.IsEnabled = false;
                                break;
                            case "SpacingValue":
                                element.IsEnabled = true;
                                break;
                            case "Diameter":
                                element.IsEnabled = true;
                                break;
                            case "ZoneLength":
                                element.IsEnabled = false;
                                break;
                            case "ZoneInterDistance":
                                element.IsEnabled = false;
                                break;
                            case "RadiusGiven":
                                element.IsEnabled = true;
                                break;
                            case "DistanceFromBottom":
                                element.IsEnabled = false;
                                break;
                            case "OffsetFromEdge":
                                element.IsEnabled = false;
                                break;
                            case "DistributionBars":
                                element.IsEnabled = true;
                                break;
                        }
                    }
                }
            }
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataModelCircular_ZoneCollection.Add();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            DataModelCircular_ZoneCollection.Remove();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string imageSource = "Assets/Images/BottomR_01.png";

            PictureInfo PictureInfo = new PictureInfo(imageSource);
            PictureInfo.Show();
        }
    }
}
