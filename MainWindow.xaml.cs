using System;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows;
using System.Windows.Controls;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = this.DataContext as ViewModel;
            this.sfDataGrid.SearchHelper = new SearchHelperExt(this.sfDataGrid);
            btnFind.Click += BtnFind_Click;
        }

        private void BtnFind_Click(object sender, RoutedEventArgs e)
        {
            this.sfDataGrid.SearchHelper.ClearSearch();
            this.sfDataGrid.SearchHelper.FindNext(txtSearch.Text);
            this.sfDataGrid.SearchHelper = new SearchHelperExt(this.sfDataGrid);            
        }
    }

    public class SearchHelperExt : SearchHelper
    {
        public SearchHelperExt(SfDataGrid datagrid)
            : base(datagrid)
        {
           
        }

        protected override bool MatchSearchText(GridColumn column, object record)
        {        

                var cellvalue = Provider.GetFormattedValue(record, column.MappingName);
           
                if (!AllowCaseSensitiveSearch)
                    return cellvalue != null && cellvalue.ToString().ToLower().Equals(SearchText.ToString().ToLower());
                else
                    return cellvalue != null && cellvalue.ToString().Equals(SearchText.ToString());           
        }        
    }
}
         
   

