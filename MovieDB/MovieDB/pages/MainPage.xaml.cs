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
using MovieDB.model;
using MovieDB.userControl;


namespace MovieDB.pages
{
    public partial class MainPage : Page
    {
        static Users user = new Users();
        Attachments attach = new Attachments();
        static StackPanel sp_TopFilms;
        static StackPanel sp_NewFilms;
        static StackPanel sp_MyFilms;
        static Grid grid_FilmsInfo;

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Users user)
        {
            InitializeComponent();

            MainPage.user = user;

            FillFields();
            LoadImage();
            ShowFilms();
        }

        private void FillFields()
        {
            sp_TopFilms = pnl_FilmsT;
            sp_NewFilms = pnl_FilmsA;
            sp_MyFilms = pnl_FilmsF;
            grid_FilmsInfo = grid_films;

            lbl_Name.Content = user.Surname + " " + user.Name;
            lbl_Discription.Content = user.Description;
        }

        private void LoadImage()
        {
            try
            {
                user = Registration.unit.Users.Get(u => u.Id == user.Id).FirstOrDefault();
                if (user != null && user.Image != null && user.ImagePath != null)
                {
                    img_ProfilePhoto.ImageSource = new BitmapImage(new Uri(user.ImagePath));
                }
            }
            catch
            {
                MessageBox.Show("Photo path " + user.ImagePath + " is not found");
            }
        }

        private void ShowFilms() 
        {
            var films = Registration.unit.Films.Get().OrderByDescending(o => o.Rating);
            if (films != null)
            {
                foreach (Films film in films)
                {
                    var item = AddFilmItem(film.Title, film.Id, film.Category);
                }
            }
        }

        public static FilmItem AddFilmItem(string text, int id, string Category)   
        {
            bool check2 = false;
            var attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == user.Id).FirstOrDefault();
            FilmItem item = new FilmItem(text, id, check2, user.Id)
            {
                Margin = new Thickness(10, 10, 10, 0),
                HorizontalAlignment = HorizontalAlignment.Stretch
            };
            if (Category == "TopFilms")
            {
                sp_TopFilms.Children.Add(item);
            }
            if (Category == "NewFilms")
            {
                sp_NewFilms.Children.Add(item);
            }
          
            if (attach != null)
            {
                FilmItem item2 = new FilmItem(text, id, true, user.Id)
                {
                    Margin = new Thickness(10, 10, 10, 0),
                    HorizontalAlignment = HorizontalAlignment.Stretch
                };

                if (attach.FavoriteFilm == true)
                {
                    sp_MyFilms.Children.Add(item2);
                }
            }
            return item;
        }

        private void Btn_Profile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("pages/ProfilePage.xaml", UriKind.Relative));
        }

        public static void Info(UIElement item, int id)  
        {
            FilmInfo f = new FilmInfo(id);
            grid_FilmsInfo.Children.Add(f);
        }

        public static void AddInfo(UIElement item, int id, string text)  
        {
            var attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == user.Id).FirstOrDefault();
            sp_TopFilms.Children.Clear();
            sp_NewFilms.Children.Clear();
            sp_MyFilms.Children.Clear();
            bool check = true;

            FilmItem info = new FilmItem(text, id, check, user.Id)
            {
                Margin = new Thickness(10, 30, 10, 0),
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Bottom
            };

            if (text == "TopFilms")
            {
                sp_TopFilms.Children.Add(info);
            }
            if (text == "NewFilms")
            {
                sp_NewFilms.Children.Add(info);
            }

            if (attach != null)
            {
                FilmItem info2 = new FilmItem(text, id, true, user.Id)
                {
                    Margin = new Thickness(10, 30, 10, 0),
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Bottom
                };

                if (attach.FavoriteFilm == true)
                {
                    sp_MyFilms.Children.Add(info2);
                }
            }
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            var x = MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);
            if (x.Equals(MessageBoxResult.Yes))
            {
                Registration registration = new Registration();
                registration.Show();
                MainWindow.GetWindow(this).Close();
            }
        }

        bool checkSortByAlphabetical = true;
        private void SortByAlphabetical(object sender, RoutedEventArgs e)
        {
            if (checkSortByAlphabetical)
            {
                var films = Registration.unit.Films.Get().OrderByDescending(o => o.Title);
                ClearStackPanel();
                if (films != null)
                {
                    foreach (Films film in films)
                    {
                        var item = AddFilmItem(film.Title, film.Id, film.Category);
                    }
                }
                checkSortByAlphabetical = false;
            }
            else
            {
                var films = Registration.unit.Films.Get().OrderBy(o => o.Title);
                ClearStackPanel();
                if (films != null)
                {
                    foreach (Films film in films)
                    {
                        var item = AddFilmItem(film.Title, film.Id, film.Category);
                    }
                }
                checkSortByAlphabetical = true;
            }
        }

        private void SortByAscending(object sender, RoutedEventArgs e)
        {
            var films = Registration.unit.Films.Get().OrderBy(o => o.Rating);
            ClearStackPanel();
            if (films != null)
            {
                foreach (Films film in films)
                {
                    var item = AddFilmItem(film.Title, film.Id, film.Category);
                }
            }
        }

        private void SortByDescending(object sender, RoutedEventArgs e)
        {
            var films = Registration.unit.Films.Get().OrderByDescending(o => o.Rating);
            ClearStackPanel();
            if (films != null)
            {
                foreach (Films film in films)
                {
                    var item = AddFilmItem(film.Title, film.Id, film.Category);
                }
            }
        }

        private void ClearStackPanel()
        {
            
            sp_TopFilms.Children.Clear();
            sp_NewFilms.Children.Clear();
            sp_MyFilms.Children.Clear();
        }
    }
}
