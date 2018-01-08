using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using WBR_Common.Common.AttachedProperties;

namespace WBR_Common.Resources
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
            if (container.Child is UIElement)
                Rename((UIElement)container.Child);
        }

        private static void RenameLabel(Label label)
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
        private static void RenameRadioButton(RadioButton radioButton)
        {
            object value = radioButton.GetValue(CultureKey.CultureResKey);
            if (value != null)
            {
                string replacement = RManager.GetCultureWord((string)value);
                if (!string.IsNullOrEmpty(replacement))
                {
                    radioButton.Content = RManager.GetCultureWord((string)value);
                }
            }
        }
        private static void RenameTextBlock(TextBlock textBlock)
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
        private static void RenameItemContainerGenerator(ItemContainerGenerator container)
        {
            foreach (var element in container.Items)
            {
                if (element is UIElement)
                    Rename((UIElement)element);
            }
        }
        public static void RenameCollection(UIElementCollection Element)
        {
            foreach (var element in Element)
            {
                if (element is UIElement)
                    Rename((UIElement)element);
            }
        }
        public static void Rename(UIElement Element)
        {
            if (Element is TextBlock)
            {
                RenameTextBlock((TextBlock)Element);
            }
            if (Element is Label)
            {
                RenameLabel((Label)Element);
            }
            if (Element is RadioButton)
                RenameRadioButton((RadioButton)Element);
            //Check for content
            PropertyInfo ContentProperty = Element.GetType().GetProperty("Content", BindingFlags.Instance | BindingFlags.Public);
            if (ContentProperty != null)
            {
                var _content = ContentProperty.GetValue(Element);
                if (_content != null)
                    if (_content is UIElement)
                        Rename((UIElement)_content);
            }
            //check for Children
            PropertyInfo ChildrenPropertyInfo = Element.GetType().GetProperty("Children", BindingFlags.Public | BindingFlags.Instance);
            if (ChildrenPropertyInfo != null)
            {
                var children = ChildrenPropertyInfo.GetValue(Element);
                if(children != null)
                    if (children is UIElementCollection)
                        RenameCollection((UIElementCollection)children);
            }

            PropertyInfo ItemContainerGeneratorInfo = Element.GetType().GetProperty("ItemContainerGenerator", BindingFlags.Public | BindingFlags.Instance);
            if (ItemContainerGeneratorInfo != null)
            {
                ItemContainerGenerator _ItemContainerGenerator = (ItemContainerGenerator)ItemContainerGeneratorInfo.GetValue(Element);
                if(_ItemContainerGenerator != null)
                    RenameItemContainerGenerator(_ItemContainerGenerator);
            }
        }
    }
}

