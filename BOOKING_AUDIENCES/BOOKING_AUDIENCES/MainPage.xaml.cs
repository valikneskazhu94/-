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
            

            ListView listview = new ListView();
            //Content = new StackLayout { Children = { header } };

            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label
            //        {
            //             Text = "STEP",
            //             FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //             BackgroundColor = Color.Blue,
            //             HorizontalTextAlignment = TextAlignment.Center
            //        },

            //        new Label
            //        {
            //            Text = "Пара №1",
            //            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //            Margin = 5
            //        },

            //        new Label
            //        {
            //            Text = "9:00 - 10:20",
            //            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //            HorizontalTextAlignment = TextAlignment.End,
            //            Margin = 5
            //        }
            //    }
            //};

           

        }


    }
}
