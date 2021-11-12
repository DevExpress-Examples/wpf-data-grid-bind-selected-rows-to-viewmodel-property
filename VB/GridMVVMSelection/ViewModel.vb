Imports System.Collections.ObjectModel
Imports System.Windows.Input
Imports DevExpress.Utils.Commands
Imports DevExpress.Xpf.Core.Commands
Imports System.Linq
Imports DevExpress.Xpf.Core
Imports System.Collections.Specialized

Namespace Model

    Public Class ViewModel

        Private _SelectOddRowsCommand As ICommand, _DeleteSelectedRowsCommand As DelegateCommand(Of Object)

        Private ReadOnly sourceField As ObservableCollection(Of DataItem) = DataItem.GetData()

        Private ReadOnly selectionField As ObservableCollection(Of DataItem) = New ObservableCollection(Of DataItem)()

        Public ReadOnly Property Source As ObservableCollection(Of DataItem)
            Get
                Return sourceField
            End Get
        End Property

        Public ReadOnly Property Selection As ObservableCollection(Of DataItem)
            Get
                Return selectionField
            End Get
        End Property

        Public Property SelectOddRowsCommand As ICommand
            Get
                Return _SelectOddRowsCommand
            End Get

            Private Set(ByVal value As ICommand)
                _SelectOddRowsCommand = value
            End Set
        End Property

        Public Property DeleteSelectedRowsCommand As DelegateCommand(Of Object)
            Get
                Return _DeleteSelectedRowsCommand
            End Get

            Private Set(ByVal value As DelegateCommand(Of Object))
                _DeleteSelectedRowsCommand = value
            End Set
        End Property

        Public Sub New()
            AddHandler Selection.CollectionChanged, AddressOf Selection_CollectionChanged
            SelectOddRowsCommand = New DelegateCommand(Of Object)(AddressOf SelectOddRows)
            DeleteSelectedRowsCommand = New DelegateCommand(Of Object)(AddressOf DeleteSelectedRows, AddressOf CanDeleteSelectedRows)
        End Sub

        Private Sub Selection_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            DeleteSelectedRowsCommand.RaiseCanExecuteChanged()
        End Sub

        Private Sub SelectOddRows(ByVal obj As Object)
            Selection.Clear()
            For i As Integer = 0 To Source.Count - 1 Step 2
                Selection.Add(Source(i))
            Next
        End Sub

        Private Sub DeleteSelectedRows(ByVal obj As Object)
            Enumerable.ToList(Selection).ForEach(Sub(item) Source.Remove(item))
        End Sub

        Private Function CanDeleteSelectedRows(ByVal obj As Object) As Boolean
            Return Selection.Count > 0
        End Function
    End Class

    Public Class DataItem

        Public Shared Function GetData(ByVal Optional count As Integer = 100) As ObservableCollection(Of DataItem)
            Dim result As ObservableCollection(Of DataItem) = New ObservableCollection(Of DataItem)()
            For i As Integer = 0 To count - 1
                result.Add(New DataItem(i, "Name" & i, Date.Now.AddDays(i)))
            Next

            Return result
        End Function

        Public Property Id As Integer

        Public Property Name As String

        Public Property Date_Time As Date

        Public Sub New()
        End Sub

        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal [date] As Date)
            Me.Id = id
            Me.Name = name
            Date_Time = [date]
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Namespace
