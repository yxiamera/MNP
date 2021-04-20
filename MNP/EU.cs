using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNP
{
    public partial class EU : Form
    {
        public EU()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(m_nexteu.Text);
                GV.in_VCVS[i, 0] = Convert.ToInt32(np1eu.Text);
                GV.in_VCVS[i, 1] = Convert.ToInt32(nm1eu.Text);
                GV.in_VCVS[i, 2] = Convert.ToInt32(np2eu.Text);
                GV.in_VCVS[i, 3] = Convert.ToInt32(nm2eu.Text);
                GV.z_VCVS[i, 0] = Convert.ToInt32(t1.Text);
                GV.z_VCVS[i, 1] = Convert.ToInt32(t2.Text);
                GV.z_VCVS[i, 2] = Convert.ToInt32(mu.Text);
                i++;
                m_nexteu.Text = i.ToString();
                if (i <= GV.VoltContrVoltSources)
                {
                    np1eu.Text = "0";
                    nm1eu.Text = "0";
                    np2eu.Text = "0";
                    nm2eu.Text = "0";
                    m_nexteu.Text = "0";
                    np1eu.Focus();
                }
                else
                    this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Введены неправильные значения");
            }
        }
    }
}
