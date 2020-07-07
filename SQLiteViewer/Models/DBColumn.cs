using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteViewer.Models
{
    public class DBColumn
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public bool isPrimaryKey { get; set; }
        public bool isAliased { get; set; }
        public bool isNotNull { get; set; }
        public bool isAutoIncrement { get; set; }
        public bool isUnique { get; set; }
        public DBColumn(string columnName)
        {
            ColumnName = columnName;
            isPrimaryKey = false;
            isAliased = false;
            isNotNull = false;
            isAutoIncrement = false;
            isUnique = false;

        }
    }
}
