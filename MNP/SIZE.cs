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
    public partial class SIZE : Form
    {
        public SIZE()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //считываем данные из формы в переменные, проверяем на правильность
            //количество узлов
            try
            {
                GV.nodesValue = Int32.Parse(m_nodesValue.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество узлов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.nodesValue = 0;
            }

            if (GV.nodesValue < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" +  "\nКоличество узлов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.nodesValue = 0;
            }

            //количество резисторов
            try
            {
                GV.resistorsValue = Int32.Parse(m_resistorsValue.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество резисторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.resistorsValue = 0;
            }

            if (GV.resistorsValue < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество резисторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.resistorsValue = 0;
            }

            //количество конденсаторов
            try
            {
                GV.capasitorsValue = Int32.Parse(m_capasitorsValue.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество конденсаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.capasitorsValue = 0;
            }

            if (GV.capasitorsValue < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество конденсаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.capasitorsValue = 0;
            }

            //количество индуктивностей
            try
            {
                GV.inductorsValue = Int32.Parse(m_inductorsValue.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество индуктивностей будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.inductorsValue = 0;
            }

            if (GV.inductorsValue < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество индуктивностей будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.inductorsValue = 0;
            }

            this.Close();
        }
    }
}
