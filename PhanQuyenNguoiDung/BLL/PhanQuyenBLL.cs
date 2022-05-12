using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL phanQuyenDAL = new PhanQuyenDAL();

        public PhanQuyenBLL() { }

        public List<PhanQuyen> LoadDSPhanQuyenTheoMaNhom(string maNhom)
        {
            return phanQuyenDAL.GetDSPhanQuyenTheoMaNhom(maNhom);
        }
    }
}
