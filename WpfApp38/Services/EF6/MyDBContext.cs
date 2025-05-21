using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;

namespace WpfApp38.Services.EF6
{
    class MyDBContext:DbContext
    {
        //创建数据库上下文
        public MyDBContext():base("Server=localhost;Database=contact_db;Trusted_Connection=True;")
        {

        }
        public DbSet<ContactInformationModel> CITable { get; set; }
    }
}
 