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
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindBarrierReinforcement.Common.Attributes;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage06;
using WindBarrierReinforcement.Resources;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class MenuPageProvider
    {
        public Page01 Page01 { get; private set; }
        public Page02 Page02 { get; private set; }
        public Page03 Page03 { get; private set; }
        public Page04 Page04 { get; private set; }
        public Page05 Page05 { get; private set; }
        public Page06 Page06 { get; private set; }
        public Page07 Page07 { get; private set; }
        public Page08 Page08 { get; private set; }
        public Page09 Page09 { get; private set; }
        public Page10 Page10 { get; private set; }
        public Page11 Page11 { get; private set; }
        public Page12 Page12 { get; private set; }

        public MenuPageProvider(GlobalDataModels global)
        {
            Page01 = new Page01(global);
            Page02 = new Page02(global);
            Page03 = new Page03(global);
            Page04 = new Page04(global);
            Page05 = new Page05(global);
            Page06 = new Page06(global);
            Page07 = new Page07(global);
            Page08 = new Page08(global);
            Page09 = new Page09(global);
            Page10 = new Page10(global);
            Page11 = new Page11(global);
            Page12 = new Page12(global);
        }
    }

    public partial class MainWindow : Window
    {
        public GlobalDataModels Global { get; private set; }

        public MenuPageProvider MenuPageProvider { get; private set; }

        public void InitializeMenuItemHeaders() {
            foreach (var item in UI_Menu.Items)
            {
                var menuItem = (MenuItem)item;
                object Tag = menuItem.Tag;
                if (Tag != null)
                {
                    string tag = Tag.ToString();
                    menuItem.Header = RManager.GetWord(tag);
                }
            }
        }
        public void InitializeMenuClicks() {
            foreach (var item in UI_Menu.Items)
            {
                var menuItem = (MenuItem)item;
                object Tag = menuItem.Tag;
                if (Tag != null)
                {
                    string tag = Tag.ToString();

                    Type MenuProviderType = typeof(MenuPageProvider);
                    PropertyInfo Page01PropertyInfo = MenuProviderType.GetProperty(tag, BindingFlags.Public | BindingFlags.Instance);
                    if (Page01PropertyInfo != null)
                    {
                        Page MyProperty = (Page)Page01PropertyInfo.GetValue(MenuPageProvider);

                        menuItem.Click += delegate (object sender, RoutedEventArgs e)
                        {
                            FrameMain.Content = MyProperty;
                        };
                    }
                }
            }
        }

        public MainWindow()
        {
            Global = new GlobalDataModels();

            MenuPageProvider = new MenuPageProvider(Global);
            Global.EvtHandler.CallPopulateDataAction();
            InitializeComponent();
            InitializeMenuClicks();
            InitializeMenuItemHeaders();
            //Writer.Writer.WriteTexts();
        }
      
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Writer.Writer.Save(Global);
        }
        private void  Open_Click(object sender, RoutedEventArgs e)
        {
            Writer.Writer.Open(Global);


        }
    }
}
