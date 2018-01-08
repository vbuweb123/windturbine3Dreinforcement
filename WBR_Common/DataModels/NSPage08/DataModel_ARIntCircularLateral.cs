using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage08
{
    public class DataModel_ARIntCircularLateral : DataModel
    {
        /// <summary>
        /// Common Data
        /// </summary>
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));
        /// <summary>
        /// UI_ComboBox_AR_ICL_Diameter
        /// </summary>
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.SelectedIndexDiameter));
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.globalData);

        /// <summary>
        /// UI_ComboBox_AR_ICL_Option
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set
            {
                selectedIndexOption = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.CurrentOption));

            }
        }
        /// <summary>
        /// Will affect a trigger in the textbox that has SpacingEnabled Binded to it.
        /// The trigger itself is defined in XamlResources and added to textboxes
        /// </summary>
        [DynGet(DynKey = "CurrentOption")]
        public string CurrentOption => Calculator.GetOptionName((EOption)SelectedIndexOption);

        /// <summary>
        /// UI_TextBox_AR_ICL_Spacing
        /// </summary>
        private int spacing;
        [SaveKeyCode(KeyCode = "Spacing")]
        [DynGet(DynKey = "Spacing")]
        public int Spacing
        {
            get { return spacing; }
            set
            {
                spacing = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.Spacing));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_ICL_NoOfBars
        /// </summary>
        private int noOfBars;
        [SaveKeyCode(KeyCode = "NoOfBars")]
        [DynGet(DynKey = "NoOfBars")]
        public int NoOfBars
        {
            get { return noOfBars; }
            set
            {
                noOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.NoOfBars));
            }
        }
        /// <summary>
        /// UI_TextBox_AR_ECL_MinBarLength
        /// </summary>
        private int minbarLength;
        [SaveKeyCode(KeyCode = "MinBarLength")]
        [DynGet(DynKey = "MinBarLength")]
        public int MinBarLength
        {
            get { return minbarLength; }
            set
            {
                minbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.MinBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_MaxBarLength
        /// </summary>
        private int maxbarLength;
        [SaveKeyCode(KeyCode = "MaxBarLength")]
        [DynGet(DynKey = "MaxBarLength")]
        public int MaxBarLength
        {
            get { return maxbarLength; }
            set
            {
                maxbarLength = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.MaxBarLength));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_TopExtraOffset
        /// </summary>
        private int topExtraOffset;
        [SaveKeyCode(KeyCode = "TopExtraOffset")]
        [DynGet(DynKey = "TopExtraOffset")]
        public int TopExtraOffset
        {
            get { return topExtraOffset; }
            set
            {
                topExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.TopExtraOffset));
            }
        }

        /// <summary>
        /// UI_TextBox_AR_ECL_MaxBarLength
        /// </summary>
        private int bottomExtraOffset;
        [SaveKeyCode(KeyCode = "BottomExtraOffset")]
        [DynGet(DynKey = "BottomExtraOffset")]
        public int BottomExtraOffset
        {
            get { return bottomExtraOffset; }
            set
            {
                bottomExtraOffset = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ARIntCircularLateral>(x => x.BottomExtraOffset));
            }
        }

        private GlobalDataModels globalData { get; set; }

        public DataModel_ARIntCircularLateral(GlobalDataModels global)
        {
            this.globalData = global;

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
                this.SelectedIndexOption = 0;
            });
        }
    }
}
