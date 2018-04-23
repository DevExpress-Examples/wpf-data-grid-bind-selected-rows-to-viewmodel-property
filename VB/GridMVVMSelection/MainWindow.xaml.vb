Imports System.Windows
Imports Model

Namespace WPFGridMVVMSelection
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            DataContext = New ViewModel()
        End Sub

    End Class
End Namespace
