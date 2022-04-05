using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myDatePicker.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void myButton_Clicked(object sender, EventArgs e)
        {

            var currentYear = DateTime.Now.Year;
            var yearOfBirth = myDatePicker.Date.Year;
            var country = (String)picker.SelectedItem;
            Message.Text = country;
            var age = currentYear - yearOfBirth;
            var ageLimit = 21;
            if (country == "USA")
            {
                ageLimit = 21;
            }
            else if (country == "South Korea")
            {
                ageLimit = 19;
            }
            else if (country == "Japan")
            {
                ageLimit = 20;
            }
            else if (country == "Germany")
            {
                ageLimit = 16;
            }

            
            if (age >= ageLimit)
            {
                Message.Text = $"You can legally drink!";
            }
            else
            {
                Message.Text = $"You have {ageLimit - age} more years until you can drink in {country}!";
            }


        }

    }
}