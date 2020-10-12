namespace MNP
{
    partial class L
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
            this.m_nextInductor = new System.Windows.Forms.TextBox();
            this.m_nPlusInductor = new System.Windows.Forms.TextBox();
            this.m_nMinusInductor = new System.Windows.Forms.TextBox();
            this.m_zInductor = new System.Windows.Forms.TextBox();
            this.IDC_NEXTIND_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индуктивность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Узел n+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Узел n-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номинал (Гн)";
            // 
            // m_nextInductor
            // 
            this.m_nextInductor.Location = new System.Drawing.Point(121, 17);
            this.m_nextInductor.Name = "m_nextInductor";
            this.m_nextInductor.ReadOnly = true;
            this.m_nextInductor.Size = new System.Drawing.Size(61, 20);
            this.m_nextInductor.TabIndex = 4;
            this.m_nextInductor.Text = "1";
            // 
            // m_nPlusInductor
            // 
            this.m_nPlusInductor.Location = new System.Drawing.Point(121, 43);
            this.m_nPlusInductor.Name = "m_nPlusInductor";
            this.m_nPlusInductor.Size = new System.Drawing.Size(61, 20);
            this.m_nPlusInductor.TabIndex = 5;
            this.m_nPlusInductor.Text = "0";
            // 
            // m_nMinusInductor
            // 
            this.m_nMinusInductor.Location = new System.Drawing.Point(121, 72);
            this.m_nMinusInductor.Name = "m_nMinusInductor";
            this.m_nMinusInductor.Size = new System.Drawing.Size(61, 20);
            this.m_nMinusInductor.TabIndex = 6;
            this.m_nMinusInductor.Text = "0";
            // 
            // m_zInductor
            // 
            this.m_zInductor.Location = new System.Drawing.Point(121, 100);
            this.m_zInductor.Name = "m_zInductor";
            this.m_zInductor.Size = new System.Drawing.Size(61, 20);
            this.m_zInductor.TabIndex = 7;
            this.m_zInductor.Text = "0";
            // 
            // IDC_NEXTIND_BUTTON
            // 
            this.IDC_NEXTIND_BUTTON.Location = new System.Drawing.Point(61, 141);
            this.IDC_NEXTIND_BUTTON.Name = "IDC_NEXTIND_BUTTON";
            this.IDC_NEXTIND_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_NEXTIND_BUTTON.TabIndex = 8;
            this.IDC_NEXTIND_BUTTON.Text = "Следующий";
            this.IDC_NEXTIND_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTIND_BUTTON.Click += new System.EventHandler(this.IDC_NEXTIND_BUTTON_Click);
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 179);
            this.Controls.Add(this.IDC_NEXTIND_BUTTON);
            this.Controls.Add(this.m_zInductor);
            this.Controls.Add(this.m_nMinusInductor);
            this.Controls.Add(this.m_nPlusInductor);
            this.Controls.Add(this.m_nextInductor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "L";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_nextInductor;
        private System.Windows.Forms.TextBox m_nPlusInductor;
        private System.Windows.Forms.TextBox m_nMinusInductor;
        private System.Windows.Forms.TextBox m_zInductor;
        private System.Windows.Forms.Button IDC_NEXTIND_BUTTON;
    }
}