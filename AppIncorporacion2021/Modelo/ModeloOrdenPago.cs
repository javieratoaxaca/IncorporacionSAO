﻿using System;
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
        private string _addSQL;
        public string AddSQL {
            get
            {
                return _addSQL;
            }
            set
            {
                _addSQL = value;

            }
        }
        public void setOrdenPago2(BecarioOrdenPago dtOrdenPago)
        {
            AddSQL += string.Format("INSERT INTO ordenpago (codResultado,becarioId,folioFormato,folioEncuesta,folioVerificador)" +
                                         "VALUES('{0}',{1},'{2}','{3}','{4}'); ",
                                         dtOrdenPago.CodResultado, dtOrdenPago.BecarioId, dtOrdenPago.FolioFormato, dtOrdenPago.FolioEncuesta, dtOrdenPago.FolioVerificador);
        }
        public bool Procesar()
        {
            try
            {
                int result = ExecuteQuery(AddSQL);
                if (result > 0)
                    return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return false;
        }
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
