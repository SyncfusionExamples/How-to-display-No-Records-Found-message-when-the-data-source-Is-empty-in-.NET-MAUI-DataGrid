using System.Collections.ObjectModel;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
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
    }

}
