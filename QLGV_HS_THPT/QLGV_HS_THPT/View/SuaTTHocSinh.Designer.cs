namespace QLGV_HS_THPT.View
{
    partial class SuaTTHocSinh
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
            this.label9 = new System.Windows.Forms.Label();
            this.colMalop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnGt = new System.Windows.Forms.Panel();
            this.RdNu = new System.Windows.Forms.RadioButton();
            this.RdNam = new System.Windows.Forms.RadioButton();
            this.ListHocSinh = new System.Windows.Forms.ListView();
            this.colMaHS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnTt = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.TbDiaChi = new System.Windows.Forms.TextBox();
            this.TbHo = new System.Windows.Forms.TextBox();
            this.TbTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbBoxLop = new System.Windows.Forms.ComboBox();
            this.BTSua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrBThemNV = new System.Windows.Forms.GroupBox();
            this.lbMaHs = new System.Windows.Forms.Label();
            this.PnGt.SuspendLayout();
            this.PnTt.SuspendLayout();
            this.GrBThemNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Danh Sách Học Sinh ";
            // 
            // colMalop
            // 
            this.colMalop.Text = "Mã Lớp";
            this.colMalop.Width = 106;
            // 
            // TT
            // 
            this.TT.Text = "Trạng Thái";
            this.TT.Width = 111;
            // 
            // gt
            // 
            this.gt.Text = "Giới Tính";
            this.gt.Width = 85;
            // 
            // ns
            // 
            this.ns.Text = "Ngày Sinh";
            this.ns.Width = 135;
            // 
            // ten
            // 
            this.ten.Text = "Tên";
            this.ten.Width = 196;
            // 
            // PnGt
            // 
            this.PnGt.Controls.Add(this.RdNu);
            this.PnGt.Controls.Add(this.RdNam);
            this.PnGt.Location = new System.Drawing.Point(669, 43);
            this.PnGt.Name = "PnGt";
            this.PnGt.Size = new System.Drawing.Size(255, 40);
            this.PnGt.TabIndex = 23;
            // 
            // RdNu
            // 
            this.RdNu.AutoSize = true;
            this.RdNu.Location = new System.Drawing.Point(149, 5);
            this.RdNu.Name = "RdNu";
            this.RdNu.Size = new System.Drawing.Size(58, 29);
            this.RdNu.TabIndex = 10;
            this.RdNu.TabStop = true;
            this.RdNu.Text = "Nữ";
            this.RdNu.UseVisualStyleBackColor = true;
            // 
            // RdNam
            // 
            this.RdNam.AutoSize = true;
            this.RdNam.Location = new System.Drawing.Point(6, 5);
            this.RdNam.Name = "RdNam";
            this.RdNam.Size = new System.Drawing.Size(74, 29);
            this.RdNam.TabIndex = 9;
            this.RdNam.TabStop = true;
            this.RdNam.Text = "Nam";
            this.RdNam.UseVisualStyleBackColor = true;
            // 
            // ListHocSinh
            // 
            this.ListHocSinh.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ListHocSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHS,
            this.ho,
            this.ten,
            this.ns,
            this.gt,
            this.DC,
            this.TT,
            this.colMalop});
            this.ListHocSinh.FullRowSelect = true;
            this.ListHocSinh.GridLines = true;
            this.ListHocSinh.HideSelection = false;
            this.ListHocSinh.Location = new System.Drawing.Point(2, 320);
            this.ListHocSinh.Name = "ListHocSinh";
            this.ListHocSinh.Size = new System.Drawing.Size(973, 220);
            this.ListHocSinh.TabIndex = 14;
            this.ListHocSinh.UseCompatibleStateImageBehavior = false;
            this.ListHocSinh.View = System.Windows.Forms.View.Details;
            this.ListHocSinh.SelectedIndexChanged += new System.EventHandler(this.ListHocSinh_SelectedIndexChanged);
            // 
            // colMaHS
            // 
            this.colMaHS.Text = "Mã Học Sinh";
            this.colMaHS.Width = 102;
            // 
            // ho
            // 
            this.ho.Text = "Họ";
            this.ho.Width = 73;
            // 
            // DC
            // 
            this.DC.Text = "Quê Quán ";
            this.DC.Width = 158;
            // 
            // PnTt
            // 
            this.PnTt.Controls.Add(this.radioButton1);
            this.PnTt.Controls.Add(this.radioButton3);
            this.PnTt.Location = new System.Drawing.Point(669, 157);
            this.PnTt.Name = "PnTt";
            this.PnTt.Size = new System.Drawing.Size(255, 40);
            this.PnTt.TabIndex = 24;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(149, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Đã Nghỉ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 29);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Đi Học";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(725, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 60);
            this.button2.TabIndex = 16;
            this.button2.Text = "Quay Lại Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TbDiaChi
            // 
            this.TbDiaChi.Location = new System.Drawing.Point(669, 103);
            this.TbDiaChi.Multiline = true;
            this.TbDiaChi.Name = "TbDiaChi";
            this.TbDiaChi.Size = new System.Drawing.Size(255, 30);
            this.TbDiaChi.TabIndex = 19;
            // 
            // TbHo
            // 
            this.TbHo.Location = new System.Drawing.Point(178, 103);
            this.TbHo.Multiline = true;
            this.TbHo.Name = "TbHo";
            this.TbHo.Size = new System.Drawing.Size(197, 30);
            this.TbHo.TabIndex = 18;
            // 
            // TbTen
            // 
            this.TbTen.Location = new System.Drawing.Point(178, 157);
            this.TbTen.Multiline = true;
            this.TbTen.Name = "TbTen";
            this.TbTen.Size = new System.Drawing.Size(197, 30);
            this.TbTen.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Họ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lớp :";
            // 
            // CbBoxLop
            // 
            this.CbBoxLop.FormattingEnabled = true;
            this.CbBoxLop.Location = new System.Drawing.Point(669, 221);
            this.CbBoxLop.Name = "CbBoxLop";
            this.CbBoxLop.Size = new System.Drawing.Size(255, 33);
            this.CbBoxLop.TabIndex = 13;
            // 
            // BTSua
            // 
            this.BTSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSua.Location = new System.Drawing.Point(16, 586);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(187, 60);
            this.BTSua.TabIndex = 15;
            this.BTSua.Text = "Sửa";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Địa Chỉ :";
            // 
            // DTNgaySinh
            // 
            this.DTNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.DTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaySinh.Location = new System.Drawing.Point(178, 216);
            this.DTNgaySinh.Name = "DTNgaySinh";
            this.DTNgaySinh.Size = new System.Drawing.Size(197, 30);
            this.DTNgaySinh.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng Thái :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Học Sinh :";
            // 
            // GrBThemNV
            // 
            this.GrBThemNV.Controls.Add(this.PnTt);
            this.GrBThemNV.Controls.Add(this.PnGt);
            this.GrBThemNV.Controls.Add(this.TbDiaChi);
            this.GrBThemNV.Controls.Add(this.TbHo);
            this.GrBThemNV.Controls.Add(this.TbTen);
            this.GrBThemNV.Controls.Add(this.label8);
            this.GrBThemNV.Controls.Add(this.label7);
            this.GrBThemNV.Controls.Add(this.CbBoxLop);
            this.GrBThemNV.Controls.Add(this.lbMaHs);
            this.GrBThemNV.Controls.Add(this.DTNgaySinh);
            this.GrBThemNV.Controls.Add(this.label6);
            this.GrBThemNV.Controls.Add(this.label5);
            this.GrBThemNV.Controls.Add(this.label4);
            this.GrBThemNV.Controls.Add(this.label3);
            this.GrBThemNV.Controls.Add(this.label2);
            this.GrBThemNV.Controls.Add(this.label1);
            this.GrBThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.GrBThemNV.Location = new System.Drawing.Point(2, 2);
            this.GrBThemNV.Name = "GrBThemNV";
            this.GrBThemNV.Size = new System.Drawing.Size(973, 284);
            this.GrBThemNV.TabIndex = 13;
            this.GrBThemNV.TabStop = false;
            this.GrBThemNV.Text = "Sửa Thông Tin Học Sinh";
            // 
            // lbMaHs
            // 
            this.lbMaHs.AutoSize = true;
            this.lbMaHs.Location = new System.Drawing.Point(186, 43);
            this.lbMaHs.Name = "lbMaHs";
            this.lbMaHs.Size = new System.Drawing.Size(37, 25);
            this.lbMaHs.TabIndex = 12;
            this.lbMaHs.Text = ".....";
            // 
            // SuaTTHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 662);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ListHocSinh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTSua);
            this.Controls.Add(this.GrBThemNV);
            this.Name = "SuaTTHocSinh";
            this.Text = "SuaTTHocSinh";
            this.Load += new System.EventHandler(this.SuaTTHocSinh_Load);
            this.PnGt.ResumeLayout(false);
            this.PnGt.PerformLayout();
            this.PnTt.ResumeLayout(false);
            this.PnTt.PerformLayout();
            this.GrBThemNV.ResumeLayout(false);
            this.GrBThemNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader colMalop;
        private System.Windows.Forms.ColumnHeader TT;
        private System.Windows.Forms.ColumnHeader gt;
        private System.Windows.Forms.ColumnHeader ns;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.Panel PnGt;
        private System.Windows.Forms.RadioButton RdNu;
        private System.Windows.Forms.RadioButton RdNam;
        private System.Windows.Forms.ListView ListHocSinh;
        private System.Windows.Forms.ColumnHeader colMaHS;
        private System.Windows.Forms.ColumnHeader ho;
        private System.Windows.Forms.ColumnHeader DC;
        private System.Windows.Forms.Panel PnTt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TbDiaChi;
        private System.Windows.Forms.TextBox TbHo;
        private System.Windows.Forms.TextBox TbTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbBoxLop;
        private System.Windows.Forms.Button BTSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBThemNV;
        private System.Windows.Forms.Label lbMaHs;
    }
}