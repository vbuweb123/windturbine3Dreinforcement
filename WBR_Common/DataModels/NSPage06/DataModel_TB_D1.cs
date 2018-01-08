using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.Attributes;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.DataModels.NSPage01;
using WBR_Common.StaticModel;
using WBR_Common.Writer;

namespace WBR_Common.DataModels.NSPage06
{
    public class DataModel_TB_D1 : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        public List<String> OptionNames => EnumHelpers.GetEnumDisplayText(typeof(EOption));
        /// <summary>
        /// UI_ComboBox_UPBR_TB_Dir1_Diameter
        /// </summary>
        private int selectedIndexDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexDiameter")]
        public int SelectedIndexDiameter
        {
            get { return selectedIndexDiameter; }
            set
            {
                selectedIndexDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.SelectedIndexDiameter));
               
            }
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameter")]
        public int RebarDiameter => Calculator.GetNominalSize((EDiameters)SelectedIndexDiameter, this.global);

       
        /// <summary>
        /// UI_ComboBox_UPBR_TB_Dir1_Option
        /// </summary>
        private int selectedIndexOption;
        [SaveKeyCode(KeyCode = "SelectedIndexOption")]
        public int SelectedIndexOption
        {
            get { return selectedIndexOption; }
            set { selectedIndexOption = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.SelectedIndexOption));
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.CurrentOption)); }
        }

        [DynGet(DynKey = "CurrentOption")]
        public string CurrentOption => Calculator.GetOptionName((EOption)SelectedIndexOption);
        /// <summary>
        /// UI_TextBox_UPBR_TB_OffsetFromBottom
        /// </summary>
        private int offsetFromBottom;
        [SaveKeyCode(KeyCode = "OffsetFromBottom")]
        [DynGet(DynKey = "OffsetFromBottom")]
        public int OffsetFromBottom
        {
            get { return offsetFromBottom; }
            set
            {
                offsetFromBottom = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.OffsetFromBottom));
            }
        }

        /// <summary>
        /// UI_TextBox_UPBR_TB_RadiusOfRebars
        /// </summary>
        private int radiusOfRebars;
        [SaveKeyCode(KeyCode = "RadiusOfRebars")]
        [DynGet(DynKey = "RadiusOfRebars")]
        public int RadiusOfRebars
        {
            get { return radiusOfRebars; }
            set
            {
                radiusOfRebars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.RadiusOfRebars));
            }
        }

        /// <summary>
        /// UI_TextBox_UPBR_TB_MinLengthRebar
        /// </summary>
        private int minLengthRebar;
        [SaveKeyCode(KeyCode = "MinLengthRebar")]
        [DynGet(DynKey = "MinLengthRebar")]
        public int MinLengthRebar
        {
            get { return minLengthRebar; }
            set
            {
                minLengthRebar = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.MinLengthRebar));
            }
        }

        /// <summary>
        /// UI_TextBox_UPBR_TB_Dir1_NoOfBars
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
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.NoOfBars));
            }
        }


        /// <summary>
        /// UI_TextBox_UPBR_TB_Dir1_SpacingValue
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
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_TB_D1>(x => x.Spacing));
            }
        }
        private GlobalDataModels global;

        public DataModel_TB_D1(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.AddPostBuildEvents(() =>
            {
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) =>
                {
                    //Depth Pile
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HBottom))
                        Set_OffsetFromBottom();
                };
            });

            global.EvtHandler.AddPostEventsRegisterAction(() => {
                this.SelectedIndexDiameter = 0;
                this.SelectedIndexOption = 0;
            });                                 
        }

        private void Set_OffsetFromBottom()
        {
            OffsetFromBottom = 
                  global.GDMPage01.DataModel_Global_Formwork.HBottom
                + Calculator.GetNominalSize((EDiameters)global.GDMPage04.DataModelRadial1.SelectedIndexLargeDiameter, global)
                + Calculator.GetNominalSize((EDiameters)global.GDMPage04.DataModelRadial2.SelectedIndexLargeDiameter, global);
        }
    }
}
