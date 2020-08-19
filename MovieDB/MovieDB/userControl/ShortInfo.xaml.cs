using MovieDB.model;
using MovieDB.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieDB.userControl
{

    public partial class ShortInfo : UserControl
    {
        Films film;
        int id;
        bool currentCategory;
        public ShortInfo()
        {
            InitializeComponent();
        }

        public ShortInfo(string text, int Id, bool checkCategory)
        {
            InitializeComponent();
            id = Id;
            currentCategory = checkCategory;
            LoadInfo();
        }

        private void Btn_Info_Click(object sender, RoutedEventArgs e)
        {
            film = Registration.unit.Films.Get().FirstOrDefault();
            MainPage.Info(this, id);
            MainPage.AddInfo(this, id, film.Category);
        }

        private void LoadInfo()
        {
            film = Registration.unit.Films.Get(f => f.Id == id).FirstOrDefault();

            string path = "pack://application:,,,/MovieDB;component";
            string path2 = film.FilePath;
            string filepath = path + path2;
            img_Poster3.Source = new BitmapImage(new Uri(filepath));
            txt_filmName.Text = film.Title;
            txt_filmYear.Text = Convert.ToString(film.Year);

            if (currentCategory)
            {
                btn_Close.Visibility = Visibility.Visible;
            }
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            film = Registration.unit.Films.Get(f => f.Id == id).FirstOrDefault();
            film.Category = "TopFilms";
            Registration.unit.Films.Update(film);
            Registration.unit.Save();
        }
    }
}
