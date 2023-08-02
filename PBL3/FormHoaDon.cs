using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BLL;

namespace PBL3
{
    public partial class FormHoaDon : Form
    {
        DataBase DB = new DataBase();
        public FormHoaDon()
        {
            InitializeComponent();
            Sender = new mydel1(GetText);
            dataGridViewHD.CurrentCell = null;
            ShowDGVHD();
            txtMaHD.Text = TangMa();
            HoaDonBLL.Instance.DeleteCTHD(txtMaHD.Text);
            SetCBBNC();
            //SetCBB1();
            SetCBBNCPK();
        }
        public delegate void mydel1(string maND);
        public mydel1 Sender; // public Form2()
        private void GetText(string MaND)
        {
            txtMaND.Text = MaND;

        }
        public void ShowDGVHD()
        {
            dataGridViewHD.DataSource = HoaDonBLL.Instance.LoadAllHD();
        }
        public void ShowDGVChiTietHD()
        {
            dataGridViewChiTietHD.DataSource = ChiTietHoaDonBLL.Instance.LoadAllCTHD(txtMaHD.Text);
        }
        public void ShowCTHD()
        {
            string maHD;
            if (dataGridViewHD.SelectedRows.Count > 0)
            {
                maHD = dataGridViewHD.SelectedRows[dataGridViewHD.SelectedRows.Count - 1].Cells[0].Value.ToString();
                dataGridViewChiTietHD.DataSource = ChiTietHoaDonBLL.Instance.LoadAllCTHD(maHD);
            }
            else MessageBox.Show("Chọn hóa đơn muốn xem chi tiết");

        }
        public void ShowCTHD1(string maHD)
        {
            dataGridViewChiTietHD.DataSource = ChiTietHoaDonBLL.Instance.LoadAllCTHD(maHD);
        }
        public void SetCBBNC()
        {
            cbbLoaiNC.Items.Add(new CBBItem { Value = "", Text = "All" });
            foreach (DataRow i in HoaDonBLL.Instance.SetCBB().Rows)
            {

                cbbLoaiNC.Items.Add(new CBBItem
                {

                    Value = i["LoaiNC"].ToString(),
                    Text = i["LoaiNC"].ToString()
                });

            }
        }
        public void SetCBBNCPK()
        {
            cbbLoaiNCPK.Items.Add(new CBBItem { Value = "", Text = "All" });

            foreach (DataRow i in HoaDonBLL.Instance.SetCBB().Rows)
            {

                cbbLoaiNCPK.Items.Add(new CBBItem
                {

                    Value = i["LoaiNC"].ToString(),
                    Text = i["LoaiNC"].ToString()
                });

            }
        }
        public string TangMa()
        {
            string maHD = "";
            int sohang = dataGridViewHD.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dataGridViewHD.Rows[sohang - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
            if (chuoi2 < 9) maHD = "HD0" + (chuoi2 + 1).ToString();
            else maHD = "HD" + (chuoi2 + 1);
            return maHD;
        }


        private void butThemKH_Click(object sender, EventArgs e)
        {
            //string maHD = "";
            //int sohang = dataGridViewHD.Rows.Count;
            //string chuoi1 = "";
            //int chuoi2 = 0;
            //chuoi1 = Convert.ToString(dataGridViewHD.Rows[sohang - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
            //if (chuoi2 < 9) maHD = "HD0" + (chuoi2 + 1).ToString();
            //else maHD = "HD" + (chuoi2 + 1);
            HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
            if (txtMaKH.Text.Length == 0 || txtTenKH.Text.Length == 0 || txtSDT.Text.Length == 0 || txtTongTien.Text.Length == 0 || txtMaGG.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                HoaDonBLL.Instance.AddHD(HD);
                MessageBox.Show("Thêm thành công");
                ShowDGVHD();
                txtMaHD.Text = TangMa();
                ShowCTHD1(txtMaHD.Text);

            }
        }

        private void cbbLoaiNC_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbbTenNC.Items.Clear();
            cbbTenNC.ResetText();
            txtGiaNC.Text = "";
            txtMaNC.Text = "";
            if (cbbLoaiNC.SelectedItem.ToString() == "All")
            {
                foreach (DataRow i in HoaDonBLL.Instance.SetCBBNC1().Rows)
                {
                    cbbTenNC.Items.Add(i["TenNC"]);
                }
            }

            foreach (DataRow i in HoaDonBLL.Instance.SetCBBNC1().Rows)
            {
                if (i["LoaiNC"].ToString() == cbbLoaiNC.SelectedItem.ToString())
                {
                    cbbTenNC.Items.Add(i["TenNC"]);
                }
            }
        }

