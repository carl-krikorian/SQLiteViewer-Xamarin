using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DevExpress.Mobile.DataGrid;
using SQLiteViewer.Models;
using System.Collections.ObjectModel;
using System.Data;
using DevExpress.Mobile.DataGrid.Theme;
using DevExpress.XtraExport.Helpers;

namespace SQLiteViewer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamerinFormsDataGridView : ContentPage
    {
        public XamerinFormsDataGridView()
        {
            DJ = new GridControl();
            InitializeComponent();
            ThemeManager.ThemeName = Themes.Light;
            //ThemeFontAttributes myFont1 = new ThemeFontAttributes("Verdana", 20, FontAttributes.None, Color.Black);
            //ThemeManager.Theme.CellCustomizer.Font = myFont1;
            //DJ.RowHeight = 100;
            DJ.ColumnsAutoWidth = false;
            ObservableCollection<Item> items = new ObservableCollection<Item>();
            for (int i = 0; i < 100; i++)
                items.Add(new Item { Id = i.ToString(), Text = "First item", Description = "This is an item description." });
            DataTable d = new DataTable();
            DJ.ItemsSource = items;

        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            App.Database.ExecuteInput(InputEntry.Text);
            DJ.ItemsSource = App.Database.SelectDataTable;
        }
    }
}