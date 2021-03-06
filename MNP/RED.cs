﻿using System;
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
    public partial class RED : Form
    {
        public RED()
        {
            InitializeComponent();
        }

        private void m_redlst_DoubleClick(object sender, EventArgs e)
        {
            {
                String i1, i2, i3, i4, i5, i6, i7, i8, i9;
                //Начальная установка
                m_np1.Show();
                m_nm1.Show();
                m_np2.Show();
                m_nm2.Show();
                m_z1.Show();
                m_z2.Show();
                m_z3.Show();
                m_z4.Show();
                m_z5.Show();
                m_z6.Show();

                IDC_NP1_STATIC.Show();
                IDC_NM1_STATIC.Show();
                IDC_NP2_STATIC.Show();
                IDC_NM2_STATIC.Show();
                IDC_Z1_STATIC.Show();
                IDC_Z2_STATIC.Show();
                IDC_Z3_STATIC.Show();
                IDC_Z4_STATIC.Show();
                IDC_Z5_STATIC.Show();
                IDC_Z6_STATIC.Show();

                m_np1.Text = "";
                m_nm1.Text = "";
                m_np2.Text = "";
                m_nm2.Text = "";
                m_z1.Text = "";
                m_z2.Text = "";
                m_z3.Text = "";
                m_z4.Text = "";
                m_z5.Text = "";
                m_z6.Text = "";

                //Выбор типа компонента из списка и настройка панели
                int idx = m_redlst.SelectedIndex;
                switch (idx)
                {
                    case 0: //резисторы
                        i1 = "n+";
                        i2 = "n-";
                        i3 = "КОм";

                        IDC_NP2_STATIC.Text = i1;
                        IDC_NM2_STATIC.Text = i2;
                        IDC_Z1_STATIC.Text = i3;

                        m_np1.Hide();
                        m_nm1.Hide();
                        m_z2.Hide();
                        m_z3.Hide();
                        m_z4.Hide();
                        m_z5.Hide();
                        m_z6.Hide();

                        IDC_NP1_STATIC.Hide();
                        IDC_NM1_STATIC.Hide();
                        IDC_Z2_STATIC.Hide();
                        IDC_Z3_STATIC.Hide();
                        IDC_Z4_STATIC.Hide();
                        IDC_Z5_STATIC.Hide();
                        IDC_Z6_STATIC.Hide();

                        m_n.Focus();
                        break;
                    case 1: //конеденсаторы
                        i1 = "n+";
                        i2 = "n-";
                        i3 = "мкФ";

                        IDC_NP2_STATIC.Text = i1;
                        IDC_NM2_STATIC.Text = i2;
                        IDC_Z1_STATIC.Text = i3;

                        m_np1.Hide();
                        m_nm1.Hide();
                        m_z2.Hide();
                        m_z3.Hide();
                        m_z4.Hide();
                        m_z5.Hide();
                        m_z6.Hide();

                        IDC_NP1_STATIC.Hide();
                        IDC_NM1_STATIC.Hide();
                        IDC_Z2_STATIC.Hide();
                        IDC_Z3_STATIC.Hide();
                        IDC_Z4_STATIC.Hide();
                        IDC_Z5_STATIC.Hide();
                        IDC_Z6_STATIC.Hide();

                        m_n.Focus();
                        break;
                    case 2: //индуктивности
                        i1 = "n+";
                        i2 = "n-";
                        i3 = "Значение";

                        IDC_NP2_STATIC.Text = i1;
                        IDC_NM2_STATIC.Text = i2;
                        IDC_Z1_STATIC.Text = i3;

                        m_np1.Hide();
                        m_nm1.Hide();
                        m_z2.Hide();
                        m_z3.Hide();
                        m_z4.Hide();
                        m_z5.Hide();
                        m_z6.Hide();

                        IDC_NP1_STATIC.Hide();
                        IDC_NM1_STATIC.Hide();
                        IDC_Z2_STATIC.Hide();
                        IDC_Z3_STATIC.Hide();
                        IDC_Z4_STATIC.Hide();
                        IDC_Z5_STATIC.Hide();
                        IDC_Z6_STATIC.Hide();

                        m_n.Focus();

                        break;
                    case 6: //ИНУН
                        i1 = "n1+";
                        i2 = "n1-";
                        i3 = "n2+";
                        i4 = "n2-";
                        i5 = "mu";
                        i6 = "T1";
                        i7 = "T2";

                        IDC_NP1_STATIC.Text = i1;
                        IDC_NM1_STATIC.Text = i2;
                        IDC_NP2_STATIC.Text = i3;
                        IDC_NM2_STATIC.Text = i4;
                        IDC_Z1_STATIC.Text = i5;
                        IDC_Z2_STATIC.Text = i6;
                        IDC_Z3_STATIC.Text = i7;

                        m_z4.Hide();
                        m_z5.Hide();
                        m_z6.Hide();

                        IDC_Z4_STATIC.Hide();
                        IDC_Z5_STATIC.Hide();
                        IDC_Z6_STATIC.Hide();
                        m_n.Focus();
                        break;

                    case 5: //ИНУТ
                        i1 = "n1+";
                        i2 = "n1-";
                        i3 = "n2+";
                        i4 = "n2-";
                        i7 = "betta";

                        IDC_NP1_STATIC.Text = i1;
                        IDC_NM1_STATIC.Text = i2;
                        IDC_NP2_STATIC.Text = i3;
                        IDC_NM2_STATIC.Text = i4;
                        IDC_Z1_STATIC.Text = i7;

                        m_z2.Hide();
                        m_z3.Hide();
                        m_z4.Hide();
                        m_z5.Hide();
                        m_z6.Hide();

                        IDC_Z2_STATIC.Hide();
                        IDC_Z3_STATIC.Hide();
                        IDC_Z4_STATIC.Hide();
                        IDC_Z5_STATIC.Hide();
                        IDC_Z6_STATIC.Hide();
                        m_n.Focus();
                        break;
                    case 11: //ИОУ
                        i1 = "n1+";
                        i2 = "n1-";
                        i3 = "n2+";
                        i4 = "n2-";

                        IDC_NP1_STATIC.Text = i1;
                        IDC_NM1_STATIC.Text = i2;
                        IDC_NP2_STATIC.Text = i3;
                        IDC_NM2_STATIC.Text = i4;

                        m_z1.Hide();
                        m_z2.Hide();
                        m_z3.Hide();
                        m_z4.Hide();
                        m_z5.Hide();
                        m_z6.Hide();

                        IDC_Z1_STATIC.Hide();
                        IDC_Z2_STATIC.Hide();
                        IDC_Z3_STATIC.Hide();
                        IDC_Z4_STATIC.Hide();
                        IDC_Z5_STATIC.Hide();
                        IDC_Z6_STATIC.Hide();

                        m_n.Focus();
                        break;
                    case 8: //Униполярные транзисторы
                        i1 = "Затвор";
                        i2 = "Сток";
                        i3 = "Исток";
                        i5 = "Rc";
                        i6 = "Czi";
                        i7 = "Czs";
                        i8 = "Csi";
                        i9 = "S";

                        IDC_NP1_STATIC.Text = i1;
                        IDC_NM1_STATIC.Text = i2;
                        IDC_NP2_STATIC.Text = i3;
                        IDC_Z1_STATIC.Text = i5;
                        IDC_Z2_STATIC.Text = i6;
                        IDC_Z3_STATIC.Text = i7;
                        IDC_Z4_STATIC.Text = i8;
                        IDC_Z5_STATIC.Text = i9;

                        m_nm2.Hide();
                        m_z6.Hide();
                        IDC_NM2_STATIC.Hide();
                        IDC_Z6_STATIC.Hide();

                        m_n.Focus();
                        break;
                }
            }
        }

        private void IDC_OUT_BUTTON_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;

            try
            {
                GV.k = Int32.Parse(m_n.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение номера будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.k = 1;
            }

            if (GV.k < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение номера будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.k = 1;
            }

            switch (idx)
            {
                case 0:
                    if (GV.k > GV.resistorsValue)
                    {
                        MessageBox.Show("Ошибка: Введенный номер больше количества элементов данного типа" + "\nПовторите попытку", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IDC_IN_BUTTON.Enabled = false;
                    }
                    else
                    {
                        m_np2.Text = GV.in_r[GV.k, 0].ToString();
                        m_nm2.Text = GV.in_r[GV.k, 1].ToString();
                        m_z1.Text = GV.z_r[GV.k].ToString();
                        IDC_IN_BUTTON.Enabled = true;
                    }
                    break;
                case 1:
                    if (GV.k > GV.capasitorsValue)
                    {
                        MessageBox.Show("Ошибка: Введенный номер больше количества элементов данного типа" + "\nПовторите попытку", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IDC_IN_BUTTON.Enabled = false;
                    }
                    else
                    {
                        m_np2.Text = GV.in_c[GV.k, 0].ToString();
                        m_nm2.Text = GV.in_c[GV.k, 1].ToString();
                        m_z1.Text = GV.z_c[GV.k].ToString();
                        IDC_IN_BUTTON.Enabled = true;
                    }
                    break;
                case 2:
                    if (GV.k > GV.inductorsValue)
                    {
                        MessageBox.Show("Ошибка: Введенный номер больше количества элементов данного типа" + "\nПовторите попытку", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IDC_IN_BUTTON.Enabled = false;
                    }
                    else
                    {
                        m_np2.Text = GV.in_l[GV.k, 0].ToString();
                        m_nm2.Text = GV.in_l[GV.k, 1].ToString();
                        m_z1.Text = GV.z_l[GV.k].ToString();
                        IDC_IN_BUTTON.Enabled = true;
                    }
                    break;

                case 6:
                    try
                    {
                        GV.in_VCVS[GV.k, 0] = int.Parse(m_np1.Text);
                        GV.in_VCVS[GV.k, 1] = int.Parse(m_nm1.Text);
                        GV.in_VCVS[GV.k, 2] = int.Parse(m_np2.Text);
                        GV.in_VCVS[GV.k, 3] = int.Parse(m_nm2.Text);
                        GV.z_VCVS[GV.k, 2] = float.Parse(m_z1.Text);
                        GV.z_VCVS[GV.k, 0] = float.Parse(m_z2.Text);
                        GV.z_VCVS[GV.k, 1] = float.Parse(m_z3.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    if ((GV.in_VCVS[GV.k, 0] < 0) || (GV.in_VCVS[GV.k, 1] < 0) || (GV.z_VCVS[GV.k, 0] < 0)
                        || (GV.in_VCVS[GV.k, 2] < 0) || (GV.in_VCVS[GV.k, 3] < 0) || (GV.z_VCVS[GV.k, 1] < 0)
                        || (GV.z_VCVS[GV.k, 2] < 0))
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    break;
                case 5:
                    try
                    {
                        GV.in_CCVS[GV.k, 0] = int.Parse(m_np1.Text);
                        GV.in_CCVS[GV.k, 1] = int.Parse(m_nm1.Text);
                        GV.in_CCVS[GV.k, 2] = int.Parse(m_np2.Text);
                        GV.in_CCVS[GV.k, 3] = int.Parse(m_nm2.Text);
                        GV.z_CCVS[GV.k] = float.Parse(m_z1.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    if ((GV.in_CCVS[GV.k, 0] < 0) || (GV.in_CCVS[GV.k, 1] < 0) || (GV.z_CCVS[GV.k] < 0)
                        || (GV.in_CCVS[GV.k, 2] < 0) || (GV.in_CCVS[GV.k, 3] < 0))
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    break;
                case 9:
                    try
                    {
                        GV.in_IOA[GV.k, 0] = int.Parse(m_np1.Text);
                        GV.in_IOA[GV.k, 1] = int.Parse(m_nm1.Text);
                        GV.in_IOA[GV.k, 2] = int.Parse(m_np2.Text);
                        GV.in_IOA[GV.k, 3] = int.Parse(m_nm2.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    if ((GV.in_IOA[GV.k, 0] < 0) || (GV.in_IOA[GV.k, 1] < 0)
                                                 || (GV.in_IOA[GV.k, 2] < 0) || (GV.in_IOA[GV.k, 3] < 0))
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    break;
                case 8:
                    try
                    {
                        GV.in_tu[GV.k, 0] = int.Parse(m_np1.Text);
                        GV.in_tu[GV.k, 1] = int.Parse(m_nm1.Text);
                        GV.in_tu[GV.k, 2] = int.Parse(m_np2.Text);
                        GV.z_tu[GV.k, 0] = float.Parse(m_z1.Text);
                        GV.z_tu[GV.k, 1] = float.Parse(m_z2.Text);
                        GV.z_tu[GV.k, 2] = float.Parse(m_z3.Text);
                        GV.z_tu[GV.k, 3] = float.Parse(m_z4.Text);
                        GV.z_tu[GV.k, 4] = float.Parse(m_z5.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    if ((GV.in_tu[GV.k, 0] < 0) || (GV.in_tu[GV.k, 1] < 0) || (GV.z_tu[GV.k, 0] < 0)
                        || (GV.in_tu[GV.k, 2] < 0) || (GV.z_tu[GV.k, 1] < 0) || (GV.z_tu[GV.k, 2] < 0) ||
                        (GV.z_tu[GV.k, 3] < 0) || (GV.z_tu[GV.k, 4] < 0))
                    {
                        MessageBox.Show("Введены неправильные значения");
                        return;
                    }

                    break;
            }
            OK.Focus();
        }

        private void IDC_IN_BUTTON_Click(object sender, EventArgs e)
        {
            int temp = 0;
            float fTemp = 0;
            int idx = m_redlst.SelectedIndex;
            switch (idx)
            {
                case 0:
                //Резисторы
                    //n+
                    try
                    {
                        temp = GV.in_r[GV.k, 0];
                        GV.in_r[GV.k, 0] = Int32.Parse(m_np2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.in_r[GV.k, 0] = temp;
                    }

                    if (GV.in_r[GV.k, 0] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.in_r[GV.k, 0] = temp;
                    }

                    //n-
                    try
                    {
                        temp = GV.in_r[GV.k, 1];
                        GV.in_r[GV.k, 1] = Int32.Parse(m_nm2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.in_r[GV.k, 1] = temp;
                    }

                    if (GV.in_r[GV.k, 1] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.in_r[GV.k, 1] = temp;
                    }

                    //номинал
                    try
                    {
                        fTemp = GV.z_r[GV.k];
                        GV.z_r[GV.k] = Single.Parse(m_z1.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение номинала будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.z_r[GV.k] = fTemp;
                    }

                    if (GV.z_r[GV.k] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение номинала будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.z_r[GV.k] = fTemp;
                    }
                    break;
                case 1:
                //Конденсаторы
                    //n+
                    try
                    {
                        temp = GV.in_c[GV.k, 0];
                        GV.in_c[GV.k, 0] = Int32.Parse(m_np2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.in_c[GV.k, 0] = temp;
                    }

                    if (GV.in_c[GV.k, 0] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.in_c[GV.k, 0] = temp;
                    }

                    //n-
                    try
                    {
                        temp = GV.in_c[GV.k, 1];
                        GV.in_c[GV.k, 1] = Int32.Parse(m_nm2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.in_c[GV.k, 1] = temp;
                    }

                    if (GV.in_c[GV.k, 1] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.in_c[GV.k, 1] = temp;
                    }

                    //номинал
                    try
                    {
                        fTemp = GV.z_c[GV.k];
                        GV.z_c[GV.k] = Single.Parse(m_z1.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение номинала будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.z_c[GV.k] = fTemp;
                    }

                    if (GV.z_c[GV.k] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение номинала будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.z_c[GV.k] = fTemp;
                    }
                    break;
                case 2:
                //Индуктивности
                    //n+
                    try
                    {
                        temp = GV.in_l[GV.k, 0];
                        GV.in_l[GV.k, 0] = Int32.Parse(m_np2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.in_l[GV.k, 0] = temp;
                    }

                    if (GV.in_l[GV.k, 0] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n+ будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.in_l[GV.k, 0] = temp;
                    }

                    //n-
                    try
                    {
                        temp = GV.in_l[GV.k, 1];
                        GV.in_l[GV.k, 1] = Int32.Parse(m_nm2.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.in_l[GV.k, 1] = temp;
                    }

                    if (GV.in_l[GV.k, 1] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение n- будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.in_l[GV.k, 1] = temp;
                    }

                    //номинал
                    try
                    {
                        fTemp = GV.z_l[GV.k];
                        GV.z_l[GV.k] = Single.Parse(m_z1.Text);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка: " + exception.Message + "\nЗначение номинала будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GV.z_l[GV.k] = fTemp;
                    }

                    if (GV.z_l[GV.k] < 0)
                    {
                        MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nЗначение номинала будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GV.z_l[GV.k] = fTemp;
                    }
                    break;
            }
            OK.Focus();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
