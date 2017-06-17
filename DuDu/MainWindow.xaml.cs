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

namespace DuDu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtInput.Text))
            {
                Button btn = new Button();
                btn.Content = this.txtInput.Text;
                btn.Padding = new Thickness(6, 6, 6, 10);
                btn.Margin = new Thickness(1, 10, 15, 10);
                btn.HorizontalAlignment = HorizontalAlignment.Right;
                this.txtHistory.Children.Add(btn);
                this.txtInput.Text = string.Empty;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.txtInput.Text = string.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtInput.Text))
            {
                Button btn = new Button();
                btn.Content = this.txtInput.Text;
                btn.Padding = new Thickness(6, 6, 6, 10);
                btn.Margin = new Thickness(15, 10, 1, 10);
                btn.HorizontalAlignment = HorizontalAlignment.Left;
                this.txtHistory.Children.Add(btn);
                this.txtInput.Text = string.Empty;
            }
        }
    }
}
