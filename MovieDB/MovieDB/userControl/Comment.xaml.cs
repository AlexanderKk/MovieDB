using MovieDB.model;
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
    public partial class Comment : UserControl
    {
        Films film;
        int id;
        DateTime? timeComment;
        public Comment()
        {
            InitializeComponent();
        }

        public Comment(int? idUser, string text, DateTime? time, int currentUserId)
        {
            InitializeComponent();
            id = currentUserId;
            txt_comment.Text = text;
            timeComment = time;
            var currentUser = Registration.unit.Users.Get(u => u.Id == idUser).FirstOrDefault();
            string nameUser = currentUser.User;
            lbl_username.Content = nameUser;
            lbl_data.Content = time;

            var name = Registration.unit.Users.Get(u => u.Id == currentUserId).FirstOrDefault();
            if (name.User == nameUser)
            {
                edit_comment.Visibility = Visibility.Visible;
            }
            else
            {
                edit_comment.Visibility = Visibility.Hidden;
            }
        }

        bool checkEdit = true;
        private void btn_edit_comment(object sender, RoutedEventArgs e)
        {
            if (checkEdit)
            {
                txt_comment.IsReadOnly = false;
                checkEdit = false;
            }
            else
            {
                var attach = Registration.unit.Attachments.Get(a => a.UsersID == id && a.CommentTime == timeComment).FirstOrDefault();

                txt_comment.IsReadOnly = true;
                checkEdit = true;

                attach.Comment = txt_comment.Text;
                DateTime dt = DateTime.Now;
                attach.CommentTime = dt;
                lbl_data.Content = dt;
                Registration.unit.Attachments.Update(attach);
                Registration.unit.Save();
            }
           
        }
    }
}
