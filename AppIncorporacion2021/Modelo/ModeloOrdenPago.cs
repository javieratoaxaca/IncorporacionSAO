using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

using AppIncorporacion2021.Data;



namespace AppIncorporacion2021.Modelo
{
    class ModeloOrdenPago: Config.ConexionBD
    {
        public bool setOrdenPago(BecarioOrdenPago dtOrdenPago)
        {

            string Query = string.Format("INSERT INTO ordenpago (codResultado,becarioId,folioFormato,folioEncuesta,folioVerificador)" +
                                         "VALUES('{0}',{1},'{2}','{3}','{4}')",
                                         dtOrdenPago.CodResultado,dtOrdenPago.BecarioId,dtOrdenPago.FolioFormato,dtOrdenPago.FolioEncuesta,dtOrdenPago.FolioVerificador);
            try
            {
                int result = ExecuteQuery(Query);
                if (result > 0)
                    return true;
            }
            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return false;
        }
    }
}
