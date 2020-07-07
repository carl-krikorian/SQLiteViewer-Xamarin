using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SQLiteViewer.Models
{
    public class DBTable
    {
        public string Name { get; set; }
        //public ObservableCollection<DBColumn> Columns { get; set; }
        public Dictionary<string, DBColumn> Columns;
        public DBTable()
        {
            Columns = new Dictionary<string, DBColumn>();
        }
        public DBTable(string name)
        {
            Name = name;
            Columns = new Dictionary<string, DBColumn>();
        }
    }
}
