using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;

namespace WpfApp38.Services
{
    public interface IAddButtonFirstService
    {
        void OpenAddOrEditForm(string Name, string Email, string Designnation);
    }
}
