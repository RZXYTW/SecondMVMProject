using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp38.Models;
using WpfApp38.Services;

namespace WpfApp38.ViewModels
{
    class MainWindowViewModel : NotificationObject
    {
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand SearchCommand { get; set; }
        public DelegateCommand<ContactInformationModel> DeleteCommand { get; set; }
        public DelegateCommand<ContactInformationModel> EditCommand { get; set; }

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

        public MainWindowViewModel()
        {
            this.LoadCITable();
            this.AddCommand = new DelegateCommand(new Action(this.AddCommandExecute));
            this.SearchCommand = new DelegateCommand(new Action(this.SearchCommandExecute));
            this.DeleteCommand = new DelegateCommand<ContactInformationModel>(new Action<ContactInformationModel>(this.DeleteCommandExecute));
            this.EditCommand = new DelegateCommand<ContactInformationModel>(new Action<ContactInformationModel>(this.EditCommandExecute));
        }

        public void LoadCITable()
        {
            DBDataService dBDataService = new DBDataService();

            this.ListCITable = dBDataService.GetContactInformation();
        }
        private void SearchCommandExecute()
        {
            this.LoadCITable();
            ISearchButtonService searchService = new MockSearchButtonService();
            List<ContactInformationModel> listSearchCITable = searchService.SearchContactInformation(this.Name, this.Email, this.Designnation, this.ListCITable);
            this.ListCITable = listSearchCITable;
        }
        private void AddCommandExecute()
        {
            IAddButtonFirstService addFirstService = new MockAddButtonService();           
            addFirstService.OpenAddOrEditForm(this.Name, this.Email, this.Designnation);
        }
        private void DeleteCommandExecute(ContactInformationModel selectItem)
        {
            
            IDeleteButtonService deleteButtonService = new MockDeleteButtonService();
            deleteButtonService.DeleteButtonClicked(selectItem);
            this.LoadCITable();
        }
        private void EditCommandExecute(ContactInformationModel selectItem)
        {
            //this.LoadCITable();
            IEditButtonService editButtonService = new MockEditButtonService();
            editButtonService.OpenAddOrEditForm(selectItem);
        }
    }
}
