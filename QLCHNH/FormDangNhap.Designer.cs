namespace QLCHNH
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pndangnhap = new System.Windows.Forms.Panel();
            this.btthoat = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.d = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pndangnhap.SuspendLayout();
            this.panel6.SuspendLayout();
            this.d.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(126)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlogo
            // 
            this.pnlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pnlogo.Controls.Add(this.pictureBox1);
            this.pnlogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlogo.Location = new System.Drawing.Point(0, 54);
            this.pnlogo.Name = "pnlogo";
            this.pnlogo.Size = new System.Drawing.Size(305, 424);
            this.pnlogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(126)))), ((int)(((byte)(58)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 424);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pndangnhap
            // 
            this.pndangnhap.Controls.Add(this.btthoat);
            this.pndangnhap.Controls.Add(this.btLogin);
            this.pndangnhap.Controls.Add(this.panel6);
            this.pndangnhap.Controls.Add(this.panel4);
            this.pndangnhap.Controls.Add(this.label1);
            this.pndangnhap.Controls.Add(this.label4);
            this.pndangnhap.Controls.Add(this.label2);
            this.pndangnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndangnhap.ForeColor = System.Drawing.Color.White;
            this.pndangnhap.Location = new System.Drawing.Point(305, 54);
            this.pndangnhap.Name = "pndangnhap";
            this.pndangnhap.Size = new System.Drawing.Size(495, 424);
            this.pndangnhap.TabIndex = 2;
            // 
            // btthoat
            // 
            this.btthoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btthoat.FlatAppearance.BorderSize = 2;
            this.btthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthoat.ForeColor = System.Drawing.Color.White;
            this.btthoat.Location = new System.Drawing.Point(249, 289);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(169, 46);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btLogin
            // 
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btLogin.FlatAppearance.BorderSize = 2;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(70, 289);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(169, 46);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Đăng Nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.MouseEnter += new System.EventHandler(this.btLogin_MouseEnter);
            this.btLogin.MouseLeave += new System.EventHandler(this.btLogin_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.d);
            this.panel6.Location = new System.Drawing.Point(123, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 116);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 84);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 25);
            this.panel7.TabIndex = 2;
            // 
            // d
            // 
            this.d.Controls.Add(this.panel9);
            this.d.Controls.Add(this.tbTaiKhoan);
            this.d.Location = new System.Drawing.Point(0, 15);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(286, 63);
            this.d.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(16, 49);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(254, 1);
            this.panel9.TabIndex = 2;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.tbTaiKhoan.Location = new System.Drawing.Point(16, 14);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(255, 20);
            this.tbTaiKhoan.TabIndex = 3;
            this.tbTaiKhoan.TextChanged += new System.EventHandler(this.tbTaiKhoan_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(123, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 90);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 25);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbMK);
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 63);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(16, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 1);
            this.panel3.TabIndex = 2;
            // 
            // tbMK
            // 
            this.tbMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK.ForeColor = System.Drawing.Color.White;
            this.tbMK.Location = new System.Drawing.Point(16, 14);
            this.tbMK.Name = "tbMK";
            this.tbMK.PasswordChar = '*';
            this.tbMK.Size = new System.Drawing.Size(255, 20);
            this.tbMK.TabIndex = 3;
            this.tbMK.TextChanged += new System.EventHandler(this.tbMK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.pndangnhap);
            this.Controls.Add(this.pnlogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.pnlogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pndangnhap.ResumeLayout(false);
            this.pndangnhap.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.d.ResumeLayout(false);
            this.d.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlogo;
        private System.Windows.Forms.Panel pndangnhap;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel d;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}