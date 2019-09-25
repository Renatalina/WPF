using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFSobitiya
{
    class SpaceButton:Button
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set {
                _text = value;
                Content = SpaceOutText(_text);
            }
        }


        public int Space
        {
            get { return (int)GetValue(SpaceProperty); }
            set { SetValue(SpaceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Space.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpaceProperty;
        static SpaceButton()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata
            {
                DefaultValue = 1,
                AffectsMeasure = true,
                Inherits = true

            };
            metadata.PropertyChangedCallback += OnSpacePropertyChanged;
            //мы сами создали это свойство. и сами теперь его будет определять

            SpaceProperty = DependencyProperty.Register("Space",
                typeof(int), typeof(SpaceButton), metadata, ValidateSpaceValue);
        }

        private static bool ValidateSpaceValue(object value)
        {
          return   (int)value >= 0;
        }

        private static void OnSpacePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SpaceButton spaceButton = d as SpaceButton;
            if(spaceButton !=null)
            {
                spaceButton.Content = spaceButton.SpaceOutText(spaceButton.Text);
            }
        }

        private string SpaceOutText(string text)
        {
            if(text==null)
            {
                return null;
            }
            StringBuilder builder = new StringBuilder();
            foreach (char item in text)
            {
                builder.Append($"{item}{new string(' ', Space)}");
            }
            return builder.ToString();
        }
    }
}
