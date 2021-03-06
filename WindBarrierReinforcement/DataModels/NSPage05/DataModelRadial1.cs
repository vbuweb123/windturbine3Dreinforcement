﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;
using WindBarrierReinforcement.Writer;

namespace WindBarrierReinforcement.DataModels.NSPage05
{
    public class DataModelRadial1 : DataModel
    {
        public List<string> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        public List<string> HookTypesNames => EnumHelpers.GetEnumDisplayText(typeof(EHookTypes));

        /// <summary>
        /// 
        /// </summary>
        private int largeDiamNoOfBars;
        [SaveKeyCode(KeyCode = "LargeDiamNoOfBars")]
        public int LargeDiamNoOfBars
        {
            get { return largeDiamNoOfBars; }
            set
            {
                largeDiamNoOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.LargeDiamNoOfBars));
            }
        }

        private int selectedIndexLargeDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexLargeDiameter")]
        public int SelectedIndexLargeDiameter
        {
            get { return selectedIndexLargeDiameter; }
            set
            {
                selectedIndexLargeDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SelectedIndexLargeDiameter));
            }
        }

        private int smallDiamNoOfBars;
        [SaveKeyCode(KeyCode = "SmallDiamNoOfBars")]
        public int SmallDiamNoOfBars
        {
            get { return smallDiamNoOfBars; }
            set
            {
                smallDiamNoOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SmallDiamNoOfBars));
            }
        }

        private int selectedIndexSmallDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexSmallDiameter")]
        public int SelectedIndexSmallDiameter
        {
            get { return selectedIndexSmallDiameter; }
            set
            {
                selectedIndexSmallDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SelectedIndexSmallDiameter));
            }
        }

        private int thirdDiamNoOfBars;
        [SaveKeyCode(KeyCode = "ThirdDiamNoOfBars")]
        public int ThirdDiamNoOfBars
        {
            get { return thirdDiamNoOfBars; }
            set
            {
                thirdDiamNoOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.ThirdDiamNoOfBars));
            }
        }

        private int selectedIndexThirdDiameter;
        [SaveKeyCode(KeyCode = "SelectedIndexThirdDiameter")]
        public int SelectedIndexThirdDiameter
        {
            get { return selectedIndexThirdDiameter; }
            set
            {
                selectedIndexThirdDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SelectedIndexThirdDiameter));
            }
        }

        private int unreinforcedCore;
        [SaveKeyCode(KeyCode = "UnreinforcedCore")]
        public int UnreinforcedCore
        {
            get { return unreinforcedCore; }
            set
            {
                unreinforcedCore = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.UnreinforcedCore));
            }
        }

        private double spacingAngle;
        //NO SAVE CODE REQUIRED
        public double SpacingAngle
        {
            get { return spacingAngle; }
            private set
            {
                spacingAngle = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SpacingAngle));
            }
        }

        private int largeDiameterOffsetFromCenter;
        //NO SAVE CODE REQUIRED
        public int LargeDiameterOffsetFromCenter
        {
            get { return largeDiameterOffsetFromCenter; }
            private set
            {
                largeDiameterOffsetFromCenter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.LargeDiameterOffsetFromCenter));
            }
        }

        private double smallDiameterOffsetFromCenter;
        //NO SAVE CODE REQUIRED
        public double SmallDiameterOffsetFromCenter
        {
            get { return smallDiameterOffsetFromCenter; }
            private set
            {
                smallDiameterOffsetFromCenter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SmallDiameterOffsetFromCenter));
            }
        }

        private int thirdDiameterOffsetFromCenter;
        //NO SAVE CODE REQUIRED
        public int ThirdDiameterOffsetFromCenter
        {
            get { return thirdDiameterOffsetFromCenter; }
            private set { thirdDiameterOffsetFromCenter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.ThirdDiameterOffsetFromCenter)); }
        }

        private int selectedIndexHookType;
        [SaveKeyCode(KeyCode = "SelectedIndexHookType")]
        public int SelectedIndexHookType
        {
            get { return selectedIndexHookType; }
            set
            {
                selectedIndexHookType = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SelectedIndexHookType));
            }
        }

        private int overlappLargeDiameter;
        [SaveKeyCode(KeyCode = "OverlappLargeDiameter")]
        public int OverlappLargeDiameter
        {
            get { return overlappLargeDiameter; }
            set { overlappLargeDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.OverlappLargeDiameter)); }
        }

        private int overlappSmallDiameter;
        [SaveKeyCode(KeyCode = "OverlappSmallDiameter")]
        public int OverlappSmallDiameter
        {
            get { return overlappSmallDiameter; }
            set { overlappSmallDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.OverlappSmallDiameter)); }
        }

        private int overlapp3rdDiameter;
        [SaveKeyCode(KeyCode = "Overlapp3rdDiameter")]
        public int Overlapp3rdDiameter
        {
            get { return overlapp3rdDiameter; }
            set { overlapp3rdDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.Overlapp3rdDiameter)); }
        }

        private double spacing3rdDiameterAngle;
        //NO SAVE CODE REQUIRED
        public double Spacing3rdDiameterAngle
        {
            get { return spacing3rdDiameterAngle; }
            private set { spacing3rdDiameterAngle = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.Spacing3rdDiameterAngle)); }
        }

        private double startOffsetAngle;
        //NO SAVE CODE REQUIRED
        public double StartOffsetAngle
        {
            get { return startOffsetAngle; }
            set { startOffsetAngle = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.StartOffsetAngle)); }
        }

        private int maximumLength;
        [SaveKeyCode(KeyCode = "MaximumLength")]
        public int MaximumLength
        {
            get { return maximumLength; }
            set { maximumLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.MaximumLength)); }
        }

        private GlobalDataModels global;

        public DataModelRadial1(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.AddPostBuildEvents(() => {
                this.PropertyChanged += (o, e) =>
                {

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.LargeDiamNoOfBars))
                        Set_SpacingAngle();
                    // LargeDiameterOffsetFromCenter => Math.Max(UnreinforcedCore, GlobalPage04.DataModelRadialGeneral.MinCore);

                    //e ok
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.LargeDiamNoOfBars)
                    || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SmallDiamNoOfBars)
                    || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SpacingAngle))
                        Set_SmallDiameterOffsetFromCenter();

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.Spacing3rdDiameterAngle))
                        Set_ThirdDiameterOffsetFromCenter();

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.ThirdDiamNoOfBars))
                        Set_Spacing3rdDiameterAngle();

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SpacingAngle))
                        Set_StartOffsetAngle();
                };
            });

            global.EvtHandler.AddPostBuildEvents(() => {
                global.GDMPage04.DataModelRadialGeneral.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceField))
                        Set_ThirdDiameterOffsetFromCenter();
                };
            });
            global.EvtHandler.AddPostBuildEvents(() => {
                global.GDMPage04.DataModelRadial1.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.LargeDiameterOffsetFromCenter))
                        Set_LargeDiameterOffsetFromCenter();

                };
            });
            //e ok
            global.EvtHandler.AddPostBuildEvents(() => {
                global.GDMPage01.DataModel_Global_Formwork.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModels.NSPage01.DataModel_Global_Formwork>(x => x.DTowerBase))
                        Set_SmallDiameterOffsetFromCenter();
                };
            });
        }
        
       // private void Set_SmallDiameterOffsetFromCenter()
       // {
            //TODO: Change into a combobox in pgae2
            // SmallDiameterOffsetFromCenter = (int)Math.Round(Math.Ceiling((double)(global.GDMPage02.DataModel_Anchor.DiameterAnchor / 2 + 50 + global.GDMPage02.DataModel_Anchor.BoltDiameter/2)), 0);
           
            //if (((global.GDMPage01.DataModel_Global_Formwork.DTowerBase * Math.PI)/(LargeDiamNoOfBars + SmallDiamNoOfBars)) < 150)
            //{
            //    SmallDiameterOffsetFromCenter = global.GDMPage01.DataModel_Global_Formwork.DTowerBase / 2;
            //    var aaa = 1;
            //}             
            //else
            //SmallDiameterOffsetFromCenter = 75 + Math.Sin(SpacingAngle/2);
        //}

        private void Set_SmallDiameterOffsetFromCenter()
        {
            var raport = ((LargeDiamNoOfBars + SmallDiamNoOfBars) == 0) ? 0 : (global.GDMPage01.DataModel_Global_Formwork.DTowerBase * Math.PI) / (LargeDiamNoOfBars + SmallDiamNoOfBars);

            SmallDiameterOffsetFromCenter = (raport < 150) ?
                                            global.GDMPage01.DataModel_Global_Formwork.DTowerBase / 2 :
                                            75 + Math.Sin(SpacingAngle / 2);    
        }


        private void Set_SpacingAngle()
        {
            SpacingAngle = (LargeDiamNoOfBars == 0) ? 0 : (LargeDiamNoOfBars == 0) ? 0 : Math.Round((double)360 / LargeDiamNoOfBars, 2);
        }
        /// <summary>
        /// 
        /// </summary>
        private void Set_LargeDiameterOffsetFromCenter()
        {
            LargeDiameterOffsetFromCenter = global.GDMPage04.DataModelRadial1.LargeDiameterOffsetFromCenter;
        }
        private void Set_ThirdDiameterOffsetFromCenter()
        {
            ThirdDiameterOffsetFromCenter = (Spacing3rdDiameterAngle == 0) ? 0 :
                (int)(Math.Round(Math.Ceiling((double)global.GDMPage04.DataModelRadialGeneral.MinSpaceField / (0.5 * Spacing3rdDiameterAngle * Math.PI / 180)), 2));
        }
        private void Set_Spacing3rdDiameterAngle()
        {
            Spacing3rdDiameterAngle = (ThirdDiamNoOfBars == 0) ? 0 : (double)Math.Round((double)360 / ThirdDiamNoOfBars, 2);
        }
        private void Set_StartOffsetAngle()
        {
            StartOffsetAngle = Math.Round(SpacingAngle / 2,2);
        }
    }
}
