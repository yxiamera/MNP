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
    public partial class IO : Form
    {
        public IO()
        {
            InitializeComponent();
        }

        private void IDC_IOOK_BUTTON_Click(object sender, EventArgs e)
        {
            //l+
            try
            {
                GV.lp = Int32.Parse(m_lp.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение l+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.lp = 0;
            }

            if (GV.lp < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение l+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.lp = 0;
            }

            //l-
            try
            {
                GV.lm = Int32.Parse(m_lm.Text); 
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение l- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.lm = 0;
            }

            if (GV.lm < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение l- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.lm = 0;
            }

            //k+
            try
            {
                GV.kp = Int32.Parse(m_kp.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение k+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.kp = 0;
            }

            if (GV.kp < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение k+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.kp = 0;
            }

            //k-
            try
            {
                GV.km = Int32.Parse(m_km.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение k- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.km = 0;
            }

            if (GV.km < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение k- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.km = 0;
            }

            this.Close();
        }
    }
}
