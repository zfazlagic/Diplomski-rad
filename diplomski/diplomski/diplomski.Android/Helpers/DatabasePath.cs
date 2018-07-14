using diplomski.Droid.Helpers;
using diplomski.Helpers;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(DatabasePath))]
namespace diplomski.Droid.Helpers
{
	public class DatabasePath : IDBPath
	{

		public DatabasePath()
		{
		}

		public string GetDbPath()
		{
			return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "EFCoreDB.db");
		}
	}
}