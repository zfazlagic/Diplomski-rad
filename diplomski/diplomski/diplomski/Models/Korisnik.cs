using System;
using System.Collections.Generic;
using System.Text;

namespace diplomski.Models
{
    public class Korisnik
    {
		private int id;
		private string imeKorisnika;
		private string prezimeKorisnika;
		private string emailKorisnika;
		private string passwordKorisnika;
		private string stecenoObrazovanjeKorisnika;
		private string nazivObrazovanjaKOrisnika;
		private string godinaZavrsetkaObrazovanja;

		public Korisnik(string imeKorisnika, string prezimeKorisnika, string emailKorisnika, string passwordKorisnika, string stecenoObrazovanjeKorisnika, string nazivObrazovanjaKOrisnika, string godinaZavrsetkaObrazovanja)
		{
			this.ImeKorisnika = imeKorisnika;
			this.PrezimeKorisnika = prezimeKorisnika;
			this.EmailKorisnika = emailKorisnika;
			this.PasswordKorisnika = passwordKorisnika;
			this.StecenoObrazovanjeKorisnika = stecenoObrazovanjeKorisnika;
			this.NazivObrazovanjaKOrisnika = nazivObrazovanjaKOrisnika;
			this.GodinaZavrsetkaObrazovanja = godinaZavrsetkaObrazovanja;
		}

		public Korisnik() { }
		public string ImeKorisnika { get => imeKorisnika; set => imeKorisnika = value; }
		public string PrezimeKorisnika { get => prezimeKorisnika; set => prezimeKorisnika = value; }
		public string EmailKorisnika { get => emailKorisnika; set => emailKorisnika = value; }
		public string PasswordKorisnika { get => passwordKorisnika; set => passwordKorisnika = value; }
		public string StecenoObrazovanjeKorisnika { get => stecenoObrazovanjeKorisnika; set => stecenoObrazovanjeKorisnika = value; }
		public string NazivObrazovanjaKOrisnika { get => nazivObrazovanjaKOrisnika; set => nazivObrazovanjaKOrisnika = value; }
		public string GodinaZavrsetkaObrazovanja { get => godinaZavrsetkaObrazovanja; set => godinaZavrsetkaObrazovanja = value; }
		public int Id { get => id; set => id = value; }
	}
}
