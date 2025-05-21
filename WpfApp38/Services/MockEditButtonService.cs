using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;
using WpfApp38.Views;

namespace WpfApp38.Services
{
    class MockEditButtonService : IEditButtonService
    {
        public void OpenAddOrEditForm(ContactInformationModel selectItem)
        {
            
            ContactEntryForm contactEntryForm = new ContactEntryForm(selectItem);
            contactEntryForm.ShowDialog();
        }
    }
}
