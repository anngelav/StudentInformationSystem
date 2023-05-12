using DataLayer.Database;
using DataLayer.Model;
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
using System.Windows.Shapes;
using Welcome.Others;


namespace UI.Windows
{
    /// <summary>
    /// Interaction logic for EditingWindow.xaml
    /// </summary>
    public partial class EditingWindow : Window
    {
        private readonly DatabaseUser _user;

        public string Names {
            get { return _user.Names; }
            private set { }
        }
        public UserRolesEnum Role
        {
            get { return _user.Role; }
            private set { }
        }

        //public EditingWindow()
        //{
        //    InitializeComponent();
        //    this.DataContext = this;
        //}

        public EditingWindow(DatabaseUser user)
        {
            _user = user;
            InitializeComponent();
            this.DataContext = this;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (role.Text.Length == 0)
            {
                MessageBox.Show("TextBox is empty!");
            }
            string checkRole = role.Text.ToUpper();
            if (checkRole == "ANONYMOUS")
            {
                _user.Role = UserRolesEnum.ANONYMOUS;
                this.Close();
            }
            else
            {
                if (checkRole == "ADMIN")
                {
                    _user.Role = UserRolesEnum.ADMIN;
                    this.Close();
                }
                else
                {
                    if (checkRole == "INSPECTOR")
                    {
                        _user.Role = UserRolesEnum.INSPECTOR;
                        this.Close();
                    }
                    else
                    {
                        if (checkRole == "PROFESSOR")
                        {
                            _user.Role = UserRolesEnum.PROFESSOR;
                            this.Close();
                        }
                        else
                        {
                            if (checkRole == "STUDENT")
                            {
                                _user.Role = UserRolesEnum.STUDENT;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid role. You can choose from following: ANONYMOUS, ADMIN, INSPECTOR, PROFESSOR, STUDENT!");
                            }
                        }
                    }
                }
            }
        }
    }
}
