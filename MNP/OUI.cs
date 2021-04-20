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
    public partial class OUI : Form
    {
        public OUI()
        {
            InitializeComponent();
        }

        private void IDC_NEXT_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                var i = Convert.ToInt32(n.Text);
                GV.in_IOA[i, 0] = Convert.ToInt32(n1p.Text);
                GV.in_IOA[i, 1] = Convert.ToInt32(n1m.Text);
                GV.in_IOA[i, 2] = Convert.ToInt32(n2p.Text);
                GV.in_IOA[i, 3] = Convert.ToInt32(n2m.Text);
                i++;
                n.Text = i.ToString();
                if (i <= GV.idealOpAmps)
                {
                    n1p.Text = "0";
                    n1m.Text = "0";
                    n2p.Text = "0";
                    n2m.Text = "0";
                    n1p.Focus();
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
