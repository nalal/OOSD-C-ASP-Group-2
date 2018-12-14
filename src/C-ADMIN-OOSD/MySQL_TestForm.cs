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
    public partial class MySQL_TestForm : Form
    {
        private string TestOutput = "TEST:\n";
        public MySQL_TestForm()
        {
            InitializeComponent();
        }

        private void MySQL_TestForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            DBData.DB = TBDB.Text;
            DBData.IP = TBIP.Text;
            DBData.Pass = TBPass.Text;
            DBData.User = TBUser.Text;
            DBData.Port = TBPort.Text;
            string DBLogin = DBData.DB + DBData.IP + DBData.Pass + DBData.User + DBData.Port;
            LTest.Text = TestOutput + DBLogin;
            MessageBox.Show(DBLogin, "TESTBOX");
            DBData.DBCon();

        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
