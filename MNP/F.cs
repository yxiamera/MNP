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
    public partial class F : Form
    {
        int m_f = 0;
        public F()
        {
            InitializeComponent();
        }

        private void IDC_F_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 0;
            IDC_T1.Text = "Значение частоты (кгц)";
            IDC_T2.Text = "";
            IDC_T3.Text = "";
        }

        private void IDC_DF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 1;
            IDC_T1.Text = "Минимальная частота Fmin(кгц)";
            IDC_T2.Text = "Максимальная частота Fmax(кгц)";
            IDC_T3.Text = "Шаг изменения частоты dF(кгц)";
        }

        private void IDC_KF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 2;
            IDC_T1.Text = "Минимальная частота Fmin(кгц)";
            IDC_T2.Text = "Максимальная частота Fmax(кгц)";
            IDC_T3.Text = "Отношение соседних частот K";
        }

        private void IDC_FOK_BUTTON_Click(object sender, EventArgs e)
        {
            float fmin, fmax, df, kk;
            int kf;
            switch (m_f)
            {
                case 0:
                    //частота
                    try
                    {
                        GV.frequences[1] = Single.Parse(IDC_F1.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.frequences[1] = 0;
                    }

                    if (GV.frequences[1] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.frequences[1] = 0;
                    }

                    GV.nf = 1;
                    break;
                case 1:
                    //минимальная частота
                    try
                    {
                        GV.frequences[1] = Single.Parse(IDC_F1.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение минимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.frequences[1] = 0;
                    }

                    if (GV.frequences[1] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение минимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.frequences[1] = 0;
                    }
                    fmin = GV.frequences[1];

                    //максимальная частота
                    try
                    {
                        fmax = Single.Parse(IDC_F2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение максимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fmax = 0;
                    }

                    if (fmax < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение максимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fmax = 0;
                    }

                    //шаг изменения частоты
                    try
                    {
                        df = Single.Parse(IDC_F3.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение шага изменения частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        df = 0;
                    }

                    if (df < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение шага изменения частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        df = 0;
                    }

                    kf = 1;
                    while ((GV.frequences[kf] < fmax)&&(kf <= GV.MF - 1))
                    {
                        GV.frequences[kf + 1] = GV.frequences[kf] + df;
                        kf = kf + 1;
                    }

                    if (GV.frequences[kf] < fmax)
                    {
                        MessageBox.Show("Отношение соседних частот слишком мало." + "\nДиапазон частот записан частично.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    GV.nf = kf;
                    break;
                case 2:
                    //минимальная частота
                    try
                    {
                        GV.frequences[1] = Single.Parse(IDC_F1.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение минимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.frequences[1] = 0;
                    }

                    if (GV.frequences[1] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение минимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.frequences[1] = 0;
                    }
                    fmin = GV.frequences[1];

                    //максимальная частота
                    try
                    {
                        fmax = Single.Parse(IDC_F2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение максимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fmax = 0;
                    }

                    if (fmax < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение максимальной частоты будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fmax = 0;
                    }

                    //отношение соседних частот
                    try
                    {
                        kk = Single.Parse(IDC_F3.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение отношения соседних частот будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kk = 10;
                    }

                    if (kk < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение отношения соседних частот будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kk = 10;
                    }

                    kf = 1;
                    while ((GV.frequences[kf] < fmax)&&(kf <= GV.MF - 1))
                    {
                        GV.frequences[kf + 1] = kk * GV.frequences[kf];
                        kf = kf + 1;
                    }

                    if (GV.frequences[kf] < fmax)
                    {
                        MessageBox.Show("Отношение соседних частот слишком мало." + "\nДиапазон частот записан частично.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    GV.nf = kf;
                    break;
            }
            this.Close();
        }
    }
}
