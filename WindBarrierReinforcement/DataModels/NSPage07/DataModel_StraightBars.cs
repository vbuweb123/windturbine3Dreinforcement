using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage07
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
       
        /// <summary>
        /// Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set { spacing = value; NotifyPropertyChanged("Spacing"); }
        }

        public string CurrentOption => (SelectedIndexOption == 0) ? Enum.GetName(typeof(EOption), EOption.NoOfBars) : Enum.GetName(typeof(EOption), EOption.Spacing);

        /// <summary>
        /// NoOfBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
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
        public int EdgeCover
        {
            get { return edgeCover; }
            set { edgeCover = value; NotifyPropertyChanged("EdgeCover"); }
        }

        public DataModel_StraightBars(GlobalDataModels global)
        {
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexDiameter = 0;
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.SelectedIndexOption = 0;
            });
        }
    }
}
