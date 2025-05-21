using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;
using WpfApp38.Services.EF6;

namespace WpfApp38.Services
{
    public class DBDataService : IDataService
    {
        public List<ContactInformationModel> GetContactInformation()
        {
            //连接数据库并获取数据表
            MyDBContext db = new MyDBContext();            
            List<ContactInformationModel> listCITable = db.CITable.AsNoTracking().ToList();
            db.Dispose(); // 释放数据库连接 
            return listCITable;
        }
    }
}
