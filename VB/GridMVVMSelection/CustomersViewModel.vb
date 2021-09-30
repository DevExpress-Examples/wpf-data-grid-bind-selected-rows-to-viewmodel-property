Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace WPFGridMVVMSelection

    Public Class CustomersViewModel
        Inherits ViewModelBase

        Public ReadOnly Property Customers As IList(Of Customer) = CustomersDataModel.GetCustomers()

        Public ReadOnly Property Selection As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer)()

        <Command>
        Public Sub DeleteSelectedRows()
            Enumerable.ToList(Selection).ForEach(Sub(item) Customers.Remove(item))
        End Sub

        Public Function CanDeleteSelectedRows() As Boolean
            Return Selection.Count > 0
        End Function
    End Class
End Namespace
