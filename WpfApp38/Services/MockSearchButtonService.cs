using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;

namespace WpfApp38.Services
{
    public class MockSearchButtonService : ISearchButtonService
    {
        public List<ContactInformationModel> SearchContactInformation(string Name, string Email, string Designnation, List<ContactInformationModel> listCITable)
        {
            List<ContactInformationModel> listSearchCIModel = new List<ContactInformationModel>();
            foreach (var item in listCITable)
            {
                if (Name == item.Name && Email == item.Email && Designnation == item.Designnation)
                {
                    listSearchCIModel.Add(new ContactInformationModel
                    {
                        Name = item.Name,
                        Email = item.Email,
                        Designnation = item.Designnation,
                        Address = item.Address,
                        City = item.City,
                        Country = item.Country
                    });
                }
            }
            return listSearchCIModel;
        }
    }
}
