using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using WpfApp38.Models;
using WpfApp38.Services;

namespace WpfApp38.ViewModels
{
    class ContactEntryFormViewModel : NotificationObject
    {
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand<ContactInformationModel> DeleteCommand { get; set; }
        public DelegateCommand<ContactInformationModel> EditCommand { get; set; }
        public DelegateCommand<object> CancelCommand { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.RaisePropertyChanged("Name");
            }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                this.RaisePropertyChanged("Email");
            }
        }

        private string designnation;

        public string Designnation
        {
            get { return designnation; }
            set
            {
                designnation = value;
                this.RaisePropertyChanged("Designnation");
            }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                this.RaisePropertyChanged("Address");
            }
        }

        private string city;

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                this.RaisePropertyChanged("City");
            }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                this.RaisePropertyChanged("Country");
            }
        }

        private List<ContactInformationModel> listCITable;

        public List<ContactInformationModel> ListCITable
        {
            get { return listCITable; }
            set
            {
                listCITable = value;
                this.RaisePropertyChanged("ListCITable");
            }
        }

        public ContactEntryFormViewModel(string Name, string Email, string Designnation)
        {
            this.LoadCITable(Name, Email, Designnation);
            this.AddCommand = new DelegateCommand(new Action(this.AddCommandExecute));
            this.SaveCommand = new DelegateCommand(new Action(this.SaveCommandExecute));
            this.DeleteCommand=new DelegateCommand<ContactInformationModel>(new Action<ContactInformationModel>(this.DeleteCommandExecute));
            this.EditCommand=new DelegateCommand<ContactInformationModel>(new Action<ContactInformationModel>(this.EditCommandExecute));
            this.CancelCommand = new DelegateCommand<object>(new Action<object>(this.CancelCommandExecute));
        }
        public ContactEntryFormViewModel(ContactInformationModel selectItem)
        {
            this.LoadCITable(selectItem);
            this.AddCommand = new DelegateCommand(new Action(this.AddCommandExecute));
            this.SaveCommand = new DelegateCommand(new Action(this.SaveCommandExecute));
            this.DeleteCommand = new DelegateCommand<ContactInformationModel>(new Action<ContactInformationModel>(this.DeleteCommandExecute));
            this.EditCommand = new DelegateCommand<ContactInformationModel>(new Action<ContactInformationModel>(this.EditCommandExecute));
            this.CancelCommand = new DelegateCommand<object>(new Action<object>(this.CancelCommandExecute));
        }

        private void LoadCITable(ContactInformationModel selectItem)
        {
            this.Name = selectItem.Name;
            this.Email = selectItem.Email;
            this.Designnation = selectItem.Designnation;
            this.Address = selectItem.Address;
            this.City = selectItem.City;
            this.Country = selectItem.Country;
            IDataService dataService = new DBDataService();
            this.ListCITable = dataService.GetContactInformation();
            this.ListCITable.RemoveAll(x => x.Name != selectItem.Name || x.Email != selectItem.Email || x.Designnation != selectItem.Designnation);

        }

        private void CancelCommandExecute(object ob)
        {
              (ob as System.Windows.Window).Close();
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            mainWindowViewModel.LoadCITable();
        }

        private void EditCommandExecute(ContactInformationModel selectItem)
        {
            this.Name = selectItem.Name;
            this.Email = selectItem.Email;
            this.Designnation = selectItem.Designnation;
            this.Address = selectItem.Address;
            this.City = selectItem.City;
            this.Country = selectItem.Country;
        }

        private void DeleteCommandExecute(ContactInformationModel selectItem)
        {
            MockDeleteButtonSecond mockDeleteButtonSecond = new MockDeleteButtonSecond();
            mockDeleteButtonSecond.DeleteButtonClicked(selectItem);
            this.LoadCITable(this.Name,this.Email,this.Designnation);
        }

        private void SaveCommandExecute()
        {
            MockSaveButtonService mockSaveButtonService = new MockSaveButtonService();
            mockSaveButtonService.AddDataToDB(this.Name,this.Email,this.Designnation,this.Address,this.City,this.Country);
            this.LoadCITable(this.Name, this.Email, this.Designnation);
        }

        private void LoadCITable(string Name, string Email, string Designnation)
        {
            this.Name = Name;
            this.Email = Email;
            this.Designnation = Designnation;
            IDataService dataService = new DBDataService();
            this.ListCITable = dataService.GetContactInformation();
            this.ListCITable.RemoveAll(x => x.Name != Name || x.Email != Email || x.Designnation != Designnation);
        }
        private void AddCommandExecute()
        {
            MockAddButtonSecond mockAddButtonSecond = new MockAddButtonSecond();
            mockAddButtonSecond.AddDataToDB(this.Name, this.Email, this.Designnation, this.Address, this.City, this.Country);
            this.LoadCITable(this.Name, this.Email, this.Designnation);
        }
    }
}
