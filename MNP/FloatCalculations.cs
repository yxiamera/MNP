using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNP
{
    class FloatCalculations
    {
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

        //Формирование вещественных частных матриц ИТУН
        void form_ju()
        {
            int i, j, g;
            for (int kju = 1; kju <= GV.VoltContrCurSources; kju++)
                for (int l = 2; l <= 3; l++)
                {
                    i = GV.in_VCCS[kju, l];
                    if (i == 0) continue;
                    for (int m = 0; m <= 1; m++)
                    {
                        j = GV.in_VCCS[kju, m];
                        if (j == 0) continue;
                        g = (5 - 2 * 1) * (1 - 2 * m);
                        GV.a[i, j] += g * GV.z_VCCS[kju, 0];
                    }
                }
        }

        //Формирование вещественных частных матриц ИНУН
        void form_eu()
        {
            int i, j;
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

        //Формирование вещественных частных матриц ИТУТ
        void form1_ji()
        {
            int i, j, g;
            for (int kji = 1; kji <= GV.CurContrCurSources; kji++)
            {
                j = GV.n + kji;
                for (int l = 0; l <= 3; l++)
                {
                    i = GV.in_CCCS[kji, l];
                    if (i == 0) continue;
                    if (l < 2)
                    {
                        g = 1 - 2 * l;
                        GV.a[i, j] += g;
                        GV.a[j, i] -= g;
                    }
                    else
                    {
                        g = 5 - 2 * l;
                        GV.a[i, j] += g * GV.z_CCCS[kji, 0];
                    }
                }
            }
            GV.n += GV.CurContrCurSources;
        }

        //Формирование вещественных частных матриц ИНУТ
        void form_ei()
        {
            int i1, i2, j, g;
            for (int kei = 1; kei <= GV.CurContrVoltSources; kei++)
            {
                i1 = GV.n + kei;
                i2 = i1 + GV.CurContrVoltSources;
                GV.a[i2, i1] = GV.z_CCVS[kei, 0];
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

        //Формирование вещественных частных матриц частотно-зависимых ИТУН
        void form_ju_f()
        {
            int i, j; g;
            for (int kju = 1; kju <= GV.VoltContrCurSources; kju++)
            {
                i = GV.n + kju;
                GV.a[i, i] = 1;
                GV.b[i, i] = GV.z_VCCS[kju, 2];
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_VCCS[kju, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.a[i, j] -= g * GV.z_VCCS[kju, 0];
                        GV.b[i, j] -= g * GV.z_VCCS[kju, 0] * GV.z_VCCS[kju, 1];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.a[j, i] += g;
                    }
                }
            }
        }

        //Формирование вещественных частных матриц частотно-зависимых ИНУН
        void form_eu_f()
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
                        GV.b[i, j] += g * GV.z_VCVS[keu, 0] * GV.z_VCVS[keu, 1];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.a[i, j] -= g;
                        GV.a[j, i] += g;
                        GV.b[i, j] -= g * GV.z_VCVS[keu, 2];
                    }
                }
            }
            GV.n += GV.VoltContrVoltSources;
        }

        //Формирование вещественных частных матриц частотно-зависимых ИНУT
        void form_ei_f()
        {
            int i, j, g;
            for (int kei = 1; kei <= GV.CurContrVoltSources; kei++)
            {
                i = GV.n + kei;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_CCVS[kei, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.a[i, j] += g * GV.z_CCVS[kei, 0];
                        GV.b[i, j] += g * GV.z_CCVS[kei, 0] * GV.z_CCVS[kei, 1];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.a[i, j] -= g;
                        GV.a[j, i] += g;
                        GV.b[i, j] -= g * GV.z_CCVS[kei, 2];
                    }
                }
            }
            GV.n += GV.CurContrVoltSources;
        }

        //Формирование вещественных частных матриц частотно-зависимых ИТУТ
        void form_ji_f()
        {
            int i, j, g;
            for (int kji = 1; kji <= GV.CurContrCurSources; kji++)
            {
                i = GV.n + kji;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_CCCS[kji, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.a[i, j] += g * GV.z_VCVS[kji, 0];
                        GV.b[i, j] += g * GV.z_VCVS[kji, 0] * GV.z_VCVS[kji, 1];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.a[i, j] -= g;
                        GV.a[j, i] += g;
                        GV.b[i, j] -= g * GV.z_VCVS[kji, 2];
                    }
                }
            }
            GV.n += GV.CurContrCurSources;
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

        //Формирование вещественных частных матриц идеального трансформатора
        void form_tri()
        {
            int i, j, g;
            for (int ktri = 1; ktri <= GV.idealTransformers; ktri++)
            {
                i = GV.n + ktri;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_ITr[ktri, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.a[i, j] += g * GV.z_ITr[ktri];
                        GV.a[j, i] -= g * GV.z_ITr[ktri];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.a[i, j] -= g;
                        GV.a[j, i] += g;
                    }
                }
            }
            GV.n += GV.idealTransformers;
        }

        //Формирование вещественных частных матриц трансформатора
        void form_tr()
        {
            int i1, i2, j, g;
            for (int ktr = 1; ktr <= GV.transformers; ktr++)
            {
                i1 = GV.n + ktr;
                i2 = i1 + GV.transformers;
                GV.a[i1, i1] = GV.z_tr[ktr, 0];
                GV.b[i1, i1] = GV.z_tr[ktr, 2];
                GV.a[i2, i2] = GV.z_tr[ktr, 4];
                GV.b[i2, i2] = GV.z_tr[ktr, 4];
                GV.b[i1, i2] = GV.z_tr[ktr, 4];
                GV.b[i2, i1] = GV.z_tr[ktr, 4];
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_tr[ktr, m];
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
            GV.n += 2 * GV.transformers;
        }

        //Формирование вещественных частных матриц биполярного транзистора
        void form_tb()
        {
            int i, j, ii = 0, jj, g, l, m;
            double[,] ay = new double[5, 5];
            double[,] by = new double[5, 5];
            int[,] in_d = { { 4, 3, 1, 4, 4 }, { 2, 1, 4, 4, 2 } };
            int[] in_ju = { 4, 1, 2, 4 };
            for (int ktb = 1; ktb <= GV.biPolarTransistors; ktb++)
            {
                for (i = 1; i <= 4; i++)
                    for (j = 1; j <= 4; j++)
                    {
                        ay[i, j] = 0;
                        by[i, j] = 0;
                    }
                for (int k = 0; k <= 4; k++)
                    for (l = 0; l <= 1; l++)
                    {
                        i = in_d[k, l];
                        for (m = 0; m <= 1; m++)
                        {
                            j = in_d[k, m];
                            g = (1 - 2 * l) * (1 - 2 * m);
                            if (k < 3)
                                ay[i, j] += g / GV.z_tb[ktb, k];
                            else
                                by[i, j] += g / GV.z_tb[ktb, k];
                        }
                    }
                for (l = 2; l <= 3; l++)
                {
                    i = in_ju[l];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_ju[m];
                        g = (5 - 2 * l) * (1 - 2 * m);
                        ay[i, j] = g * GV.z_tb[ktb, 5] / (1 + GV.z_tb[ktb, 5]) / GV.z_tb[ktb, 1];
                    }
                }
                for (i = 1; i <= 4; i++)
                {
                    ii = GV.in_tb[ktb, i];
                    if (ii == 0) continue;
                    else
                        ii = GV.n + 1;
                }
                for (j = 1; j <= 4; j++)
                {
                    if (j <= 3)
                    {
                        jj = GV.in_tb[ktb, j];
                        if (jj == 0) continue;
                    }
                    else
                        jj = GV.n + l;
                    GV.a[ii, jj] += ay[i, j];
                    GV.b[ii, jj] += by[i, j];
                }
            }
            GV.n += 1;
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

        //Формирование вещественных частных матриц операционного усилителя
        void form_ou()
        {
            double[,] ay = new double[6, 6];
            double[,] by = new double[6, 6];
            double y;
            int[,] in_d = { { 1, 2 }, { 3, 4 } };
            int[] in_ju = { 1, 2, 4, 3 };
            int i, j, g, ii, jj = 0, l, m;
            for (int kou = 1; kou <= GV.opAmps; kou++)
            {
                for (i = 1; i <= 5; i++)
                    for (j = 1; j <= 5; j++)
                    {
                        ay[i, j] = 0;
                        by[i, j] = 0;
                        for (int k = 0; k <= 1; k++)
                            for (l = 0; l <= 1; l++)
                            {
                                i = in_d[k, l];
                                for (m = 0; m <= 1; m++)
                                {
                                    j = in_d[k, m];
                                    g = (1 - 2 * l) * (1 - 2 * m);
                                    ay[i, j] += g / GV.z_OpAmp[kou, k];
                                }
                            }
                        y = GV.z_OpAmp[kou, 2] / GV.z_OpAmp[kou, 1];
                        i = 5;
                        ay[i, i] = 1;
                        by[i, i] = 0.16 * GV.z_OpAmp[kou, 2] / GV.z_OpAmp[kou, 3];
                        for (m = 0; m <= 3; m++)
                        {
                            j = in_ju[m];
                            if (j == 0) continue;
                            if (m < 2)
                            {
                                g = 1 - 2 * m;
                                ay[i, j] -= g * y;
                            }
                            else
                            {
                                g = 5 - 2 * m;
                                ay[i, j] += g;
                            }
                        }
                        for (i = 1; i <= 5; i++)
                        {
                            if (i <= 4)
                            {
                                ii = GV.in_OpAmp[kou, i];
                                if (ii == 0) continue;
                            }
                            else
                                ii = GV.n + 1;
                            for (j = 1; j <= 5; j++)
                                if (j <= 4)
                                {
                                    jj = GV.in_OpAmp[kou, j];
                                    if (jj == 0) continue;
                                }
                                else
                                    jj = GV.n + 1;
                            GV.a[ii, jj] += ay[i, j];
                            GV.b[ii, jj] += by[i, j];
                        }
                    }
                GV.n += 1;
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
            for (int i = 0; i <= GV.M; i++)
                //Обнуление массивов a и b
                for (int j = 0; j <= GV.M; j++)
                {
                    GV.a[i, j] = 0;
                    GV.b[i, j] = 0;
                }
            GV.n = GV.nodesValue;
            for (int kf = 1; kf <= GV.nf; kf++)
            {
                GV.om = 2 * 3.141593 * GV.frequences[kf];
                form_d(ref GV.in_r, ref GV.z_r, GV.resistorsValue, 'R');
                form_d(ref GV.in_c, ref GV.z_c, GV.capasitorsValue, 'C');
                form_d(ref GV.in_l, ref GV.z_l, GV.inductorsValue, 'L');
                //…
                form_w();
                form_s();
                //…
            }
        }
    }
}
