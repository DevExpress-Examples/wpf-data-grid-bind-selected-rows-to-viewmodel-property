Imports System
Imports System.Collections.ObjectModel
Imports System.Windows.Input
Imports DevExpress.Utils.Commands
Imports DevExpress.Xpf.Core.Commands
Imports System.Collections
Imports System.Linq
Imports DevExpress.Xpf.Core
Imports System.Collections.Specialized

Namespace Model
    Public Class ViewModel

        Private ReadOnly source_Renamed As ObservableCollection(Of DataItem) = DataItem.GetData()

        Private ReadOnly selection_Renamed As New ObservableCollection(Of DataItem)()
        Public ReadOnly Property Source() As ObservableCollection(Of DataItem)
            Get
                Return Me.source_Renamed
            End Get
        End Property
        Public ReadOnly Property Selection() As ObservableCollection(Of DataItem)
            Get
                Return Me.selection_Renamed
            End Get
        End Property
        Private privateSelectOddRowsCommand As ICommand
        Public Property SelectOddRowsCommand() As ICommand
            Get
                Return privateSelectOddRowsCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateSelectOddRowsCommand = value
            End Set
        End Property
        Private privateDeleteSelectedRowsCommand As DelegateCommand(Of Object)
        Public Property DeleteSelectedRowsCommand() As DelegateCommand(Of Object)
            Get
                Return privateDeleteSelectedRowsCommand
            End Get
            Private Set(ByVal value As DelegateCommand(Of Object))
                privateDeleteSelectedRowsCommand = value
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
            Next i
        End Sub
        Private Sub DeleteSelectedRows(ByVal obj As Object)
            Selection.ToList().ForEach(Function(item) Source.Remove(item))
        End Sub
        Private Function CanDeleteSelectedRows(ByVal obj As Object) As Boolean
            Return Selection.Count > 0
        End Function
    End Class

    Public Class DataItem
        Public Shared Function GetData(Optional ByVal count As Integer = 100) As ObservableCollection(Of DataItem)
            Dim result As New ObservableCollection(Of DataItem)()
            For i As Integer = 0 To count - 1
                result.Add(New DataItem(i, "Name" & i, Date.Now.AddDays(i)))
            Next i
            Return result
        End Function
        Public Property Id() As Integer
        Public Property Name() As String
        Public Property Date_Time() As Date
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
