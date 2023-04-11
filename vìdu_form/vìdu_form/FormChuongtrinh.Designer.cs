namespace vìdu_form
{
    partial class FormChuongtrinh
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.Label();
            this.tb_b = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_nghiem = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_resert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtc);
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.tb_c);
            this.groupBox1.Controls.Add(this.tb_b);
            this.groupBox1.Controls.Add(this.tb_a);
            this.groupBox1.Location = new System.Drawing.Point(25, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hệ số ";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(28, 99);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(135, 22);
            this.txtc.TabIndex = 6;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(28, 64);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(135, 22);
            this.txtb.TabIndex = 6;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(28, 30);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(135, 22);
            this.txta.TabIndex = 6;
            // 
            // tb_c
            // 
            this.tb_c.AutoSize = true;
            this.tb_c.Location = new System.Drawing.Point(6, 99);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(16, 16);
            this.tb_c.TabIndex = 6;
            this.tb_c.Text = "C";
            // 
            // tb_b
            // 
            this.tb_b.AutoSize = true;
            this.tb_b.Location = new System.Drawing.Point(6, 64);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(16, 16);
            this.tb_b.TabIndex = 6;
            this.tb_b.Text = "B";
            // 
            // tb_a
            // 
            this.tb_a.AutoSize = true;
            this.tb_a.Location = new System.Drawing.Point(6, 30);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(16, 16);
            this.tb_a.TabIndex = 6;
            this.tb_a.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(203, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "GIẢI VÀ BIỆN LUẬN PHƯƠNG TRÌNH BẬC 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_nghiem);
            this.groupBox2.Location = new System.Drawing.Point(355, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nghiệm của PT";
            // 
            // b_nghiem
            // 
            this.b_nghiem.AutoSize = true;
            this.b_nghiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.b_nghiem.Location = new System.Drawing.Point(49, 36);
            this.b_nghiem.Name = "b_nghiem";
            this.b_nghiem.Size = new System.Drawing.Size(0, 16);
            this.b_nghiem.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nghiệm ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_resert
            // 
            this.bt_resert.Location = new System.Drawing.Point(497, 301);
            this.bt_resert.Name = "bt_resert";
            this.bt_resert.Size = new System.Drawing.Size(75, 23);
            this.bt_resert.TabIndex = 5;
            this.bt_resert.Text = "Resert";
            this.bt_resert.UseVisualStyleBackColor = true;
            // 
            // FormChuongtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.bt_resert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormChuongtrinh";
            this.Text = "Giai và Biện luận phuong trinh bậc 2";
            this.Load += new System.EventHandler(this.FormChuongtrinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label tb_c;
        private System.Windows.Forms.Label tb_b;
        private System.Windows.Forms.Label tb_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_resert;
        private System.Windows.Forms.Label b_nghiem;
    }
}