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
    public class NhacCuBLL
    {

        public static NhacCuBLL _instance;
        public static NhacCuBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhacCuBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAll()
        {
            return NhacCuDAL.Instance.LoadAll();
        }
        public DataTable LoadSearch(string txt)
        {
            return NhacCuDAL.Instance.LoadSearch(txt);
        }
        public void AddNC(NhacCu NC)
        {
            NhacCuDAL.Instance.AddNC(NC);
        }
        public void UpdateNC(NhacCu NC)
        {
            NhacCuDAL.Instance.UpdateNC(NC);
        }
        public void DeleteNC(List<string> MaNC)
        {
            foreach (string i in MaNC)
            {
                NhacCuDAL.Instance.DeleteNC(i);
            }
        }
        public long GetGiaNhapNC(string MaNC)
        {
            return NhacCuDAL.Instance.GetGiaNhapNC(MaNC);
        }
        public void UpdateSLNC(string maNC, int SL)
        {
            NhacCuDAL.Instance.UpdateSLNC(maNC, SL);
        }
    }
}
