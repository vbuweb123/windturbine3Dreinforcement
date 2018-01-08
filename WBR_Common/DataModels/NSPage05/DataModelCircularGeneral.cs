using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBR_Common.Common.DataModel;
using WBR_Common.Common.Eng;
using WBR_Common.Common.Reflected;
using WBR_Common.Writer;
using WBR_Common.DataModels.NSPage01;
using WBR_Common.DataModels.NSPage02;
using WBR_Common.StaticModel;
using WBR_Common.Common.Attributes;

namespace WBR_Common.DataModels.NSPage05
{
    public class DataModelCircularGeneral : DataModel
    {
        public List<string> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int overlapLength;
        [SaveKeyCode(KeyCode = "OverlapLength")]
        [DynGet(DynKey = "OverlapLength")]
        public int OverlapLength
        {
            get { return overlapLength; }
            set { overlapLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.OverlapLength)); }
        }

        private int maximumRebarLength;
        [SaveKeyCode(KeyCode = "MaximumRebarLength")]
        [DynGet(DynKey = "MaximumRebarLength")]
        public int MaximumRebarLength
        {
            get { return maximumRebarLength; }
            set { maximumRebarLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.MaximumRebarLength)); }
        }

        private int selectedDiameterEdgeCirculars;
        [SaveKeyCode(KeyCode = "SelectedDiameterEdgeCirculars")]
        public int SelectedDiameterEdgeCirculars
        {
            get { return selectedDiameterEdgeCirculars; }
            set{ selectedDiameterEdgeCirculars = value;NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SelectedDiameterEdgeCirculars));}
        }

        //property for dynamo only
        [DynGet(DynKey = "RebarDiameterEdgeCirculars")]
        public int RebarDiameterEdgeCirculars => Calculator.GetNominalSize((EDiameters)SelectedDiameterEdgeCirculars, this.global);

        private int numberEdgeCirculars;
        [SaveKeyCode(KeyCode = "NumberEdgeCirculars")]
        [DynGet(DynKey = "NumberEdgeCirculars")]
        public int NumberEdgeCirculars
        {
            get { return numberEdgeCirculars; }
            set { numberEdgeCirculars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.NumberEdgeCirculars)); }
        }

        private int spacingEdgeCirculars;
        [SaveKeyCode(KeyCode = "SpacingEdgeCirculars")]
        [DynGet(DynKey = "SpacingEdgeCirculars")]
        public int SpacingEdgeCirculars
        {
            get { return spacingEdgeCirculars; }
            set { spacingEdgeCirculars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SpacingEdgeCirculars)); }
        }

        private int radiusCore;
        [SaveKeyCode(KeyCode = "RadiusCore")]
        [DynGet(DynKey = "RadiusCore")]
        public int RadiusCore
        {
            get { return radiusCore; }
            set { radiusCore = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.RadiusCore)); }
        }

        private GlobalDataModels global;

        public DataModelCircularGeneral(GlobalDataModels global)
        {
            this.global = global;
            global.EvtHandler.AddPostBuildEvents(() => {
                this.PropertyChanged += (o, e) => {

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SpacingEdgeCirculars))
                        Set_NumberEdgeCircular();
                };
            });

            global.EvtHandler.AddPostBuildEvents(() => {
                this.global.GDMPage02.DataModel_Anchor.PropertyChanged += (o, e) => {

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.RadiusCenterLineTower) ||
                    e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.WidthBottFlange))
                        Set_RadiusCore();
                };
            });

            global.EvtHandler.AddPostBuildEvents(() => {
                this.global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) => {

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.HFoundationEdge) ||
                    e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.BottomCover) ||
                    e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Formwork>(x => x.TopCover))
                        Set_NumberEdgeCircular();
                };
            });
        }

        private void Set_RadiusCore()
        {
            RadiusCore = global.GDMPage02.DataModel_Anchor.RadiusCenterLineTower - global.GDMPage02.DataModel_Anchor.WidthBottFlange;
        }
        private void Set_NumberEdgeCircular()
        {
            NumberEdgeCirculars = (SpacingEdgeCirculars == 0) ? 0 : (global.GDMPage01.DataModel_Global_Formwork.HFoundationEdge -
                                                                    global.GDMPage01.DataModel_Global_Formwork.BottomCover -
                                                                    global.GDMPage01.DataModel_Global_Formwork.TopCover)
                                                                    / SpacingEdgeCirculars;
        }


    }
}
