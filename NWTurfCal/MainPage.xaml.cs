using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NWTurfCal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            addButton.Clicked+= async delegate {

                await GoToNextPage();

            };
        }

        private async Task GoToNextPage()
        {

            if(!string.IsNullOrEmpty(numberEntry.Text))
            {
                if(numberEntry.Text.All(char.IsDigit))
                {
                    if(Int32.Parse(numberEntry.Text) <= 1)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error!", "Value should be greater than 01", "OK");
                        numberEntry.Text = string.Empty;
                        numberEntry.Focus();
                    }
                    else
                    {
                        await Navigation.PushAsync(new CalPage(Int32.Parse(numberEntry.Text)));
                    }
                    
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error!", "Please enter a numeric value", "OK");
                    numberEntry.Text = string.Empty;
                    numberEntry.Focus();
                }
                
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Empty Field!", "Please enter a numeric value", "OK");
                numberEntry.Focus();
            }

            
        }

        
    }
}
