using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HoaDonBLL
    {
        public static HoaDonBLL _instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllHD()
        {
            return HoaDonDAL.Instance.LoadAllHD();
        }
        public void AddHD(HoaDon HD)
        {
            HoaDonDAL.Instance.AddHD(HD);
        }
        public void UpdateHD(HoaDon HD)
        {
            HoaDonDAL.Instance.UpdateHD(HD);
        }
        public void DeleteCTHD(string maHD)
        {
            HoaDonDAL.Instance.DeleteCTHD(maHD);
        }
        public void DeleteCTHD1(string maCTHD)
        {
            HoaDonDAL.Instance.DeleteCTHD1(maCTHD);
        }
        public DataTable GetKH()
        {
            return HoaDonDAL.Instance.GetKH();
        }
        public DataTable SetCBB()
        {
            return HoaDonDAL.Instance.SetCBB();
        }
        public DataTable SetCBBMGG()
        {
            return HoaDonDAL.Instance.SetCBBMGG();
        }
        public DataTable SetCBBNC1()
        {
            return HoaDonDAL.Instance.SetCBBNC1();
        }
        public DataTable SetCBBPK()
        {
            return HoaDonDAL.Instance.SetCBBPK();
        }
        public DataTable GetMaCTHD()
        {
            return HoaDonDAL.Instance.GetMaCTHD();
        }
        public void InsertNC(string maNC)
        {
            HoaDonDAL.Instance.InsertNC(maNC);
        }
        public void InsertPK(string maPK)
        {
            HoaDonDAL.Instance.InsertPK(maPK);
        }
        public void UpdateCTHD(string maHD, int SL, int maCTHD)
        {
            HoaDonDAL.Instance.UpdateCTHD(maHD, SL, maCTHD);
        }
    }
}
