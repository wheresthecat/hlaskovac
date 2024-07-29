using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hlaskovac
{
    public class QuoteManager
    {
        private static List<Quote> m_quotesList;

        public static List<Quote> QuotesList => m_quotesList;

        //private static ObservableCollection<Quote> m_quotesList;
        //public static ObservableCollection<Quote> QuotesList => m_quotesList;


        public QuoteManager()
        {
            m_quotesList = new List<Quote>();
            //m_quotesList = new ObservableCollection<Quote>();
        }

        public void AddQuote(Quote newQuote)
        {
            m_quotesList.Add(newQuote);
        }
    }
}
