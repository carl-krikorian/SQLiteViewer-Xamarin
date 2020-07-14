using DevExpress.Core;
using DevExpress.Mobile.DataGrid.Internal;
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
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;

namespace SQLiteViewer.ViewModels
{
    public class SQLiteViewerViewModel : INotifyPropertyChanged
    {
        //Keep the "please enter sql query above" because populating the datagrid at the begining makes it faster to load your first table 
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
                if (dt != value)
                {
                    dt = new DataTable();
                    dt = value;
                    OnPropertyChanged(nameof(DisplayDT));
                }
            }
        }
        public string EntryString { get; set; }
        public ICommand ExecuteInputCommand { get; }
        public bool isRefreshing { get; set; }
        public void DBExecuteInput() 
        {
            App.Database.ExecuteInput(EntryString);
            DisplayDT = new DataTable();
            DisplayDT = App.Database.SelectDataTable;
            Debug.WriteLine("end of command");
        }
        /*private bool busy = false;
        public bool IsBusy
        {
            get { return busy; }
            set
            {
                if (busy == value)
                    return;

                busy = value;
                OnPropertyChanged("IsBusy");
            }
        }*/
    }
}
