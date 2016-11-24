using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Maker_ECManagement
{
    public partial class ECManagement : Form
    {
        public ECManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecdataDataSet1.HocSinh' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'ecdataDataSet.HocSinh' table. You can move, or remove it, as needed.
            panel1.AutoSize = true;
        }
    }
}
