using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BEL
{
    public class TaiKhoan
    {
        
        private string UserName;
        private string Password;
        private string MaCV;

        public TaiKhoan(string username, string pass, string macv)
        {
            
            this.UserName1 = username;
            this.Password1 = pass;
            this.MaCV = macv;
        }

  
        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string MaCV1 { get => MaCV; set => MaCV = value; }
    }
}
