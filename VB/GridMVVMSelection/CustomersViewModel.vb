Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace WPFGridMVVMSelection

    Public Class CustomersViewModel
        Inherits ViewModelBase

        Private _DeleteSelectedRowsCommand As DelegateCommand

        Public Sub New()
            DeleteSelectedRowsCommand = New DelegateCommand(AddressOf DeleteSelectedRows, AddressOf CanDeleteSelectedRows)
        End Sub

        Public ReadOnly Property Customers As IList(Of Customer) = CustomersDataModel.GetCustomers()

        Public ReadOnly Property Selection As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer)()

        Public Property DeleteSelectedRowsCommand As DelegateCommand
            Get
                Return _DeleteSelectedRowsCommand
            End Get

            Private Set(ByVal value As DelegateCommand)
                _DeleteSelectedRowsCommand = value
            End Set
        End Property

        Private Sub DeleteSelectedRows()
            Enumerable.ToList(Selection).ForEach(Sub(item) Customers.Remove(item))
        End Sub

        Private Function CanDeleteSelectedRows() As Boolean
            Return Selection.Count > 0
        End Function
    End Class
End Namespace
