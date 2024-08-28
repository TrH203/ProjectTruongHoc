namespace ProjectTruongHoc
{
    partial class frm_DangNhap
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
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.rb_sinhvien = new System.Windows.Forms.RadioButton();
            this.rb_giaovien = new System.Windows.Forms.RadioButton();
            this.rb_qtv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập thông tin đăng nhập bên dưới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(341, 127);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(267, 22);
            this.txt_taikhoan.TabIndex = 3;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(341, 212);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(267, 22);
            this.txt_matkhau.TabIndex = 4;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(196, 351);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(95, 37);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(518, 351);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(90, 37);
            this.btn_dong.TabIndex = 6;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            // 
            // rb_sinhvien
            // 
            this.rb_sinhvien.AutoSize = true;
            this.rb_sinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sinhvien.Location = new System.Drawing.Point(125, 289);
            this.rb_sinhvien.Name = "rb_sinhvien";
            this.rb_sinhvien.Size = new System.Drawing.Size(93, 20);
            this.rb_sinhvien.TabIndex = 7;
            this.rb_sinhvien.TabStop = true;
            this.rb_sinhvien.Text = "Sinh Viên";
            this.rb_sinhvien.UseVisualStyleBackColor = true;
            // 
            // rb_giaovien
            // 
            this.rb_giaovien.AutoSize = true;
            this.rb_giaovien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_giaovien.Location = new System.Drawing.Point(322, 289);
            this.rb_giaovien.Name = "rb_giaovien";
            this.rb_giaovien.Size = new System.Drawing.Size(96, 20);
            this.rb_giaovien.TabIndex = 8;
            this.rb_giaovien.TabStop = true;
            this.rb_giaovien.Text = "Giáo Viên";
            this.rb_giaovien.UseVisualStyleBackColor = true;
            // 
            // rb_qtv
            // 
            this.rb_qtv.AutoSize = true;
            this.rb_qtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_qtv.Location = new System.Drawing.Point(505, 289);
            this.rb_qtv.Name = "rb_qtv";
            this.rb_qtv.Size = new System.Drawing.Size(122, 20);
            this.rb_qtv.TabIndex = 9;
            this.rb_qtv.TabStop = true;
            this.rb_qtv.Text = "Quản Trị Viên";
            this.rb_qtv.UseVisualStyleBackColor = true;
            this.rb_qtv.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_qtv);
            this.Controls.Add(this.rb_giaovien);
            this.Controls.Add(this.rb_sinhvien);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.RadioButton rb_sinhvien;
        private System.Windows.Forms.RadioButton rb_giaovien;
        private System.Windows.Forms.RadioButton rb_qtv;
    }
}