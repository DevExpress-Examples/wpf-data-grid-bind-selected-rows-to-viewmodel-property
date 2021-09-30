using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace WPFGridMVVMSelection {
    public class CustomersViewModel : ViewModelBase {
        public IList<Customer> Customers { get; } = CustomersDataModel.GetCustomers();
        public ObservableCollection<Customer> Selection { get; } = new ObservableCollection<Customer>();
        
        [Command]
        public void DeleteSelectedRows() {
            Selection.ToList().ForEach(item => Customers.Remove(item));
        }
        public bool CanDeleteSelectedRows() {
            return Selection.Count > 0;
        }
    }
}
