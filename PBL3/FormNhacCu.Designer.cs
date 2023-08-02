namespace PBL3
{
    partial class FormNhacCu
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
            this.numSoLuongNC = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.butThemNC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butSuaNC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butXoaNC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butTimKiemNC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTGBH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLoaiNC = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numSoLuongNC
            // 
            this.numSoLuongNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.numSoLuongNC.Location = new System.Drawing.Point(659, 41);
            this.numSoLuongNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSoLuongNC.Name = "numSoLuongNC";
            this.numSoLuongNC.Size = new System.Drawing.Size(71, 22);
            this.numSoLuongNC.TabIndex = 102;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNC,
            this.LoaiNC,
            this.TenNC,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan,
            this.ThoiGian});
            this.dataGridView1.Location = new System.Drawing.Point(3, 364);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(439, 52);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm Kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(407, 44);
            this.txtSearch.TabIndex = 91;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 85);
            this.label2.TabIndex = 93;
            this.label2.Text = "Nhạc Cụ ";
            // 
            // txtMaNC
            // 
            this.txtMaNC.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtMaNC.BorderRadius = 10;
            this.txtMaNC.BorderThickness = 2;
            this.txtMaNC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNC.DefaultText = "";
            this.txtMaNC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtMaNC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNC.Location = new System.Drawing.Point(49, 27);
            this.txtMaNC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.PasswordChar = '\0';
            this.txtMaNC.PlaceholderText = "Mã NC";
            this.txtMaNC.SelectedText = "";
            this.txtMaNC.Size = new System.Drawing.Size(105, 37);
            this.txtMaNC.TabIndex = 94;
            // 
            // txtTenNC
            // 
            this.txtTenNC.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtTenNC.BorderRadius = 10;
            this.txtTenNC.BorderThickness = 2;
            this.txtTenNC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNC.DefaultText = "";
            this.txtTenNC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtTenNC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNC.Location = new System.Drawing.Point(212, 27);
            this.txtTenNC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNC.Name = "txtTenNC";
            this.txtTenNC.PasswordChar = '\0';
            this.txtTenNC.PlaceholderText = "Tên";
            this.txtTenNC.SelectedText = "";
            this.txtTenNC.Size = new System.Drawing.Size(176, 37);
            this.txtTenNC.TabIndex = 96;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtGiaNhap.BorderRadius = 10;
            this.txtGiaNhap.BorderThickness = 2;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.DefaultText = "";
            this.txtGiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtGiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Location = new System.Drawing.Point(49, 143);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.PlaceholderText = "Giá Nhập";
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(179, 43);
            this.txtGiaNhap.TabIndex = 97;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtGiaBan.BorderRadius = 10;
            this.txtGiaBan.BorderThickness = 2;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Location = new System.Drawing.Point(277, 143);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "Giá Bán";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(220, 43);
            this.txtGiaBan.TabIndex = 98;
            // 
            // butThemNC
            // 
            this.butThemNC.AutoRoundedCorners = true;
            this.butThemNC.BackColor = System.Drawing.Color.SlateGray;
            this.butThemNC.BorderRadius = 20;
            this.butThemNC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThemNC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThemNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemNC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThemNC.FillColor = System.Drawing.Color.SlateBlue;
            this.butThemNC.FillColor2 = System.Drawing.Color.Lavender;
            this.butThemNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butThemNC.ForeColor = System.Drawing.Color.Black;
            this.butThemNC.Location = new System.Drawing.Point(872, 122);
            this.butThemNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butThemNC.Name = "butThemNC";
            this.butThemNC.Size = new System.Drawing.Size(145, 43);
            this.butThemNC.TabIndex = 103;
            this.butThemNC.Text = "Thêm ";
            this.butThemNC.Click += new System.EventHandler(this.butThemNC_Click);
            // 
            // butSuaNC
            // 
            this.butSuaNC.AutoRoundedCorners = true;
            this.butSuaNC.BackColor = System.Drawing.Color.SlateGray;
            this.butSuaNC.BorderRadius = 20;
            this.butSuaNC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSuaNC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSuaNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaNC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSuaNC.FillColor = System.Drawing.Color.SlateBlue;
            this.butSuaNC.FillColor2 = System.Drawing.Color.Lavender;
            this.butSuaNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butSuaNC.ForeColor = System.Drawing.Color.Black;
            this.butSuaNC.Location = new System.Drawing.Point(872, 193);
            this.butSuaNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butSuaNC.Name = "butSuaNC";
            this.butSuaNC.Size = new System.Drawing.Size(145, 43);
            this.butSuaNC.TabIndex = 104;
            this.butSuaNC.Text = "Sửa ";
            this.butSuaNC.Click += new System.EventHandler(this.butSuaNC_Click_1);
            // 
            // butXoaNC
            // 
            this.butXoaNC.AutoRoundedCorners = true;
            this.butXoaNC.BackColor = System.Drawing.Color.SlateGray;
            this.butXoaNC.BorderRadius = 20;
            this.butXoaNC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butXoaNC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butXoaNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butXoaNC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butXoaNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butXoaNC.FillColor = System.Drawing.Color.SlateBlue;
            this.butXoaNC.FillColor2 = System.Drawing.Color.Lavender;
            this.butXoaNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butXoaNC.ForeColor = System.Drawing.Color.Black;
            this.butXoaNC.Location = new System.Drawing.Point(872, 268);
            this.butXoaNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butXoaNC.Name = "butXoaNC";
            this.butXoaNC.Size = new System.Drawing.Size(145, 43);
            this.butXoaNC.TabIndex = 105;
            this.butXoaNC.Text = "Xóa";
            this.butXoaNC.Click += new System.EventHandler(this.butXoaNC_Click_1);
            // 
            // butTimKiemNC
            // 
            this.butTimKiemNC.AutoRoundedCorners = true;
            this.butTimKiemNC.BackColor = System.Drawing.Color.SlateGray;
            this.butTimKiemNC.BorderRadius = 21;
            this.butTimKiemNC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTimKiemNC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTimKiemNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTimKiemNC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTimKiemNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTimKiemNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butTimKiemNC.ForeColor = System.Drawing.Color.Black;
            this.butTimKiemNC.Location = new System.Drawing.Point(872, 52);
            this.butTimKiemNC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butTimKiemNC.Name = "butTimKiemNC";
            this.butTimKiemNC.Size = new System.Drawing.Size(145, 44);
            this.butTimKiemNC.TabIndex = 106;
            this.butTimKiemNC.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTGBH);
            this.groupBox1.Controls.Add(this.txtLoaiNC);
            this.groupBox1.Controls.Add(this.txtMaNC);
            this.groupBox1.Controls.Add(this.txtTenNC);
            this.groupBox1.Controls.Add(this.numSoLuongNC);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Location = new System.Drawing.Point(49, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(795, 219);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhạc Cụ";
            // 
            // txtTGBH
            // 
            this.txtTGBH.BackColor = System.Drawing.Color.Transparent;
            this.txtTGBH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtTGBH.BorderRadius = 10;
            this.txtTGBH.BorderThickness = 2;
            this.txtTGBH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTGBH.DefaultText = "";
            this.txtTGBH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTGBH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTGBH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTGBH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTGBH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTGBH.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtTGBH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTGBH.Location = new System.Drawing.Point(49, 81);
            this.txtTGBH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTGBH.Name = "txtTGBH";
            this.txtTGBH.PasswordChar = '\0';
            this.txtTGBH.PlaceholderText = "TG Bảo Hành";
            this.txtTGBH.SelectedText = "";
            this.txtTGBH.Size = new System.Drawing.Size(179, 43);
            this.txtTGBH.TabIndex = 104;
            // 
            // txtLoaiNC
            // 
            this.txtLoaiNC.BackColor = System.Drawing.Color.Transparent;
            this.txtLoaiNC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtLoaiNC.BorderRadius = 10;
            this.txtLoaiNC.BorderThickness = 2;
            this.txtLoaiNC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiNC.DefaultText = "";
            this.txtLoaiNC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoaiNC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoaiNC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiNC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiNC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiNC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtLoaiNC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiNC.Location = new System.Drawing.Point(455, 27);
            this.txtLoaiNC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLoaiNC.Name = "txtLoaiNC";
            this.txtLoaiNC.PasswordChar = '\0';
            this.txtLoaiNC.PlaceholderText = "Loại ";
            this.txtLoaiNC.SelectedText = "";
            this.txtLoaiNC.Size = new System.Drawing.Size(179, 37);
            this.txtLoaiNC.TabIndex = 103;
            // 
            // MaNC
            // 
            this.MaNC.DataPropertyName = "MaNC";
            this.MaNC.HeaderText = "Mã nhạc cụ";
            this.MaNC.MinimumWidth = 6;
            this.MaNC.Name = "MaNC";
            this.MaNC.ReadOnly = true;
            // 
            // LoaiNC
            // 
            this.LoaiNC.DataPropertyName = "LoaiNC";
            this.LoaiNC.HeaderText = "Loại nhạc cụ";
            this.LoaiNC.MinimumWidth = 6;
            this.LoaiNC.Name = "LoaiNC";
            this.LoaiNC.ReadOnly = true;
            // 
            // TenNC
            // 
            this.TenNC.DataPropertyName = "TenNC";
            this.TenNC.HeaderText = "Tên nhạc cụ";
            this.TenNC.MinimumWidth = 6;
            this.TenNC.Name = "TenNC";
            this.TenNC.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng ";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGianBaoHanh";
            this.ThoiGian.HeaderText = "Thời gian bảo hành";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // FormNhacCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1087, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butTimKiemNC);
            this.Controls.Add(this.butXoaNC);
            this.Controls.Add(this.butSuaNC);
            this.Controls.Add(this.butThemNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhacCu";
            this.Text = "FormNhacCu";
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNC;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNC;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private Guna.UI2.WinForms.Guna2GradientButton butThemNC;
        private Guna.UI2.WinForms.Guna2GradientButton butSuaNC;
        private Guna.UI2.WinForms.Guna2GradientButton butXoaNC;
        private Guna.UI2.WinForms.Guna2GradientButton butTimKiemNC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSoLuongNC;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiNC;
        private Guna.UI2.WinForms.Guna2TextBox txtTGBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
    }
}