﻿using System;
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
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage06;

namespace WindBarrierReinforcement
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page01 : Page
    {
        public DataModel_Global_Formwork DataModel_Global_Formwork { get; set; }
        public DataModel_Global_Coordinations_GroundPoint DataModel_Global_Coordinations_GroundPoint { get; set; }
        public DataModel_Global_Materials DataModel_Global_Materials { get; set; }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        public Page01()
        {
            DataModel_Global_Formwork = new DataModel_Global_Formwork();

            DataModel_Global_Coordinations_GroundPoint = new DataModel_Global_Coordinations_GroundPoint();
            DataModel_Global_Coordinations_GroundPoint.Update(DataModel_Global_Formwork.DeptFoundation, DataModel_Global_Formwork.HBottom);

            DataModel_Global_Materials = new DataModel_Global_Materials();

            DataModel_Global_Formwork.PropertyChanged += delegate (object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                if (e.PropertyName == "HBottom" || e.PropertyName == "DeptFoundation")
                {
                    //update
                    DataModel_Global_Coordinations_GroundPoint.Update(DataModel_Global_Formwork.DeptFoundation, DataModel_Global_Formwork.HBottom);
                    DataModel_Global_Coordinations_GroundPoint.NotifyPropertyChanged("FoundationPointZ");
                }
            };
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
