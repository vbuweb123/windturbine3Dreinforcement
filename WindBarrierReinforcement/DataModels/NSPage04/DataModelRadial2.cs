using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPage04
{
    public class DataModelRadial2 : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
        public List<string> HookTypesNames => EnumHelpers.GetEnumDisplayText(typeof(EHookTypes));

        /// <summary>
        /// 
        /// </summary>
        private int largeDiamNoOfBars;
        public int LargeDiamNoOfBars
        {
            get { return largeDiamNoOfBars; }
            set
            {
                largeDiamNoOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.LargeDiamNoOfBars));
            }
        }

        private int selectedIndexLargeDiameter;
        public int SelectedIndexLargeDiameter
        {
            get { return selectedIndexLargeDiameter; }
            set
            {
                selectedIndexLargeDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SelectedIndexLargeDiameter));
            }
        }

        private int smallDiamNoOfBars;
        public int SmallDiamNoOfBars
        {
            get { return smallDiamNoOfBars; }
            set
            {
                smallDiamNoOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SmallDiamNoOfBars));
            }
        }

        private int selectedIndexSmallDiameter;
        public int SelectedIndexSmallDiameter
        {
            get { return selectedIndexSmallDiameter; }
            set
            {
                selectedIndexSmallDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SelectedIndexSmallDiameter));
            }
        }

        private int thirdDiamNoOfBars;
        public int ThirdDiamNoOfBars
        {
            get { return thirdDiamNoOfBars; }
            set
            {
                thirdDiamNoOfBars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.ThirdDiamNoOfBars));
            }
        }

        private int selectedIndexThirdDiameter;
        public int SelectedIndexThirdDiameter
        {
            get { return selectedIndexThirdDiameter; }
            set
            {
                selectedIndexThirdDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SelectedIndexThirdDiameter));
            }
        }

        private int unreinforcedCore;
        public int UnreinforcedCore
        {
            get { return unreinforcedCore; }
            set
            {
                unreinforcedCore = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.UnreinforcedCore));
            }
        }

        private double spacingAngle;
        public double SpacingAngle
        {
            get { return spacingAngle; }
            private set
            {
                spacingAngle = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SpacingAngle));
            }
        }

        private int largeDiameterOffsetFromCenter;
        public int LargeDiameterOffsetFromCenter
        {
            get { return largeDiameterOffsetFromCenter; }
            private set
            {
                largeDiameterOffsetFromCenter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.LargeDiameterOffsetFromCenter));
            }
        }

        private int smallDiameterOffsetFromCenter;
        public int SmallDiameterOffsetFromCenter
        {
            get { return smallDiameterOffsetFromCenter; }
            private set
            {
                smallDiameterOffsetFromCenter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SmallDiameterOffsetFromCenter));
            }
        }

        private int thirdDiameterOffsetFromCenter;
        public int ThirdDiameterOffsetFromCenter
        {
            get { return thirdDiameterOffsetFromCenter; }
            private set { thirdDiameterOffsetFromCenter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.ThirdDiameterOffsetFromCenter)); }
        }

        private int selectedIndexHookType;
        public int SelectedIndexHookType
        {
            get { return selectedIndexHookType; }
            set
            {
                selectedIndexHookType = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.SelectedIndexHookType));
            }
        }

        private int overlappLargeDiameter;
        public int OverlappLargeDiameter
        {
            get { return overlappLargeDiameter; }
            private set { overlappLargeDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.OverlappLargeDiameter)); }
        }

        private int overlappSmallDiameter;
        public int OverlappSmallDiameter
        {
            get { return overlappSmallDiameter; }
            private set { overlappSmallDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.OverlappSmallDiameter)); }
        }

        private int overlapp3rdDiameter;
        public int Overlapp3rdDiameter
        {
            get { return overlapp3rdDiameter; }
            private set { overlapp3rdDiameter = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.Overlapp3rdDiameter)); }
        }

        private double spacing3rdDiameterAngle;
        public double Spacing3rdDiameterAngle
        {
            get { return spacing3rdDiameterAngle; }
            private set { spacing3rdDiameterAngle = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.Spacing3rdDiameterAngle)); }
        }

        private double startOffsetAngle;
        public double StartOffsetAngle
        {
            get { return startOffsetAngle; }
            private set { startOffsetAngle = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.StartOffsetAngle)); }
        }

        private int maximumLength;
        public int MaximumLength
        {
            get { return maximumLength; }
            set { maximumLength = value; NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.MaximumLength)); }
        }
        private GlobalDataModels global;

        public DataModelRadial2(GlobalDataModels global)
        {
            this.global = global;

            global.EvtHandler.Add(() =>
            {
                this.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.LargeDiamNoOfBars))
                        Set_SpacingAngle();
                    // LargeDiameterOffsetFromCenter => Math.Max(UnreinforcedCore, GlobalPage04.DataModelRadialGeneral.MinCore);
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial2>(x => x.UnreinforcedCore))
                        Set_LargeDiameterOffsetFromCenter();

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.Spacing3rdDiameterAngle))
                        Set_ThirdDiameterOffsetFromCenter();

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.ThirdDiamNoOfBars))
                        Set_Spacing3rdDiameterAngle();

                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.SpacingAngle))
                        Set_StartOffsetAngle();
                };
            });
            global.EvtHandler.Add(() =>
            {
                global.GDMPage04.DataModelRadialGeneral.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinCore))
                        Set_LargeDiameterOffsetFromCenter();
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadialGeneral>(x => x.MinSpaceField))
                        Set_ThirdDiameterOffsetFromCenter();
                };
            });
            global.EvtHandler.Add(() =>
            {
                global.GDMPage04.DataModelRadial1.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.OverlappLargeDiameter))
                        Set_OverlappLargeDiameter();
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.OverlappSmallDiameter))
                        Set_OverlappSmallDiameter();
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelRadial1>(x => x.Overlapp3rdDiameter))
                        Set_Overlapp3rdDiameter();
                };
            });
            global.EvtHandler.Add(() =>
            {
               global.GDMPage02.DataModel_Anchor.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModels.NSPage02.DataModel_Anchor>(x => x.DiameterAnchor)
                        || e.PropertyName == Reflected.ObjGetLastPropertyName<DataModels.NSPage02.DataModel_Anchor>(x => x.BoltDiameter))
                        Set_SmallDiameterOffsetFromCenter();
                };
            });
        }
        private void Set_SmallDiameterOffsetFromCenter()
        {
            //TODO: Change into a combobox in pgae2
            SmallDiameterOffsetFromCenter = (int)Math.Round(Math.Ceiling((double)(global.GDMPage02.DataModel_Anchor.DiameterAnchor / 2 + 50 +
                global.GDMPage02.DataModel_Anchor.BoltDiameter/2)), 0);
        }
        private void Set_SpacingAngle()
        {
            SpacingAngle = (LargeDiamNoOfBars == 0) ? 0 : (LargeDiamNoOfBars == 0) ? 0 : Math.Round((double)360 / LargeDiamNoOfBars, 2);
        }
        private void Set_LargeDiameterOffsetFromCenter()
        {
            LargeDiameterOffsetFromCenter = Math.Max(UnreinforcedCore, global.GDMPage04.DataModelRadialGeneral.MinCore);
        }
        private void Set_ThirdDiameterOffsetFromCenter()
        {
            ThirdDiameterOffsetFromCenter = (Spacing3rdDiameterAngle == 0) ? 0 :
                (int)(Math.Round(Math.Ceiling((double)global.GDMPage04.DataModelRadialGeneral.MinSpaceField / (0.5 * Spacing3rdDiameterAngle * Math.PI / 180)), 2));
        }
        private void Set_OverlappLargeDiameter()
        {
            OverlappLargeDiameter = global.GDMPage04.DataModelRadial1.OverlappLargeDiameter;
        }
        private void Set_OverlappSmallDiameter()
        {
            OverlappSmallDiameter = global.GDMPage04.DataModelRadial1.OverlappSmallDiameter;
        }
        private void Set_Overlapp3rdDiameter()
        {
            Overlapp3rdDiameter = global.GDMPage04.DataModelRadial1.Overlapp3rdDiameter;
        }
        private void Set_Spacing3rdDiameterAngle()
        {
            Spacing3rdDiameterAngle = (ThirdDiamNoOfBars == 0) ? 0 : (double)Math.Round((double)360 / ThirdDiamNoOfBars, 2);
        }
        private void Set_StartOffsetAngle()
        {
            StartOffsetAngle = Math.Round(SpacingAngle / 2, 2);
        }
    }
}
