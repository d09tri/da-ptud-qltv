using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSettings.Properties; // Using cái này đầu tiên
using DTO;

namespace DAL
{
    public class TestDAL
    {
        /// <summary>
        /// Hầu hết các class DAL thuộc project DAL sẽ sử dụng UserConnectionString setting nằm trong project ProjectSettings
        /// để kết nối cơ sở dữ liệu, việc thay đổi UserConnectionString sẽ tiện cho việc thay thế toàn bộ kết nối nhanh chóng hơn
        /// </summary>
        string TestConnectionString = Settings.Default.UserConnectionString;
        DB_PTUD_QLTVDataContext qltv = new DB_PTUD_QLTVDataContext(Settings.Default.UserConnectionString);

       

        public TestDAL() { }

        public string LoadUserConnectionString()
        {
            return TestConnectionString;
        }
    }
}
