using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

/*
 * class used within DBTable to retain information from Database Table when read is contained within DatabaseInfo property in SDatabase
 * Also contains a Dict mapping Columns to strings
 */
namespace SQLiteViewer.Models
{
    public class DBTable
    {
        public string Name { get; set; }
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
