using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hlaskovac
{
    public class Quote
    {
        // Add id or timestamp later
        private string m_title;
        private string m_quoteText;
        private string m_author;

        public string Title => m_title;
        public string QuoteText => m_quoteText;
        public string Author => m_author;

        public Quote(string title, string quoteText, string author)
        {
            m_title = title;
            m_quoteText = quoteText;
            m_author = author;
        }

        public string GetQuoteTitle()
        {
            return $"{m_title}";
        }

        public override string ToString()
        {
            return $"{m_title}";
        }

    }
}
