using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MeghanShannon
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            /*
             * This form will display all the quotes by reading from the a text file where quotes are stored.
             */ 
            InitializeComponent();
            try
            {
                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    MessageBox.Show("No data exist.");
                }
                using (FileStream fs = new FileStream(cFile, FileMode.Open)) { 
                    using (StreamReader sr = new StreamReader(fs)) {
                        while (sr.Peek() >= 0)
                        {
                            var listViewItem = new ListViewItem(sr.ReadLine());
                            quoteListView.View = View.List;
                            quoteListView.Items.Add(listViewItem);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }
    }
}
