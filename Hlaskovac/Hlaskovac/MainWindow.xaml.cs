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

namespace Hlaskovac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            QuoteManager qm = new QuoteManager();
            Quote q1 = new Quote("Jednicka", "Bla bla bla bla prvni qote.", "Me");
            Quote q2 = new Quote("Duhy", "Duhy me serou. To si tak sedis, hledis si svyho, duhy prilezou a zacnou te kousat do prdele.", "Eric Cartmann");
            qm.AddQuote(q1);
            qm.AddQuote(q2);

            listBoxQuotesList.ItemsSource = QuoteManager.QuotesList;
            
        }

        private T FindWindow<T>() where T : Window
        {
            return Application.Current.Windows.OfType<T>().SingleOrDefault();
        }

        private void buttonAddQuote_Click(object sender, RoutedEventArgs e)
        {
            AddQuote addQuote = FindWindow<AddQuote>() ?? new AddQuote();
            addQuote.Show();
            addQuote.WindowState = WindowState.Normal;
            addQuote.Activate(); 
        }

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            listBoxQuotesList.ItemsSource = QuoteManager.QuotesList;
        }
    }
}