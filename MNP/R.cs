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

            //n+
            try
            {
                GV.in_r[i, 0] = Int32.Parse(m_nPlusResistor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.in_r[i, 0] = 0;
            }

            if (GV.in_r[i, 0] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.in_r[i, 0] = 0;
            }

            //n-
            try
            {
                GV.in_r[i, 1] = Int32.Parse(m_nMinusResistor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.in_r[i, 1] = 0;
            }

            if (GV.in_r[i, 1] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.in_r[i, 1] = 0;
            }

            //номинал
            try
            {
                GV.z_r[i] = Single.Parse(m_zResistor.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение номинала резистора будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.z_r[i] = 0;
            }

            if (GV.z_r[i] < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение номинала резистора будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.z_r[i] = 0;
            }

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
