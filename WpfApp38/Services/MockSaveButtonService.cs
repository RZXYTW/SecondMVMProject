using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp38.Models;
using WpfApp38.Services.EF6;

namespace WpfApp38.Services
{
    class MockSaveButtonService : IAddButtonSecondService
    {
        public void AddDataToDB(string Name, string Email, string Designation, string Address, string City, string Country)
        {
            try
            {
                using (MyDBContext db = new MyDBContext())
                {
                    ContactInformationModel cIM = new ContactInformationModel()
                    {
                        Name = Name,
                        Email = Email,
                        Designnation = Designation,
                        Address = Address,
                        City = City,
                        Country = Country,
                    };
                    DbEntityEntry<ContactInformationModel> entry = db.Entry<ContactInformationModel>(cIM);
                    entry.State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    return;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("This Contact is already exist", "Erroe", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                return;
            }
        }
    }
}
