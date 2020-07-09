using DevExpress.Core;
using DevExpress.Mvvm.Native;
using SQLiteViewer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SQLiteViewer.ViewModels
{
    public class SQLiteViewerViewModel : INotifyPropertyChanged
    {
                public SQLiteViewerViewModel()
        {
            ExecuteInputCommand = new Command(DBExecuteInput);
            DisplayDT = new DataTable();
            DataColumn dc = new DataColumn("Please Enter an", typeof(String));
            DisplayDT.Columns.Add(dc);
            DataRow dr = DisplayDT.NewRow();
            dr[0] = "SQL Querie above";
            DisplayDT.Rows.Add(dr);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public DataTable dt;
        public DataTable DisplayDT
        {
            get { return dt; }
            set
            {
                if(dt != value)
                {
                    dt = value;
                    OnPropertyChanged(nameof(DisplayDT));
                }
            }
        }
        public string EntryString { get; set; }
        public ICommand ExecuteInputCommand { get; }
        public bool isRefreshing { get; set; }
        public void DBExecuteInput() {
            Debug.WriteLine("Command pressed");
            App.Database.ExecuteInput(EntryString);

            DisplayDT = new DataTable();
            DisplayDT = App.Database.SelectDataTable;
        }
    }
}
