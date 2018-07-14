using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using diplomski.Helpers;
using diplomski.iOS.Helpers;
using Foundation;
using UIKit;
[assembly: Xamarin.Forms.Dependency(typeof(DatabasePath))]
namespace diplomski.iOS.Helpers
{
	public class DatabasePath : IDBPath
	{

		public string GetDbPath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "EFCoreDB.db");
		}
	}
}