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
using DAL;
using DTO;

namespace PBL3
{
    public partial class FormPhuKien : Form
    {
        public FormPhuKien()
        {
            InitializeComponent();
            ShowDGV();
            SetCBB();
        }
        public DataBase DB = new DataBase();
        public void ShowDGV()
        {
            dataGridView1.DataSource = PhuKienBLL.Instance.LoadAll();
        }
        public void ShowDGV(string txt)
        {
            if (txt == "All") dataGridView1.DataSource = PhuKienBLL.Instance.LoadAll();
            else dataGridView1.DataSource = PhuKienBLL.Instance.LoadSearch(txt);
        }

        public void SetCBB()
        {
            cbbLoaiNC.Items.Add(new CBBItem { Value = "", Text = "All" });
            string query = "select distinct LoaiNC from NhacCu";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {

                cbbLoaiNC.Items.Add(new CBBItem
                {

                    Value = i["LoaiNC"].ToString(),
                    Text = i["LoaiNC"].ToString()
                });

            }
        }
        public void clear()
        {
            txtMaPK.Text = "";
            cbbLoaiNC.Items.Clear();
            cbbLoaiNC.ResetText();
            txtTenPK.Text = "";
            numSoLuongPK.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtTGBH.Text = "";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void butThemPK_Click_1(object sender, EventArgs e)
        {
            string maPK = "";
            int sohang = dataGridView1.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dataGridView1.Rows[sohang - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
            if (chuoi2 < 9) maPK = "PK0" + (chuoi2 + 1).ToString();
            else maPK = "PK" + (chuoi2 + 1);

            PhuKien PK = new PhuKien(maPK, cbbLoaiNC.Text, txtTenPK.Text, Convert.ToInt32(numSoLuongPK.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtTGBH.Text));
            if (cbbLoaiNC.Text.Length == 0 || txtTenPK.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                PhuKienBLL.Instance.AddPK(PK);
                MessageBox.Show("Thêm thành công");
                ShowDGV();
                clear();

            }
        }

        private void butSuaPK_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                PhuKien PK = new PhuKien(txtMaPK.Text, cbbLoaiNC.Text, txtTenPK.Text, Convert.ToInt32(numSoLuongPK.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtTGBH.Text));
                PhuKienBLL.Instance.UpdatePK(PK);
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

                txtMaPK.Text = row.Cells[0].Value.ToString();
                cbbLoaiNC.Text = row.Cells[1].Value.ToString();
                txtTenPK.Text = row.Cells[2].Value.ToString();
                numSoLuongPK.Text = row.Cells[3].Value.ToString();
                txtGiaNhap.Text = row.Cells[4].Value.ToString();
                txtGiaBan.Text = row.Cells[5].Value.ToString();
                txtTGBH.Text = row.Cells[6].Value.ToString();


                txtMaPK.Enabled = false;
            }
        }

        private void butXoaPK_Click_1(object sender, EventArgs e)
        {
            List<string> MaPK = new List<string>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        MaPK.Add(row.Cells[0].Value.ToString());
                    }
                    PhuKienBLL.Instance.DeletePK(MaPK);
                    ShowDGV();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa");
            }
        }
    }
}
