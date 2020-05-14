using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace WPFGridMVVMSelection {
    public class CustomersViewModel : ViewModelBase {
        public CustomersViewModel() {
            DeleteSelectedRowsCommand = new DelegateCommand(DeleteSelectedRows, CanDeleteSelectedRows);
        }
        public IList<Customer> Customers { get; } = CustomersDataModel.GetCustomers();
        public ObservableCollection<Customer> Selection { get; } = new ObservableCollection<Customer>();
        public DelegateCommand DeleteSelectedRowsCommand { get; private set; }
        void DeleteSelectedRows() {
            Selection.ToList().ForEach(item => Customers.Remove(item));
        }
        bool CanDeleteSelectedRows() {
            return Selection.Count > 0;
        }
    }
}
