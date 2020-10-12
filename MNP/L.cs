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
    public partial class L : Form
    {
        public L()
        {
            InitializeComponent();
        }

        private void IDC_NEXTIND_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextInductor.Text);

            //n+
            try
            {
                GV.in_l[i, 0] = Int32.Parse(m_nPlusInductor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.in_l[i, 0] = 0;
            }

            if (GV.in_l[i, 0] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.in_l[i, 0] = 0;
            }

            //n-
            try
            {
                GV.in_l[i, 1] = Int32.Parse(m_nMinusInductor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.in_l[i, 1] = 0;
            }

            if (GV.in_l[i, 1] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.in_l[i, 1] = 0;
            }

            //номинал
            try
            {
                GV.z_l[i] = Single.Parse(m_zInductor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение номинала индуктивности будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.z_l[i] = 0;
            }

            if (GV.z_l[i] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение номинала индуктивности будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.z_l[i] = 0;
            }

            i++;
            m_nextInductor.Text = i.ToString();
            if (i <= GV.inductorsValue)
            {
                m_nPlusInductor.Text = "0";
                m_nMinusInductor.Text = "0";
                m_zInductor.Text = "0";
                m_nPlusInductor.Focus();
            }
            else
                this.Close();
        }
    }
}
