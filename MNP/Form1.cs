using System;
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
        }

    }
}
