using DevExpress.Core;
using SQLiteViewer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SQLiteViewer.ViewModels
{
    public class SQLiteViewerViewModel
    {
        public ObservableCollection<Item> items { get; set; }
        public SQLiteViewerViewModel()
        {
            /*items = new ObservableCollection<Item>();
            for (int i = 0; i < 100; i++)
               items.Add(new Item { Id = i.ToString(), Text = "First item", Description = "This is an item description." });*/
        }
        public string EntryString { get; set; }
        public ICommand ExecuteInputCommand { get; }
        public bool isRefreshing { get; set; }
        public void DBExecuteInput() { }
    }
}
