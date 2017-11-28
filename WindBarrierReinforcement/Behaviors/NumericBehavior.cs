using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace WindBarrierReinforcement.Behaviors
{
    public class NumericBehaviour : Behavior<TextBox>
    {
        //public static readonly DependencyProperty RegularExpressionProperty =
        //    DependencyProperty.Register("RegularExpression", typeof(string), typeof(NumericBehaviour));

        //public string RegularExpression {
        //    get { return (string)base.GetValue(RegularExpressionProperty); }
        //    set { SetValue(RegularExpressionProperty, value); }
        //}

        public static readonly DependencyProperty InitialValueProperty =
            DependencyProperty.Register("InitialValue", typeof(int), typeof(NumericBehaviour));

        public int InitialValue
        {
            get { return (int)GetValue(InitialValueProperty); }
            set { SetValue(InitialValueProperty, value); }
        }
        public static readonly DependencyProperty MaximumValueProperty =
            DependencyProperty.Register("MaximumValue", typeof(int), typeof(NumericBehaviour));

        public int MaximumValue
        {
            get { return (int)GetValue(MaximumValueProperty); }
            set { SetValue(MaximumValueProperty, value); }
        }
        public static readonly DependencyProperty MinimumValueProperty =
            DependencyProperty.Register("MinimumValue", typeof(int), typeof(NumericBehaviour));
        public int MinimumValue
        {
            get { return (int)GetValue(MinimumValueProperty); }
            set { SetValue(MinimumValueProperty, value); }
        }

        private string __lastKnowText { get; set; }
        private int __lastKnowCaretPosition;
        private bool __internalTextChange = false;
        private string __numericalRegEx = "^[0-9]+$";

        public NumericBehaviour()
        {

        }
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.TextChanged += AssociatedObject_TextChanged;
            AssociatedObject.Initialized += AssociatedObject_Initialized;
            AssociatedObject.SelectionChanged += AssociatedObject_SelectionChanged;
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.TextChanged -= AssociatedObject_TextChanged;
            AssociatedObject.Initialized -= AssociatedObject_Initialized;
            AssociatedObject.SelectionChanged -= AssociatedObject_SelectionChanged;
        }

        private void AssociatedObject_SelectionChanged(object sender, RoutedEventArgs e)
        {
            __lastKnowCaretPosition = AssociatedObject.CaretIndex;
        }

        private void AssociatedObject_Initialized(object sender, EventArgs e)
        {
            //LastKnowCaretPosition = 1;
            ((TextBox)sender).Text = InitialValue.ToString();
            AssociatedObject.CaretIndex = InitialValue.ToString().Length;
            AssociatedObject.Focus();
        }

        private void AssociatedObject_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            //if (!__internalTextChange && string.IsNullOrEmpty(textBox.Text))
            //{
            //    __lastKnowText = "";
            //    __lastKnowCaretPosition = 0;
            //}
            if (!__internalTextChange)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    __lastKnowText = "";
                    __lastKnowCaretPosition = 0;
                }
                else
                {
                    if (!ValidateInputData(textBox.Text))
                    {
                        //when textBox.Text is set bellow, the caret will reset to 0
                        //for this we set a bool (InternalTextChange) to a true value, and next time this function is called
                        //it will go straight to else branch where (InternalTextChange) is set to false
                        __internalTextChange = true;
                        textBox.Text = __lastKnowText;
                        AssociatedObject.CaretIndex = __lastKnowCaretPosition;
                        e.Handled = true;
                    }
                    else
                    {
                        __lastKnowText = textBox.Text;
                        __lastKnowCaretPosition = AssociatedObject.CaretIndex;
                    }
                }
            }
            else
            {
                __internalTextChange = false;
            }
        }

        private bool ValidateInputData(string Text)
        {
            Regex regex = new Regex(__numericalRegEx);
            if (!regex.IsMatch(Text))
                return false;

            int value;
            int.TryParse(Text, out value);
            if (!(MinimumValue == 0 && MaximumValue == 0))
                if (value < MinimumValue || value > MaximumValue)
                    return false;

            return true;
        }
    }
}
