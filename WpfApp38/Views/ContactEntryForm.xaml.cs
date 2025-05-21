using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp38.Models;
using WpfApp38.ViewModels;

namespace WpfApp38.Views
{
    /// <summary>
    /// ContactEntryForm.xaml 的交互逻辑
    /// </summary>
    public partial class ContactEntryForm : Window
    {
        public ContactEntryForm(string Name,string Email,string Designnation)
        {
            InitializeComponent();
            this.DataContext=new ContactEntryFormViewModel(Name, Email, Designnation);
        }
        public ContactEntryForm(ContactInformationModel selectItem)
        {
            InitializeComponent();
            this.DataContext=new ContactEntryFormViewModel(selectItem);
        }
    }
}
