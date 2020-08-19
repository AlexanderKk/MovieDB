using MovieDB.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class StatisticsControl : UserControl
    {
        Users User;
        Attachments Attach;

        static StackPanel sp_rating;
        
        public StatisticsControl(Users user, Attachments attach)
        {
            InitializeComponent();

            User = user;

            sp_rating = sp_rate;
            sp_rating.Children.Clear();


            FillData();
            DataContext = this;
            
            int week = 6 ;
            var points = new Collection<DateValue>();

            var films = Registration.unit.Attachments.Get(a => a.UsersID == User.Id).OrderBy(o => o.RatingDate);
            for (int i = week; i >= 0; i--)
            {
                if (films != null)
                {
                    foreach (Attachments film in films)
                    {
                        DateTime date = Convert.ToDateTime(film.RatingDate);
                        string dt = date.ToShortDateString();
                        if (dt == DateTime.Now.AddDays(-i).ToShortDateString())
                        {
                            DateTime date1 = DateTime.Now.AddDays(-i);
                            DateTime result1 = date1.AddHours(-5);
                            points.Add(new DateValue(result1, 0));
                            points.Add(new DateValue(result1, Convert.ToDouble(film.NumberOfStars)));
                            points.Add(new DateValue(DateTime.Now.AddDays(-i), Convert.ToDouble(film.NumberOfStars)));
                            DateTime date2 = DateTime.Now.AddDays(-i);
                            DateTime resul2 = date2.AddHours(5);
                            points.Add(new DateValue(resul2, Convert.ToDouble(film.NumberOfStars)));
                            points.Add(new DateValue(resul2, 0));

                            var filmName = Registration.unit.Films.Get(f => f.Id == film.FilmsId).FirstOrDefault();
                            var converter = new System.Windows.Media.BrushConverter();
                            var brush = (Brush)converter.ConvertFromString("#ffffff");
                            Label lb = new Label()
                            {
                                HorizontalAlignment = HorizontalAlignment.Center,
                                Content = filmName.Title + " " + film.NumberOfStars,
                                Foreground = brush
                            };
                            sp_rating.Children.Add(lb);
                        }

                    }
                }
            }
            this.Points = points;

        }

        private void FillData()
        {
            dp_Start.SelectedDate = DateTime.Now.AddDays(-6);
            dp_Finish.SelectedDate = DateTime.Now;

            int countChecked = Registration.unit.Attachments.Get(a => a.UsersID == User.Id ).Count();
            int countUnchecked = Registration.unit.Attachments.Get(a => a.UsersID == User.Id && a.NumberOfStars != null).Count();
            lbl_Scheduled.Content += " " + countUnchecked.ToString();
            lbl_Completed.Content += " " + countChecked.ToString();
        }

        public IList<DateValue> Points { get; private set; }

        private void Btn_Build_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            DataContext = this;
            sp_rating = sp_rate;
            sp_rating.Children.Clear();
            var points = new Collection<DateValue>();
            DateTime d1 = dp_Start.SelectedDate.Value;
            DateTime d2 = dp_Finish.SelectedDate.Value;
            if (d2 > d1)
            {
                int days = Convert.ToInt32((d2 - d1).Days);
                var films = Registration.unit.Attachments.Get(a => a.UsersID == User.Id).OrderBy(o => o.RatingDate);
                for (int i = days; i >= 0; i--)
                {
                    if (films != null)
                    {
                        foreach (Attachments film in films)
                        {
                            DateTime date = Convert.ToDateTime(film.RatingDate);
                            string dt = date.ToShortDateString();
                            if (dt == DateTime.Now.AddDays(-i).ToShortDateString())
                            {
                                DateTime date1 = DateTime.Now.AddDays(-i);
                                DateTime result1 = date1.AddHours(-5);
                                points.Add(new DateValue(result1, 0));
                                points.Add(new DateValue(result1, Convert.ToDouble(film.NumberOfStars)));
                                points.Add(new DateValue(DateTime.Now.AddDays(-i), Convert.ToDouble(film.NumberOfStars)));
                                DateTime date2 = DateTime.Now.AddDays(-i);
                                DateTime resul2 = date2.AddHours(5);
                                points.Add(new DateValue(resul2, Convert.ToDouble(film.NumberOfStars)));
                                points.Add(new DateValue(resul2, 0));

                                var filmName = Registration.unit.Films.Get(f => f.Id == film.FilmsId).FirstOrDefault();
                                var converter = new System.Windows.Media.BrushConverter();
                                var brush = (Brush)converter.ConvertFromString("#ffffff");
                                Label lb = new Label()
                                {
                                    HorizontalAlignment = HorizontalAlignment.Center,
                                    Content = filmName.Title + " " + film.NumberOfStars,
                                    Foreground = brush
                                };
                                sp_rating.Children.Add(lb);
                            }

                        }
                    }
                }
                this.Points = points;
            }
            else
            {
                MessageBox.Show("The date range is incorrect.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    public class DateValue
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public DateValue(DateTime date, double value)
        {
            Date = date;
            Value = value;
        }
    }
}
