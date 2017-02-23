using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using FormsAssistControl.Storage.Interfaces;
using SQLite;
using System.IO;
using Xamarin.Forms;
using FormsAssistControl.iOS.Storage.Implementation;

[assembly:Dependency(typeof (SQLIteIOS))]
namespace FormsAssistControl.iOS.Storage.Implementation
{
    public class SQLIteIOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}