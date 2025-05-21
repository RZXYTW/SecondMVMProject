using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp38.Services
{
    interface IAddButtonSecondService
    {
        void AddDataToDB(string Name, string Email, string Designnation, string Address, string City, string Country);
    }
}
