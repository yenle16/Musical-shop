using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL : DataBase
    {
        public static HoaDonDAL _instance;
        public static HoaDonDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonDAL();
                return _instance;
            }
            set { }
        }
        public DataTable GetKH()
        {
            string query = "select * from KhachHang";
            return LoadData(query);
        }
        public DataTable SetCBBMGG()
        {
            string query = "select * from MaGiamGia";
            return LoadData(query);
        }
        public DataTable SetCBBPK()
        {
            string query = "select * from PhuKien";
            return LoadData(query);
        }
        public DataTable SetCBBNC1()
        {
            string query = "select * from NhacCu";
            return LoadData(query);
        }
        public DataTable LoadAllHD()
        {
            string query = "select * from HoaDon ";
            return LoadData(query);

        }
        public void AddHD(HoaDon HD)
        {
            string query = "Insert into HoaDon (MaHD,MaND,MaKH,TenKH,SDT,TongTien,MaGG,ThanhTien) values (N'" + HD.MaHD + "',N'" + HD.MaND + "',N'" + HD.MaKH + "',N'" + HD.TenKH + "','" + HD.SDT + "',N'" + HD.TongTien + "','" + HD.MaGG + "','" + HD.ThanhTien + "')";
            EditData(query);
            // return query;
        }
        public void UpdateHD(HoaDon HD)
        {
            string query = "Update HoaDon set MaND = N'" + HD.MaND + "', MaKH = '" + HD.MaKH + "',TenKH = N'" + HD.TenKH + "', SDT = N'" + HD.SDT + "',TongTien = '" + HD.TongTien + "',MaGG='" + HD.MaGG + "',ThanhTien='" + HD.ThanhTien + "' where MaHD = N'" + HD.MaHD + "'";
            EditData(query);
        }
        public void DeleteCTHD(string MaHD)
        {
            string query = "Delete from ChiTietHoaDon where MaHD ='" + MaHD + "'";
            EditData(query);
            // return query;
        }
        public void DeleteCTHD1(string MaCTHD)
        {
            string query = "Delete from ChiTietHoaDon where MaCTHD ='" + MaCTHD + "'";
            EditData(query);
            // return query;
        }
        public DataTable SetCBB()
        {
            string query = "select distinct LoaiNC from NhacCu";
            return LoadData(query);
        }
        public DataTable GetMaCTHD()
        {
            string query = "select * from ChiTietHoaDon where MaCTHD = (select max(MaCTHD) from ChiTietHoaDon)";
            return LoadData(query);
        }
        public void InsertNC(string maNC)
        {
            string query = "insert into ChiTietHoaDon (MaSP,TenSP,GiaSP,ThoiGianBaoHanh) select MaNC,TenNC,GiaBan,ThoiGianBaoHanh from NhacCu where MaNC='" + maNC + "'";
            EditData(query);
        }
        public void InsertPK(string maPK)
        {
            string query = "insert into ChiTietHoaDon (MaSP,TenSP,GiaSP,ThoiGianBaoHanh) select MaPK,TenPK,GiaBan,ThoiGianBaoHanh from PhuKien where MaPK='" + maPK + "'";
            EditData(query);
        }
        public void UpdateCTHD(string maHD, int SL, int MaCTHD)
        {
            string query = "update ChiTietHoaDon set MaHD='" + maHD + "',SoLuong='" + SL + "',NgayMua='" + DateTime.Now + "' where MaCTHD='" + MaCTHD + "'";
            EditData(query);
        }



    }
}
