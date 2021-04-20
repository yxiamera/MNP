using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MNP
{
    class SF
    {
        public static void st()
        {
            Complex c = new Complex(0, 0);
            Complex t = new Complex(0, 0);
            Complex cn = new Complex(0, 0);
            double g;
            int l;
            for (int k = GV.n; k >= 3; k--)
            {
                l = k;
                g = 0.001;
                while (GV.w[l, k].abs <= g)
                {
                    l = l - 1;
                    if (l == 2)
                    {
                        l = k;
                        g = 0.1 * g;
                    }
                }
                if (l != k)
                    for (int j = k; j <= GV.n; j++)
                    {
                        t = GV.w[k, j];
                        GV.w[k, j] = GV.w[l, j];
                        GV.w[l, j] = t;
                    }
                for (int i = k - 1; i >= 1; i--)
                {
                    if (GV.w[i, k] == cn) continue;
                    c = GV.w[i, k] / GV.w[k, k];
                    for (int j = 1; j <= k - 1; j++)
                        if (GV.w[k, j] != cn)
                            GV.w[i, j] -= c * GV.w[k, j];
                }
            }
        }

        public static void sf1(int kf)
        {
            Complex ku = new Complex(0, 0);
            Complex ri = new Complex(0, 0);
            Complex ro = new Complex(0, 0);
            Complex d = new Complex(0, 0);
            ku = -GV.w[2, 1] / GV.w[2, 2];
            d = GV.w[1, 1] * GV.w[2, 2] - GV.w[2, 1] * GV.w[1, 2];
            ri = GV.w[2, 2] / d;
            ro = GV.w[1, 1] / d;
            GV.kum[kf] = (float)ku.abs;
            GV.kua[kf] = (float)ku.arg * 180.0f / (float)Math.PI;
            GV.rim[kf] = (float)ri.abs;
            GV.ria[kf] = (float)ri.arg * 180.0f / (float)Math.PI;
            GV.rom[kf] = (float)ro.abs;
            GV.roa[kf] = (float)ro.arg * 180.0f / (float)Math.PI;
        }

        public static void gauss_c()
        {
            int i, j, k, l;
            Complex c = new Complex(0, 0);
            Complex d = new Complex(0, 0);
            Complex t = new Complex(0, 0);
            Complex cn = new Complex(0, 0);
            for (k = 1; k < GV.n; k++)
            {
                l = k;
                for (i = k + 1; i <= GV.n; i++)
                    if (GV.w[i, k].abs > GV.w[l, k].abs)
                        l = i;
                if (l != k)
                    for (j = 0; j <= GV.n; j++)
                        if (j == 0 || j >= k)
                        {
                            t = GV.w[k, j];
                            GV.w[k, j] = GV.w[l, j];
                            GV.w[l, j] = t;
                        }
                d = 1.0 / GV.w[k, k];
                for (i = k + 1; i <= GV.n; i++)
                {
                    if (GV.w[i, k] == cn)
                        continue;
                    c = GV.w[i, k] * d;
                    for (j = k + 1; j <= GV.n; j++)
                        if (GV.w[k, j] != cn)
                            GV.w[i, j] = GV.w[i, j] - c * GV.w[k, j];
                    if (GV.w[k, 0] != cn)
                        GV.w[i, 0] = GV.w[i, 0] - c * GV.w[k, 0];
                }
            }
            GV.w[0, GV.n] = -GV.w[GV.n, 0] / GV.w[GV.n, GV.n];
            for (i = GV.n - 1; i >= 1; i--)
            {
                t = GV.w[i, 0];
                for (j = i + 1; j <= GV.n; j++)
                    t = t + GV.w[i, j] * GV.w[0, j];
                GV.w[0, i] = -t / GV.w[i, i];
            }
        }

        public static void sf2(int kf)
        {
            Complex ku = new Complex(0, 0);
            Complex ri = new Complex(0, 0);
            ri = GV.w[0, GV.lp] - GV.w[0, GV.lm];
            ku = (GV.w[0, GV.kp] - GV.w[0, GV.km]) / ri;
            GV.kum[kf] = (float)ku.abs;
            GV.kua[kf] = (float)ku.arg * 180.0f / (float)Math.PI;
            GV.rim[kf] = (float)ri.abs;
            GV.ria[kf] = (float)ri.arg * 180.0f / (float)Math.PI;
        }

        public static void write_out()
        {
            StreamWriter fout = new StreamWriter("PR.txt");
            String str;
            str = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." +
            DateTime.Now.Year.ToString() + "  " + DateTime.Now.Hour.ToString() + ":" +
            DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            fout.WriteLine(str);
            str = "Описание компонентов";
            fout.WriteLine(str);
            //Описание резисторов
            if (GV.resistorsValue != 0)
            {
                str = "Резисторы";
                fout.WriteLine(str);
                str = String.Format("		n+ 	n- R(ком)");
                fout.WriteLine(str);
                for (int kr = 1; kr <= GV.resistorsValue; kr++)
                {
                    str = String.Format("R{0:D}{1,10:D}{2,10:D}{3,10:F}",
                    kr, GV.in_r[kr, 0], GV.in_r[kr, 1], GV.z_r[kr]);
                    fout.WriteLine(str);
                }
            }
            //...
            str = "Результаты моделирования";
            fout.WriteLine(str);
            if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
            {
                str = " f кГц 	 kum 	 kua 	 rim 	 ria 	 rom 	 roa";
                fout.WriteLine(str);
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,10:F2}{1,12:E2}{2,10:F2}" +
                    "{3,12:E2}{4,10:F2}{5,12:E2}{6,10:F2}",
                    GV.frequences[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf],
                    GV.ria[kf], GV.rom[kf], GV.roa[kf]);
                    fout.WriteLine(str);
                }
            }
            else
            {
                str = " f кГц 	 kum 	 kua 	 rim 	 ria";
                fout.WriteLine(str);
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,10:F2}{1,12:E2}{2,10:F2}{3,12:E2}{4,10:F2}",
                    GV.frequences[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf], GV.ria[kf]);
                    fout.WriteLine(str);
                }
            }
            fout.Close();
            MessageBox.Show("Описание и результаты выведены в файл  PR.txt");
        }


    }
}
