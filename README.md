# How to implement Equals Search type in SearchController in WPF DataGrid(SfDataGrid)?

## About the sample

This example illustrates how to implement Equals Search type in SearchController in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

[WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) does not provide the support for [SearchType](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.SearchHelper~SearchType.html) property as Equals in [SearchHelper](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.SearchHelper.html). You can achieve this by override the [MatchSearchText](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.SearchHelper~MatchSearchText.html) method in [SfDataGrid.SearchHelper](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.SearchHelper.html). 

```C#
btnFind.Click += BtnFind_Click;

private void BtnFind_Click(object sender, RoutedEventArgs e)
{
    this.sfDataGrid.SearchHelper.ClearSearch();
    this.sfDataGrid.SearchHelper.FindNext(txtSearch.Text);
    this.sfDataGrid.SearchHelper = new SearchHelperExt(this.sfDataGrid);            
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
```

KB article - [How to implement Equals Search type in SearchController in WPF DataGrid(SfDataGrid)?](https://www.syncfusion.com/kb/11756/how-to-implement-equals-search-type-in-searchcontroller-in-wpf-datagrid-sfdatagrid)

## Requirements to run the demo
Visual Studio 2015 and above versions
