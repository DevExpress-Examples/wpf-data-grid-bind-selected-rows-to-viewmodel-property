<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653921/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3139)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Bind Selected Rows to a ViewModel Property

This example shows how to synchronize the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)‘s selection with an item collection in a ViewModel. The example:

1) Binds the GridControl‘s [SelectedItems](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.SelectedItems) property to the **Selection** collection defined in a ViewModel.
2) Adds a button that deletes the selected rows.

![](https://docs.devexpress.com/WPF/images/WPF_Grid_BindToSelected.png)

<!-- default file list -->

## Files to Look At

* [MainWindow.xaml](./CS/GridMVVMSelection/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GridMVVMSelection/MainWindow.xaml))
* [CustomersViewModel.cs](./CS/GridMVVMSelection/CustomersViewModel.cs) (VB: [CustomersViewModel.vb](./VB/GridMVVMSelection/CustomersViewModel.vb))
* [CustomersDataModel.cs](./CS/GridMVVMSelection/CustomersDataModel.cs) (VB: [CustomersDataModel.vb](./VB/GridMVVMSelection/CustomersDataModel.vb))

<!-- default file list end -->

## Documentation

- [Binding to a Collection of Selected Items](https://docs.devexpress.com/WPF/10125/controls-and-libraries/data-grid/examples/mvvm-enhancements/binding-to-a-collection-of-selected-items)
- [DataControlBase.SelectedItems](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.SelectedItems)
- [Multiple Row Selection](https://docs.devexpress.com/WPF/7359/controls-and-libraries/data-grid/focus-navigation-selection/multiple-row-selection)
- [Focus, Navigation, Selection](https://docs.devexpress.com/WPF/6118/controls-and-libraries/data-grid/focus-navigation-selection)
- [WPF Data Grid: MVVM Support](https://docs.devexpress.com/WPF/10122/controls-and-libraries/data-grid/mvvm-support)

## More Examples

- [WPF Data Grid - Handle Row Double-clicks in a MVVM Application](https://github.com/DevExpress-Examples/how-to-handle-a-double-click-on-a-grid-row-in-a-mvvm-application-e2458)
- [How to Bind the ChartControl to the GridControl's VisibleItems Collection](https://github.com/DevExpress-Examples/how-to-bind-the-chartcontrol-to-the-gridcontrol-visibleitems-collection)
- [WPF Data Grid - How to Change the Appearance of Selected Cells](https://github.com/DevExpress-Examples/how-to-change-selected-cells-appearance-when-gridcontrols-multi-cell-selection-is-enabled-e2568)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-bind-selected-rows-to-viewmodel-property&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-bind-selected-rows-to-viewmodel-property&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
