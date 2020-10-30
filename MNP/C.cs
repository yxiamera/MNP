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
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void IDC_NEXTC_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextCapasitor.Text);

            //n+
            try
            {
                GV.in_c[i, 0] = Int32.Parse(m_nPlusCapasitor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.in_c[i, 0] = 0;
            }

            if (GV.in_c[i, 0] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.in_c[i, 0] = 0;
            }

            //n-
            try
            {
                GV.in_c[i, 1] = Int32.Parse(m_nMinusCapasitor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.in_c[i, 1] = 0;
            }

            if (GV.in_c[i, 1] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.in_c[i, 1] = 0;
            }

            //номинал
            try
            {
                GV.z_c[i] = Single.Parse(m_zCapasitor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение номинала конденсатора будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.z_c[i] = 0;
            }

            if (GV.z_c[i] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение номинала конденсатора будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.z_c[i] = 0;
            }

            i++;
            m_nextCapasitor.Text = i.ToString();
            if (i <= GV.capasitorsValue)
            {
                m_nPlusCapasitor.Text = "0";
                m_nMinusCapasitor.Text = "0";
                m_zCapasitor.Text = "0";
                m_nPlusCapasitor.Focus();
            }
            else
                this.Close();
        }
    }
}
