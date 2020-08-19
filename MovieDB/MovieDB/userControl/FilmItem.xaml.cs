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
    public partial class FilmItem : UserControl
    {
        public FilmItem()
        {
            InitializeComponent();
        }

        Films film;
        Attachments attach = new Attachments();
        int id;
        int userId;
        static int numberTopFilm = 0;
        static int counterTopFilm = 0;
        static StackPanel sp_comment;

        public FilmItem(string text, int Id, bool check, int userID)
        {
            InitializeComponent();
            txt_Film.Text = text;
            id = Id;
            userId = userID;
            LoadItem(check);
        }

        private void LoadItem(bool check)
        {
        try
        {
             film = Registration.unit.Films.Get(f => f.Id == id).FirstOrDefault();
             attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

             int countTopFilm = Registration.unit.Films.Get(f => f.Category == "TopFilms").Count();

             string path = "pack://application:,,,/MovieDB;component";
             string path2 = film.FilePath;
             string filepath = path + path2;
             img_Poster1.Source = new BitmapImage(new Uri(filepath));
             lbl_rating.Content = film.Rating;

             if (attach.CheckView == true)
             {
                 var converter2 = new System.Windows.Media.BrushConverter();
                 var brush2 = (Brush)converter2.ConvertFromString("#c3dbce");
                 item.Background = brush2;
             }
             else
             {
                 item.Background = Brushes.White;
             }

             if (attach.FavoriteFilm == true)
             {
                 var converter3 = new System.Windows.Media.BrushConverter();
                 var brush3 = (Brush)converter3.ConvertFromString("#bf360c");
                 iconFavoriteFilm.Foreground = brush3;
             }
             else
             {
                 iconFavoriteFilm.Foreground = Brushes.White;
             }



             if (attach.NumberOfStars != null)
             {
                 lbl_myRating.Content = attach.NumberOfStars;
                 lbl_myRating.Visibility = Visibility.Visible;
             }
             else
             {
                 lbl_myRating.Visibility = Visibility.Hidden;
             }

             //-------
             if(film.Category == "TopFilms")
             {
                 if (check != true)
                 {
                     if (counterTopFilm < countTopFilm)
                     {
                         switch (film.Category)
                         {
                             case "TopFilms":
                                 numberTopFilm++;
                                 NumberOfFilm.Content = numberTopFilm;
                                 break;
                         }
                         counterTopFilm++;
                     }
                     else
                     {
                         numberTopFilm = 0;
                         counterTopFilm = 0;
                         switch (film.Category)
                         {
                             case "TopFilms":
                                 numberTopFilm++;
                                 NumberOfFilm.Content = numberTopFilm;
                                 break;
                         }
                         counterTopFilm++;
                     }
                 }
                 else
                 {
                     NumberOfFilm.Visibility = Visibility.Hidden;
                     Ellipse.Visibility = Visibility.Hidden;
                 }
             }

             var converter = new System.Windows.Media.BrushConverter();
             var brush = (Brush)converter.ConvertFromString("#c91a06");

             if (attach.NumberOfStars != null)
             {
                 switch (attach.NumberOfStars)
                 {
                     case 1:
                         IconStar1.Foreground = brush;
                         var convert1 = new System.Windows.Media.BrushConverter();
                         var brushRate1 = (Brush)converter.ConvertFromString("#ff4929");
                         lbl_myRating.Background = brushRate1;
                         break;
                     case 2:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         var convert2 = new System.Windows.Media.BrushConverter();
                         var brushRate2 = (Brush)converter.ConvertFromString("#ff4929");
                         lbl_myRating.Background = brushRate2;
                         break;
                     case 3:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         var convert3 = new System.Windows.Media.BrushConverter();
                         var brushRate3 = (Brush)converter.ConvertFromString("#ff4929");
                         lbl_myRating.Background = brushRate3;
                         break;
                     case 4:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         IconStar4.Foreground = brush;
                         var convert4 = new System.Windows.Media.BrushConverter();
                         var brushRate4 = (Brush)converter.ConvertFromString("#db7676");
                         lbl_myRating.Background = brushRate4;
                         break;
                     case 5:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         IconStar4.Foreground = brush;
                         IconStar5.Foreground = brush;
                         var convert5 = new System.Windows.Media.BrushConverter();
                         var brushRate5 = (Brush)converter.ConvertFromString("#db7676");
                         lbl_myRating.Background = brushRate5;
                         break;
                     case 6:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         IconStar4.Foreground = brush;
                         IconStar5.Foreground = brush;
                         IconStar6.Foreground = brush;
                         var convert6 = new System.Windows.Media.BrushConverter();
                         var brushRate6 = (Brush)converter.ConvertFromString("#db7676");
                         lbl_myRating.Background = brushRate6;
                         break;
                     case 7:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         IconStar4.Foreground = brush;
                         IconStar5.Foreground = brush;
                         IconStar6.Foreground = brush;
                         IconStar7.Foreground = brush;
                         var convert7 = new System.Windows.Media.BrushConverter();
                         var brushRate7 = (Brush)converter.ConvertFromString("#dee81c");
                         lbl_myRating.Background = brushRate7;
                         break;
                     case 8:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         IconStar4.Foreground = brush;
                         IconStar5.Foreground = brush;
                         IconStar6.Foreground = brush;
                         IconStar7.Foreground = brush;
                         IconStar8.Foreground = brush;
                         var convert8 = new System.Windows.Media.BrushConverter();
                         var brushRate8 = (Brush)converter.ConvertFromString("#dee81c");
                         lbl_myRating.Background = brushRate8;
                         break;
                     case 9:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         IconStar4.Foreground = brush;
                         IconStar5.Foreground = brush;
                         IconStar6.Foreground = brush;
                         IconStar7.Foreground = brush;
                         IconStar8.Foreground = brush;
                         IconStar9.Foreground = brush;
                         var convert9 = new System.Windows.Media.BrushConverter();
                         var brushRate9 = (Brush)converter.ConvertFromString("#15c218");
                         lbl_myRating.Background = brushRate9;
                         break;
                     case 10:
                         IconStar1.Foreground = brush;
                         IconStar2.Foreground = brush;
                         IconStar3.Foreground = brush;
                         IconStar4.Foreground = brush;
                         IconStar5.Foreground = brush;
                         IconStar6.Foreground = brush;
                         IconStar7.Foreground = brush;
                         IconStar8.Foreground = brush;
                         IconStar9.Foreground = brush;
                         IconStar10.Foreground = brush;
                         var convert10 = new System.Windows.Media.BrushConverter();
                         var brushRate10 = (Brush)converter.ConvertFromString("#15c218");
                         lbl_myRating.Background = brushRate10;
                         break;
                 }
             }  
        }
        catch (Exception ex) { }
    }

        bool checkViews = true;
        private void Btn_View_Click(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#c3dbce"); 

            if (attach != null)
            {
                if (item.Background == Brushes.White)
                {
                    item.Background = brush;
                    attach.CheckView = true;
                    Registration.unit.Attachments.Update(attach);
                    Registration.unit.Save();
                    checkViews = false;
                }
                else
                {
                    item.Background = Brushes.White;
                    attach.CheckView = false;
                    Registration.unit.Attachments.Update(attach);
                    Registration.unit.Save();
                    checkViews = true;
                }
            }
            else
            {
                if (item.Background == Brushes.White)
                {
                    Attachments attach = new Attachments();
                    item.Background = brush;
                    attach.UsersID = userId;
                    attach.FilmsId = id;
                    attach.CheckView = true;
                    Registration.unit.Attachments.Create(attach);
                    Registration.unit.Save();
                    checkViews = false;
                }
            }
        }

        bool checkFavoriteFilm = true;
        private void Btn_FavoriteFilm_Click(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#bf360c");

            if (attach != null)
            {
                if (iconFavoriteFilm.Foreground == Brushes.White)
                {
                    iconFavoriteFilm.Foreground = brush;
                    attach.FavoriteFilm = true;
                    Registration.unit.Attachments.Update(attach);
                    Registration.unit.Save();
                    checkFavoriteFilm = false;
                }
                else
                {
                    iconFavoriteFilm.Foreground = Brushes.White;
                    attach.FavoriteFilm = false;
                    Registration.unit.Attachments.Update(attach);
                    Registration.unit.Save();
                    checkViews = true;
                }
            }
            else
            {
                if (iconFavoriteFilm.Foreground == Brushes.White)
                {
                    Attachments attach = new Attachments();
                    iconFavoriteFilm.Foreground = brush;
                    attach.UsersID = userId;
                    attach.FilmsId = id;
                    attach.FavoriteFilm = true;
                    Registration.unit.Attachments.Create(attach);
                    Registration.unit.Save();
                    checkFavoriteFilm = false;
                }
            }
        }

        bool checkDescription = true;
        public void Btn_Description_Click(object sender, RoutedEventArgs e)    /////
        {

            if (checkDescription)
            {
                maingrid.Height = 330;
                description.Visibility = Visibility.Visible;
                checkDescription = false;

                var films = Registration.unit.Attachments.Get(a => a.Comment != null && a.FilmsId == id).OrderBy(o => o.CommentTime);
                sp_comment = pnl_comment;
                sp_comment.Children.Clear();
                if (films != null)
                {

                    foreach (Attachments film in films)
                    {
                        var user = Registration.unit.Attachments.Get(a => a.UsersID == userId).FirstOrDefault();
                        int? idUser = film.UsersID;
                        var currentUser = Registration.unit.Users.Get(u => u.Id == idUser).FirstOrDefault();
                        string nameUser = currentUser.User;

                        if (film != null)
                        {
                            string text = film.Comment;
                            txt_WriteComment.Text = "";
                            Comment comment = new Comment(idUser, text, film.CommentTime, userId)
                            {
                                Margin = new Thickness(10, 14, 4, 3),
                                HorizontalAlignment = HorizontalAlignment.Left,
                            };
                            sp_comment.Children.Add(comment);
                        }
                    }
                }
            }
            else
            {
                maingrid.Height = 135;
                description.Visibility = Visibility.Hidden;
                checkDescription = true;
            }

        }

        private void Btn_Info_Click(object sender, RoutedEventArgs e)  
        {
                MainPage.Info(this, id);
        }

        private void Send_Comment_Click(object sender, RoutedEventArgs e)
        {
            var user = Registration.unit.Attachments.Get(a => a.UsersID == userId).FirstOrDefault();
            int? idUser = user.UsersID;
            var currentUser = Registration.unit.Users.Get(u => u.Id == idUser).FirstOrDefault();
            string nameUser = currentUser.User;

            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId ).FirstOrDefault();

            if(attach.Comment != null)
            {
                MessageBox.Show("You have already written a comment! Edit your comment.");
            }
            else
            {
                  if (attach != null)
                  {
                        DateTime dt = DateTime.Now;
                        attach.Comment = txt_WriteComment.Text;
                        attach.CommentTime = dt;
                        string text = txt_WriteComment.Text;
                        Registration.unit.Attachments.Update(attach);
                        Registration.unit.Save();
                        txt_WriteComment.Text = "";

                        sp_comment = pnl_comment;
                        sp_comment.Children.Clear();

                        Comment comment = new Comment(idUser, text, dt, userId)
                        {
                            Margin = new Thickness(10, 14, 4, 3),
                            HorizontalAlignment = HorizontalAlignment.Left,
                        };
                        sp_comment.Children.Add(comment);
                  }
                  else
                  {
                        DateTime dt = DateTime.Now;
                        attach.Comment = txt_WriteComment.Text;
                        attach.CommentTime = dt;
                        attach.UsersID = userId;
                        attach.FilmsId = id;
                        string text = txt_WriteComment.Text;
                        Registration.unit.Attachments.Create(attach);
                        Registration.unit.Save();
                        txt_WriteComment.Text = "";

                        sp_comment = pnl_comment;
           
                        Comment comment = new Comment(idUser, text, dt, userId)
                        {
                            Margin = new Thickness(10, 14, 4, 3),
                            HorizontalAlignment = HorizontalAlignment.Left,
                        };
                        sp_comment.Children.Add(comment);
                    }
            }
        }

        private void Star1(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#ff4929");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 1;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#ff4929");
                lbl_myRating.Background = brushRate;

                attach.NumberOfStars = 1;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }
           
        }
        private void Star2(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#ff4929");
                lbl_myRating.Background = brushRate;

                attach.NumberOfStars = 2;
                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#ff4929");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;
                attach.NumberOfStars = 2;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }

        }
        private void Star3(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#ff4929");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 3;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#ff4929");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 3;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }
        }
        private void Star4(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#db7676");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 4;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#db7676");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 4;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }

        }
        private void Star5(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#db7676");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 5;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#db7676");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 5;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }
        }
        private void Star6(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#db7676");
                lbl_myRating.Background = brushRate;

                attach.NumberOfStars = 6;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#db7676");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 6;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }


        }
        private void Star7(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#dee81c");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 7;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#dee81c");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 7;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }

        }
        private void Star8(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;
                IconStar8.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#dee81c");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 8;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;
                IconStar8.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#dee81c");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 8;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }

        }
        private void Star9(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;
                IconStar8.Foreground = brush;
                IconStar9.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#15c218");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 9;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;
                IconStar8.Foreground = brush;
                IconStar9.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#15c218");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 9;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }
        }
        private void Star10(object sender, RoutedEventArgs e)
        {
            attach = Registration.unit.Attachments.Get(a => a.FilmsId == id && a.UsersID == userId).FirstOrDefault();

            if (attach != null)
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;
                IconStar8.Foreground = brush;
                IconStar9.Foreground = brush;
                IconStar10.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#15c218");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 10;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
            else
            {
                Attachments attach = new Attachments();

                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#c91a06");
                fillStars();
                IconStar1.Foreground = brush;
                IconStar2.Foreground = brush;
                IconStar3.Foreground = brush;
                IconStar4.Foreground = brush;
                IconStar5.Foreground = brush;
                IconStar6.Foreground = brush;
                IconStar7.Foreground = brush;
                IconStar8.Foreground = brush;
                IconStar9.Foreground = brush;
                IconStar10.Foreground = brush;

                var convert = new System.Windows.Media.BrushConverter();
                var brushRate = (Brush)converter.ConvertFromString("#15c218");
                lbl_myRating.Background = brushRate;

                DateTime dt = DateTime.Now;
                attach.RatingDate = dt;

                attach.NumberOfStars = 10;
                attach.UsersID = userId;
                attach.FilmsId = id;
                lbl_myRating.Content = attach.NumberOfStars;
                lbl_myRating.Visibility = Visibility.Visible;
                Registration.unit.Attachments.Create(attach);
                Registration.unit.Save();
            }
        }

        private void fillStars()
        {
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#f2beb8");

            IconStar1.Foreground = brush;
            IconStar2.Foreground = brush;
            IconStar3.Foreground = brush;
            IconStar4.Foreground = brush;
            IconStar5.Foreground = brush;
            IconStar6.Foreground = brush;
            IconStar7.Foreground = brush;
            IconStar8.Foreground = brush;
            IconStar9.Foreground = brush;
            IconStar10.Foreground = brush;
        }
    }
}
