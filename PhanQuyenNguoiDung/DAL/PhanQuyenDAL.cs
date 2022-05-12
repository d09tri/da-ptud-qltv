using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhanQuyenDAL
    {
        DB_PTUD_PQNGDataContext dataContext = new DB_PTUD_PQNGDataContext();

        public PhanQuyenDAL() { }

        public List<PhanQuyen> GetDSPhanQuyenTheoMaNhom(string maNhom)
        {
            return dataContext.PhanQuyens.Where(t => t.MaNhom.Equals(maNhom)).Select(t => t).ToList();
        }
    }
}
