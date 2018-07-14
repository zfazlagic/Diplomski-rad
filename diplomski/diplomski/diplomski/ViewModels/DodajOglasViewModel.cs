using diplomski.DataAccess;
using diplomski.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace diplomski.ViewModels
{
    public class DodajOglasViewModel : BaseViewModel
    {
		private int id;
		private string nazivOglasa;
		private string pozicijaM;
		private string opisPozicije;
		private string opisZaposlenika;
		private string dodatniOpis;
		private DateTime vrijemeIstekaOglasa;
		private string lokacija;
		private string brojPozicija;
		private int idKompanije;
		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
				OnPropertyChanged();
			}
		}
		public string NazivOglasa
		{
			get
			{
				return nazivOglasa;
			}
			set
			{
				nazivOglasa = value;
				OnPropertyChanged();
			}
		}
		public string PozicijaM
		{
			get
			{
				return pozicijaM;
			}
			set
			{
				pozicijaM = value;
				OnPropertyChanged();
			}
		}
		public string OpisPozicije
		{
			get
			{
				return opisPozicije;
			}
			set
			{
				opisPozicije = value;
				OnPropertyChanged();
			}
		}
		public string OpisZaposlenika
		{
			get
			{
				return OpisZaposlenika;
			}
			set
			{
				OpisZaposlenika = value;
				OnPropertyChanged();
			}
		}
		public string DodatniOpis
		{
			get
			{
				return dodatniOpis;
			}
			set
			{
				dodatniOpis = value;
				OnPropertyChanged();
			}
		}
		public DateTime VrijemeIstekaOglasa
		{
			get
			{
				return vrijemeIstekaOglasa;
			}
			set
			{
				vrijemeIstekaOglasa = value;
				OnPropertyChanged();
			}
		}
		public string Lokacija
		{
			get
			{
				return lokacija;
			}
			set
			{
				lokacija = value;
				OnPropertyChanged();
			}
		}
		public string BrojPozicija
		{
			get
			{
				return brojPozicija;
			}
			set
			{
				brojPozicija = value;
				OnPropertyChanged();
			}
		}
		public int IdKompanije
		{
			get
			{
				return idKompanije;
			}
			set
			{
				idKompanije = value;
				OnPropertyChanged();
			}
		}
		public ICommand DodajOglas { get; private set; }
		private DatabaseContext context;
	}
}
