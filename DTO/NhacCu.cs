using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhacCu
    {
        public string MaNC { get; set; }

        public string LoaiNC { get; set; }
        public string TenNC { get; set; }
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public NhacCu(string MaNC, string LoaiNC, string TenNC, int SoLuong, int GiaNhap, int GiaBan, int ThoiGianBaoHanh)
        {
            this.MaNC = MaNC;
            this.LoaiNC = LoaiNC;
            this.TenNC = TenNC;
            this.SoLuong = SoLuong;
            this.GiaNhap = GiaNhap;
            this.GiaBan = GiaBan;
            this.ThoiGianBaoHanh = ThoiGianBaoHanh;
        }

    }
}
