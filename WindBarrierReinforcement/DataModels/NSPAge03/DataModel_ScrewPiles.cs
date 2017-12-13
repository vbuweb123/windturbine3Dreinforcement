using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindBarrierReinforcement.Common.DataModel;
using WindBarrierReinforcement.Common.Eng;
using WindBarrierReinforcement.Common.Reflected;
using WindBarrierReinforcement.DataModels.NSPage01;
using WindBarrierReinforcement.DataModels.NSPage11;
using WindBarrierReinforcement.StaticModel;

namespace WindBarrierReinforcement.DataModels.NSPAge03
{
    public  class DataModel_ScrewPiles : DataModel
    {
        public List<String> DiameterNames => EnumHelpers.GetEnumDisplayText(typeof(EDiameters));

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

        private string materialPiles;
        public string MaterialPiles
        {
            get { return materialPiles;  }
            private set
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
        /// <summary>
        /// PR_StirrupRadius_Layer1
        /// </summary>
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
        /// <summary>
        /// PR_Spacing_Layer1
        /// </summary>
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
        /// <summary>
        /// PR_StirrupRebarDiam_Layer1
        /// </summary>
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
        /// <summary>
        /// PR_NoOfLongRebars
        /// </summary>
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

        /// <summary>
        /// PR_LongRebarDiam
        /// </summary>
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

        /// <summary>
        /// PR_TopLongExtension
        /// </summary>
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

        /// <summary>
        /// PR_StirrupRadius_Layer2
        /// </summary>
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
        /// <summary>
        /// PR_Spacing_Layer2
        /// </summary>
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

        /// <summary>
        /// PR_StirrupRebarDiam_Layer2
        /// </summary>
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
        /// <summary>
        /// PR_Ureinforcement_RebarDiam
        /// </summary>
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
        private GlobalDataModels global;

        public DataModel_ScrewPiles(GlobalDataModels global)
        {
            this.global = global;            

            global.EvtHandler.Add(() => {
                this.PropertyChanged += (o, e) =>
                {
                    //Depth Pile
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_ScrewPiles>(x => x.PileDepth))
                        Set_DepthPile();                   
                };
            });

            global.EvtHandler.Add(() =>
            {
                global.GDMPage01.DataModel_Global_Coordinations_GroundPoint.PropertyChanged += (o, e) =>
                {
                    //Depth Pile
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModel_Global_Coordinations_GroundPoint>(x => x.FoundationPointZ))
                        Set_DepthPile();
                };
            });

            global.EvtHandler.Add(() =>
            {
                global.GDMPage11.DataModelMaterialsFoundationPile.PropertyChanged += (o, e) =>
                {
                    //Material Piles
                    if (e.PropertyName == Reflected.ObjGetLastPropertyName<DataModelMaterials>(x => x.SelectedIndexConcreteQuality))
                        Set_MaterialPiles();                    
                };
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.PR_StirrupRebarDiam_Layer1 = 0;               
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.PR_LongRebarDiam = 0;
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.PR_StirrupRadius_Layer2 = 0;
            });
            global.EvtHandler.AddPostEvtAction(() => {
                this.PR_Ureinforcement_RebarDiam = 0;
            });            
        }

        private void Set_DepthPile()
        {
            DepthPile = global.GDMPage01.DataModel_Global_Coordinations_GroundPoint.FoundationPointZ + PileDepth;
        }

        private void Set_PR_StirrupRadius_Layer2()
        {
            PR_StirrupRadius_Layer2 = PR_StirrupRadius_Layer1;
        }

        private void Set_MaterialPiles()
        {         
            MaterialPiles = this.global.GDMPage11.DataModelMaterialsFoundationPile.ConcreteQualityNames[this.global.GDMPage11.DataModelMaterialsFoundationPile.SelectedIndexConcreteQuality];
        }
    }
}
