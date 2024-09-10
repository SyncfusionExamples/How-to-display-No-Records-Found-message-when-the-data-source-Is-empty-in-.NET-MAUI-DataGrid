# How to display No Records found message when the data source is empty in .NET MAUI DataGrid
In this article, we will show you how to display No Records found message when the data source is empty in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<StackLayout>
    <HorizontalStackLayout Margin="10">
        <Button Text="clear ItemSource" WidthRequest="200"
                Clicked="Button_Clicked" />
        <Button Text="Add ItemSource" WidthRequest="200"
                Clicked="Button_Clicked_1" />
    </HorizontalStackLayout>
    <Label Margin="50,200,50,100" x:Name="label"
           FontSize="Large"
           Text="No Records are Found :("
           HorizontalOptions="Center"
           VerticalOptions="End" />
    
    <syncfusion:SfDataGrid x:Name="sfGrid" VerticalOptions="FillAndExpand" HorizontalOptions="FillAndExpand" Margin="10"
                           GridLinesVisibility="Both"
                           HeaderGridLinesVisibility="Both"
                           ColumnWidthMode="Auto"
                           AutoGenerateColumnsMode="None"
                           ItemsSource="{Binding Employees}">

        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                              HeaderText="Employee ID" />
            <syncfusion:DataGridTextColumn MappingName="Name" HeaderText="Employee Name" />
            <syncfusion:DataGridTextColumn MappingName="Title" HeaderText="Designation" />
            <syncfusion:DataGridDateColumn MappingName="HireDate" HeaderText="Hire Date"/>
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>

</StackLayout>
```

## C#
The below code toggles the visibility of a Syncfusion SfDataGrid and a label based on whether the grid's data source is null or empty, with buttons to clear or repopulate the DataGrid.
```
 public MainPage()
 {
     InitializeComponent();
     sfGrid.ItemsSourceChanged += SfGrid_ItemsSourceChanged;
 }

 private void SfGrid_ItemsSourceChanged(object? sender, Syncfusion.Maui.DataGrid.DataGridItemsSourceChangedEventArgs e)
 {
     if (e.NewView == null || (e.NewView is ObservableCollection<Employee> employees && employees.Count == 0))
     {
         sfGrid.IsVisible = false;
         label.IsVisible = true;
     }
     else
     {
         // Otherwise, show the grid and hide the label
         sfGrid.IsVisible = true;
         label.IsVisible = false;
     }
 }

 private void Button_Clicked(object sender, EventArgs e)
 {
     sfGrid.ItemsSource = null;
 }

 private void Button_Clicked_1(object sender, EventArgs e)
 {
     sfGrid.ItemsSource = viewModel.Employees;
 }
```
 ![NoRecordDemo.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI5MzMyIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.86Ozn9CeBckwibpOYD8D6ZIpxPMMfrDgB_lhI-weav8)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-display-No-Records-Found-message-when-the-data-source-Is-empty-in-.NET-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to display No Records found message when the data source is empty in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!