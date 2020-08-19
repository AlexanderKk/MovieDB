using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MovieDB.model;
using MovieDB.pages;
using MovieDB.userControl;

namespace MovieDB
{
    public partial class MainWindow : Window
    {
        public static Users User;

        public MainWindow(Users user)
        {
            InitializeComponent();

            User = user;

            AddAlert();
            MainFrame.Navigate(new MainPage(User));
        }

        private void Btn_Profile_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage(User));
        }

        private void Btn_Support_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("created by Alexander Konopatscky\n2020, Minsk", "Support", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
        }

        private void Btn_Alert_Click(object sender, RoutedEventArgs e)
        {
            cb_Alert.Items.Clear();
            AddAlert();
            cb_Alert.IsDropDownOpen = true;
        }

        bool checkCategory = true;

        private void AddAlert()
        {
            int count = 0;
            var films = Registration.unit.Films.Get(f => f.Category == "NewFilms");
            DateTime now = DateTime.Now;
            foreach (Films f in films)
            {
                DateTime date1 = DateTime.Now;
                DateTime? date2 = f.Premiere;
                if (f.Premiere != null && date2 < date1)
                {
                    count++;
                    cb_Alert.Items.Add(new ShortInfo(f.Title, f.Id, checkCategory));
                }
            }
            md_Badged.Badge = count;
        }

        private void Cb_Drop_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.IsDropDownOpen = false;
        }

        private void Txt_Search_TextChanged(object sender, TextChangedEventArgs e) 
        {
            cb_Search.Items.Clear();
            var films = Registration.unit.Films.Get();
            Collection<string> filmList = new Collection<string>();
            foreach (Films film in films)
            {
                filmList.Add(film.Title);
            }
            Regex regex = new Regex(@"(\w*)" + txt_Search.Text + @"(\w*)", RegexOptions.IgnoreCase);
            for (int i = 0; i < filmList.Count; i++)
            {
                Match match = regex.Match(filmList[i]);
                if (match.Success)
                {
                    var item = Registration.unit.Films.Get(f => f.Title == filmList[i]).FirstOrDefault();
                    cb_Search.Items.Add(new ShortInfo(item.Title, item.Id, false));
                }
            }
            cb_Search.IsDropDownOpen = true;
        }
    }
}
