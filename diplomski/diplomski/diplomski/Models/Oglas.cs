using System;
using System.Collections.Generic;
using System.Text;

namespace diplomski.Models
{
   public class Oglas
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

		public string NazivOglasa { get => nazivOglasa; set => nazivOglasa = value; }
		public string PozicijaM { get => pozicijaM; set => pozicijaM = value; }
		public string OpisPozicije { get => opisPozicije; set => opisPozicije = value; }
		public string OpisZaposlenika { get => opisZaposlenika; set => opisZaposlenika = value; }
		public string DodatniOpis { get => dodatniOpis; set => dodatniOpis = value; }
		public DateTime VrijemeIstekaOglasa { get => vrijemeIstekaOglasa; set => vrijemeIstekaOglasa = value; }
		public string Lokacija { get => lokacija; set => lokacija = value; }
		public string BrojPozicija { get => brojPozicija; set => brojPozicija = value; }
		public int Id { get => id; set => id = value; }

		public Oglas() { }

		public Oglas(string nazivOglasa, string pozicijaM, string opisPozicije, string opisZaposlenika, DateTime vrijemeIstekaOglasa, string lokacija, string brojPozicija)
		{
			this.nazivOglasa = nazivOglasa;
			this.pozicijaM = pozicijaM;
			this.opisPozicije = opisPozicije;
			this.opisZaposlenika = opisZaposlenika;
			this.vrijemeIstekaOglasa = vrijemeIstekaOglasa;
			this.lokacija = lokacija;
			this.brojPozicija = brojPozicija;
		}
	}
}
