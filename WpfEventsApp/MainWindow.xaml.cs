using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEventsApp
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

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtTablo.Text += "sender: " + sender.ToString() + "\n";
            txtTablo.Text += "source: " + e.Source.ToString() + "\n\n";
            if (sender == e.Source)
                e.Handled = true;
        }

        private void StackPanel_Checked(object sender, RoutedEventArgs e)
        {
            //RadioButton rb = (RadioButton)e.Source;
            //txtTablo.Text = rb.Content.ToString();
        }

        private void txtEditor_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //if (e.Delta > 0)
            //    txtEditor.FontSize += 2;
            //else if(e.Delta < 0)
            //    txtEditor.FontSize -= 2;
        }
    }
}