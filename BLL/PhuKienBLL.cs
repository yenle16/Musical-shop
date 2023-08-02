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
    public class PhuKienBLL
    {
        public static PhuKienBLL _instance;
        public static PhuKienBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PhuKienBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAll()
        {
            return PhuKienDAL.Instance.LoadAll();
        }
        public DataTable LoadSearch(string txt)
        {
            return PhuKienDAL.Instance.LoadSearch(txt);
        }
        public void AddPK(PhuKien PK)
        {
            PhuKienDAL.Instance.AddPK(PK);
        }
        public void UpdatePK(PhuKien PK)
        {
            PhuKienDAL.Instance.UpdatePK(PK);
        }
        public void DeletePK(List<string> MaPK)
        {
            foreach (string i in MaPK)
            {
                PhuKienDAL.Instance.DeletePK(i);
            }
        }
        public long GetGiaNhapPK(string MaPK)
        {
            return PhuKienDAL.Instance.GetGiaNhapPK(MaPK);
        }
        public void UpdateSLPK(string maPK, int SL)
        {
            PhuKienDAL.Instance.UpdateSLPK(maPK, SL);
        }
    }
}
