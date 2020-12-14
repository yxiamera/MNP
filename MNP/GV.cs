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
        public static int M = 100, MR = 50, MC = 50, ML = 20, MF = 20;
        //количество элементов, получаемых из формы SIZE
        public static int nodesValue, resistorsValue, capasitorsValue, inductorsValue,
            VoltContCurSources, VoltContVoltSources, CurContCurSources, CurContVoltSources,
            biPolarTransistors, uniPolarTransistors, opAmps, transformers, idealOpAmps, idealTransformers, k;

        public static int nf, lp, lm, kp, km;

        public static String filename;

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

        //массив частот
        public static float[] frequences = new float[MF + 1];

        //флаг для выбора браузера
        public static bool flag;
    }
}
