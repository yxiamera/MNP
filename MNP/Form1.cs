﻿using System;
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
    }
}
