using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MeghanShannon
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddNewQuotes_Click(object sender, EventArgs e)
        {
            AddQuote AddNewQuoteForm = new AddQuote { Tag = this };
            AddNewQuoteForm.Show(this);
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAllQuotesForm = new ViewAllQuotes { Tag = this };
            ViewAllQuotesForm.Show(this);
            this.Hide();
        }

        private void SearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotesForm = new SearchQuotes { Tag = this };
            SearchQuotesForm.Show(this);
            this.Hide();
        }
    }
}
