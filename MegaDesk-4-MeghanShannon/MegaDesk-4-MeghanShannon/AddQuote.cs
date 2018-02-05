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
    public partial class AddQuote : Form
    {
        #region Declarations

        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0; // number of desk drawers
        string MaterialString = ""; // "" versus String.Empty desktop material selection
        Material Material;
        int RushOrderDays = 0; // rush order selection in days
        int DeskQuoteTotal = 0; // desk quote total
        string fileName = "";

        #endregion

        public AddQuote()
        {
            /*
             * This form provides the user input interface.
             */
            InitializeComponent();
            List<Material> DesktopMaterialList = Enum.GetValues(typeof(Material)).Cast<Material>().ToList();
            surfaceMaterialCB.DataSource = DesktopMaterialList;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var ReturnMainMenu = (MainMenu)Tag;
            //ReturnMainMenu.Show();
            //this.Close();
        }

        private void deskWidthTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int widthInput;
            if (int.TryParse(deskWidthTB.Text, out widthInput)) {
                if (widthInput < Desk.MINWIDTH || widthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width between 24 and 96 inches.");
                    deskWidthTB.Text = String.Empty;
                    deskWidthTB.BackColor = Color.LightSalmon;
                    deskWidthTB.Focus();
                }
                else {
                    deskWidthTB.BackColor = Color.White;
                }
            } else
            {
                MessageBox.Show("Please enter a valid width measurement as a whole number.");
                deskWidthTB.Text = "";
                deskWidthTB.BackColor = Color.LightSalmon;
                deskWidthTB.Focus();
            }
        }
        
        private void deskDepthTB_Validating(object sender, CancelEventArgs e)
        {
            int depthInput;
            if (int.TryParse(deskDepthTB.Text, out depthInput))
            {
                if (depthInput < Desk.MINDEPTH || depthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth between 12 and 48 inches.");
                    deskDepthTB.Text = String.Empty;
                    deskDepthTB.BackColor = Color.LightSalmon;
                    deskDepthTB.Focus();
                }
                else
                {
                    deskDepthTB.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid depth measurement as a whole number.");
                deskDepthTB.Text = "";
                deskDepthTB.BackColor = Color.LightSalmon;
                deskDepthTB.Focus();
            }
        }

        private void Dimensions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void AddDeskButton_Click(object sender, EventArgs e)
        {
            //MaterialString = surfaceMaterialCB.SelectedItem.ToString();
            //Material materialValue = (Material)Enum.Parse(typeof(Material), MaterialString);
            //Input
            try
            {
                CustomerName = customerNameTB.Text;
                DeskWidth = int.Parse(deskWidthTB.Text);
                DeskDepth = int.Parse(deskDepthTB.Text);
                Drawers = int.Parse(drawerNumCB.SelectedItem.ToString());

                string MaterialString = surfaceMaterialCB.SelectedItem.ToString();
                Enum.TryParse(MaterialString, out Material);

                //MaterialString = surfaceMaterialCB.SelectedItem.ToString();
                //Material materialValue = (Material)Enum.Parse(typeof(Material), MaterialString);

                //get rush order selection
                if (rushThreeRadio.Checked)
                {
                    RushOrderDays = 3;
                }
                else if (rushFiveRadio.Checked)
                {
                    RushOrderDays = 5;
                }
                else if (rushSevenRadio.Checked)
                {
                    RushOrderDays = 7;
                }

                //Create  new DeskQuote object and calculate total
                DeskQuote NewQuote = new DeskQuote(DeskWidth, DeskDepth, Drawers, Material, RushOrderDays);
                DeskQuoteTotal = NewQuote.CalculateQuoteTotal();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input methods.");
                throw;
            }

            try
            {
                //build output string csv
                var DeskRecord = CustomerName + ", " + DateTime.Now + ", " + DeskWidth + ", " + DeskDepth + ", " + Drawers +
                    ", " + Material + ", " + RushOrderDays + ", " + DeskQuoteTotal;
                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    StreamWriter sw = File.CreateText("quotes.txt");
                }
                using (StreamWriter sw = File.AppendText("quotes.txt"))
                {
                    sw.WriteLine(DeskRecord);
                }
            }
            catch {
                MessageBox.Show("Did not save.");
            }

            #region Display To Screen
            // Show confirmation page on new screen named DeskQuoteView
            var MainMenu = (MainMenu)Tag; // need to bring along a reference tag to the main menu form
            DisplayQuote newOrderView = new DisplayQuote(CustomerName, DateTime.Now.Date, DeskWidth, DeskDepth, Drawers,
                Material, RushOrderDays, DeskQuoteTotal)
            {
                Tag = MainMenu
            };
            newOrderView.Show();
            this.Close();
            #endregion
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }
    }
}
