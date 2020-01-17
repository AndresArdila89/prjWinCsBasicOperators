using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsBasicOperators
{
    public partial class frmOperators : Form
    {
        public frmOperators()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblResoult_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            Int32 resoult = Convert.ToInt32(txtValue1.Text) + Convert.ToInt32(txtValue2.Text);

            lblResoult.Text = Convert.ToString(resoult);

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            lblResoult.Text = "";
            txtValue1.Clear();
            txtValue2.Clear();
        }
    }
}
