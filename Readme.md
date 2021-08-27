<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653921/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3139)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/GridMVVMSelection/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GridMVVMSelection/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/GridMVVMSelection/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/GridMVVMSelection/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/GridMVVMSelection/ViewModel.cs) (VB: [ViewModel.vb](./VB/GridMVVMSelection/ViewModel.vb))
<!-- default file list end -->
# MVVM - How to bind the GridControl's selected rows to a property in a ViewModel


<p>This example demonstrates how to bind GridControl's selected rows to a property in ViewModel in a MVVM-based application. The SelectionAttachedBehavior helper class used in this sample, provides a bindable SelectedItemsSource property, that can be used to define selection at the ViewModel level.</p>
<p><strong>Note</strong>, we made the SelectionAttachedBehavior class as generic as possible, and the same approach can also be used for other controls that support multiple selection. This example demonstrates how this can be done when working with the standard ListBox control, as well as with the standard DataGrid.</p>

<br/>


