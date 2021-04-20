namespace MNP
{
    partial class EI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.m_nextei = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mu = new System.Windows.Forms.TextBox();
            this.nm2ei = new System.Windows.Forms.TextBox();
            this.np2ei = new System.Windows.Forms.TextBox();
            this.nm1ei = new System.Windows.Forms.TextBox();
            this.np1ei = new System.Windows.Forms.TextBox();
            this.IDC_NEXTR_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИНУТ";
            // 
            // m_nextei
            // 
            this.m_nextei.Location = new System.Drawing.Point(105, 6);
            this.m_nextei.Name = "m_nextei";
            this.m_nextei.ReadOnly = true;
            this.m_nextei.Size = new System.Drawing.Size(100, 20);
            this.m_nextei.TabIndex = 1;
            this.m_nextei.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Номинал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Узел N2-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Узел N2+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Узел N1-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Узел N1+";
            // 
            // mu
            // 
            this.mu.Location = new System.Drawing.Point(105, 136);
            this.mu.Name = "mu";
            this.mu.Size = new System.Drawing.Size(100, 20);
            this.mu.TabIndex = 18;
            this.mu.Text = "0";
            // 
            // nm2ei
            // 
            this.nm2ei.Location = new System.Drawing.Point(105, 110);
            this.nm2ei.Name = "nm2ei";
            this.nm2ei.Size = new System.Drawing.Size(100, 20);
            this.nm2ei.TabIndex = 17;
            this.nm2ei.Text = "0";
            // 
            // np2ei
            // 
            this.np2ei.Location = new System.Drawing.Point(105, 84);
            this.np2ei.Name = "np2ei";
            this.np2ei.Size = new System.Drawing.Size(100, 20);
            this.np2ei.TabIndex = 16;
            this.np2ei.Text = "0";
            // 
            // nm1ei
            // 
            this.nm1ei.Location = new System.Drawing.Point(105, 58);
            this.nm1ei.Name = "nm1ei";
            this.nm1ei.Size = new System.Drawing.Size(100, 20);
            this.nm1ei.TabIndex = 15;
            this.nm1ei.Text = "0";
            // 
            // np1ei
            // 
            this.np1ei.Location = new System.Drawing.Point(105, 32);
            this.np1ei.Name = "np1ei";
            this.np1ei.Size = new System.Drawing.Size(100, 20);
            this.np1ei.TabIndex = 14;
            this.np1ei.Text = "0";
            // 
            // IDC_NEXTR_BUTTON
            // 
            this.IDC_NEXTR_BUTTON.Location = new System.Drawing.Point(68, 162);
            this.IDC_NEXTR_BUTTON.Name = "IDC_NEXTR_BUTTON";
            this.IDC_NEXTR_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_NEXTR_BUTTON.TabIndex = 24;
            this.IDC_NEXTR_BUTTON.Text = "Следующий";
            this.IDC_NEXTR_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTR_BUTTON.Click += new System.EventHandler(this.IDC_NEXTR_BUTTON_Click);
            // 
            // EI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 188);
            this.Controls.Add(this.IDC_NEXTR_BUTTON);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mu);
            this.Controls.Add(this.nm2ei);
            this.Controls.Add(this.np2ei);
            this.Controls.Add(this.nm1ei);
            this.Controls.Add(this.np1ei);
            this.Controls.Add(this.m_nextei);
            this.Controls.Add(this.label1);
            this.Name = "EI";
            this.Text = "EI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_nextei;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mu;
        private System.Windows.Forms.TextBox nm2ei;
        private System.Windows.Forms.TextBox np2ei;
        private System.Windows.Forms.TextBox nm1ei;
        private System.Windows.Forms.TextBox np1ei;
        private System.Windows.Forms.Button IDC_NEXTR_BUTTON;
    }
}