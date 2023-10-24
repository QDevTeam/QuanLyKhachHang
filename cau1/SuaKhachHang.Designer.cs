namespace cau1
{
    partial class SuaKhachHang
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
            label1 = new Label();
            sua_click = new Button();
            sua_sdt = new TextBox();
            label5 = new Label();
            sua_diachi = new TextBox();
            label4 = new Label();
            sua_ngaysinh = new TextBox();
            label3 = new Label();
            sua_tenkhachhang = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 45);
            label1.TabIndex = 2;
            label1.Text = "Sửa Thông Tin";
            // 
            // sua_click
            // 
            sua_click.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sua_click.Location = new Point(12, 422);
            sua_click.Name = "sua_click";
            sua_click.Size = new Size(373, 44);
            sua_click.TabIndex = 19;
            sua_click.Text = "Sửa Thông Tin";
            sua_click.UseVisualStyleBackColor = true;
            sua_click.Click += sua_click_Click;
            // 
            // sua_sdt
            // 
            sua_sdt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sua_sdt.Location = new Point(12, 371);
            sua_sdt.Name = "sua_sdt";
            sua_sdt.Size = new Size(373, 33);
            sua_sdt.TabIndex = 18;
            sua_sdt.TextChanged += sua_sdt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 332);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 17;
            label5.Text = "Số Điện Thoại:";
            // 
            // sua_diachi
            // 
            sua_diachi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sua_diachi.Location = new Point(12, 283);
            sua_diachi.Name = "sua_diachi";
            sua_diachi.Size = new Size(373, 33);
            sua_diachi.TabIndex = 16;
            sua_diachi.TextChanged += sua_diachi_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 15;
            label4.Text = "Địa Chỉ:";
            // 
            // sua_ngaysinh
            // 
            sua_ngaysinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sua_ngaysinh.Location = new Point(12, 198);
            sua_ngaysinh.Name = "sua_ngaysinh";
            sua_ngaysinh.Size = new Size(373, 33);
            sua_ngaysinh.TabIndex = 14;
            sua_ngaysinh.TextChanged += sua_ngaysinh_TextChanged;
            sua_ngaysinh.Validating += sua_ngaysinh_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 13;
            label3.Text = "Ngày Sinh:";
            // 
            // sua_tenkhachhang
            // 
            sua_tenkhachhang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sua_tenkhachhang.Location = new Point(12, 113);
            sua_tenkhachhang.Name = "sua_tenkhachhang";
            sua_tenkhachhang.Size = new Size(373, 33);
            sua_tenkhachhang.TabIndex = 12;
            sua_tenkhachhang.TextChanged += sua_tenkhachhang_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 11;
            label2.Text = "Tên Khách Hàng:";
            // 
            // SuaKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 478);
            Controls.Add(sua_click);
            Controls.Add(sua_sdt);
            Controls.Add(label5);
            Controls.Add(sua_diachi);
            Controls.Add(label4);
            Controls.Add(sua_ngaysinh);
            Controls.Add(label3);
            Controls.Add(sua_tenkhachhang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuaKhachHang";
            Text = "SuaKhachHang";
            FormClosing += SuaKhachHang_FormClosing_1;
            Load += SuaKhachHang_Load;
            KeyDown += SuaKhachHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button sua_click;
        private TextBox sua_sdt;
        private Label label5;
        private TextBox sua_diachi;
        private Label label4;
        private TextBox sua_ngaysinh;
        private Label label3;
        private TextBox sua_tenkhachhang;
        private Label label2;
    }
}