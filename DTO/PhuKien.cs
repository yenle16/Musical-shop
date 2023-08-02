using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhuKien
    {
        public string MaPK { get; set; }
        public string LoaiNC { get; set; }
        public string TenPK { get; set; }
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public PhuKien(string MaPK, string LoaiNC, string TenPK, int SoLuong, int GiaNhap, int GiaBan, int ThoiGianBaoHanh)
        {
            this.MaPK = MaPK;
            this.LoaiNC = LoaiNC;
            this.TenPK = TenPK;
            this.SoLuong = SoLuong;
            this.GiaNhap = GiaNhap;
            this.GiaBan = GiaBan;
            this.ThoiGianBaoHanh = ThoiGianBaoHanh;
        }
    }
}
