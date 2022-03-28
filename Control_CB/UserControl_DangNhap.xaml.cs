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

namespace Control_CB
{
    /// <summary>
    /// Interaction logic for UserControl_DangNhap.xaml
    /// </summary>
    public partial class UserControl_DangNhap : UserControl
    {
        public UserControl_DangNhap()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login thành công với ");
        }
    }
}
