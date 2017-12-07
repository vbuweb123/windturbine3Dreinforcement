using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using WindBarrierReinforcement.Common.AttachedProperties;

namespace WindBarrierReinforcement.Resources
{
    public static class CultureRenamer
    {
        private static void InlineRenamer(InlineCollection collection)
        {
            foreach (var item in collection)
            {
                if (item is InlineUIContainer)
                {
                    InlineUiContainerRenamer((InlineUIContainer)item);
                }

            }
        }
        private static void InlineUiContainerRenamer(InlineUIContainer container)
        {
            switch (container.Child)
            {
                case Label labelChild:
                    RenameLabel(labelChild);
                    break;
            }
        }
        public static void RenameLabel(Label label)
        {
            if (label.HasContent)
                if (label.Content is Panel)
                {
                    RenameCollection(((Panel)label.Content).Children);
                }
                else
                {
                    object value = label.GetValue(CultureKey.CultureResKey);
                    if (value != null)
                    {
                        string replacement = RManager.GetCultureWord((string)value);
                        if (!string.IsNullOrEmpty(replacement))
                        {
                            label.Content = RManager.GetCultureWord((string)value);
                        }
                    }
                }
        }
        public static void RenameTextBlock(TextBlock textBlock)
        {
            if (textBlock.Inlines.Count > 0)
            {
                InlineRenamer(textBlock.Inlines);
            }
            object value = textBlock.GetValue(CultureKey.CultureResKey);

            if (value != null)
            {
                string replacement = RManager.GetCultureWord((string)value);
                if (!string.IsNullOrEmpty(replacement))
                {
                    textBlock.Text = replacement;
                }
            }

        }
        public static void RenameCollection(UIElementCollection Collection)
        {

            foreach (var child in Collection)
            {
                switch (child)
                {
                    case Label labelChild:
                        RenameLabel(labelChild);
                        break;
                    case TextBlock textBlockChild:
                        RenameTextBlock(textBlockChild);
                        break;
                }
            }
        }
    }
}
