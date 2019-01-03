using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_ADMIN_OOSD
{
    public partial class FileIOTest : Form
    {
        public FileIOTest()
        {
            InitializeComponent();
        }

        private void BMake_Click(object sender, EventArgs e)
        {
            string fName = TBName.Text;
            List<string> fCont = new List<string>();
            fCont.Add(TBTest1.Text);
            FileIO.save(fName, fCont);
        }
    }
}