        private void cbbLoaiNCPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string query = "select * from PhuKien";
            cbbTenPK.Items.Clear();
            cbbTenPK.ResetText();
            txtGiaPK.Text = "";
            txtMaPK.Text = "";
            if (cbbLoaiNCPK.SelectedItem.ToString() == "All")
            {
                foreach (DataRow i in HoaDonBLL.Instance.SetCBBPK().Rows)
                {
                    cbbTenPK.Items.Add(i["TenPK"]);
                }
            }

            foreach (DataRow i in HoaDonBLL.Instance.SetCBBPK().Rows)
            {
                if (i["LoaiNC"].ToString() == cbbLoaiNCPK.SelectedItem.ToString())
                {
                    cbbTenPK.Items.Add(i["TenPK"]);
                }
            }

        }

        private void cbbTenPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string query = "select * from PhuKien";
            foreach (DataRow i in HoaDonBLL.Instance.SetCBBPK().Rows)
            {
                if (i["TenPK"].ToString() == cbbTenPK.SelectedItem.ToString())
                {
                    txtMaPK.Text = i["MaPK"].ToString();
                    txtGiaPK.Text = i["GiaBan"].ToString();
                }
            }
        }
        public int GetMaCTHD()
        {
            int MaCTHD = 0;
            // string query1 = "select * from ChiTietHoaDon where MaCTHD = (select max(MaCTHD) from ChiTietHoaDon)";
            foreach (DataRow i in HoaDonBLL.Instance.GetMaCTHD().Rows)
            {
                MaCTHD = Convert.ToInt32(i["MaCTHD"]);
            }
            return MaCTHD;
        }

        private void butThemNC_Click(object sender, EventArgs e)
        {
            //string query = "insert into ChiTietHoaDon (MaSP,TenSP,GiaSP,ThoiGianBaoHanh) select MaNC,TenNC,GiaBan,ThoiGianBaoHanh from NhacCu where MaNC='" + txtMaNC.Text + "'";
            //DB.EditData(query);
            HoaDonBLL.Instance.InsertNC(txtMaNC.Text);
            NhacCuBLL.Instance.UpdateSLNC(txtMaNC.Text, GetSLNCThem());

            int MaCTHD = GetMaCTHD();
            //string query2 = "update ChiTietHoaDon set MaHD='" + txtMaHD.Text + "',SoLuong='" + numSoLuongNC.Value + "',NgayMua='" + DateTime.Now + "' where MaCTHD='" + MaCTHD + "'";
            //DB.EditData(query2);
            HoaDonBLL.Instance.UpdateCTHD(txtMaHD.Text, Convert.ToInt32(numSoLuongNC.Value), MaCTHD);
            ShowDGVChiTietHD();
            TongTien();

        }
        public void TongTien()
        {
            int TongTien = 0;
            for (int i = 0; i < dataGridViewChiTietHD.Rows.Count - 1; i++)
            {

                TongTien += Convert.ToInt32(dataGridViewChiTietHD.Rows[i].Cells[4].Value.ToString()) * Convert.ToInt32(dataGridViewChiTietHD.Rows[i].Cells[5].Value.ToString());



            }
            txtTongTien.Text = TongTien.ToString();

        }

        private void butThemPK_Click(object sender, EventArgs e)
        {

            // string query = "insert into ChiTietHoaDon (MaSP,TenSP,GiaSP,ThoiGianBaoHanh) select MaPK,TenPK,GiaBan,ThoiGianBaoHanh from PhuKien where MaPK='" + txtMaPK.Text + "'";
            //DB.EditData(query);
            HoaDonBLL.Instance.InsertPK(txtMaPK.Text);
            int MaCTHD = GetMaCTHD();
            PhuKienBLL.Instance.UpdateSLPK(txtMaPK.Text, GetSLPKThem());

            //string query2 = "update ChiTietHoaDon set MaHD='" + txtMaHD.Text + "',SoLuong='" + numSoLuongPK.Value + "',NgayMua='" + DateTime.Now + "' where MaCTHD='" + MaCTHD + "'";
            //DB.EditData(query2);
            HoaDonBLL.Instance.UpdateCTHD(txtMaHD.Text, Convert.ToInt32(numSoLuongPK.Value), MaCTHD);
            ShowDGVChiTietHD();
            TongTien();


        }

        private void cbbTenNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string query = "select * from NhacCu";
            foreach (DataRow i in HoaDonBLL.Instance.SetCBBNC1().Rows)
            {
                if (i["TenNC"].ToString() == cbbTenNC.SelectedItem.ToString())
                {
                    txtMaNC.Text = i["MaNC"].ToString();
                    txtGiaNC.Text = i["GiaBan"].ToString();
                }
            }
        }
       
        private void load(DataGridViewRow row)
        {
            txtMaHD.Text = row.Cells[0].Value.ToString();
            txtMaND.Text = row.Cells[1].Value.ToString();
            txtMaKH.Text = row.Cells[2].Value.ToString();
            txtTenKH.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            // txtTongTien.Text = row.Cells[5].Value.ToString();
            txtMaGG.Text = row.Cells[6].Value.ToString();
            // txtThanhTien.Text = row.Cells[7].Value.ToString();

        }

        

       
        public string GetMaSP()
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            string ma = row.Cells["MaSP"].Value.ToString();
            return ma;
        }
        //public string GetMaPK()
        //{
        //    DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
        //    string ma = row.Cells["MaSP"].Value.ToString();
        //    return ma;
        //}
        public int GetSLNCinDGV()
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            int sl = Convert.ToInt32(row.Cells["SoLuong"].Value.ToString());
            return sl;
        }
        public int GetSLPKinDGV()
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            int sl = Convert.ToInt32(row.Cells["SoLuong"].Value.ToString());
            return sl;
        }
        public int GetSLNCXoa()
        {
            int SL = 0;
            foreach (DataRow i in NhacCuBLL.Instance.LoadAll().Rows)
            {
                if (i["MaNC"].ToString() == GetMaSP())
                {
                    SL = Convert.ToInt32(i["Soluong"]) + Convert.ToInt32(GetSLNCinDGV());
                    // return SL;
                }
                // return SL;
            }
            return SL;
        }
        public int GetSLPKXoa()
        {
            int SL = 0;
            foreach (DataRow i in PhuKienBLL.Instance.LoadAll().Rows)
            {
                if (i["MaPK"].ToString() == GetMaSP())
                {
                    SL = Convert.ToInt32(i["Soluong"]) + Convert.ToInt32(GetSLPKinDGV());
                    // return SL;
                }
                // return SL;
            }
            return SL;
        }
        public int GetSLNCThem()
        {
            int SL = 0;
            foreach (DataRow i in NhacCuBLL.Instance.LoadAll().Rows)
            {
                if (i["MaNC"].ToString() == txtMaNC.Text)
                {
                    SL = Convert.ToInt32(i["Soluong"]) - Convert.ToInt32(numSoLuongNC.Value.ToString());
                    // return SL;
                }
                // return SL;
            }
            return SL;
        }
        public int GetSLPKThem()
        {
            int SL = 0;
            foreach (DataRow i in PhuKienBLL.Instance.LoadAll().Rows)
            {
                if (i["MaPK"].ToString() == txtMaPK.Text)
                {
                    SL = Convert.ToInt32(i["Soluong"]) - Convert.ToInt32(numSoLuongPK.Value.ToString());
                    // return SL;
                }
                // return SL;
            }
            return SL;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            foreach (DataRow i in HoaDonBLL.Instance.SetCBBMGG().Rows)
            {
                if (i["MaGG"].ToString() == txtMaGG.Text)
                {
                    double chietkhau = Convert.ToDouble(i["ChietKhau"]);
                    labelChietKhau.Text = "-" + (chietkhau * Convert.ToInt32(txtTongTien.Text)).ToString() + "VND";
                    txtThanhTien.Text = (Convert.ToInt32(txtTongTien.Text) - (chietkhau * Convert.ToInt32(txtTongTien.Text))).ToString();
                }
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            string ma = row.Cells["MaCTHD"].Value.ToString();
            // TongTienXoa();
            //MessageBox.Show(GetSLNC().ToString());
            //MessageBox.Show(GetSLNCinDGV().ToString());
            //MessageBox.Show(GetMaNC());
            if (GetMaSP().ToLower().Contains("NC"))
            {
                NhacCuBLL.Instance.UpdateSLNC(GetMaSP(), GetSLNCXoa());
            }
            else
            {
                PhuKienBLL.Instance.UpdateSLPK(GetMaSP(), GetSLPKXoa());

            }
            HoaDonBLL.Instance.DeleteCTHD1(ma);
            MessageBox.Show("Xóa thành công");
            ShowDGVChiTietHD();
            TongTien();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtTongTien.Text = "0";
            txtMaGG.Text = "";
            txtThanhTien.Text = "0";
            labelChietKhau.Text = "-0VND";
        }
        private void butSuaHD_Click(object sender, EventArgs e)
        {
            if (dataGridViewHD.SelectedRows.Count == 1)
            {
                HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
                HoaDonBLL.Instance.UpdateHD(HD);
                MessageBox.Show("Đã Lưu thành công");
                ShowDGVHD();
                txtMaHD.Text = TangMa();
                clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần chỉnh sửa");
            }
        }

        private void butThemHD_Click(object sender, EventArgs e)
        {
            //string maHD = "";
            //int sohang = dataGridViewHD.Rows.Count;
            //string chuoi1 = "";
            //int chuoi2 = 0;
            //chuoi1 = Convert.ToString(dataGridViewHD.Rows[sohang - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
            //if (chuoi2 < 9) maHD = "HD0" + (chuoi2 + 1).ToString();
            //else maHD = "HD" + (chuoi2 + 1);
            HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
            if (txtMaKH.Text.Length == 0 || txtTenKH.Text.Length == 0 || txtSDT.Text.Length == 0 || txtTongTien.Text.Length == 0 || txtMaGG.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                HoaDonBLL.Instance.AddHD(HD);
                MessageBox.Show("Thêm thành công");
                ShowDGVHD();
                txtMaHD.Text = TangMa();
                ShowCTHD1(txtMaHD.Text);

            }
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewHD.Rows[e.RowIndex];
                load(row);
                ShowDGVChiTietHD();
                TongTien();
            }
            catch (Exception ex) { };
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            //string query = "select * from KhachHang";
            //string query = "Select  * from KhachHang where TenKH like N'%" + txtMaKH.Text + "%'";
            foreach (DataRow i in HoaDonBLL.Instance.GetKH().Rows)
            {
                if (i["MaKH"].ToString() == txtMaKH.Text)
                {
                    txtTenKH.Text = i["TenKH"].ToString();
                    txtSDT.Text = i["SDT"].ToString();
                }
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            string ma = row.Cells["MaCTHD"].Value.ToString();
            // TongTienXoa();
            //MessageBox.Show(GetSLNC().ToString());
            //MessageBox.Show(GetSLNCinDGV().ToString());
            //MessageBox.Show(GetMaNC());
            if (GetMaSP().ToLower().Contains("NC"))
            {
                NhacCuBLL.Instance.UpdateSLNC(GetMaSP(), GetSLNCXoa());
            }
            else
            {
                PhuKienBLL.Instance.UpdateSLPK(GetMaSP(), GetSLPKXoa());

            }
            HoaDonBLL.Instance.DeleteCTHD1(ma);
            MessageBox.Show("Xóa thành công");
            ShowDGVChiTietHD();
            TongTien();

        }
    }
}
