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

            //количество ИТУТ
            try
            {
                GV.CurContrCurSources = Int32.Parse(m_CurContCurSources.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество ИТУТ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.CurContrCurSources = 0;
            }

            if (GV.CurContrCurSources < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество ИТУТ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.CurContrCurSources = 0;
            }

            //количество ИТУН
            try
            {
                GV.VoltContrCurSources = Int32.Parse(m_VolContCurSources.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество ИТУН будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.VoltContrCurSources = 0;
            }

            if (GV.VoltContrCurSources < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество ИТУН будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.VoltContrCurSources = 0;
            }

            //количество ИНУТ
            try
            {
                GV.CurContrVoltSources = Int32.Parse(m_CurContVolSources.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество ИНУТ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.CurContrVoltSources = 0;
            }

            if (GV.CurContrVoltSources < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество ИНУТ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.CurContrVoltSources = 0;
            }

            //количество ИНУН
            try
            {
                GV.VoltContrVoltSources = Int32.Parse(m_VolContVolSources.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество ИНУН будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.VoltContrVoltSources = 0;
            }

            if (GV.VoltContrVoltSources < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество ИНУН будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.VoltContrVoltSources = 0;
            }

            //количество ИОУ
            try
            {
                GV.idealOpAmps = Int32.Parse(m_idealOpAmps.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество ИОУ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.idealOpAmps = 0;
            }

            if (GV.idealOpAmps < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество ИОУ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.idealOpAmps = 0;
            }

            //количество ИТр
            try
            {
                GV.idealTransformers = Int32.Parse(m_idealTransformers.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество идеальных трансформаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.idealTransformers = 0;
            }

            if (GV.idealTransformers < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество идеальных трансформаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.idealTransformers = 0;
            }

            //количество ОУ
            try
            {
                GV.opAmps = Int32.Parse(m_opAmps.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество ОУ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.opAmps = 0;
            }

            if (GV.opAmps < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество ОУ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.opAmps = 0;
            }

            //количество трансформаторов
            try
            {
                GV.transformers = Int32.Parse(m_transformers.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество трансформаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.transformers = 0;
            }

            if (GV.transformers < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество трансформаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.transformers = 0;
            }

            //количество униполярных транзисторов
            try
            {
                GV.uniPolarTransistors = Int32.Parse(m_uniPolarTransistors.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество униполярных транзисторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.uniPolarTransistors = 0;
            }

            if (GV.uniPolarTransistors < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество униполярных транзисторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.uniPolarTransistors = 0;
            }

            //количество биполярных транзисторов
            try
            {
                GV.biPolarTransistors = Int32.Parse(m_biPolarTransistors.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество биполярных транзисторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.biPolarTransistors = 0;
            }

            if (GV.uniPolarTransistors < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество биполярных транзисторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.biPolarTransistors = 0;
            }

            this.Close();
        }
    }
}
