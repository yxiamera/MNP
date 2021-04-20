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
    public partial class TU : Form
    {
        public TU()
        {
            InitializeComponent();
        }

        private void IDC_NEXT_TU_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                var i = Convert.ToInt32(tun.Text);
                GV.in_tu[i, 0] = Convert.ToInt32(nz.Text);
                GV.in_tu[i, 1] = Convert.ToInt32(ns.Text);
                GV.in_tu[i, 2] = Convert.ToInt32(ni.Text);

                GV.z_tu[i, 0] = Convert.ToInt32(rc.Text);
                GV.z_tu[i, 1] = Convert.ToInt32(czi.Text);
                GV.z_tu[i, 2] = Convert.ToInt32(czs.Text);
                GV.z_tu[i, 3] = Convert.ToInt32(csi.Text);
                GV.z_tu[i, 4] = Convert.ToInt32(s.Text);
                i++;
                tun.Text = i.ToString();
                if (i <= GV.uniPolarTransistors)
                {
                    nz.Text = "0";
                    ns.Text = "0";
                    ni.Text = "0";
                    rc.Text = "0";
                    czi.Text = "0";
                    czs.Text = "0";
                    csi.Text = "0";
                    s.Text = "0";
                    nz.Focus();
                }
                else
                    this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Введены неправильные значения");
            }
        }
    }
}
