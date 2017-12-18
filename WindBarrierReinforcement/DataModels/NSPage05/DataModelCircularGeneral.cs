﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage02;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage05
{
    public class DataModelCircularGeneral : DataModel
    {
        public List<string> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

        private int overlapLength;
        public int OverlapLength
        {
            get { return overlapLength; }
            set { overlapLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.OverlapLength)); }
        }

        private int maximumRebarLength;
        public int MaximumRebarLength
        {
            get { return maximumRebarLength; }
            set { maximumRebarLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.MaximumRebarLength)); }
        }

        private int selectedDiameterEdgeCirculars;
        public int SelectedDiameterEdgeCirculars
        {
            get { return selectedDiameterEdgeCirculars; }
            set{ selectedDiameterEdgeCirculars = value;NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SelectedDiameterEdgeCirculars));}
        }

        private int numberEdgeCirculars;
        public int NumberEdgeCirculars
        {
            get { return numberEdgeCirculars; }
            set { numberEdgeCirculars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.NumberEdgeCirculars)); }
        }

        private int spacingEdgeCirculars;
        public int SpacingEdgeCirculars
        {
            get { return spacingEdgeCirculars; }
            set { spacingEdgeCirculars = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SpacingEdgeCirculars)); }
        }

        private int radiusCore;
        public int RadiusCore
        {
            get { return radiusCore; }
            set { radiusCore = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.RadiusCore)); }
        }

        private GlobalDataModels global;

        public DataModelCircularGeneral(GlobalDataModels global)
        {
            this.global = global;
            global.EvtHandler.Add(() => {
                this.PropertyChanged += (o, e) => {

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelCircularGeneral>(x => x.SpacingEdgeCirculars))
                        Set_NumberEdgeCircular();
                };
            });

            global.EvtHandler.Add(() => {
                this.global.GDMPage02.DataModel_Anchor.PropertyChanged += (o, e) => {

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.RadiusCenterLineTower) ||
                    e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Anchor>(x => x.WidthBottFlange))
                        Set_RadiusCore();
                };
            });

            global.EvtHandler.Add(() => {
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
