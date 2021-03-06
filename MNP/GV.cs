using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNP
{
    class GV
    {
        //размеры массивов
        public static int M = 100, MR = 50, MC = 50, ML = 20, MF = 20,
            MJU = 20, MEU = 20, MJI = 20, MEI = 20, MTRI = 20, MOUI = 20, MTR = 20, MTB = 20, MTU = 20, MOU = 20;
        //количество элементов, получаемых из формы SIZE
        public static int n, nodesValue, resistorsValue, capasitorsValue, inductorsValue,
            VoltContrCurSources, VoltContrVoltSources, CurContrCurSources, CurContrVoltSources,
            biPolarTransistors, uniPolarTransistors, opAmps, transformers, idealOpAmps, idealTransformers, k;

        public static int nf, lp, lm, kp, km;

        public static String filename;

        //матрицы расчета
        public static Complex s;
        public static Complex[,] w = new Complex[M + 1, M +1 ];
        //массивы резисторов
        //полюса
        public static int[,] in_r = new int[MR + 1, 2];
        //номинал
        public static float[] z_r = new float[MR + 1];

        //массивы индуктивностей
        //полюса
        public static int[,] in_l = new int[ML + 1, 2];
        //номинал
        public static float[] z_l = new float[ML + 1];

        //массивы конденсаторов
        //полюса
        public static int[,] in_c = new int[MC + 1, 2];
        //номинал
        public static float[] z_c = new float[MC + 1];

        //массивы ИТУН
        public static int[,] in_VCCS = new int[MJU + 1, 4];
        //номинал
        public static float[,] z_VCCS = new float[MJU + 1, 3];

        //массивы ИНУН
        public static int[,] in_VCVS = new int[MEU + 1, 4];
        //номинал
        public static float[,] z_VCVS = new float[MEU + 1, 3];

        //массивы ИТУТ
        public static int[,] in_CCCS = new int[MJI + 1, 4];
        //номинал
        public static float[,] z_CCCS = new float[MJI + 1, 3];

        //массивы ИНУТ
        public static int[,] in_CCVS = new int[MEI + 1, 4];
        //номинал
        public static float[,] z_CCVS = new float[MEI + 1, 3];

        //массив ИОУ
        public static int[,] in_IOA = new int[MOUI + 1, 4];

        //массивы ИТр
        public static int[,] in_ITr = new int[MTRI + 1, 4];
        //номинал
        public static float[] z_ITr = new float[MTRI + 1];

        //массивы трансформаторов
        public static int[,] in_tr = new int[MTR + 1, 4];
        //номинал
        public static float[,] z_tr = new float[MTR + 1, 5];

        //массивы транзисторов
        //биполярных
        public static int[,] in_tb = new int[MTB + 1, 4];
        //номинал
        public static float[,] z_tb = new float[MTB + 1, 6];

        //униполярных
        public static int[,] in_tu = new int[MTU + 1, 4];
        //номинал
        public static float[,] z_tu = new float[MTU + 1, 6];

        //массивы операционных усилителей
        public static int[,] in_OpAmp = new int[MTU + 1, 5];
        //номинал
        public static float[,] z_OpAmp = new float[MTU + 1, 6];

        //массив частот
        public static float[] frequences = new float[MF + 1];

        //комплексные величины

        //флаг для выбора браузера
        public static bool flag;
    }
}
