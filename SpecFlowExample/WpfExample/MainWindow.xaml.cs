using System.Windows;

namespace WpfExample
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

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtResult.Text))
            {
                txtResult.Text = "Clicked";
            }
            else
            {
                txtResult.Text = string.Empty;
            }
        }
    }
}