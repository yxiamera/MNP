namespace MNP
{
    partial class OUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.n1p = new System.Windows.Forms.TextBox();
            this.n1m = new System.Windows.Forms.TextBox();
            this.n2p = new System.Windows.Forms.TextBox();
            this.n2m = new System.Windows.Forms.TextBox();
            this.IDC_NEXT_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идеальный операционный усилитель ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Узел N1+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Узел N1-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Узел N2+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Узел N2-";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(218, 6);
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 5;
            this.n.Text = "1";
            // 
            // n1p
            // 
            this.n1p.Location = new System.Drawing.Point(218, 32);
            this.n1p.Name = "n1p";
            this.n1p.Size = new System.Drawing.Size(100, 20);
            this.n1p.TabIndex = 6;
            this.n1p.Text = "0";
            // 
            // n1m
            // 
            this.n1m.Location = new System.Drawing.Point(218, 58);
            this.n1m.Name = "n1m";
            this.n1m.Size = new System.Drawing.Size(100, 20);
            this.n1m.TabIndex = 7;
            this.n1m.Text = "0";
            // 
            // n2p
            // 
            this.n2p.Location = new System.Drawing.Point(218, 84);
            this.n2p.Name = "n2p";
            this.n2p.Size = new System.Drawing.Size(100, 20);
            this.n2p.TabIndex = 8;
            this.n2p.Text = "0";
            // 
            // n2m
            // 
            this.n2m.Location = new System.Drawing.Point(218, 110);
            this.n2m.Name = "n2m";
            this.n2m.Size = new System.Drawing.Size(100, 20);
            this.n2m.TabIndex = 9;
            this.n2m.Text = "0";
            // 
            // IDC_NEXT_BUTTON
            // 
            this.IDC_NEXT_BUTTON.Location = new System.Drawing.Point(126, 144);
            this.IDC_NEXT_BUTTON.Name = "IDC_NEXT_BUTTON";
            this.IDC_NEXT_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_NEXT_BUTTON.TabIndex = 10;
            this.IDC_NEXT_BUTTON.Text = "Следующий";
            this.IDC_NEXT_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXT_BUTTON.Click += new System.EventHandler(this.IDC_NEXT_BUTTON_Click);
            // 
            // OUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 172);
            this.Controls.Add(this.IDC_NEXT_BUTTON);
            this.Controls.Add(this.n2m);
            this.Controls.Add(this.n2p);
            this.Controls.Add(this.n1m);
            this.Controls.Add(this.n1p);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OUI";
            this.Text = "OUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox n1p;
        private System.Windows.Forms.TextBox n1m;
        private System.Windows.Forms.TextBox n2p;
        private System.Windows.Forms.TextBox n2m;
        private System.Windows.Forms.Button IDC_NEXT_BUTTON;
    }
}