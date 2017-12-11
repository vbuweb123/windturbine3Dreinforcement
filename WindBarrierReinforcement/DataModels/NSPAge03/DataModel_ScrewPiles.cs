using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPAge03
{
    public  class DataModel_ScrewPiles : DataModel
    {
        public List<String> Diameter => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));
               
        private int circleDiameter;
        public int CircleDiameter
        {
            get { return circleDiameter; }
            set
            {
                circleDiameter = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.CircleDiameter));
            }
        }

        private int noPiles;
        public int NoPiles
        {
            get { return noPiles; }
            set
            {
                noPiles = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.NoPiles));
            }
        }

        private int divPerCurve;
        public int DivPerCurve
        {
            get { return divPerCurve; }
            set
            {
                divPerCurve = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.DivPerCurve));
            }
        }

        private double angle ;
        public double Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.Angle));
            }
        }

        private int pileDepth;
        public int PileDepth
        {
            get { return pileDepth; }
            set
            {
                pileDepth = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PileDepth));
            }
        }

        private string materialPiles = "C12/45-OB";
        public string MaterialPiles
        {
            get { return materialPiles; }
            set
            {
                materialPiles = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.MaterialPiles));
            }
        }

        private double slope;
        public double Slope
        {
            get { return slope; }
            set
            {
                slope = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.Slope));
            }
        }

        private int depthPile;
        public int DepthPile
        {
            get { return depthPile; }
            set
            {
                depthPile = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.DepthPile));
            }
        }

        private string forces;
        public string Forces
        {
            get { return forces; }
            set
            {
                forces = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.Forces));
            }
        }

        private int pr_BottomCover;
        public int PR_BottomCover
        {
            get { return pr_BottomCover; }
            set
            {
                pr_BottomCover = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_BottomCover));
            }
        }

        private int pr_TopCover;
        public int PR_TopCover
        {
            get { return pr_TopCover; }
            set
            {
                pr_TopCover = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_TopCover));
            }
        }

        private int pr_StirrupRadius_Layer1;
        public int PR_StirrupRadius_Layer1
        {
            get { return pr_StirrupRadius_Layer1; }
            set
            {
                pr_StirrupRadius_Layer1 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_StirrupRadius_Layer1));
            }
        }

        private int pr_Spacing_Layer1;
        public int PR_Spacing_Layer1
        {
            get { return pr_Spacing_Layer1; }
            set
            {
                pr_Spacing_Layer1 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_Spacing_Layer1));
            }
        }

        private int pR_StirrupRebarDiam_Layer1;
        public int PR_StirrupRebarDiam_Layer1
        {
            get { return pR_StirrupRebarDiam_Layer1; }
            set
            {
                pR_StirrupRebarDiam_Layer1 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_StirrupRebarDiam_Layer1));
            }
        }

        private int pr_NoOfLongRebars;
        public int PR_NoOfLongRebars
        {
            get { return pr_NoOfLongRebars; }
            set
            {
                pr_NoOfLongRebars = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_NoOfLongRebars));
            }
        }

        private int pR_LongRebarDiam;
        public int PR_LongRebarDiam
        {
            get { return pR_LongRebarDiam; }
            set
            {
                pR_LongRebarDiam = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_LongRebarDiam));
            }
        }
        
        private int pr_TopLongExtension;
        public int PR_TopLongExtension
        {
            get { return pr_TopLongExtension; }
            set
            {
                pr_TopLongExtension = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_TopLongExtension));
            }
        }


        private int pr_StirrupRadius_Layer2;
        public int PR_StirrupRadius_Layer2
        {
            get { return pr_StirrupRadius_Layer2; }
            set
            {
                pr_StirrupRadius_Layer2 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_StirrupRadius_Layer2));
            }
        }

        private int pr_Spacing_Layer2;
        public int PR_Spacing_Layer2
        {
            get { return pr_Spacing_Layer2; }
            set
            {
                pr_Spacing_Layer2 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_Spacing_Layer2));
            }
        }

        private int selectedIndexDiameter3;
        public int SelectedIndexDiameter3
        {
            get { return selectedIndexDiameter3; }
            set
            {
                selectedIndexDiameter3 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.SelectedIndexDiameter3));
            }
        }

        private int pR_StirrupRebarDiam_Layer2;
        public int PR_StirrupRebarDiam_Layer2
        {
            get { return pR_StirrupRebarDiam_Layer2; }
            set
            {
                pR_StirrupRebarDiam_Layer2 = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_StirrupRebarDiam_Layer2));
            }
        }

        private int pR_Ureinforcement_RebarDiam;
        public int PR_Ureinforcement_RebarDiam
        {
            get { return pR_Ureinforcement_RebarDiam; }
            set
            {
                pR_Ureinforcement_RebarDiam = value;
                NotifyPropertyChanged(Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PR_Ureinforcement_RebarDiam));
            }
        }

        public DataModel_ScrewPiles()
        {
            this.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PileDepth))
                    Set_DepthPile();
                if (true)
                {

                }
            };
            GlobalPage01.DataModel_Global_Coordinations_GroundPoint.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Coordinations_GroundPoint>(x => x.FoundationPointZ))
                    Set_DepthPile();
            };
        }

        private void Set_DepthPile()
        {
            DepthPile = GlobalPage01.DataModel_Global_Coordinations_GroundPoint.FoundationPointZ + PileDepth;
        }

        private void Set_PR_StirrupRadius_Layer2()
        {
            PR_StirrupRadius_Layer2 = PR_StirrupRadius_Layer1;
        }

    }
}
