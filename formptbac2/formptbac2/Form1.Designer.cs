namespace formptbac2
{
    partial class PT_bac2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lb_c = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lb_b = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.lb_a = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nghiem = new System.Windows.Forms.Label();
            this.bt_nghiem = new System.Windows.Forms.Button();
            this.bt_resert = new System.Windows.Forms.Button();
            this.pt_nghiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtc);
            this.groupBox1.Controls.Add(this.lb_c);
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.lb_b);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.lb_a);
            this.groupBox1.Location = new System.Drawing.Point(56, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hệ số";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(28, 93);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 22);
            this.txtc.TabIndex = 5;
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Location = new System.Drawing.Point(6, 92);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(16, 16);
            this.lb_c.TabIndex = 0;
            this.lb_c.Text = "C";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(28, 65);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 22);
            this.txtb.TabIndex = 4;
            // 
            // lb_b
            // 
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(6, 65);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(16, 16);
            this.lb_b.TabIndex = 0;
            this.lb_b.Text = "B";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(28, 35);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 3;
            // 
            // lb_a
            // 
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(6, 35);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(16, 16);
            this.lb_a.TabIndex = 0;
            this.lb_a.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_nghiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(361, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nghiệm của PT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // tb_nghiem
            // 
            this.tb_nghiem.AutoSize = true;
            this.tb_nghiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_nghiem.Location = new System.Drawing.Point(40, 51);
            this.tb_nghiem.Name = "tb_nghiem";
            this.tb_nghiem.Size = new System.Drawing.Size(0, 16);
            this.tb_nghiem.TabIndex = 0;
            // 
            // bt_nghiem
            // 
            this.bt_nghiem.Location = new System.Drawing.Point(361, 310);
            this.bt_nghiem.Name = "bt_nghiem";
            this.bt_nghiem.Size = new System.Drawing.Size(75, 23);
            this.bt_nghiem.TabIndex = 3;
            this.bt_nghiem.Text = "Nghiệm";
            this.bt_nghiem.UseVisualStyleBackColor = true;
            this.bt_nghiem.Click += new System.EventHandler(this.bt_nghiem_Click);
            // 
            // bt_resert
            // 
            this.bt_resert.Location = new System.Drawing.Point(495, 286);
            this.bt_resert.Name = "bt_resert";
            this.bt_resert.Size = new System.Drawing.Size(75, 47);
            this.bt_resert.TabIndex = 4;
            this.bt_resert.Text = "Resert";
            this.bt_resert.UseVisualStyleBackColor = true;
            this.bt_resert.Click += new System.EventHandler(this.bt_resert_Click);
            // 
            // pt_nghiem
            // 
            this.pt_nghiem.AutoSize = true;
            this.pt_nghiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pt_nghiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pt_nghiem.Location = new System.Drawing.Point(279, 49);
            this.pt_nghiem.Name = "pt_nghiem";
            this.pt_nghiem.Size = new System.Drawing.Size(273, 16);
            this.pt_nghiem.TabIndex = 5;
            this.pt_nghiem.Text = "GIẢI VÀ BIỆN LUẬN PHƯƠNG TRÌNH BẬC 2";
            // 
            // PT_bac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pt_nghiem);
            this.Controls.Add(this.bt_resert);
            this.Controls.Add(this.bt_nghiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PT_bac2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lb_a;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tb_nghiem;
        private System.Windows.Forms.Button bt_nghiem;
        private System.Windows.Forms.Button bt_resert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pt_nghiem;
    }
}

