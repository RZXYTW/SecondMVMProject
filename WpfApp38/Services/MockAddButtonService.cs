using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;
using WpfApp38.Views;

namespace WpfApp38.Services
{
   public class MockAddButtonService : IAddButtonFirstService
    {
        public void OpenAddOrEditForm(string Name, string Email, string Designnation)
        {
            
            ContactEntryForm contactEntryForm = new ContactEntryForm(Name, Email, Designnation);
            contactEntryForm.ShowDialog();  
        }
    }
}
