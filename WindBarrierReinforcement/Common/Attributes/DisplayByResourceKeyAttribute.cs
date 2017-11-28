using WindBarrierReinforcement.Resources;

namespace WindBarrierReinforcement.Common.Attributes
{
    public class DisplayByResourceKeyAttribute : System.Attribute
    {
        public string ResourceKey { get; set; }

        public string GetResourceValue()
        {
            string displayText = RManager.GetWord(ResourceKey);
            if (displayText == null)
                throw new System.Exception("Invalid Resource Key");
            return displayText;
        }
    }

}
