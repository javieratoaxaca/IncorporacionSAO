using System;

using System.Data.SQLite;


namespace AppIncorporacion2021.Config
{
    class ConexionSQLite
    {
        string cad_sqlite;
        SQLiteConnection sqlitecnn;
           public ConexionSQLite()
        {
            
            
        }
        public SQLiteConnection GetConnection(string ruta )
        {
            cad_sqlite = @"Data Source = "+ruta;
            try
            {
                   sqlitecnn = new SQLiteConnection(cad_sqlite);
                sqlitecnn.Open();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Error: Al conectarse a la Base de datos." + ex.Message);
            }
            

            return sqlitecnn;
        }

       
    }
}
