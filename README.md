# SQLiteViewer-Xamarin
This is an SQLiteViewer for Xamarin. Version 1.0.2
Should you want to try your own SQLite database in your phone instead of creating one, you can change the path in the SDatabase constructor by renaming dbPath in the constructor.
By entering an sqlQuery into the editor and submiting it using the submit button you can manipulate your SQLite Database. 
Note that all the SQLite Queries supported are that of Microsoft.Data.SQLite. 
All of the Queries work for example, you can create a table and use it within the applicatin. 
However, alert messages describing the number of rows affected will only be displayed if your query starts with UPDATE, INSERT and DELETE. For example:
-UPDATE TableName SET FieldName WHERE CONDITION
-DELETE FROM TableName SET FieldName = value WHERE CONDITION
-INSERT INTO TableName (Fields) VALUES (Field values)
Should there otherwise be an error in your Query, a display message displaying the error or exception will appear
