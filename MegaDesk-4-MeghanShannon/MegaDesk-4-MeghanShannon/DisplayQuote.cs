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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string customerName, DateTime quoteDate, int width, int depth,
            int numOfDrawers, Material desktopMaterial, int rushOrderDays, int deskQuote)
        {
            /*
             * This form view displays the current quote information after a successful quote add.
             */

            InitializeComponent();
            customerNameLabel.Text = customerName;
            quoteDateLabel.Text = quoteDate.ToString("dd MMM yyyy");
            deskWidthLabel.Text = width.ToString() + " inches";
            deskDepthLabel.Text = depth.ToString() + " inches";
            numDrawersLabel.Text = numOfDrawers.ToString();
            desktopMaterialLabel.Text = desktopMaterial.ToString();
            if (rushOrderDays == 0)
            {
                rushOrderLabel.Text = "None";
            }
            else
            {
                rushOrderLabel.Text = rushOrderDays.ToString() + " days";
            }
            quoteAmountLabel.Text = String.Format("{0:C}", deskQuote);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }
    }
}
