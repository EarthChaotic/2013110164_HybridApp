using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TNI2013110164
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            sendButton.Clicked += SendButton_Clicked;

            aSlider.ValueChanged += ASlider_ValueChanged;

            userEntry.TextChanged += UserEntry_TextChanged;

            aStepper.ValueChanged += AStepper_ValueChanged;

            aSwitch.Toggled += ASwitch_Toggled;

            colorPicker.SelectedIndexChanged += ColorPicker_SelectedIndexChanged;
        }

        private void ColorPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            yaLabel.Text = colorPicker.SelectedItem.ToString();
        }

        private void ASwitch_Toggled(object sender, ToggledEventArgs e)
        {
            
            if(e.Value == true)
            {
                yaLabel.Text = "เปิด";
            }
            else if(e.Value == false){
                yaLabel.Text = "ปิด";
            }
        }

        private void AStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
           yaLabel.Text = e.NewValue.ToString();
        }

        private void UserEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            yaLabel.Text = userEntry.Text;
        }

        private void ASlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            yaLabel.Text = e.NewValue.ToString();
        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            yaLabel.Text = userEntry.Text;
        }
    }
}
