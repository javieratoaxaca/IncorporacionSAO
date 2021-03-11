using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace AppIncorporacion2021.Modelo
{
    class ModeloBecarios:Config.ConexionSQLite
    {
        public ModeloBecarios() {}


        //Metodo para cargar los datos del S3db en el DatagridView

        //public void CargarGrid(DataGridView grid)
        //{

        //    try
        //    {

        //        string query = string.Format("SELECT * FROM BECARIOS  ");//creamos la consulta a la base 
        //        //creamos el cmd para que se lleve el query y cargue la conexion con la DB
        //       SQLiteCommand cmd = new SQLiteCommand(query, GetConnection());

        //        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        grid.DataSource = dt;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }


        //}
    }
    
}
