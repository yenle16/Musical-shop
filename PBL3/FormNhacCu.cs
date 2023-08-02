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
    public partial class FormNhacCu : Form
    {
        public FormNhacCu()
        {
            InitializeComponent();
            ShowDGV();
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = NhacCuBLL.Instance.LoadAll();
        }
        public void ShowDGV(string txt)
        {
            if (txt == "All") dataGridView1.DataSource = NhacCuBLL.Instance.LoadAll();
            else dataGridView1.DataSource = NhacCuBLL.Instance.LoadSearch(txt);

        }
        public void clear()
        {
            txtMaNC.Text = "";
            txtLoaiNC.Text = "";
            txtTenNC.Text = "";
            numSoLuongNC.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtTGBH.Text = "";
        }

       

       
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void butXoaNC_Click_1(object sender, EventArgs e)
        {
            List<string> MaNC = new List<string>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        MaNC.Add(row.Cells[0].Value.ToString());
                    }
                    NhacCuBLL.Instance.DeleteNC(MaNC);
                    ShowDGV();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtMaNC.Text = row.Cells[0].Value.ToString();
                txtLoaiNC.Text = row.Cells[1].Value.ToString();
                txtTenNC.Text = row.Cells[2].Value.ToString();
                numSoLuongNC.Text = row.Cells[3].Value.ToString();
                txtGiaNhap.Text = row.Cells[4].Value.ToString();
                txtGiaBan.Text = row.Cells[5].Value.ToString();
                txtTGBH.Text = row.Cells[6].Value.ToString();


                txtMaNC.Enabled = false;
            }
        }

        private void butThemNC_Click(object sender, EventArgs e)
        {
            string maNC = "";
            int sohang = dataGridView1.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dataGridView1.Rows[sohang - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
            if (chuoi2 < 9) maNC = "NC0" + (chuoi2 + 1).ToString();
            else maNC = "NC" + (chuoi2 + 1);

            NhacCu NC = new NhacCu(maNC, txtLoaiNC.Text, txtTenNC.Text, Convert.ToInt32(numSoLuongNC.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtTGBH.Text));
            if (txtLoaiNC.Text.Length == 0 || txtTenNC.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                NhacCuBLL.Instance.AddNC(NC);
                MessageBox.Show("Thêm thành công");
                ShowDGV();
                clear();

            }
        }

        private void butSuaNC_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                NhacCu NC = new NhacCu(txtMaNC.Text, txtLoaiNC.Text, txtTenNC.Text, Convert.ToInt32(numSoLuongNC.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtTGBH.Text));
                NhacCuBLL.Instance.UpdateNC(NC);
                ShowDGV();
                MessageBox.Show("Sửa thành công");
                clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa");
            }
        }
    }
}
