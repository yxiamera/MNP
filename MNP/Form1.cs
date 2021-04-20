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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            //открываем форму SIZE
            SIZE size = new SIZE();
            size.ShowDialog(this);
            size.Dispose();

            //открываем форму редактрирования характеристик резисторов
            if (GV.resistorsValue > 0)
            {
                R ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }

            //открываем форму редактрирования характеристик индуктивностей
            if (GV.inductorsValue > 0)
            {
                L il = new L();
                il.ShowDialog(this);
                il.Dispose();
            }

            //открываем форму редактрирования характеристик конденсаторов
            if (GV.capasitorsValue > 0)
            {
                C ic = new C();
                ic.ShowDialog(this);
                ic.Dispose();
            }

            //открываем форму редактрирования характеристик ИНУН
            if (GV.VoltContrVoltSources > 0)
            {
                var ieu = new EU();
                ieu.ShowDialog(this);
                ieu.Dispose();
            }

            //открываем форму редактрирования характеристик ИНУТ
            if (GV.CurContrVoltSources > 0)
            {
                var iei = new EI();
                iei.ShowDialog(this);
                iei.Dispose();
            }

            //открываем форму редактрирования характеристик идеальных ОУ
            if (GV.idealOpAmps > 0)
            {
                var ioui = new OUI();
                ioui.ShowDialog(this);
                ioui.Dispose();
            }

            //открываем форму редактрирования характеристик униполярных транзисторов
            if (GV.uniPolarTransistors > 0)
            {
                var itu = new TU();
                itu.ShowDialog(this);
                itu.Dispose();
            }

            //открываем формы частотных характеристик и вх/вых узлов
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();

            //спрашиваем пользователя о необходимости использовать файл
            DialogResult res = MessageBox.Show("Выводить описание схемы в файл?",
                "Вывод в файл", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                FILE ofile = new FILE();
                GV.k = 0;
                ofile.ShowDialog(this);
                ofile.Dispose();
            }
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            RED red = new RED();
            red.ShowDialog(this);
            red.Dispose();
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            GV.k = 1;
            FILE file = new FILE();
            try
            {
                file.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            file.Dispose();

            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_F_Click(object sender, EventArgs e)
        {

            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_PRIV_Click(object sender, EventArgs e)
        {
            GV.flag = false;
        }

        private void ID_SYS_Click(object sender, EventArgs e)
        {
            GV.flag = true;
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            if (!GV.flag)
            {
                INT cint = new INT();
                cint.Show(this);
            }
            else
            {
                System.Diagnostics.Process.Start("iexplore.exe", "http://127.0.0.1/MF/Int3d.htm");
            }
        }

        private void ID_CALC_Click(object sender, EventArgs e)
        {
            OnCalc();
        }

        //расчеты
        //Формирование вещественных частных матриц двухполюсников типа R, C, L
        void form_d(ref int[,] in_d, ref float[] z_d, int nd, char td)
        {
            int i, j, l, m, g;
            if (td != 'L')
                for (int kd = 1; kd <= nd; kd++)
                    for (l = 0; l <= 1; l++)
                    {
                        i = in_d[kd, l];
                        if (i == 0) continue;
                        for (m = 0; m <= 1; m++)
                        {
                            j = in_d[kd, m];
                            if (j == 0) continue;
                            g = (1 - 2 * l) * (1 - 2 * m);
                            switch (td)
                            {
                                case 'R': GV.a[i, j] += g / z_d[kd]; break;
                                case 'C': GV.b[i, j] += g * z_d[kd]; break;
                            }
                        }
                    }
            else
            {
                for (int kd = 1; kd <= nd; kd++)
                {
                    i = GV.n + kd;
                    GV.b[i, i] = z_d[kd];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_d[kd, m];
                        if (j == 0) continue;
                        g = 1 - 2 * m;
                        GV.a[i, j] -= g;
                        GV.a[j, i] += g;
                    }
                }
                GV.n += nd;
            }
        }

        //Формирование вещественных частных матриц ИНУН
        void form_eu()
        {
            int i, j, g;
            for (int keu = 1; keu <= GV.VoltContrVoltSources; keu++)
            {
                i = GV.n + keu;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_VCVS[keu, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.a[i, j] += g * GV.z_VCVS[keu, 0];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.a[i, j] -= g;
                        GV.a[j, i] += g;
                    }
                }
            }
            GV.n += GV.VoltContrVoltSources;
        }

        //Формирование вещественных частных матриц ИНУТ
        void form_ei()
        {
            int i1, i2, j, g;
            for (int kei = 1; kei <= GV.CurContrVoltSources; kei++)
            {
                i1 = GV.n + kei;
                i2 = i1 + GV.CurContrVoltSources;
                GV.a[i2, i1] = GV.z_CCVS[kei];
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_CCVS[kei, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.a[i1, j] -= g;
                        GV.a[j, i1] += g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.a[i2, j] -= g;
                        GV.a[j, i2] += g;
                    }
                }
            }
            GV.n += 2 * GV.CurContrVoltSources;
        }

        //Формирование вещественных частных матриц идеального ОУ
        void form_oui()
        {
            int i, j1, j2, g;
            for (int koui = 1; koui <= GV.idealOpAmps; koui++)
            {
                j1 = GV.n + koui;
                j2 = j1 + GV.idealOpAmps;
                GV.a[j2, j1] = -1;
                for (int l = 0; l <= 3; l++)
                {
                    i = GV.in_IOA[koui, l];
                    if (i == 0) continue;
                    if (l < 2)
                    {
                        g = 1 - 2 * l;
                        GV.a[i, j1] += g;
                        GV.a[j1, i] -= g;
                    }
                    else
                    {
                        g = 5 - 2 * l;
                        GV.a[i, j2] += g;
                    }
                }
            }
            GV.n += 2 * GV.idealOpAmps;
        }

        //Формирование вещественных частных матриц униполярного транзистора
        void form_tu()
        {
            int i, j, ii, jj, l, m, g;
            double[,] ay = new double[4, 4];
            double[,] by = new double[4, 4];
            int[,] in_d = { { 2, 3, 1, 3 }, { 1, 2, 2, 3 } };
            int[] in_ju = { 1, 3, 2, 3 };
            for (int ktu = 1; ktu <= GV.uniPolarTransistors; ktu++)
            {
                for (i = 1; i <= 3; i++)
                    for (j = 1; j <= 3; j++)
                    {
                        ay[i, j] = 0;
                        by[i, j] = 0;
                    }
                for (int k = 0; k <= 3; k++)
                    for (l = 0; l <= 1; l++)
                    {
                        i = in_d[k, l];
                        for (m = 0; m <= 1; m++)
                        {
                            j = in_d[k, m];
                            g = (1 - 2 * l) * (l - 2 * m);
                            if (k == 0)
                                ay[i, j] += g / GV.z_tu[ktu, k];
                            else
                                by[i, j] += g * GV.z_tu[ktu, k];
                        }
                    }
                for (l = 2; l <= 3; l++)
                {
                    i = in_ju[l];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_ju[m];
                        g = (5 - 2 * l) * (l - 2 * m);
                        ay[i, j] += g * GV.z_tu[ktu, 4];
                    }
                }
                for (i = 1; i <= 3; i++)
                {
                    ii = GV.in_tu[ktu, i];
                    if (ii == 0) continue;
                    for (j = l; j <= 3; j++)
                    {
                        jj = GV.in_tu[ktu, j];
                        if (jj == 0) continue;
                        GV.a[ii, jj] += ay[i, j];
                        GV.b[ii, jj] += by[i, j];
                    }
                }
            }
        }

        void form_w()
        {
            int i, j;
            double t;
            for (i = 1; i <= GV.n; i++)
                for (j = 1; j <= GV.n; j++)
                {
                    t = GV.b[i, j];
                    if (t != 0) t *= GV.om;
                    GV.w[i, j] = new Complex(GV.a[i, j], t);
                }
        }

        void form_s()
        {
            for (int i = 1; i <= GV.M; i++)
                GV.w[i, 0] = new Complex();
            if (GV.lp != 0)
                GV.w[GV.lp, 0] = new Complex(-1, 0);
            if (GV.lm != 0)
                GV.w[GV.lm, 0] = new Complex(1, 0);
        }

        private void OnCalc()
        {
            for (int kf = 1; kf <= GV.nf; kf++)
            {
                GV.s = new Complex(0.0, 2 * 3.141593 * GV.frequences[kf]);
                // Обнуление массива
                for (int i = 0; i <= GV.M; i++)
                    for (int j = 0; j <= GV.M; j++)
                    {
                        GV.w[i, j] = new Complex(0, 0);
                    }

                GV.n = GV.nodesValue;

                //Формирование частных матриц компонентов
                form_d(ref GV.in_r, ref GV.z_r, GV.resistorsValue, 'R');
                form_d(ref GV.in_c, ref GV.z_c, GV.capasitorsValue, 'C');
                form_d(ref GV.in_l, ref GV.z_l, GV.inductorsValue, 'L');
                //Формирование задающего источника

                form_eu();
                form_ei();
                form_oui();
                form_tu();
                form_s();

                if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
                {
                    SF.st();
                    SF.sf1(kf);
                }
                else
                {
                    SF.gauss_c();
                    SF.sf2(kf);
                }
            }

            string str = "";
            str = "Результаты моделирования ";
            richTextBox1.AppendText(str + "\r\n");
            if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
            {
                str = "    f кГц \t kum \t kua \t rim \t ria \t rom \t roa";
                richTextBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,12:F2}{1,12:E2}{2,12:F2}" +
                                        "{3,12:E2}{4,12:F2}{5,12:E2}{6,12:F2}",
                        GV.frequences[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf],
                        GV.ria[kf], GV.rom[kf], GV.roa[kf]);
                    richTextBox1.AppendText(str + "\r\n");
                }
            }
            else
            {
                str = "    f кГц \t kum \t kua \t rim \t ria";
                richTextBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,12:F2}{1,12:E2}{2,12:F2}" +
                                        "{3,12:E2}{4,12:F2}",
                        GV.frequences[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf], GV.ria[kf]);
                    richTextBox1.AppendText(str + "\r\n");
                }
            }

            DialogResult res = MessageBox.Show("Выводить результаты в файл?",
                "Вывод результатов", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)

                WriteOut();
            MessageBox.Show("Выберите в меню дальнейший режим работы",
                "Режим работы", MessageBoxButtons.OK);
        }

        private void WriteOut()
        {
            var fout = new StreamWriter("PR.txt");
            string str;
            str = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." +
                  DateTime.Now.Year.ToString() + "  " + DateTime.Now.Hour.ToString() + ":" +
                  DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            fout.WriteLine(str);
            str = "Описание компонентов";
            fout.WriteLine(str);

            if (GV.resistorsValue != 0)
            {
                str = "Резисторы";
                fout.WriteLine(str);
                str = "           n+        n-     R(ком)";
                fout.WriteLine(str);
                for (int kr = 1; kr <= GV.resistorsValue; kr++)
                {
                    str = $"R{kr:D}{GV.in_r[kr, 0],10:D}{GV.in_r[kr, 1],10:D}{GV.z_r[kr],10:F}";
                    fout.WriteLine(str);
                }
            }

            if (GV.capasitorsValue != 0)
            {
                str = "Конденсаторы";
                fout.WriteLine(str);
                str = "          n+        n-     C(Ф)";
                fout.WriteLine(str);
                for (int kc = 1; kc <= GV.capasitorsValue; kc++)
                {
                    str = $"C{kc:D}{GV.in_c[kc, 0],10:D}{GV.in_c[kc, 1],10:D}{GV.z_c[kc],10:F}";
                    fout.WriteLine(str);
                }
            }

            if (GV.inductorsValue != 0)
            {
                str = "Катушки";
                fout.WriteLine(str);
                str = "           n+        n-     L(Гн)";
                fout.WriteLine(str);
                for (int kl = 1; kl <= GV.inductorsValue; kl++)
                {
                    str = $"L{kl:D}{GV.in_l[kl, 0],10:D}{GV.in_l[kl, 1],10:D}{GV.z_l[kl],10:F}";
                    fout.WriteLine(str);
                }
            }

            if (GV.VoltContrVoltSources != 0)
            {
                str = "ИНУН";
                fout.WriteLine(str);
                str = "           n1+        n1-     n2+      n2-       T1      T2     mu";
                fout.WriteLine(str);
                for (int keu = 1; keu <= GV.VoltContrVoltSources; keu++)
                {
                    str =
                        $"ИНУН{keu:D}{GV.in_VCVS[keu, 0],10:D}{GV.in_VCVS[keu, 1],10:D}{GV.in_VCVS[keu, 2],10:D}" +
                        $"{GV.in_VCVS[keu, 3],10:D}{GV.z_VCVS[keu, 0],10:F}{GV.z_VCVS[keu, 1],10:F}{GV.z_VCVS[keu, 2],10:F}";
                    fout.WriteLine(str);
                }
            }

            if (GV.CurContrVoltSources != 0)
            {
                str = "ИНУТ";
                fout.WriteLine(str);
                str = "           n1+        n1-     n2+      n2-      betta";
                fout.WriteLine(str);
                for (int kei = 1; kei <= GV.CurContrVoltSources; kei++)
                {
                    str =
                        $"ИТУТ{kei:D}{GV.in_CCVS[kei, 0],10:D}{GV.in_CCVS[kei, 1],10:D}{GV.in_CCVS[kei, 2],10:D}" +
                        $"{GV.in_CCVS[kei, 3],10:D}{GV.z_CCVS[kei],10:F}";
                    fout.WriteLine(str);
                }
            }

            if (GV.idealOpAmps != 0)
            {
                str = "ОУ";
                fout.WriteLine(str);
                str = "           n1+        n1-     n2+      n2-";
                fout.WriteLine(str);
                for (var koui = 1; koui <= GV.idealOpAmps; koui++)
                {
                    str =
                        $"ОУ{koui:D}{GV.in_IOA[koui, 0],10:D}{GV.in_IOA[koui, 1],10:D}{GV.in_IOA[koui, 2],10:D}" +
                        $"{GV.in_IOA[koui, 3],10:D}";
                    fout.WriteLine(str);
                }
            }

            if (GV.uniPolarTransistors != 0)
            {
                str = "У/п транзисторы";
                fout.WriteLine(str);
                str = "           nz        ns     ni      Rc      Czi      Czs     Csi     S";
                fout.WriteLine(str);
                for (var ktu = 1; ktu <= GV.uniPolarTransistors; ktu++)
                {
                    str =
                        $"У/п транзисторы{ktu:D}{GV.in_tu[ktu, 0],10:D}{GV.in_tu[ktu, 1],10:D}{GV.in_tu[ktu, 2],10:D}" +
                        $"{GV.z_tu[ktu, 0],10:F}{GV.z_tu[ktu, 1],10:F}{GV.z_tu[ktu, 2],10:F}{GV.z_tu[ktu, 3],10:F}{GV.z_tu[ktu, 4],10:F}";
                    fout.WriteLine(str);
                }
            }

            str = "Результаты моделирования";
            fout.WriteLine(str);
            if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
            {
                str = "     f кГц  	   kum 	     kua 	 rim 	   ria 	      rom 	 roa";
                fout.WriteLine(str);
                for (var kf = 1; kf <= GV.nf; kf++)
                {
                    str = $"{GV.frequences[kf],10:F2}{GV.kum[kf],12:E2}{GV.kua[kf],10:F2}" +
                          $"{GV.rim[kf],12:E2}{GV.ria[kf],10:F2}{GV.rom[kf],12:E2}{GV.roa[kf],10:F2}";
                    fout.WriteLine(str);
                }
            }
            else
            {
                str = "     f кГц  	   kum 	     kua 	 rim 	   ria";
                fout.WriteLine(str);
                for (var kf = 1; kf <= GV.nf; kf++)
                {
                    str = $"{GV.frequences[kf],10:F2}{GV.kum[kf],12:E2}{GV.kua[kf],10:F2}{GV.rim[kf],12:E2}{GV.ria[kf],10:F2}";
                    fout.WriteLine(str);
                }
            }

            fout.Close();
            MessageBox.Show("Описание и результаты выведены в файл  PR.txt");
        }
    }
}
