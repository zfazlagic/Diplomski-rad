using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diplomski.Views

{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void Login_Clicked(object sender,EventArgs e)
		{
			Navigation.PushModalAsync(new Pocetna());
			
		}
		private void Poslodavac_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new RegistracijaKompanije());

		}
		private void Posloprimac_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new RegistracijaKorisnika());

		}
	}
}
