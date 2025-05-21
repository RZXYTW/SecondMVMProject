using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;

namespace WpfApp38.Services
{
    public interface ISearchButtonService
    {
        List<ContactInformationModel> SearchContactInformation(string Name, string Email, string Designnation,List<ContactInformationModel> listCITable);
    }
}
