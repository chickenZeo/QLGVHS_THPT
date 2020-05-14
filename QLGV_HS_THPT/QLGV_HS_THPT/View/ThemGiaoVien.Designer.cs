namespace QLGV_HS_THPT.View
{
    partial class ThemGiaoVien
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
            this.cbBoxMaMH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listGiaoVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHoGv = new System.Windows.Forms.TextBox();
            this.cbBoxTT = new System.Windows.Forms.ComboBox();
            this.cbBoxGtinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtTenGv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxMaMH
            // 
            this.cbBoxMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxMaMH.FormattingEnabled = true;
            this.cbBoxMaMH.Items.AddRange(new object[] {
            "1"});
            this.cbBoxMaMH.Location = new System.Drawing.Point(721, 248);
            this.cbBoxMaMH.Name = "cbBoxMaMH";
            this.cbBoxMaMH.Size = new System.Drawing.Size(100, 24);
            this.cbBoxMaMH.TabIndex = 73;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listGiaoVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 183);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // listGiaoVien
            // 
            this.listGiaoVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGiaoVien.HideSelection = false;
            this.listGiaoVien.Location = new System.Drawing.Point(18, 26);
            this.listGiaoVien.Name = "listGiaoVien";
            this.listGiaoVien.Size = new System.Drawing.Size(852, 151);
            this.listGiaoVien.TabIndex = 0;
            this.listGiaoVien.UseCompatibleStateImageBehavior = false;
            this.listGiaoVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã GV";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giới tính";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quê quán";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CMND";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lương";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Trạng thái";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Môn dạy";
            this.columnHeader10.Width = 90;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(621, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.Red;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(284, 13);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 28);
            this.button_Them.TabIndex = 0;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm giáo viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(721, 174);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 25);
            this.txtCMND.TabIndex = 68;
            // 
            // txtHoGv
            // 
            this.txtHoGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoGv.Location = new System.Drawing.Point(118, 114);
            this.txtHoGv.Multiline = true;
            this.txtHoGv.Name = "txtHoGv";
            this.txtHoGv.Size = new System.Drawing.Size(119, 25);
            this.txtHoGv.TabIndex = 67;
            // 
            // cbBoxTT
            // 
            this.cbBoxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTT.FormattingEnabled = true;
            this.cbBoxTT.Items.AddRange(new object[] {
            "Đang đi dạy",
            "Đã nghỉ dạy"});
            this.cbBoxTT.Location = new System.Drawing.Point(118, 246);
            this.cbBoxTT.Name = "cbBoxTT";
            this.cbBoxTT.Size = new System.Drawing.Size(119, 24);
            this.cbBoxTT.TabIndex = 71;
            // 
            // cbBoxGtinh
            // 
            this.cbBoxGtinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxGtinh.FormattingEnabled = true;
            this.cbBoxGtinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbBoxGtinh.Location = new System.Drawing.Point(721, 115);
            this.cbBoxGtinh.Name = "cbBoxGtinh";
            this.cbBoxGtinh.Size = new System.Drawing.Size(100, 24);
            this.cbBoxGtinh.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "TrangThai";
            // 
            // txtluong
            // 
            this.txtluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtluong.Location = new System.Drawing.Point(421, 243);
            this.txtluong.Multiline = true;
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(119, 25);
            this.txtluong.TabIndex = 66;
            // 
            // txtTenGv
            // 
            this.txtTenGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGv.Location = new System.Drawing.Point(421, 115);
            this.txtTenGv.Multiline = true;
            this.txtTenGv.Name = "txtTenGv";
            this.txtTenGv.Size = new System.Drawing.Size(119, 25);
            this.txtTenGv.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(640, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "GioiTinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(650, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "MaMH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Luong";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(650, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "NgaySinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "QueQuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "TenGV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "HoGV";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 86);
            this.panel1.TabIndex = 53;
            // 
            // txtquequan
            // 
            this.txtquequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquequan.Location = new System.Drawing.Point(118, 177);
            this.txtquequan.Multiline = true;
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(119, 25);
            this.txtquequan.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button_Them);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 56);
            this.panel2.TabIndex = 54;
            // 
            // ThemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 533);
            this.Controls.Add(this.cbBoxMaMH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtHoGv);
            this.Controls.Add(this.cbBoxTT);
            this.Controls.Add(this.cbBoxGtinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txtTenGv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.panel2);
            this.Name = "ThemGiaoVien";
            this.Text = "ThemGiaoVien";
            this.Load += new System.EventHandler(this.ThemGiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxMaMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listGiaoVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoGv;
        private System.Windows.Forms.ComboBox cbBoxTT;
        private System.Windows.Forms.ComboBox cbBoxGtinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtTenGv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.Panel panel2;
    }
}