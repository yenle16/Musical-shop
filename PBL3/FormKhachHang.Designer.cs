namespace PBL3
{
    partial class FormKhachHang
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
            this.butThemHD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.butSuaKH = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butXoaKH = new Guna.UI2.WinForms.Guna2GradientButton();
            this.butTimKiemKH = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimKiemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butThemHD
            // 
            this.butThemHD.AutoRoundedCorners = true;
            this.butThemHD.BackColor = System.Drawing.Color.SlateGray;
            this.butThemHD.BorderRadius = 23;
            this.butThemHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThemHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThemHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemHD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThemHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThemHD.FillColor = System.Drawing.Color.SlateBlue;
            this.butThemHD.FillColor2 = System.Drawing.Color.Lavender;
            this.butThemHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butThemHD.ForeColor = System.Drawing.Color.White;
            this.butThemHD.Location = new System.Drawing.Point(423, 192);
            this.butThemHD.Margin = new System.Windows.Forms.Padding(4);
            this.butThemHD.Name = "butThemHD";
            this.butThemHD.Size = new System.Drawing.Size(103, 48);
            this.butThemHD.TabIndex = 0;
            this.butThemHD.Text = "Thêm ";
            this.butThemHD.Click += new System.EventHandler(this.butThemKH_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.AutoRoundedCorners = true;
            this.txtMaKH.BackColor = System.Drawing.Color.SlateGray;
            this.txtMaKH.BorderRadius = 17;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.Enabled = false;
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(295, 55);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(231, 36);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoRoundedCorners = true;
            this.txtTenKH.BackColor = System.Drawing.Color.SlateGray;
            this.txtTenKH.BorderRadius = 17;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Location = new System.Drawing.Point(295, 129);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(231, 36);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoRoundedCorners = true;
            this.txtDiaChi.BackColor = System.Drawing.Color.SlateGray;
            this.txtDiaChi.BorderRadius = 17;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(740, 129);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 36);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoRoundedCorners = true;
            this.txtSDT.BackColor = System.Drawing.Color.SlateGray;
            this.txtSDT.BorderRadius = 17;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(740, 55);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(231, 36);
            this.txtSDT.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(113, 63);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(125, 22);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Mã khách hàng";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(105, 137);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(131, 22);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Tên khách hàng";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(568, 137);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(58, 22);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Địa chỉ";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(568, 63);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(109, 22);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Số điện thoại";
            // 
            // butSuaKH
            // 
            this.butSuaKH.AutoRoundedCorners = true;
            this.butSuaKH.BackColor = System.Drawing.Color.SlateGray;
            this.butSuaKH.BorderRadius = 23;
            this.butSuaKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSuaKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSuaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaKH.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSuaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSuaKH.FillColor = System.Drawing.Color.SlateBlue;
            this.butSuaKH.FillColor2 = System.Drawing.Color.Lavender;
            this.butSuaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butSuaKH.ForeColor = System.Drawing.Color.White;
            this.butSuaKH.Location = new System.Drawing.Point(597, 192);
            this.butSuaKH.Margin = new System.Windows.Forms.Padding(4);
            this.butSuaKH.Name = "butSuaKH";
            this.butSuaKH.Size = new System.Drawing.Size(108, 48);
            this.butSuaKH.TabIndex = 10;
            this.butSuaKH.Text = "Sửa";
            this.butSuaKH.Click += new System.EventHandler(this.butSuaKH_Click);
            // 
            // butXoaKH
            // 
            this.butXoaKH.AutoRoundedCorners = true;
            this.butXoaKH.BackColor = System.Drawing.Color.SlateGray;
            this.butXoaKH.BorderRadius = 23;
            this.butXoaKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butXoaKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butXoaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butXoaKH.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butXoaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butXoaKH.FillColor = System.Drawing.Color.SlateBlue;
            this.butXoaKH.FillColor2 = System.Drawing.Color.Lavender;
            this.butXoaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butXoaKH.ForeColor = System.Drawing.Color.White;
            this.butXoaKH.Location = new System.Drawing.Point(765, 192);
            this.butXoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.butXoaKH.Name = "butXoaKH";
            this.butXoaKH.Size = new System.Drawing.Size(116, 48);
            this.butXoaKH.TabIndex = 11;
            this.butXoaKH.Text = "Xóa";
            this.butXoaKH.Click += new System.EventHandler(this.butXoaKH_Click);
            // 
            // butTimKiemKH
            // 
            this.butTimKiemKH.AutoRoundedCorners = true;
            this.butTimKiemKH.BackColor = System.Drawing.Color.SlateGray;
            this.butTimKiemKH.BorderRadius = 17;
            this.butTimKiemKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTimKiemKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTimKiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTimKiemKH.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTimKiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTimKiemKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butTimKiemKH.ForeColor = System.Drawing.Color.White;
            this.butTimKiemKH.Location = new System.Drawing.Point(33, 258);
            this.butTimKiemKH.Margin = new System.Windows.Forms.Padding(4);
            this.butTimKiemKH.Name = "butTimKiemKH";
            this.butTimKiemKH.Size = new System.Drawing.Size(125, 36);
            this.butTimKiemKH.TabIndex = 12;
            this.butTimKiemKH.Text = "Tìm kiếm";
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.AutoRoundedCorners = true;
            this.txtTimKiemKH.BackColor = System.Drawing.Color.SlateGray;
            this.txtTimKiemKH.BorderRadius = 17;
            this.txtTimKiemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemKH.DefaultText = "";
            this.txtTimKiemKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemKH.Location = new System.Drawing.Point(183, 258);
            this.txtTimKiemKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.PasswordChar = '\0';
            this.txtTimKiemKH.PlaceholderText = "";
            this.txtTimKiemKH.SelectedText = "";
            this.txtTimKiemKH.Size = new System.Drawing.Size(284, 36);
            this.txtTimKiemKH.TabIndex = 13;
            this.txtTimKiemKH.TextChanged += new System.EventHandler(this.txtTimKiemKH_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKh,
            this.SDT,
            this.DiaChi});
            this.dataGridView1.Location = new System.Drawing.Point(0, 391);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SlateGray;
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1107, 603);
            this.guna2Panel1.TabIndex = 14;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKh
            // 
            this.TenKh.DataPropertyName = "TenKH";
            this.TenKh.HeaderText = "Tên khách hàng";
            this.TenKh.MinimumWidth = 6;
            this.TenKh.Name = "TenKh";
            this.TenKh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 603);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.butTimKiemKH);
            this.Controls.Add(this.butXoaKH);
            this.Controls.Add(this.butSuaKH);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.butThemHD);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKhachHang";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton butThemHD;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2GradientButton butSuaKH;
        private Guna.UI2.WinForms.Guna2GradientButton butXoaKH;
        private Guna.UI2.WinForms.Guna2GradientButton butTimKiemKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemKH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}