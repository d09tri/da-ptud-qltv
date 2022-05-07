using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NguoiDungBLL
    {
        NguoiDungDAL nguoiDungDAL = new NguoiDungDAL();

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            return nguoiDungDAL.KiemTraDangNhap(tenDangNhap, matKhau);
        }
    }
}
