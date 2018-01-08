using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage07
{
    public class DataModel_StraightBars : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));
        /// <summary>
        /// ComboBox - Option Types
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set
            {
                selectedIndexOption = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_StraightBars>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_StraightBars>(x => x.CurrentOption));
            }
        }

        [DynGet(DynKey = "CurrentOption")]
        public string CurrentOption => Calculator.GetOptionName((EOption)SelectedIndexOption);

        /// <summary>
        /// ComboBox - Diameter Types
        /// </summary>
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set { selectedIndexDiameter = value; NotifyPropertyChanged("SelectedIndexDiameter"); }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);

        /// <summary>
        /// Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        [DynGet(DynKey = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        /// <summary>
        /// NoOfBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        [DynGet(DynKey = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set { noOfBars = value; NotifyPropertyChanged("NoOfBars"); }
        }

        /// <summary>
        /// Lx
        /// </summary>
        private int lx;
        [SaveKeyCode(KeyCode = "Lx")]
        [DynGet(DynKey = "Lx")]
        public int Lx
        {
            get { return lx; }
            set { lx = value; NotifyPropertyChanged("Lx"); }
        }       
        /// <summary>
        /// Ly
        /// </summary>
        private int ly;
        [SaveKeyCode(KeyCode = "Ly")]
        [DynGet(DynKey = "Ly")]
        public int Ly
        {
            get { return ly; }
            set { ly = value; NotifyPropertyChanged("Ly"); }
        }        
        /// <summary>
        /// EdgeCover
        /// </summary>
        private int edgeCover;
        [SaveKeyCode(KeyCode = "EdgeCover")]
        [DynGet(DynKey = "EdgeCover")]
        public int EdgeCover
        {
            get { return edgeCover; }
            set { edgeCover = value; NotifyPropertyChanged("EdgeCover"); }
        }

        private GlobalDataModels globalData { get; set; }

        public DataModel_StraightBars(GlobalDataModels global)
        {
            this.globalData = global;
            //initializing
            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
                this.SelectedIndexOption = 0;
            });
        }
    }
}
