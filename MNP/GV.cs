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
            biPolarTransistors, uniPolarTransistors, opAmps, transformers, idealOpAmps, idealTransformers;

        //массивы резисторов
        //полюса
        public static int[,] in_r = new int[MR + 1, 2];
        //номинал
        public static float[] z_r = new float[MR + 1];

    }
}
