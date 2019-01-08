using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _207Proj2
{
    public partial class Form1 : Form
    {
        // creates an object of an empty list
        List<Package> packages = new List<Package>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // read customer list from the external file and 
            // display the data in the listbox
            packages = FileIO2.ReadData();
            DisplayPackages();
            
        }
        // function that takes string from the list and adds them to the listbox
        private void DisplayPackages()
        {
            lstPackages.Items.Clear(); // start with empty list box
            // go through the list and add each product to the list box
            foreach (Package p in packages)
            {
                lstPackages.Items.Add(p.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstPackages.SelectedItems.Clear();
            for (int i = lstPackages.Items.Count - 1; i >= 0; i--)
            {
                if (lstPackages.Items[i].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    lstPackages.SetSelected(i, true);
                }
            }
            lblResults.Text = lstPackages.SelectedItems.Count.ToString() + " packages found";
        }
       



        //private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    Package curPkg = ReadData(lstPackages.SelectedItem);
        //    lstCurPkg.Items.Add(curPkg.ToString());
        //}
    }
}
