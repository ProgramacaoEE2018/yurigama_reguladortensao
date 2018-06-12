using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReguladorTensaoZener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            Double vi, vz, i, rl;
            Double rs, pot, iz, potrl, vo;

            if ((txtvi.Text == ""|| txtvi.Text == "0") || (txtvz.Text == ""|| txtvz.Text == "0") || (txti.Text == ""|| txti.Text == "0") || (txtrl.Text == ""|| txtrl.Text == "0"))
            {
                MessageBox.Show("Informe os valores de entrada!");
            }

            else
            {
                vi = Convert.ToDouble(txtvi.Text);
                vz = Convert.ToDouble(txtvz.Text);
                i = Convert.ToDouble(txti.Text);
                rl = Convert.ToDouble(txtrl.Text);

                rs = (vi - vz) / i;
                pot = i * i * rs;
                iz = ((vi - vz) / rs) - (vz / rl);
                potrl = (i - iz) * (i - iz) * rl;
                vo = (i - iz) * rl;

                lblrs.Text = rs.ToString();
                lblpot.Text = pot.ToString();
                lbliz.Text = iz.ToString();
                lblpotrl.Text = potrl.ToString();
                lblvo.Text = vo.ToString();
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtvi.Clear();
            txtvz.Clear();
            txti.Clear();
            txtrl.Clear();

            lblrs.Text = "";
            lblpot.Text = "";
            lbliz.Text = "";
            lblpotrl.Text = "";
            lblvo.Text = "";
        }
    }
}
