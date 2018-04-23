using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DevExpress.Utils.Commands;
using DevExpress.Xpf.Core.Commands;
using System.Collections;
using System.Linq;
using DevExpress.Xpf.Core;
using System.Collections.Specialized;

namespace Model {
    public class ViewModel {
        private readonly ObservableCollection<DataItem> source = DataItem.GetData();
        private readonly ObservableCollection<DataItem> selection = new ObservableCollection<DataItem>();
        public ObservableCollection<DataItem> Source { get { return this.source; } }
        public ObservableCollection<DataItem> Selection { get { return this.selection; } }
        public ICommand SelectOddRowsCommand { get; private set; }
        public DelegateCommand<object> DeleteSelectedRowsCommand { get; private set; }
        public ViewModel() {
            Selection.CollectionChanged += Selection_CollectionChanged;

            SelectOddRowsCommand = new DelegateCommand<object>(SelectOddRows);
            DeleteSelectedRowsCommand = new DelegateCommand<object>(DeleteSelectedRows, CanDeleteSelectedRows);
        }
        void Selection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            DeleteSelectedRowsCommand.RaiseCanExecuteChanged();
        }
        private void SelectOddRows(object obj) {
            Selection.Clear();
            for(int i = 0; i < Source.Count; i += 2)
                Selection.Add(Source[i]);
        }
        private void DeleteSelectedRows(object obj) {
            Selection.ToList().ForEach(item => Source.Remove(item));
        }
        private bool CanDeleteSelectedRows(object obj) {
            return Selection.Count > 0;
        }
    }

    public class DataItem {
        public static ObservableCollection<DataItem> GetData(int count = 100) {
            ObservableCollection<DataItem> result = new ObservableCollection<DataItem>();
            for(int i = 0; i < count; i++)
                result.Add(new DataItem(i, "Name" + i, DateTime.Now.AddDays(i)));
            return result;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Time { get; set; }
        public DataItem() { }
        public DataItem(int id, string name, DateTime date) {
            Id = id;
            Name = name;
            Date_Time = date;
        }
        public override string ToString() {
            return Name;
        }
    }
}
