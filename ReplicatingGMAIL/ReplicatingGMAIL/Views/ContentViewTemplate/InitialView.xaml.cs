using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReplicatingGMAIL.Views.ContentViewTemplate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialView : ContentView
    {

        public static readonly BindableProperty DefaultBackgroundColorProperty
            = BindableProperty.Create(nameof(DefaultBackgroundColor), typeof(Color),
                typeof(InitialView), Color.LightGray);

        public Color DefaultBackgroundColor
        {
            get => (Color)GetValue(DefaultBackgroundColorProperty);
            set => SetValue(DefaultBackgroundColorProperty, value);
        }


        public static readonly BindableProperty TextColorLightProperty
            = BindableProperty.Create(nameof(TextColorLight), typeof(Color),
                typeof(InitialView), Color.White);

        public Color TextColorLight
        {
            get => (Color)GetValue(TextColorLightProperty);
            set => SetValue(TextColorLightProperty, value);
        }


        public static readonly BindableProperty TextColorDarkProperty
            = BindableProperty.Create(nameof(TextColorDark), typeof(Color),
                typeof(InitialView), Color.Black);

        public Color TextColorDark
        {
            get => (Color)GetValue(TextColorDarkProperty);
            set => SetValue(TextColorDarkProperty, value);
        }

        public static readonly BindableProperty NameProperty
           = BindableProperty.Create(nameof(Text), typeof(string),
               typeof(InitialView), string.Empty,
               propertyChanged: OnNamePropertyChanged);

        public string Text
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }


        private static void OnNamePropertyChanged(BindableObject bindable,
           object oldValue, object newValue)
        {
            if (!(bindable is InitialView initialsView))
                return;

            initialsView.SetName((string)newValue);
        }

        public InitialView()
        {
            InitializeComponent();
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();

            if (WidthRequest == -1 || HeightRequest == -1)
            {
                InitControl(50);
            }
            else
            {
                InitControl(Math.Min(WidthRequest, HeightRequest));
            }
        }

        private void InitControl(double size)
        {

            // set width and height of contentboxview
            ContentBoxView.HeightRequest = size;
            ContentBoxView.WidthRequest = size;

            // calculate corner radius of contentboxview
            ContentBoxView.CornerRadius = size / 2;

            // set default background
            ContentBoxView.BackgroundColor = DefaultBackgroundColor;

            // set fontsize
            ContentLabel.FontSize = (size / 2) - 5;

            // check if name is already present
            if (!string.IsNullOrEmpty(Text))
                SetName(Text);
        }

        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ContentLabel.Text = string.Empty;
                ContentBoxView.BackgroundColor = DefaultBackgroundColor;
                return;
            }

            var words = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 1)
            {
                ContentLabel.Text = words[0][0].ToString();
            }
            else if (words.Length > 1)
            {
                var initialsString = words[0][0].ToString() + words[words.Length - 1][0].ToString();
                ContentLabel.Text = initialsString;
            }
            else
            {
                ContentLabel.Text = string.Empty;
            }

            SetColors(name);
        }

        private void SetColors(string name)
        {
            // get color for the provided text
            var hexColor = "#FF" + Convert.ToString(name.GetHashCode(), 16).Substring(0, 6);

            // fix issue if value is too short
            if (hexColor.Length == 8)
                hexColor += "5";

            // create color from hex value
            var color = Color.FromHex(hexColor);

            // set backgroundcolor of contentboxview
            ContentBoxView.BackgroundColor = color;

            // get brightness and set textcolor
            var brightness = color.R * .3 + color.G * .59 + color.B * .11;
            ContentLabel.TextColor = brightness < 0.5 ? TextColorLight : TextColorDark;
        }

    }
}