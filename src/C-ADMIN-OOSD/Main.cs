using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    FILE: DBCall.cs
    FUCNTION: Interperate calls to MSSQL DB

    Authors: 
    Noah German (Alias: Nalal/Nacalal/Nac)

    INIT DATE (D/M/Y): 13/12/2018
*/


namespace C_ADMIN_OOSD
{
    public partial class Main : Form
    {
        //Form initialization, anything you want to load when the program loads should be placed here
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Opens DB Testing Window, please don't touch, I'll remove it once the MySQL functions are working as intended
        private void BDBTest_Click(object sender, EventArgs e)
        {
            Form DBT = new MySQL_TestForm();
            DBT.ShowDialog();
        }
    }
}
