using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BOOKING_AUDIENCES
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            Label header = new Label
            {
                Text = "STEP",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                BackgroundColor = Color.Blue,
                HorizontalTextAlignment = TextAlignment.Center
            };
            string[] phones = new string[] { "iPhone 7", "Samsung Galaxy S8", "Huawei P10", "LG G6" };

            ListView listView = new ListView();
            
            listView.ItemsSource = phones;
            Content = new StackLayout { Children = { header, listView } };

        }


    }
}
