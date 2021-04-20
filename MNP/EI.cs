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
    public partial class EI : Form
    {
        public EI()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {

            try
            {
                int i = Convert.ToInt32(m_nextei.Text);
                GV.in_CCVS[i, 0] = Convert.ToInt32(np1ei.Text);
                GV.in_CCVS[i, 1] = Convert.ToInt32(nm1ei.Text);
                GV.in_CCVS[i, 2] = Convert.ToInt32(np2ei.Text);
                GV.in_CCVS[i, 3] = Convert.ToInt32(nm2ei.Text);
                GV.z_CCVS[i] = Convert.ToInt32(mu.Text);
                i++;
                m_nextei.Text = i.ToString();
                if (i <= GV.CurContrVoltSources)
                {
                    np1ei.Text = "0";
                    nm1ei.Text = "0";
                    np2ei.Text = "0";
                    nm2ei.Text = "0";
                    m_nextei.Text = "0";
                    np1ei.Focus();
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
