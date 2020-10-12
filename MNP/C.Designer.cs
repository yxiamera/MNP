namespace MNP
{
    partial class C
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
            this.IDC_NEXTC_BUTTON = new System.Windows.Forms.Button();
            this.m_zCapasitor = new System.Windows.Forms.TextBox();
            this.m_nMinusCapasitor = new System.Windows.Forms.TextBox();
            this.m_nPlusCapasitor = new System.Windows.Forms.TextBox();
            this.m_nextCapasitor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTC_BUTTON
            // 
            this.IDC_NEXTC_BUTTON.Location = new System.Drawing.Point(60, 142);
            this.IDC_NEXTC_BUTTON.Name = "IDC_NEXTC_BUTTON";
            this.IDC_NEXTC_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_NEXTC_BUTTON.TabIndex = 17;
            this.IDC_NEXTC_BUTTON.Text = "Следующий";
            this.IDC_NEXTC_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTC_BUTTON.Click += new System.EventHandler(this.IDC_NEXTC_BUTTON_Click);
            // 
            // m_zCapasitor
            // 
            this.m_zCapasitor.Location = new System.Drawing.Point(120, 101);
            this.m_zCapasitor.Name = "m_zCapasitor";
            this.m_zCapasitor.Size = new System.Drawing.Size(61, 20);
            this.m_zCapasitor.TabIndex = 16;
            this.m_zCapasitor.Text = "0";
            // 
            // m_nMinusCapasitor
            // 
            this.m_nMinusCapasitor.Location = new System.Drawing.Point(120, 73);
            this.m_nMinusCapasitor.Name = "m_nMinusCapasitor";
            this.m_nMinusCapasitor.Size = new System.Drawing.Size(61, 20);
            this.m_nMinusCapasitor.TabIndex = 15;
            this.m_nMinusCapasitor.Text = "0";
            // 
            // m_nPlusCapasitor
            // 
            this.m_nPlusCapasitor.Location = new System.Drawing.Point(120, 44);
            this.m_nPlusCapasitor.Name = "m_nPlusCapasitor";
            this.m_nPlusCapasitor.Size = new System.Drawing.Size(61, 20);
            this.m_nPlusCapasitor.TabIndex = 14;
            this.m_nPlusCapasitor.Text = "0";
            // 
            // m_nextCapasitor
            // 
            this.m_nextCapasitor.Location = new System.Drawing.Point(120, 18);
            this.m_nextCapasitor.Name = "m_nextCapasitor";
            this.m_nextCapasitor.ReadOnly = true;
            this.m_nextCapasitor.Size = new System.Drawing.Size(61, 20);
            this.m_nextCapasitor.TabIndex = 13;
            this.m_nextCapasitor.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Емкость (мкФ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Узел n-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Узел n+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Конденсатор";
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 175);
            this.Controls.Add(this.IDC_NEXTC_BUTTON);
            this.Controls.Add(this.m_zCapasitor);
            this.Controls.Add(this.m_nMinusCapasitor);
            this.Controls.Add(this.m_nPlusCapasitor);
            this.Controls.Add(this.m_nextCapasitor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "C";
            this.Text = "C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTC_BUTTON;
        private System.Windows.Forms.TextBox m_zCapasitor;
        private System.Windows.Forms.TextBox m_nMinusCapasitor;
        private System.Windows.Forms.TextBox m_nPlusCapasitor;
        private System.Windows.Forms.TextBox m_nextCapasitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}