
namespace BasicForm
{
    partial class frmMathBasic
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
            this.txt_SoThuNhat = new System.Windows.Forms.TextBox();
            this.txt_SoThuHai = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.lblSoTN = new System.Windows.Forms.Label();
            this.lblSoTH = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(200, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình toán học cơ bản";
            // 
            // txt_SoThuNhat
            // 
            this.txt_SoThuNhat.Location = new System.Drawing.Point(246, 149);
            this.txt_SoThuNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SoThuNhat.Name = "txt_SoThuNhat";
            this.txt_SoThuNhat.Size = new System.Drawing.Size(290, 26);
            this.txt_SoThuNhat.TabIndex = 2;
            // 
            // txt_SoThuHai
            // 
            this.txt_SoThuHai.Location = new System.Drawing.Point(246, 198);
            this.txt_SoThuHai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SoThuHai.Name = "txt_SoThuHai";
            this.txt_SoThuHai.Size = new System.Drawing.Size(290, 26);
            this.txt_SoThuHai.TabIndex = 2;
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.Location = new System.Drawing.Point(246, 265);
            this.btnCong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(78, 35);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(335, 265);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 35);
            this.btnTru.TabIndex = 4;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(422, 265);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 35);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(512, 265);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 35);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // lblSoTN
            // 
            this.lblSoTN.AutoSize = true;
            this.lblSoTN.Location = new System.Drawing.Point(110, 149);
            this.lblSoTN.Name = "lblSoTN";
            this.lblSoTN.Size = new System.Drawing.Size(94, 20);
            this.lblSoTN.TabIndex = 7;
            this.lblSoTN.Text = "SoThuNhat:";
            // 
            // lblSoTH
            // 
            this.lblSoTH.AutoSize = true;
            this.lblSoTH.Location = new System.Drawing.Point(114, 203);
            this.lblSoTH.Name = "lblSoTH";
            this.lblSoTH.Size = new System.Drawing.Size(84, 20);
            this.lblSoTH.TabIndex = 8;
            this.lblSoTH.Text = "SoThuHai:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(114, 310);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(67, 20);
            this.lblKQ.TabIndex = 9;
            this.lblKQ.Text = "KetQua:";
            // 
            // frmMathBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblSoTH);
            this.Controls.Add(this.lblSoTN);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txt_SoThuHai);
            this.Controls.Add(this.txt_SoThuNhat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMathBasic";
            this.Text = "Chương trình toán cơ bản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoThuNhat;
        private System.Windows.Forms.TextBox txt_SoThuHai;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label lblSoTN;
        private System.Windows.Forms.Label lblSoTH;
        private System.Windows.Forms.Label lblKQ;
    }
}

