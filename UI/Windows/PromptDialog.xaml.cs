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

namespace UI.Windows
{
    /// <summary>
    /// Interaction logic for PromptDialog.xaml
    /// </summary>
    public partial class PromptDialog : Window
    {
        private string message;
        private PasswordBox passwordBox;

        public PromptDialog()
        {
            InitializeComponent();
        }

        public PromptDialog(string message, PasswordBox passwordBox)
        {
            this.message = message;
            this.passwordBox = passwordBox;
        }
    }
}
