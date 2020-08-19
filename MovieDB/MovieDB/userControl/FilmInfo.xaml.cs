using System;
using System.Collections.Generic;
using System.IO;
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
using MovieDB.model;
using MovieDB.pages;

namespace MovieDB.userControl
{
    public partial class FilmInfo : UserControl
    {
        Films film;
        int id;
        public FilmInfo(int Id)
        {
            InitializeComponent();
            id = Id;

            LoadInfo();
        }

        private void LoadInfo()
        {
            try
            {
                film = Registration.unit.Films.Get(f => f.Id == id).FirstOrDefault();
                txt_Year_Info.Text = Convert.ToString(film.Year);
                txt_Country_Info.Text = film.Country;
                txt_slogan_Info.Text = film.Tagline;
                txt_director_Info.Text = film.Director;
                txt_genre_Info.Text = film.Genre;
                lbl_premiere_Info.Content = film.Premiere;
                txt_description.Text = film.FilmDescription;
                string s = Convert.ToString(lbl_premiere_Info.Content);

                DateTime d = Convert.ToDateTime(s);

                string date = d.ToString("D");
                string d2 = d.ToShortDateString();
                lbl_premiere_Info.Content = date;


                int minute;
                int hours = film.Duration / 60;
                int hour = film.Duration / 60;
                if (hours >= 1)
                {
                    minute = film.Duration - hour * 60;
                    string time_duration = film.Duration + " мин. / " + hour + ":" + minute;
                    lbl_duration_Info.Content = time_duration;
                }
                else
                {
                    lbl_duration_Info.Content = film.Duration + " мин.";
                }

                string path = "pack://application:,,,/MovieDB;component";
                string path2 = film.FilePath;
                string filepath = path + path2;
                img_Poster.Source = new BitmapImage(new Uri(filepath));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } 
}
