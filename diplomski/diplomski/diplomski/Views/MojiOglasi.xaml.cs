using diplomski.Models;
using diplomski.ViewModels;
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
	public partial class MojiOglasi : ContentPage
	{
		public MojiOglasi ()
		{
			InitializeComponent ();
		}
		public void DodajOglas_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajOglas());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			BindingContext = new OglasiViewModel();
		}

		private async void OnTeamTapped(object sender, ItemTappedEventArgs e)
		{

			if (e.Item != null)
			{
				var team = (Oglas)e.Item;
				//await Navigation.PushAsync(new MojOglas(team.TeamId));
			}
		}
	}
}