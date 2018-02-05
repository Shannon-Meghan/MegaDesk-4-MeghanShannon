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
    public partial class SearchQuotes : Form
    {
        Material Material;

        public SearchQuotes()
        {
            /*
             * This user interface form allows the user to pick a material type from a combo box and displays all quotes with that material.
             */
            InitializeComponent();
            //populate combobox with materials
            List<Material> DesktopMaterialList = Enum.GetValues(typeof(Material)).Cast<Material>().ToList();
            surfaceMaterialCB.DataSource = DesktopMaterialList;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            //return user to main menu
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void surfaceMaterialCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Grab the material in the combobox
            string MaterialString = surfaceMaterialCB.SelectedItem.ToString();
            Enum.TryParse(MaterialString, out Material);

            try
            {
                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    MessageBox.Show("No data exist.");
                }
                else { 
                    using (FileStream fs = new FileStream(cFile, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            int totalLines = TotalLines(sr);
                            if (totalLines > 0)
                            {
                                string line = sr.ReadLine();
                                for (int i = 0; i <= totalLines; i++)
                                {
                                    if (line.Contains(Material.ToString())) { 
                                        var listViewItem = new ListViewItem(sr.ReadLine());
                                        quoteListView.View = View.List;
                                        quoteListView.Items.Add(listViewItem);
                                    }
                                }                                
                            }
                            else {
                                MessageBox.Show("No data exist.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The process failed: {0}", ex.ToString());
            }
        }
        int TotalLines(StreamReader r)
        {
                int i = 0;
                while (r.ReadLine() != null) { i++; }
                return i;
        }
    }
}
