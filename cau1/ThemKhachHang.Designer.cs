namespace cau1
{
    partial class ThemKhachHang
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            them_tenkhachhang = new TextBox();
            them_ngaysinh = new TextBox();
            label3 = new Label();
            them_diachi = new TextBox();
            label4 = new Label();
            them_sdt = new TextBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            them_click = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 45);
            label1.TabIndex = 1;
            label1.Text = "Thêm Khách Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên Khách Hàng:";
            // 
            // them_tenkhachhang
            // 
            them_tenkhachhang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            them_tenkhachhang.Location = new Point(12, 117);
            them_tenkhachhang.Name = "them_tenkhachhang";
            them_tenkhachhang.Size = new Size(373, 33);
            them_tenkhachhang.TabIndex = 3;
            // 
            // them_ngaysinh
            // 
            them_ngaysinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            them_ngaysinh.Location = new Point(12, 202);
            them_ngaysinh.Name = "them_ngaysinh";
            them_ngaysinh.Size = new Size(373, 33);
            them_ngaysinh.TabIndex = 5;
            them_ngaysinh.Validating += them_ngaysinh_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 4;
            label3.Text = "Ngày Sinh:";
            // 
            // them_diachi
            // 
            them_diachi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            them_diachi.Location = new Point(12, 287);
            them_diachi.Name = "them_diachi";
            them_diachi.Size = new Size(373, 33);
            them_diachi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 6;
            label4.Text = "Địa Chỉ:";
            // 
            // them_sdt
            // 
            them_sdt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            them_sdt.Location = new Point(12, 375);
            them_sdt.Name = "them_sdt";
            them_sdt.Size = new Size(373, 33);
            them_sdt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 336);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 8;
            label5.Text = "Số Điện Thoại:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // them_click
            // 
            them_click.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            them_click.Location = new Point(12, 426);
            them_click.Name = "them_click";
            them_click.Size = new Size(373, 44);
            them_click.TabIndex = 10;
            them_click.Text = "Thêm Khách Hàng";
            them_click.UseVisualStyleBackColor = true;
            them_click.Click += them_click_Click;
            // 
            // ThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 482);
            Controls.Add(them_click);
            Controls.Add(them_sdt);
            Controls.Add(label5);
            Controls.Add(them_diachi);
            Controls.Add(label4);
            Controls.Add(them_ngaysinh);
            Controls.Add(label3);
            Controls.Add(them_tenkhachhang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemKhachHang";
            Text = "ThemKhachHang";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox them_tenkhachhang;
        private TextBox them_ngaysinh;
        private Label label3;
        private TextBox them_diachi;
        private Label label4;
        private TextBox them_sdt;
        private Label label5;
        private ErrorProvider errorProvider1;
        private Button them_click;
    }
}