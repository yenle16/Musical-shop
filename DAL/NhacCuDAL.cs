using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class NhacCuDAL : DataBase
    {
        public static NhacCuDAL _instance;
        public static NhacCuDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhacCuDAL();
                return _instance;
            }
            set { }
        }
        public DataBase DB = new DataBase();
        public DataTable LoadAll()
        {
            string query = "select * from NhacCu ";
            return LoadData(query);
        }
        public DataTable LoadSearch(string txt)
        {
            string query = "Select  * from NhacCu where TenNC like N'%" + txt + "%'";
            return LoadData(query);
        }
        public string AddNC(NhacCu NC)
        {
            string query = "Insert into NhacCu (MaNC,LoaiNC,TenNC,Soluong,GiaNhap,GiaBan,ThoiGianBaoHanh) values (N'" + NC.MaNC + "',N'" + NC.LoaiNC + "',N'" + NC.TenNC + "',N'" + NC.SoLuong + "',N'" + NC.GiaNhap + "',N'" + NC.GiaBan + "',N'" + NC.ThoiGianBaoHanh + "')";
            EditData(query);
            return query;
        }
        public string UpdateNC(NhacCu NC)
        {
            string query = "Update NhacCu set LoaiNC = N'" + NC.LoaiNC + "',TenNC = N'" + NC.TenNC + "', Soluong = N'" + NC.SoLuong + "', GiaNhap = N'" + NC.GiaNhap + "', GiaBan = N'" + NC.GiaBan + "', ThoiGianBaoHanh = N'" + NC.ThoiGianBaoHanh + "' where MaNC = N'" + NC.MaNC + "'";
            EditData(query);
            return query;
        }
        public string DeleteNC(string MaNC)
        {
            string query = "Delete from NhacCu where MaNC = '" + MaNC + "'";
            EditData(query);
            return query;
        }
        public long GetGiaNhapNC(string MaNC)
        {
            string query = "Select * from NhacCu";
            //int ma;
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaNC"].ToString() == MaNC)
                {
                    return Convert.ToInt32(i["GiaNhap"].ToString());
                }
            }
            return -1;

        }
        public void UpdateSLNC(string maNC, int SL)
        {
            string query = "Update NhacCu set Soluong='" + SL + "' where MaNC='" + maNC + "' ";
            EditData(query);
        }
    }
}
