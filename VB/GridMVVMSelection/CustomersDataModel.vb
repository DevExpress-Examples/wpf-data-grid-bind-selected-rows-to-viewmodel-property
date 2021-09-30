Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace WPFGridMVVMSelection

    Public Class Customer
        Inherits BindableBase

        Public Property Name As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property City As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property Visits As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property Birthday As Date?
            Get
                Return GetValue(Of Date?)()
            End Get

            Set(ByVal value As Date?)
                SetValue(value)
            End Set
        End Property
    End Class

    Public Class CustomersDataModel

        Public Shared Function GetCustomers() As IList(Of Customer)
            Dim people As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer) From {New Customer() With {.Name = "Gregory S. Price", .City = "Huntington", .Visits = 4, .Birthday = New DateTime(1980, 1, 1)}, New Customer() With {.Name = "Irma R. Marshall", .City = "Hong Kong", .Visits = 2, .Birthday = New DateTime(1966, 4, 15)}, New Customer() With {.Name = "John C. Powell", .City = "Luogosano", .Visits = 6, .Birthday = New DateTime(1982, 3, 11)}, New Customer() With {.Name = "Christian P. Laclair", .City = "Clifton", .Visits = 11, .Birthday = New DateTime(1977, 12, 5)}, New Customer() With {.Name = "Karen J. Kelly", .City = "Madrid", .Visits = 8, .Birthday = New DateTime(1956, 9, 5)}, New Customer() With {.Name = "Brian C. Cowling", .City = "Los Angeles", .Visits = 5, .Birthday = New DateTime(1990, 2, 27)}, New Customer() With {.Name = "Thomas C. Dawson", .City = "Rio de Janeiro", .Visits = 21, .Birthday = New DateTime(1965, 5, 5)}, New Customer() With {.Name = "Angel M. Wilson", .City = "Selent", .Visits = 8, .Birthday = New DateTime(1987, 11, 9)}, New Customer() With {.Name = "Winston C. Smith", .City = "London", .Visits = 1, .Birthday = New DateTime(1949, 6, 18)}, New Customer() With {.Name = "Harold S. Brandes", .City = "Bangkok", .Visits = 3, .Birthday = New DateTime(1989, 1, 8)}, New Customer() With {.Name = "Michael S. Blevins", .City = "Harmstorf", .Visits = 4, .Birthday = New DateTime(1972, 9, 14)}, New Customer() With {.Name = "Jan K. Sisk", .City = "Naples", .Visits = 6, .Birthday = New DateTime(1989, 5, 7)}, New Customer() With {.Name = "Sidney L. Holder", .City = "Watauga", .Visits = 19, .Birthday = New DateTime(1971, 10, 3)}}
            Return people
        End Function
    End Class
End Namespace
