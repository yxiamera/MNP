using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MNP
{
    public partial class FILE : Form
    {
        public FILE()
        {
            InitializeComponent();
        }

        private void IDC_FILEOK_BUTTON_Click(object sender, EventArgs e)
        {
            switch (GV.k)
            {
                case 0:
                    GV.filename = m_file.Text;
                    if (GV.filename != "")
                        fileout(GV.filename);
                    else
                        MessageBox.Show("Введите имя файла");
                    break;
                case 1:
                    GV.filename = m_file.Text;
                    try
                    {
                        filein(GV.filename);
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }

                    break;
            }
            this.Close();
        }

        //добавить проверку
        private void fileout(String filename)      //Вывод описания схемы в файл
        {
            StreamWriter fout = new StreamWriter(GV.filename);
            String str = "";
            int i;
            str = GV.nodesValue.ToString() + " " + GV.resistorsValue.ToString()
            + " " + GV.capasitorsValue.ToString() + " " + GV.inductorsValue.ToString();

            fout.WriteLine(str);
            for (i = 1; i <= GV.resistorsValue; i++)
            {
                str = GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " "
                    + GV.z_r[i].ToString();
                fout.WriteLine(str);
            }

            for (i = 1; i <= GV.capasitorsValue; i++)
            {
                str = GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " "
                    + GV.z_c[i].ToString();
                fout.WriteLine(str);
            }

            for (i = 1; i <= GV.inductorsValue; i++)
            {
                str = GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " "
                    + GV.z_l[i].ToString();
                fout.WriteLine(str);
            }

            fout.Close();
        }


        private void filein(String filename)      //Ввод описания схемы из файла
        {
            StreamReader fin = new StreamReader(GV.filename);
            char[] sep = { ' ' };
            string str = "";
            str = fin.ReadLine();
            String[] s = str.Split(sep, 4); //Значение второго аргумента!!!

            //количество узлов
            try
            {
                GV.nodesValue = Int32.Parse(s[0]);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество узлов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.nodesValue = 1;
            }

            if (GV.nodesValue <= 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше или равно нулю" + "\nКоличество узлов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.nodesValue = 1;
            }

            //резисторы
            try
            {
                GV.resistorsValue = Int32.Parse(s[1]);
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
                GV.capasitorsValue = Int32.Parse(s[2]);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message + "\nКоличество конденсаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV.capasitorsValue = 0;
            }

            if (GV.capasitorsValue < 0)
            {
                MessageBox.Show("Ошибка: Введенное число меньше нуля" + "\nКоличество конденсаторов будет выставлено по умолчанию.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GV.resistorsValue = 0;
            }

            //количество индуктивностей
            try
            {
                GV.inductorsValue = Int32.Parse(s[3]);
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

            //резисторы
            for (int i = 1; i <= GV.resistorsValue; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);

                //n+
                try
                {
                    GV.in_r[i, 0] = Int32.Parse(s[0]);
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
                    GV.in_r[i, 1] = Int32.Parse(s[1]);
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
                    GV.z_r[i] = Single.Parse(s[2]);
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
            }

            //конденсаторы
            for (int i = 1; i <= GV.capasitorsValue; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                //n+
                try
                {
                    GV.in_c[i, 0] = Int32.Parse(s[0]);
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
                    GV.in_c[i, 1] = Int32.Parse(s[1]);
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
                    GV.z_c[i] = Single.Parse(s[2]);
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
            }

            //индуктивности
            for (int i = 1; i <= GV.inductorsValue; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                //n+
                try
                {
                    GV.in_l[i, 0] = Int32.Parse(s[0]);
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
                    GV.in_l[i, 1] = Int32.Parse(s[1]);
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
                    GV.z_l[i] = Single.Parse(s[2]);
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
            }

            fin.Close();
        }
    }
}
