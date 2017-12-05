using System;
using System.Collections.Generic;
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
using WindBarrierReinforcement.DataModels.NSPage09;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page9.xaml
    /// </summary>
    public partial class Page09 : Page
    {
        public DataModelUBAB DataModelUBAB { get; set; }

        public Page09()
        {
            DataModelUBAB = new DataModelUBAB();
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabItem tabItemModel = (TabItem)UI_TabControl_DynamicZones.Items[0];
            //UI_TabControl_DynamicZones.Items.Add(tabItemModel);
            TabItem newTab = new TabItem();
            Grid templateGrid = (Grid)tabItemModel.Content;

            newTab.Header = "test";

            //create grid
            Grid grid = new Grid();
            grid.SetValue(BackgroundProperty, templateGrid.GetValue(BackgroundProperty));
            newTab.SetValue(ContentProperty, grid);

            foreach (FrameworkElement element in templateGrid.Children)
            {
                FrameworkElement newelement;

                switch (element)
                {
                    case Label labelElement:
                        newelement = new Label();
                        newelement.SetValue(FontSizeProperty, element.GetValue(FontSizeProperty));
                        newelement.SetValue(ContentProperty, element.GetValue(ContentProperty));
                        newelement.SetValue(HorizontalAlignmentProperty, element.GetValue(HorizontalAlignmentProperty));
                        newelement.SetValue(MarginProperty, element.GetValue(MarginProperty));
                        newelement.SetValue(VerticalAlignmentProperty, element.GetValue(VerticalAlignmentProperty));
                        grid.Children.Add(newelement);
                        break;
                }
                break;
                
            }
            //adding content to tab
            UI_TabControl_DynamicZones.Items.Add(newTab);
        }

    }
}
