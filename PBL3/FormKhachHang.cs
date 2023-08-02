using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DAL;

namespace PBL3
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            ShowDGV();
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = KhachHangBLL.Instance.LoadAll();
        }
        public void ShowDGV(string txt)
        {
            if (txt == "All") dataGridView1.DataSource = KhachHangBLL.Instance.LoadAll();
            else dataGridView1.DataSource = KhachHangBLL.Instance.LoadSearch(txt);
        }
        public void clear()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void butThemKH_Click(object sender, EventArgs e)
        {
            string maKH = "";
            int sohang = dataGridView1.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dataGridView1.Rows[sohang - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
            if (chuoi2 < 9) maKH = "KH0" + (chuoi2 + 1).ToString();
            else maKH = "KH" + (chuoi2 + 1);
            KhachHang KH = new KhachHang(maKH, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
            if (txtTenKH.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                KhachHangBLL.Instance.AddKH(KH);
                MessageBox.Show("Thêm thành công");
                ShowDGV();
                clear();
            }

        }

        private void butSuaKH_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                KhachHang KH = new KhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                KhachHangBLL.Instance.UpdateKH(KH);
                ShowDGV();
                MessageBox.Show("Sửa thành công");
                clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();


                txtMaKH.Enabled = false;
            }
        }

        private void butXoaKH_Click(object sender, EventArgs e)
        {
            List<string> MaKH = new List<string>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        MaKH.Add(row.Cells[0].Value.ToString());
                    }
                    KhachHangBLL.Instance.DeleteKH(MaKH);
                    ShowDGV();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa");
            }
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            ShowDGV(txtTimKiemKH.Text);
        }
    }
}
