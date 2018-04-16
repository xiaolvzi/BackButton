using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App13
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            bt.Clicked += Bt_Clicked;
		}

        private void Bt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
           
        }
    }
}
