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
    public partial class R : Form
    {
        public R()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextResistor.Text);

            //сделать защиту от дурака
            GV.in_r[i, 0] = Int32.Parse(m_nPlusResistor.Text);
            GV.in_r[i, 1] = Int32.Parse(m_nMinusResistor.Text);
            GV.z_r[i] = Single.Parse(m_zResistor.Text);
            i++;
            m_nextResistor.Text = i.ToString();
            if (i <= GV.resistorsValue)
            {
                m_nPlusResistor.Text = "0";
                m_nMinusResistor.Text = "0";
                m_zResistor.Text = "0";
                m_nPlusResistor.Focus();
            }
            else
                this.Close();

        }
    }
}
