using diplomski.Helpers;
using diplomski.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace diplomski.DataAccess
{
    public class DatabaseContext : DbContext
    {
		public DbSet<Oglas> Oglasi { get; set; }
		public DbSet<Kompanija> Kompanije { get; set; }
		public DbSet<Korisnik> Korisnici { get; set; }

		public DatabaseContext()
		{
			this.Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //podesavamo sqlite za svaku platformu  preko dependency servisa
		{

			var dbPath = DependencyService.Get<IDBPath>().GetDbPath();
			optionsBuilder.UseSqlite($"Filename={dbPath}");
		}
	}
}
