using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NguoiDungDAL
    {
        DB_PTUD_PQNGDataContext dataContext = new DB_PTUD_PQNGDataContext();

        public NguoiDungDAL() { }

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            NguoiDung nd = dataContext.NguoiDungs.Where(t => t.TenDangNhap.Equals(tenDangNhap) && t.MatKhau.Equals(matKhau)).FirstOrDefault();
            if (nd != null && (nd.HoatDong != false || nd.HoatDong != null))
                return true;
            else
                return false;
        }

        public string GetMaNhom(string tenDangNhap)
        {
            NguoiDung nd = dataContext.NguoiDungs.Where(t => t.TenDangNhap.Equals(tenDangNhap)).FirstOrDefault();
            if (nd != null)
                return nd.MaNhom;
            else
                return "NULL";
        }
    }
}
