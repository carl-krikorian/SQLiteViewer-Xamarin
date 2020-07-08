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
            DJ.ColumnsAutoWidth = false;
            //ThemeFontAttributes myFont1 = new ThemeFontAttributes("Verdana", 20, FontAttributes.None, Color.Black);
            //ThemeManager.Theme.CellCustomizer.Font = myFont1;
            //DJ.RowHeight = 100;
        }
    }
}