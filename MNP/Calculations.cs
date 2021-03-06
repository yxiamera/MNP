using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNP
{
    //все расчеты схем
    class Calculations
    {
        void form_d(ref int[,] in_d, ref float[] z_d, int nd, char td)
        {
            int i, j, g;
            for (int kd = 1; kd <= nd; kd++)
                for (int l = 0; l <= 1; l++)
                {
                    i = in_d[kd, 1];
                    if (i == 0) continue;
                    for (int m = 0; m <= 1; m++)
                    {
                        j = in_d[kd, m];
                        if (j == 0) continue;
                        g = (l - 2 * 1) * (1 - 2 * m);
                        switch (td)
                        {
                            case 'R':
                                GV.w[i, j] += g / z_d[kd];
                                break;
                            case 'C':
                                GV.w[i, j] += g * GV.s * z_d[kd];
                                break;
                            case 'L':
                                GV.w[i, j] += g / (GV.s * z_d[kd]);
                                break;
                        }
                    }
                }
        }
        //Формирование комплексных частных матриц ИТУН 
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
                        g = (5 - 2 * l) * (l - 2 * m);
                        GV.w[i, j] += g * GV.z_VCCS[kju, 0];
                    }
                }
        }

        //Формирование комплексных частных матриц ИНУН
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
                        GV.w[i, j] += g * GV.z_VCVS[keu, 0];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.VoltContrVoltSources;
        }
        //Формирование комплексных частных матриц ИТУТ
        void form_ji()
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
                        g = l - 2 * l;
                        GV.w[i, j] += g;
                        GV.w[j, j] -= g;
                    }
                    else
                    {
                        g = 5 - 2 * l;
                        GV.w[i, j] += g * GV.z_CCCS[kji, 0];
                    }
                }
            }
            GV.n += GV.CurContrCurSources;
        }
        //Формирование комплексных частных матриц ИНУТ
        void form_ei()
        {
            int i1, i2, j, g;
            for (int kei = 1; kei <= GV.CurContrVoltSources; kei++)
            {
                i1 = GV.n + kei;
                i2 = i1 + GV.CurContrVoltSources;
                GV.w[i2, i1] = new Complex(GV.z_CCVS[kei, 0]);
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_CCVS[kei, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i1, j] -= g;
                        GV.w[j, i1] += g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i2, j] -= g;
                        GV.w[j, i2] += g;
                    }
                }
            }
            GV.n += 2 * GV.CurContrVoltSources;
        }
        //Формирование комплексных частных матриц частотно-зависимых ИТУН
        void form_ju_c()
        {
            Complex ys = new Complex();
            int i, j, g;
            for (int kju = 1; kju <= GV.VoltContrCurSources; kju++)
            {
                ys = GV.z_VCCS[kju, 0] * (1 + GV.s * GV.z_VCCS[kju, 1]) / (1 + GV.s * GV.z_VCCS[kju, 2]);
                for (int l = 2; l <= 3; l++)
                {
                    i = GV.in_VCCS[kju, l];
                    if (i == 0) continue;
                    for (int m = 0; m <= 1; m++)
                    {
                        j = GV.in_VCCS[kju, m];
                        if (j == 0) continue;
                        g = (5 - 2 * l) * (l - 2 * m);
                        GV.w[i, j] += g * ys;
                    }
                }
            }
        }
        //Формирование комплексных частных матриц частотно-зависимых ИНУН
        void form_eu_c()
        {
            Complex ms = new Complex();
            int i, j, g;
            for (int keu = 1; keu <= GV.VoltContrVoltSources; keu++)
            {
                ms = GV.z_VCVS[keu, 0] * (1 + GV.s * GV.z_VCVS[keu, 1] + GV.s * GV.z_VCVS[keu, 2]);
                i = GV.n + keu;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_VCVS[keu, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * ms;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.VoltContrVoltSources;
        }
        //Формирование комплексных частных матриц частотно-зависимых ИНУТ
        void form_ei_c()
        {
            Complex xs = new Complex();
            int i1, i2, j, g;
            for (int kei = 1; kei <= GV.CurContrVoltSources; kei++)
            {
                xs = GV.z_CCVS[kei, 0] * (1 + GV.s * GV.z_CCVS[kei, 1] + GV.s * GV.z_CCVS[kei, 2]);
                i1 = GV.n + kei;
                i2 = i1 + GV.CurContrVoltSources;
                GV.w[i2, i1] = xs;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_CCVS[kei, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i1, j] -= g;
                        GV.w[j, i1] += g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i2, j] -= g;
                        GV.w[j, i2] += g;
                    }
                }
            }
            GV.n += 2 * GV.CurContrVoltSources;
        }
        //Формирование комплексных частных матриц частотно-зависимых ИТУТ
        void form_ji_c()
        {
            Complex ns = new Complex();
            int i, j, g;
            for (int kji = 1; kji <= GV.CurContrCurSources; kji++)
            {
                ns = GV.z_CCVS[kji, 0] * (1 + GV.s * GV.z_CCVS[kji, 1] + GV.s * GV.z_CCVS[kji, 2]);
                j = GV.n + kji;
                for (int l = 0; l <= 3; l++)
                {
                    i = GV.in_CCCS[kji, l];
                    if (i == 0) continue;
                    if (l < 2)
                    {
                        g = l - 2 * l;
                        GV.w[i, j] += g;
                        GV.w[j, j] -= g;
                    }
                    else
                    {
                        g = 5 - 2 * l;
                        GV.w[i, j] += g * ns;
                    }
                }
            }
            GV.n += GV.CurContrCurSources;
        }
        //Формирование комплексных частных матриц идеального ОУ
        void form_oui()
        {
            int i, j1, j2, g;
            for (int koui = 1; koui <= GV.idealOpAmps; koui++)
            {
                j1 = GV.n + koui;
                j2 = j1 + GV.idealOpAmps;
                GV.w[j2, j1] = new Complex(-1);
                for (int l = 0; l <= 3; l++)
                {
                    i = GV.in_IOA[koui, l];
                    if (i == 0) continue;
                    if (l < 2)
                    {
                        g = 1 - 2 * l;
                        GV.w[i, j1] += g;
                        GV.w[j1, i] -= g;
                    }
                    else
                    {
                        g = 5 - 2 * l;
                        GV.w[i, j2] += g;
                    }
                }
            }
            GV.n += 2 * GV.idealOpAmps;
        }
        //Формирование комплексных частных матриц идеального трансформатора
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
                        GV.w[i, j] += g * GV.z_ITr[ktri];
                        GV.w[j, i] -= g * GV.z_ITr[ktri];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.idealTransformers;
        }
        //Формированне комплексных частных матриц трансформатора
        void form_tr()
        {
            int i1, i2, j, g;
            for (int ktr = 1; ktr <= GV.transformers; ktr++)
            {
                i1 = GV.n + ktr;
                i2 = i1 + GV.transformers;
                GV.w[i1, i1] = GV.z_tr[ktr, 0] + GV.s * GV.z_tr[ktr, 2];
                GV.w[i2, i2] = GV.z_tr[ktr, 1] + GV.s * GV.z_tr[ktr, 3];
                GV.w[i1, i2] = GV.s * GV.z_tr[ktr, 4];
                GV.w[i2, i1] = GV.s * GV.z_tr[ktr, 4];
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_tr[ktr, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i1, j] -= g;
                        GV.w[j, i1] += g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i2, j] -= g;
                        GV.w[j, i2] += g;
                    }
                }
            }
            GV.n += 2 * GV.transformers;
        }
        //Формирование комплексных частных матриц биполярного транзистора
        void form_tb()
        {
            Complex cn = new Complex(0, 0);
            Complex[,] y = new Complex[5, 5];
            int i, j, ii, jj, g, l, m;
            int[,] in_d = { { 4, 3, 1, 4, 4 }, { 2, 1, 4, 4, 2 } };
            int[] in_ju = { 4, 1, 2, 4 };
            for (int ktb = 1; ktb <= GV.biPolarTransistors; ktb++)
            {
                for (i = 1; i <= 4; i++)
                    for (j = 1; j <= 4; j++)
                        y[i, j] = cn;
                for (int k = 0; k <= 4; k++)
                    for (l = 0; l <= 1; l++)
                    {
                        i = in_d[k, l];
                        for (m = 0; m <= 1; m++)
                        {
                            j = in_d[k, m];
                            g = (1 - 2 * l) * (1 - 2 * m);
                            if (k < 3)
                                y[i, j] += g / GV.z_tb[ktb, k];
                            else
                                y[i, j] += g * GV.s * GV.z_tb[ktb, k];
                        }
                    }
                for (l = 2; l <= 3; l++)
                {
                    i = in_ju[l];
                    for (m = 0; m <= l; m++)
                    {
                        j = in_ju[m];
                        g = (5 - 2 * l) * (1 - 2 * m);
                        y[i, j] += g * GV.z_tb[ktb, 5] / (1 + GV.z_tb[ktb, 5]) / GV.z_tb[ktb, l];
                    }
                }
                for (i = 3; i >= 1; i--)
                    for (j = 3; j >= 1; j--)
                        y[i, j] -= y[i, 4] * y[4, j] / y[4, 4];
                for (i = 1; i <= 3; i++)
                {
                    ii = GV.in_tb[ktb, i];
                    if (ii == 0) continue;
                    for (j = 1; j <= 3; j++)
                    {
                        jj = GV.in_tb[ktb, j];
                        if (jj == 0) continue;
                        GV.w[ii, jj] -= y[i, j];
                    }
                }
            }
        }
        //Формирование комплексных частных униполярного транзистора
        void form_tu()
        {
            Complex cn = new Complex(0, 0);
            Complex[,] y = new Complex[4, 4];
            int i, j, ii, jj, l, m, g;
            int[,] in_d = { { 2, 3, 1, 3 }, { 1, 2, 2, 3 } };
            int[] in_ju = { 1, 3, 2, 3 };
            for (int ktu = 1; ktu <= GV.uniPolarTransistors; ktu++)
            {
                for (i = 1; i <= 3; i++)
                    for (j = 1; j <= 3; j++)
                        y[i, j] = cn;
                for (int k = 0; k <= 3; k++)
                    for (l = 0; l <= 1; l++)
                    {
                        i = in_d[k, l];
                        for (m = 0; m <= 1; m++)
                        {
                            j = in_d[k, m];
                            g = (1 - 2 * l) * (1 - 2 * m);
                            if (k == 0)
                                y[i, j] += g / GV.z_tu[ktu, k];
                            else
                                y[i, j] += g * GV.s * GV.z_tu[ktu, k];
                        }
                    }
                for (l = 2; l <= 3; l++)
                {
                    i = in_ju[l];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_ju[m];
                        g = (5 - 2 * l) * (1 - 2 * m);
                        y[i, j] += g * GV.z_tu[ktu, 4];
                    }
                }
                for (i = 1; i <= 3; i++)
                {
                    ii = GV.in_tu[ktu, i];
                    if (ii == 0) continue;
                    for (j = 1; j <= 3; j++)
                    {
                        jj = GV.in_tu[ktu, j];
                        if (jj == 0) continue;
                        GV.w[ii, jj] += y[i, j];
                    }
                }
            }
        }
        //Формирование комплексных частных матриц операционного усилителя
        void form_ou()
        {
            Complex cn = new Complex(0, 0);
            Complex[,] y = new Complex[5, 5];
            Complex ys = new Complex(0, 0);
            int[,] in_d = { { 1, 2 }, { 3, 4 } };
            int[] in_ju = { 1, 2, 4, 3 };
            int i, j, g, ii, jj, l, m;
            for (int kou = 1; kou <= GV.opAmps; kou++)
            {
                for (i = 1; i <= 4; i++)
                    for (j = 1; j <= 4; j++)
                        y[i, j] = cn;
                for (int k = 0; k <= 1; k++)
                    for (l = 0; l <= 1; l++)
                    {
                        i = in_d[k, l];
                        for (m = 0; m <= 1; m++)
                        {
                            j = in_d[k, m];
                            g = (1 - 2 * l) * (1 - 2 * m);
                            y[i, j] += g / GV.z_OpAmp[kou, k];
                        }
                    }
                ys = GV.z_OpAmp[kou, 2] / (1 + GV.s * 0.16 * GV.z_OpAmp[kou, 2] / GV.z_OpAmp[kou, 3]) / GV.z_OpAmp[kou, 1];
                for (l = 2; l <= 3; l++)
                {
                    i = in_ju[l];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_ju[m];
                        g = (1 - 2 * m) * (5 - 2 * l);
                        y[i, j] += g * ys;
                    }
                }
                for (i = l; i <= 4; i++)
                {
                    ii = GV.in_OpAmp[kou, i];
                    if (ii == 0) continue;
                    for (j = l; j <= 4; j++)
                    {
                        jj = GV.in_OpAmp[kou, j];
                        if (jj == 0) continue;
                        GV.w[ii, jj] += y[i, j];
                    }
                }
            }
        }

        void form_s()
        {
            for (int i = 1; i <= GV.M; i++)
                GV.w[i, 0] = new Complex();
            if (GV.lp != 0)
                GV.w[GV.lp, 0] = new Complex(-1);
            if (GV.lm != 0)
                GV.w[GV.lm, 0] = new Complex(1);
        }


        private void OnCalc()
        {
            for (int i = 0; i <= GV.M; i++)
                for (int j = 0; j <= GV.M; j++)
                {
                    GV.w[i, j] = new Complex(0, 0);
                }
            GV.n = GV.nodesValue;
            for (int kf = 1; kf <= GV.nf; kf++)
            {
                GV.s = new Complex(0, 2 * 3.141593 * GV.frequences[kf]);
                //Формирование частных матриц компонентов
                form_d(ref GV.in_r, ref GV.z_r, GV.resistorsValue, 'R');
                form_d(ref GV.in_c, ref GV.z_c, GV.capasitorsValue, 'C');
                form_d(ref GV.in_l, ref GV.z_l, GV.inductorsValue, 'L');
                //....
                //Формирование задающего источника
                form_s();
                //...
            }

        }
    }
}
