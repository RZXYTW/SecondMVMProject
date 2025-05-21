using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using WpfApp38.Models;
using WpfApp38.Services.EF6;

namespace WpfApp38.Services
{
    class MockDeleteButtonSecond : IDeleteButtonService
    {
        public void DeleteButtonClicked(ContactInformationModel selectItem)
        {
           
            using (MyDBContext db = new MyDBContext())
            {
                if (MessageBox.Show("Are you sure delete this Contact?", "Delete Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
                {
                    int rowAffected = db.Database.ExecuteSqlCommand(
                        $"DELETE FROM CITable WHERE Name = '{selectItem.Name}' AND Email = '{selectItem.Email}' AND Designnation = '{selectItem.Designnation}' AND Address = '{selectItem.Address}' AND City = '{selectItem.City}' AND Country = '{selectItem.Country}'");
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Delete Successfully", "Delete Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed", "Delete Confirmation", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
