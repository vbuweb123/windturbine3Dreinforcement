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

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public static class MenuPageProvider
    {
        private static Page01 page01;
        private static Page02 page02;
        private static Page03 page03;
        private static Page04 page04;
        private static Page05 page05;
        private static Page06 page06;
        private static Page07 page07;
        private static Page08 page08;
        private static Page09 page09;
        private static Page10 page10;
        private static Page11 page11;
        private static Page12 page12;

        public static Page01 Page01 => page01 ?? (page01 = new Page01());
        public static Page02 Page02 => page02 ?? (page02 = new Page02());
        public static Page03 Page03 => page03 ?? (page03 = new Page03());
        public static Page04 Page04 => page04 ?? (page04 = new Page04());
        public static Page05 Page05 => page05 ?? (page05 = new Page05());
        public static Page06 Page06 => page06 ?? (page06 = new Page06());
        public static Page07 Page07 => page07 ?? (page07 = new Page07());
        public static Page08 Page08 => page08 ?? (page08 = new Page08());
        public static Page09 Page09 => page09 ?? (page09 = new Page09());
        public static Page10 Page10 => page10 ?? (page10 = new Page10());
        public static Page11 Page11 => page11 ?? (page11 = new Page11());
        public static Page12 Page12 => page12 ?? (page12 = new Page12());

    }
    public partial class MainWindow : Window
    {

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
                    PropertyInfo Page01PropertyInfo = MenuProviderType.GetProperty(tag, BindingFlags.Public | BindingFlags.Static);
                    if (Page01PropertyInfo != null)
                    {
                        Page MyProperty = (Page)Page01PropertyInfo.GetValue(MenuProviderType);

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
            InitializeComponent();
            InitializeMenuClicks();
            InitializeMenuItemHeaders();
            //Writer.Writer.WriteTexts();
        }
       
        //private void MenuItemOpenPage(object sender, RoutedEventArgs e)
        //{
        //    FrameMain.Content = MenuPageProvider.Page01;
        //}

        //private void ButtonClickP02(object sender, RoutedEventArgs e)
        //{
        //    FrameMain.Content = MenuPageProvider.Page02;
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Writer.Writer.WriteTexts();
        }
    }
}
