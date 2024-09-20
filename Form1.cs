using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaveFacil
{
    public partial class FrmChaveFacil : Form
    {
        public FrmChaveFacil()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRtrS1_Click(object sender, EventArgs e)
        {
            btnDvlrS1.Enabled = true;
            btnRtrS1.Enabled = false;
            panel1.BackColor = Color.Red;
    
            form2.ShowDialog();
        }

        private void btnDvlrS1_Click(object sender, EventArgs e)
        {
            btnDvlrS1.Enabled = false;
            btnRtrS1.Enabled = true;
            panel1.BackColor = Color.Lime;
           
            form2.ShowDialog();
        }
    }
}
