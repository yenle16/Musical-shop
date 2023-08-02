using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhuKienDAL : DataBase
    {
        public static PhuKienDAL _instance;
        public static PhuKienDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PhuKienDAL();
                return _instance;
            }
            set { }
        }
        public DataBase DB = new DataBase();
        public DataTable LoadAll()
        {
            string query = "Select * from PhuKien";
            return LoadData(query);
        }
        public DataTable LoadSearch(string txt)
        {
            string query = "Select  * from PhuKien where TenPK like N'%" + txt + "%'";
            return LoadData(query);
        }
        public string AddPK(PhuKien PK)
        {
            string query = "Insert into PhuKien(MaPK, LoaiNC, TenPK, Soluong, GiaNhap, GiaBan, ThoiGianBaoHanh) values(N'" + PK.MaPK + "', N'" + PK.LoaiNC + "', N'" + PK.TenPK + "', N'" + PK.SoLuong + "', N'" + PK.GiaNhap + "', N'" + PK.GiaBan + "', N'" + PK.ThoiGianBaoHanh + "')";
            EditData(query);
            return query;
        }
        public string UpdatePK(PhuKien PK)
        {
            string query = "Update PhuKien set LoaiNC = N'" + PK.LoaiNC + "',TenPK = N'" + PK.TenPK + "', Soluong = N'" + PK.SoLuong + "', GiaNhap = N'" + PK.GiaNhap + "', GiaBan = N'" + PK.GiaBan + "', ThoiGianBaoHanh = N'" + PK.ThoiGianBaoHanh + "' where MaPK = N'" + PK.MaPK + "'";
            EditData(query);
            return query;
        }
        public string DeletePK(string MaPK)
        {
            string query = "Delete from PhuKien where MaPK = '" + MaPK + "'";
            EditData(query);
            return query;
        }
        public long GetGiaNhapPK(string MaPK)
        {
            string query = "Select * from PhuKien";
            //int ma;
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaPK"].ToString() == MaPK)
                {
                    return Convert.ToInt32(i["GiaNhap"].ToString());
                }
            }
            return -1;
        }
        public void UpdateSLPK(string maPK, int SL)
        {
            string query = "Update PhuKien set Soluong='" + SL + "' where MaPK='" + maPK + "' ";
            EditData(query);
        }

    }
}
