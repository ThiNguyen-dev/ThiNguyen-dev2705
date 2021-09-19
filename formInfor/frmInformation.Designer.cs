namespace formInfor
{
    partial class frmInformation
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
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NoiSinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chbox_Nam = new System.Windows.Forms.CheckBox();
            this.chbox_Nu = new System.Windows.Forms.CheckBox();
            this.chbox_Khac = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(454, 77);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(334, 26);
            this.txt_Ten.TabIndex = 0;
            this.txt_Ten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(342, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(344, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(344, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nơi sinh:";
            // 
            // txt_NoiSinh
            // 
            this.txt_NoiSinh.Location = new System.Drawing.Point(454, 131);
            this.txt_NoiSinh.Name = "txt_NoiSinh";
            this.txt_NoiSinh.Size = new System.Drawing.Size(334, 26);
            this.txt_NoiSinh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(344, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(454, 180);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(334, 26);
            this.txt_Email.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(344, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh:";
            // 
            // dateTime_NgaySinh
            // 
            this.dateTime_NgaySinh.Location = new System.Drawing.Point(454, 235);
            this.dateTime_NgaySinh.Name = "dateTime_NgaySinh";
            this.dateTime_NgaySinh.Size = new System.Drawing.Size(287, 26);
            this.dateTime_NgaySinh.TabIndex = 6;
            this.dateTime_NgaySinh.Value = new System.DateTime(2021, 9, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(344, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chbox_Nam
            // 
            this.chbox_Nam.AutoSize = true;
            this.chbox_Nam.Location = new System.Drawing.Point(454, 295);
            this.chbox_Nam.Name = "chbox_Nam";
            this.chbox_Nam.Size = new System.Drawing.Size(68, 24);
            this.chbox_Nam.TabIndex = 7;
            this.chbox_Nam.Text = "Nam";
            this.chbox_Nam.UseVisualStyleBackColor = true;
            this.chbox_Nam.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbox_Nu
            // 
            this.chbox_Nu.AutoSize = true;
            this.chbox_Nu.Location = new System.Drawing.Point(543, 295);
            this.chbox_Nu.Name = "chbox_Nu";
            this.chbox_Nu.Size = new System.Drawing.Size(55, 24);
            this.chbox_Nu.TabIndex = 7;
            this.chbox_Nu.Text = "Nữ";
            this.chbox_Nu.UseVisualStyleBackColor = true;
            this.chbox_Nu.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbox_Khac
            // 
            this.chbox_Khac.AutoSize = true;
            this.chbox_Khac.Location = new System.Drawing.Point(636, 293);
            this.chbox_Khac.Name = "chbox_Khac";
            this.chbox_Khac.Size = new System.Drawing.Size(71, 24);
            this.chbox_Khac.TabIndex = 7;
            this.chbox_Khac.Text = "Khác";
            this.chbox_Khac.UseVisualStyleBackColor = true;
            this.chbox_Khac.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(344, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quê quán:";
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.Location = new System.Drawing.Point(454, 352);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(334, 26);
            this.txt_QueQuan.TabIndex = 4;
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_ten.Location = new System.Drawing.Point(109, 283);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(84, 22);
            this.lbl_ten.TabIndex = 9;
            this.lbl_ten.Text = "Sinh viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::formInfor.Properties.Resources._1630499231130;
            this.pictureBox1.Location = new System.Drawing.Point(61, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chbox_Khac);
            this.Controls.Add(this.chbox_Nu);
            this.Controls.Add(this.chbox_Nam);
            this.Controls.Add(this.dateTime_NgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_QueQuan);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_NoiSinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ten);
            this.Name = "frmInformation";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.frmInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NoiSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime_NgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbox_Nam;
        private System.Windows.Forms.CheckBox chbox_Nu;
        private System.Windows.Forms.CheckBox chbox_Khac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ten;
    }
}

