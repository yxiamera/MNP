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

        private void fileout(String filename)
        {
            StreamWriter fout = new StreamWriter(GV.filename);
            String str = "";
            int i;
            str = GV.nodesValue.ToString() + " " + GV.resistorsValue.ToString() + " " + GV.capasitorsValue.ToString() + " " + GV.inductorsValue.ToString() + " " +
                  GV.VoltContrVoltSources.ToString() + " " + GV.CurContrVoltSources.ToString() + " " + GV.idealOpAmps.ToString() + " " + GV.uniPolarTransistors.ToString();
            fout.WriteLine(str);
            //for R-elements
            for (i = 1; i <= GV.resistorsValue; i++)
            {
                str = GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " "
                      + GV.z_r[i].ToString();
                fout.WriteLine(str);
            }

            //for C-elements
            for (i = 1; i <= GV.capasitorsValue; i++)
            {
                str = GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " "
                      + GV.z_c[i].ToString();
                fout.WriteLine(str);
            }

            //for L-elements
            for (i = 1; i <= GV.inductorsValue; i++)
            {
                str = GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " "
                      + GV.z_l[i].ToString();
                fout.WriteLine(str);
            }

            for (i = 1; i <= GV.VoltContrVoltSources; i++)
            {
                str = GV.in_VCVS[i, 0].ToString() + " " + GV.in_VCVS[i, 1].ToString() + " " + GV.in_VCVS[i, 2].ToString() +
                      " " + GV.in_VCVS[i, 3].ToString() +
                      " " + GV.z_VCVS[i, 0].ToString() + " " + GV.z_VCVS[i, 1].ToString() + " " + GV.z_VCVS[i, 2].ToString();
                fout.WriteLine(str);
            }

            for (i = 1; i <= GV.CurContrVoltSources; i++)
            {
                str = GV.in_CCVS[i, 0].ToString() + " " + GV.in_CCVS[i, 1].ToString() + " " + GV.in_CCVS[i, 2].ToString() +
                      " " + GV.in_CCVS[i, 3].ToString() + " "
                      + GV.z_CCVS[i].ToString();
                fout.WriteLine(str);
            }

            for (i = 1; i <= GV.idealOpAmps; i++)
            {
                str = GV.in_IOA[i, 0].ToString() + " " + GV.in_IOA[i, 1].ToString() + " " + GV.in_IOA[i, 2] + " " + GV.in_IOA[i, 3];
                fout.WriteLine(str);
            }

            for (i = 1; i <= GV.uniPolarTransistors; i++)
            {
                str = GV.in_tu[i, 0].ToString() + " " + GV.in_tu[i, 1].ToString() + " " + GV.in_tu[i, 2].ToString() + " "
                      + GV.z_tu[i, 0] + " "
                      + GV.z_tu[i, 1].ToString() + " " + GV.z_tu[i, 2].ToString() + " " + GV.z_tu[i, 3].ToString() +
                      " " + GV.z_tu[i, 4].ToString() + " ";
                fout.WriteLine(str);
            }

            fout.Close();
        }

        private void filein(String filename)
        {
            StreamReader fin = new StreamReader(GV.filename);
            char[] sep = { ' ' };
            string str = "";
            str = fin.ReadLine();
            String[] s;
            try
            {
                s = str.Split(sep, 8);
                GV.nodesValue = int.Parse(s[0]);
                GV.resistorsValue = int.Parse(s[1]);
                GV.capasitorsValue = int.Parse(s[2]);
                GV.inductorsValue = int.Parse(s[3]);
                GV.VoltContrVoltSources = int.Parse(s[4]);
                GV.CurContrVoltSources = int.Parse(s[5]);
                GV.idealOpAmps = int.Parse(s[6]);
                GV.uniPolarTransistors = int.Parse(s[7]);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ошибка в количестве элементов. Если какие-то элементы не присутствуют в схеме, то введите в первую строку файла значение 0");
                fin.Close();
                return;
            }

            for (int i = 1; i <= GV.resistorsValue; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 3);
                    GV.in_r[i, 0] = int.Parse(s[0]);
                    GV.in_r[i, 1] = int.Parse(s[1]);
                    GV.z_r[i] = float.Parse(s[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых резисторах");
                    fin.Close();
                    return;
                }
            }

            for (int i = 1; i <= GV.capasitorsValue; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 3);
                    GV.in_c[i, 0] = int.Parse(s[0]);
                    GV.in_c[i, 1] = int.Parse(s[1]);
                    GV.z_c[i] = float.Parse(s[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых конденсаторах");
                    fin.Close();
                    return;
                }
            }

            for (int i = 1; i <= GV.inductorsValue; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 3);
                    GV.in_l[i, 0] = int.Parse(s[0]);
                    GV.in_l[i, 1] = int.Parse(s[1]);
                    GV.z_l[i] = float.Parse(s[2]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых катушках");
                    fin.Close();
                    return;
                }
            }

            for (int i = 1; i <= GV.VoltContrVoltSources; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 7);
                    GV.in_VCVS[i, 0] = int.Parse(s[0]);
                    GV.in_VCVS[i, 1] = int.Parse(s[1]);
                    GV.in_VCVS[i, 2] = int.Parse(s[2]);
                    GV.in_VCVS[i, 3] = int.Parse(s[3]);

                    GV.z_VCVS[i, 0] = float.Parse(s[4]);
                    GV.z_VCVS[i, 1] = float.Parse(s[5]);
                    GV.z_VCVS[i, 2] = float.Parse(s[6]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых ИНУН");
                    fin.Close();
                    return;
                }
            }

            for (int i = 1; i <= GV.CurContrVoltSources; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 5);
                    GV.in_CCVS[i, 0] = int.Parse(s[0]);
                    GV.in_CCVS[i, 1] = int.Parse(s[1]);
                    GV.in_CCVS[i, 2] = int.Parse(s[2]);
                    GV.in_CCVS[i, 3] = int.Parse(s[3]);

                    GV.z_CCVS[i] = float.Parse(s[4]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых ИТУН");
                    fin.Close();
                    return;
                }
            }

            for (var i = 1; i <= GV.idealOpAmps; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 4);
                    GV.in_IOA[i, 0] = int.Parse(s[0]);
                    GV.in_IOA[i, 1] = int.Parse(s[1]);
                    GV.in_IOA[i, 2] = int.Parse(s[2]);
                    GV.in_IOA[i, 3] = int.Parse(s[3]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых ИОА");
                    fin.Close();
                    return;
                }
            }

            for (var i = 1; i <= GV.uniPolarTransistors; i++)
            {
                str = fin.ReadLine();
                try
                {
                    s = str.Split(sep, 8);
                    GV.in_tu[i, 0] = int.Parse(s[0]);
                    GV.in_tu[i, 1] = int.Parse(s[1]);
                    GV.in_tu[i, 2] = int.Parse(s[2]);

                    GV.z_tu[i, 0] = float.Parse(s[3]);
                    GV.z_tu[i, 1] = float.Parse(s[4]);
                    GV.z_tu[i, 2] = float.Parse(s[5]);
                    GV.z_tu[i, 3] = float.Parse(s[6]);
                    GV.z_tu[i, 4] = float.Parse(s[7]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в введённых у/п транзисторах");
                    fin.Close();
                    return;
                }
            }

            MessageBox.Show("Значения успешно введены");
            fin.Close();
        }
    }
}
