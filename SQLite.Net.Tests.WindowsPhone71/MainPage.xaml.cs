using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using SQLite.Net.Platform.WindowsPhone71;

namespace SQLite.Net.Tests.WindowsPhone71
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Конструктор
        public MainPage()
        {
            InitializeComponent();
            var exist = IsolatedStorageFile.GetUserStoreForApplication().FileExists("db.sqlite");
            using (var db = new SQLiteConnection(new SQLitePlatformWP71(), "db.sqlite"))
            {
                
            }
            exist = IsolatedStorageFile.GetUserStoreForApplication().FileExists("db.sqlite");
        }
    }
}