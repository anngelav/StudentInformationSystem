using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
using UI.Components;
using UI.Extras;
using UI.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool unlockWithButton { get; set; }
        public ICommand Edit_ClickCommand { get; set; }
        //public ICommand Unlock_ClickCommand { get; set; }

        public MainWindow()
        {
            Edit_ClickCommand = new RelayCommand(ExecuteMethodEdit_ClickCommand, CanExecuteMethodEdit_ClickCommand);
            InitializeComponent();
            this.DataContext = this;
            //Unlock_ClickCommand = new RelayCommand(ExecuteMethodUnlock_ClickCommand, CanExecuteMethodUnlock_ClickCommand);
        }

        private void UnlockButton_Click(object sender, RoutedEventArgs e)
        {
            unlockWithButton = !unlockWithButton;
        }

        private bool CanExecuteMethodEdit_ClickCommand()
        {
            return unlockWithButton;
        }

        private void ExecuteMethodEdit_ClickCommand()
        {
            //to open new window for editing
            var sc = studentsList;
            var studentComponent = sc.students;
            if (studentComponent.SelectedItems.Count == 1)
            {
                var selectedItem = (DatabaseUser)studentComponent.SelectedItem;

                EditingWindow EditWindow = new EditingWindow(selectedItem);
                EditWindow.Show();
            } else
            {
                MessageBox.Show("Select row from the table to edit!");
            }
        }

        //private bool CanExecuteMethodUnlock_ClickCommand(object parameter)
        //{
        //    return true;
        //}

        //private void ExecuteMethodUnlock_ClickCommand(object parameter)
        //{
        //    //to unlock edit button code
        //}

        //private void UserTable_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    // Get the selected row
        //    var selectedRow = ((DataGrid)sender).SelectedItem as DataRowView;

        //    if (selectedRow != null)
        //    {
        //        // Get the user ID from the selected row
        //        //int userId = (int)selectedRow["Id"];

        //        // Display a message box asking for the password
        //        //string password = PromptForPassword();

        //        // Check if the password is correct
        //        //if (IsPasswordCorrect(userId, password))
        //        //{
        //        //    // Enable the button
        //        //    unlock.IsEnabled = true;
        //        //}
        //        //else
        //        //{
        //        //    MessageBox.Show("Invalid password!");
        //        //}
        //        MessageBox.Show("You clicked two times");
        //    }

        //}

        //public event EventHandler<DataRowView> RowDoubleClick;

        private void StudentsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //var selectedRow = ((DataGrid)sender).SelectedItem as DataRowView;
            //RowDoubleClick?.Invoke(this, selectedRow);
            //if (selectedRow != null)
            //{
            //    MessageBox.Show("Hello");
            //}
        }

        //private string PromptForPassword()
        //{
        //    var passwordBox = new PasswordBox();
        //    var prompt = new PromptDialog("Enter password:", passwordBox);
        //    prompt.ShowDialog();

        //    return passwordBox.Password;
        //}
    }
}
