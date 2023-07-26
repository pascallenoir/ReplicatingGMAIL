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
    public partial class VuePersonnaliseeInitialNameEmail : ContentView
    {


        //Inialisation des variables 
        public static readonly BindableProperty DefaultBackgroundColorProperty
            = BindableProperty.Create(nameof(DefaultBackgroundColor), typeof(Color),
                typeof(VuePersonnaliseeInitialNameEmail), Color.LightGray);

        public Color DefaultBackgroundColor
        {
            get => (Color)GetValue(DefaultBackgroundColorProperty);
            set => SetValue(DefaultBackgroundColorProperty, value);
        }


        public static readonly BindableProperty TextColorLightProperty
            = BindableProperty.Create(nameof(TextColorLight), typeof(Color),
                typeof(VuePersonnaliseeInitialNameEmail), Color.White);

        public Color TextColorLight
        {
            get => (Color)GetValue(TextColorLightProperty);
            set => SetValue(TextColorLightProperty, value);
        }


        public static readonly BindableProperty TextColorDarkProperty
            = BindableProperty.Create(nameof(TextColorDark), typeof(Color),
                typeof(VuePersonnaliseeInitialNameEmail), Color.Black);

        public Color TextColorDark
        {
            get => (Color)GetValue(TextColorDarkProperty);
            set => SetValue(TextColorDarkProperty, value);
        }


        public static readonly BindableProperty NameProperty
            = BindableProperty.Create(nameof(Name), typeof(string),
                typeof(VuePersonnaliseeInitialNameEmail), string.Empty,
                propertyChanged: OnNamePropertyChanged);

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        private static void OnNamePropertyChanged(BindableObject bindable,
            object oldValue, object newValue)
        {
            if (!(bindable is VuePersonnaliseeInitialNameEmail initialsView))
                return;

            initialsView.SetName((string)newValue);
        }



        /// <summary>
        /// Constructeur
        /// </summary>
        public VuePersonnaliseeInitialNameEmail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// vérifier si une taille a été fournie
        /// </summary>
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

        /// <summary>
        /// initialisation du contrôle
        /// </summary>
        /// <param name="size"></param>
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
            if (!string.IsNullOrEmpty(Name))
                SetName(Name);
        }

        /// <summary>
        /// Permet d'extraire les initiales d'un nom fourni. La logique est assez simple, car nous diviserons le nom fourni au niveau des espaces, puis nous utiliserons les premières lettres de la première et de la dernière entrée. 
        /// </summary>
        /// <param name="name"></param>
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
                //var initialsString = words[0][0].ToString() + words[words.Length - 1][0].ToString();
                ContentLabel.Text = words[0][0].ToString();
            }
            else
            {
                ContentLabel.Text = string.Empty;
            }

            SetColors(name);
        }

        /// <summary>
        /// Utile pour la couleur de fond
        /// </summary>
        /// <param name="name"></param>
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
            var brightness = color.R * .174 + color.G * .59 + color.B * 64;
            ContentLabel.TextColor = brightness < 0.5 ? TextColorLight : TextColorDark;
        }
    }
}