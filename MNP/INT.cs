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
    public partial class INT : Form
    {
        public INT()
        {
            InitializeComponent();
        }

        private void IDC_INP_Click(object sender, EventArgs e)
        {
            String str = IDC_COMBO.Text;
            IDC_COMBO.Items.Add(str);
            IDC_EXPLORER.Navigate(str);
        }

        private void IDC_BACK_Click(object sender, EventArgs e)
        {
            IDC_EXPLORER.GoBack();
        }

        private void IDC_FORWARD_Click(object sender, EventArgs e)
        {
            IDC_EXPLORER.GoForward();
        }

        private void IDC_STOP_Click(object sender, EventArgs e)
        {
            IDC_EXPLORER.Stop();
            IDC_PROGRESS.Value = 0;

        }

        private void IDC_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDC_EXPLORER_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            IDC_PROGRESS.Value = 0;
        }

        private void IDC_EXPLORER_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            IDC_PROGRESS.Minimum = 0;
            IDC_PROGRESS.Maximum = 100;
            IDC_PROGRESS.Step = 0;
            IDC_PROGRESS.Value = 0;
        }

        private void IDC_EXPLORER_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.MaximumProgress != 0)
                IDC_PROGRESS.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
        }
    }
}
