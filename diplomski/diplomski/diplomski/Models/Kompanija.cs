using System;
using System.Collections.Generic;
using System.Text;

namespace diplomski.Models
{
    public class Kompanija
    {
		private int id;
		private string imeKontaktOsobe;
		private string prezimeKOntaktOsobe;
		private string emailKontaktOsobe;
		private string passwordKontaktOsobe;
		private string nazivKompanije;
		private string emailKompanije;
		private string adresaKompanije;
		private string telefonKompanije;

		public Kompanija(string imeKontaktOsobe, string prezimeKOntaktOsobe, string emailKontaktOsobe, string passwordKontaktOsobe, string nazivKompanije, string emailKompanije, string adresaKompanije, string telefonKompanije)
		{
			this.ImeKontaktOsobe = imeKontaktOsobe;
			this.PrezimeKOntaktOsobe = prezimeKOntaktOsobe;
			this.EmailKontaktOsobe = emailKontaktOsobe;
			this.PasswordKontaktOsobe = passwordKontaktOsobe;
			this.NazivKompanije = nazivKompanije;
			this.EmailKompanije = emailKompanije;
			this.AdresaKompanije = adresaKompanije;
			this.TelefonKompanije = telefonKompanije;
		}
		public Kompanija() { }

		public string ImeKontaktOsobe { get => imeKontaktOsobe; set => imeKontaktOsobe = value; }
		public string PrezimeKOntaktOsobe { get => prezimeKOntaktOsobe; set => prezimeKOntaktOsobe = value; }
		public string EmailKontaktOsobe { get => emailKontaktOsobe; set => emailKontaktOsobe = value; }
		public string PasswordKontaktOsobe { get => passwordKontaktOsobe; set => passwordKontaktOsobe = value; }
		public string NazivKompanije { get => nazivKompanije; set => nazivKompanije = value; }
		public string EmailKompanije { get => emailKompanije; set => emailKompanije = value; }
		public string AdresaKompanije { get => adresaKompanije; set => adresaKompanije = value; }
		public string TelefonKompanije { get => telefonKompanije; set => telefonKompanije = value; }
		public int Id { get => id; set => id = value; }
	}
}
