namespace MNP
{
    partial class R
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_nPlusResistor = new System.Windows.Forms.TextBox();
            this.m_nMinusResistor = new System.Windows.Forms.TextBox();
            this.m_zResistor = new System.Windows.Forms.TextBox();
            this.IDC_NEXTR_BUTTON = new System.Windows.Forms.Button();
            this.m_nextResistor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Резистор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Узел n+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Узел n-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сопротивление (КОм)";
            // 
            // m_nPlusResistor
            // 
            this.m_nPlusResistor.Location = new System.Drawing.Point(144, 51);
            this.m_nPlusResistor.Name = "m_nPlusResistor";
            this.m_nPlusResistor.Size = new System.Drawing.Size(61, 20);
            this.m_nPlusResistor.TabIndex = 5;
            this.m_nPlusResistor.Text = "0";
            // 
            // m_nMinusResistor
            // 
            this.m_nMinusResistor.Location = new System.Drawing.Point(144, 87);
            this.m_nMinusResistor.Name = "m_nMinusResistor";
            this.m_nMinusResistor.Size = new System.Drawing.Size(61, 20);
            this.m_nMinusResistor.TabIndex = 6;
            this.m_nMinusResistor.Text = "0";
            // 
            // m_zResistor
            // 
            this.m_zResistor.Location = new System.Drawing.Point(144, 121);
            this.m_zResistor.Name = "m_zResistor";
            this.m_zResistor.Size = new System.Drawing.Size(61, 20);
            this.m_zResistor.TabIndex = 7;
            this.m_zResistor.Text = "0";
            // 
            // IDC_NEXTR_BUTTON
            // 
            this.IDC_NEXTR_BUTTON.Location = new System.Drawing.Point(73, 165);
            this.IDC_NEXTR_BUTTON.Name = "IDC_NEXTR_BUTTON";
            this.IDC_NEXTR_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_NEXTR_BUTTON.TabIndex = 8;
            this.IDC_NEXTR_BUTTON.Text = "Следующий";
            this.IDC_NEXTR_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTR_BUTTON.Click += new System.EventHandler(this.IDC_NEXTR_BUTTON_Click);
            // 
            // m_nextResistor
            // 
            this.m_nextResistor.Location = new System.Drawing.Point(144, 18);
            this.m_nextResistor.Name = "m_nextResistor";
            this.m_nextResistor.ReadOnly = true;
            this.m_nextResistor.Size = new System.Drawing.Size(61, 20);
            this.m_nextResistor.TabIndex = 4;
            this.m_nextResistor.Text = "1";
            // 
            // R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 204);
            this.Controls.Add(this.IDC_NEXTR_BUTTON);
            this.Controls.Add(this.m_zResistor);
            this.Controls.Add(this.m_nMinusResistor);
            this.Controls.Add(this.m_nPlusResistor);
            this.Controls.Add(this.m_nextResistor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "R";
            this.Text = "R";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_nPlusResistor;
        private System.Windows.Forms.TextBox m_nMinusResistor;
        private System.Windows.Forms.TextBox m_zResistor;
        private System.Windows.Forms.Button IDC_NEXTR_BUTTON;
        private System.Windows.Forms.TextBox m_nextResistor;
    }
}