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

namespace Hlaskovac
{
    /// <summary>
    /// Interaction logic for AddQuote.xaml
    /// </summary>
    public partial class AddQuote : Window
    {
        QuoteManager quoteManager = new QuoteManager();
        public AddQuote()
        {
            InitializeComponent();
        }

        private void buttonCancelQuote_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonSaveQuote_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxNewQuote.Text.Length != 0 && textBoxNewQuoteAuthor.Text.Length != 0 && textBoxNewQuoteTitle.Text.Length != 0)
            {
                string title = textBoxNewQuoteTitle.Text;
                string quoteText = textBoxNewQuote.Text;
                string quoteAuthor = textBoxNewQuoteAuthor.Text;

                Quote newQuote = new Quote(title, quoteText, quoteAuthor);

                quoteManager.AddQuote(newQuote);

                

                Close();
            }
        }
    }
}
