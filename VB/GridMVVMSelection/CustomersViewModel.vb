Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace WPFGridMVVMSelection
	Public Class CustomersViewModel
		Inherits ViewModelBase

		Public Sub New()
			DeleteSelectedRowsCommand = New DelegateCommand(AddressOf DeleteSelectedRows, AddressOf CanDeleteSelectedRows)
		End Sub
		Public ReadOnly Property Customers() As IList(Of Customer) = CustomersDataModel.GetCustomers()
		Public ReadOnly Property Selection() As New ObservableCollection(Of Customer)()
		Private privateDeleteSelectedRowsCommand As DelegateCommand
		Public Property DeleteSelectedRowsCommand() As DelegateCommand
			Get
				Return privateDeleteSelectedRowsCommand
			End Get
			Private Set(ByVal value As DelegateCommand)
				privateDeleteSelectedRowsCommand = value
			End Set
		End Property
		Private Sub DeleteSelectedRows()
			Selection.ToList().ForEach(Function(item) Customers.Remove(item))
		End Sub
		Private Function CanDeleteSelectedRows() As Boolean
			Return Selection.Count > 0
		End Function
	End Class
End Namespace
