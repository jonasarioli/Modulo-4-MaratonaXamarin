using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;
using FormsAssistControl.Storage.Interfaces;
using Xamarin.Forms;
using FormsAssistControl.Droid;

[assembly:Dependency(typeof (SQLiteDroid))]
namespace FormsAssistControl.Droid
{
    public class SQLiteDroid: ISQLite
    {

        public SQLiteDroid()
        {
        }

        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFileName = "TodoSQLite.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}