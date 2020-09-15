namespace MNP
{
    partial class SIZE
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
            this.m_nodesValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_resistorsValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_capasitorsValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_inductorsValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_VolContCurSources = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_VolContVolSources = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_CurContCurSources = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_CurContVolSources = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.m_biPolarTransistors = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_uniPolarTransistors = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m_opAmps = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m_transformers = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.m_idealOpAmps = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.m_idealTransformers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_nodesValue
            // 
            this.m_nodesValue.Location = new System.Drawing.Point(13, 13);
            this.m_nodesValue.Name = "m_nodesValue";
            this.m_nodesValue.Size = new System.Drawing.Size(64, 20);
            this.m_nodesValue.TabIndex = 0;
            this.m_nodesValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число узлов";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(222, 278);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Резисторы";
            // 
            // m_resistorsValue
            // 
            this.m_resistorsValue.Location = new System.Drawing.Point(12, 48);
            this.m_resistorsValue.Name = "m_resistorsValue";
            this.m_resistorsValue.Size = new System.Drawing.Size(64, 20);
            this.m_resistorsValue.TabIndex = 3;
            this.m_resistorsValue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Конденсаторы";
            // 
            // m_capasitorsValue
            // 
            this.m_capasitorsValue.Location = new System.Drawing.Point(13, 85);
            this.m_capasitorsValue.Name = "m_capasitorsValue";
            this.m_capasitorsValue.Size = new System.Drawing.Size(64, 20);
            this.m_capasitorsValue.TabIndex = 5;
            this.m_capasitorsValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Индуктивности";
            // 
            // m_inductorsValue
            // 
            this.m_inductorsValue.Location = new System.Drawing.Point(13, 123);
            this.m_inductorsValue.Name = "m_inductorsValue";
            this.m_inductorsValue.Size = new System.Drawing.Size(64, 20);
            this.m_inductorsValue.TabIndex = 7;
            this.m_inductorsValue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ИТУН";
            // 
            // m_VolContCurSources
            // 
            this.m_VolContCurSources.Location = new System.Drawing.Point(13, 165);
            this.m_VolContCurSources.Name = "m_VolContCurSources";
            this.m_VolContCurSources.Size = new System.Drawing.Size(64, 20);
            this.m_VolContCurSources.TabIndex = 9;
            this.m_VolContCurSources.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ИНУН";
            // 
            // m_VolContVolSources
            // 
            this.m_VolContVolSources.Location = new System.Drawing.Point(13, 204);
            this.m_VolContVolSources.Name = "m_VolContVolSources";
            this.m_VolContVolSources.Size = new System.Drawing.Size(64, 20);
            this.m_VolContVolSources.TabIndex = 11;
            this.m_VolContVolSources.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ИТУТ";
            // 
            // m_CurContCurSources
            // 
            this.m_CurContCurSources.Location = new System.Drawing.Point(13, 244);
            this.m_CurContCurSources.Name = "m_CurContCurSources";
            this.m_CurContCurSources.Size = new System.Drawing.Size(64, 20);
            this.m_CurContCurSources.TabIndex = 13;
            this.m_CurContCurSources.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ИНУТ";
            // 
            // m_CurContVolSources
            // 
            this.m_CurContVolSources.Location = new System.Drawing.Point(13, 285);
            this.m_CurContVolSources.Name = "m_CurContVolSources";
            this.m_CurContVolSources.Size = new System.Drawing.Size(64, 20);
            this.m_CurContVolSources.TabIndex = 15;
            this.m_CurContVolSources.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "б/п транзисторы";
            // 
            // m_biPolarTransistors
            // 
            this.m_biPolarTransistors.Location = new System.Drawing.Point(181, 16);
            this.m_biPolarTransistors.Name = "m_biPolarTransistors";
            this.m_biPolarTransistors.Size = new System.Drawing.Size(64, 20);
            this.m_biPolarTransistors.TabIndex = 17;
            this.m_biPolarTransistors.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "у/п транзисторы";
            // 
            // m_uniPolarTransistors
            // 
            this.m_uniPolarTransistors.Location = new System.Drawing.Point(181, 53);
            this.m_uniPolarTransistors.Name = "m_uniPolarTransistors";
            this.m_uniPolarTransistors.Size = new System.Drawing.Size(64, 20);
            this.m_uniPolarTransistors.TabIndex = 19;
            this.m_uniPolarTransistors.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Опер. усилители";
            // 
            // m_opAmps
            // 
            this.m_opAmps.Location = new System.Drawing.Point(181, 91);
            this.m_opAmps.Name = "m_opAmps";
            this.m_opAmps.Size = new System.Drawing.Size(64, 20);
            this.m_opAmps.TabIndex = 21;
            this.m_opAmps.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Трансформаторы";
            // 
            // m_transformers
            // 
            this.m_transformers.Location = new System.Drawing.Point(181, 133);
            this.m_transformers.Name = "m_transformers";
            this.m_transformers.Size = new System.Drawing.Size(64, 20);
            this.m_transformers.TabIndex = 23;
            this.m_transformers.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ид. опер. усилители";
            // 
            // m_idealOpAmps
            // 
            this.m_idealOpAmps.Location = new System.Drawing.Point(181, 172);
            this.m_idealOpAmps.Name = "m_idealOpAmps";
            this.m_idealOpAmps.Size = new System.Drawing.Size(64, 20);
            this.m_idealOpAmps.TabIndex = 25;
            this.m_idealOpAmps.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Ид. трансформаторы";
            // 
            // m_idealTransformers
            // 
            this.m_idealTransformers.Location = new System.Drawing.Point(181, 212);
            this.m_idealTransformers.Name = "m_idealTransformers";
            this.m_idealTransformers.Size = new System.Drawing.Size(64, 20);
            this.m_idealTransformers.TabIndex = 27;
            this.m_idealTransformers.Text = "0";
            // 
            // SIZE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 317);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.m_idealTransformers);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.m_idealOpAmps);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.m_transformers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.m_opAmps);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.m_uniPolarTransistors);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.m_biPolarTransistors);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_CurContVolSources);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_CurContCurSources);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_VolContVolSources);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_VolContCurSources);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_inductorsValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_capasitorsValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_resistorsValue);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_nodesValue);
            this.Name = "SIZE";
            this.Text = "SIZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_nodesValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_resistorsValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_capasitorsValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_inductorsValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_VolContCurSources;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_VolContVolSources;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_CurContCurSources;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_CurContVolSources;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_biPolarTransistors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox m_uniPolarTransistors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox m_opAmps;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m_transformers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox m_idealOpAmps;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox m_idealTransformers;
    }
}