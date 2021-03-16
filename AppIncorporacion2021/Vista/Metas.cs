using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppIncorporacion2021.Config;

namespace AppIncorporacion2021.Vista
{
    public partial class Metas : Form
    {
        ConexionBD cnx = null;
        public Metas()
        {
            InitializeComponent();
        }

        private void gBtnCloseFormMeta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region MetodosTotales
        //Metodo para saber cuantas Tutoras se tiene de la Incorporacion Ciclo Escolar 2019-2020/2020-2021
        private void tutorasBecas()
        {
            // MySqlConnection cnxx = new MySqlConnection();
            try
            {
                cnx = new ConexionBD();
                //cnx.GetConnection();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = cnx.GetConnection();
                comando.CommandText = "SELECT COUNT(FAMILIA_ID) as TOTALTUTORAS FROM nominainco";
                MySqlDataReader mdr = comando.ExecuteReader();
                //se comprueba si hay algun dato dispobible en la base de datos 
                if (mdr.Read() == true)
                {
                    glblTutoras.Text = mdr["TOTALTUTORAS"].ToString();
                }
                else
                {
                    MessageBox.Show("Datos no Encontrados");
                }
            }
            catch (MySqlException ex) { MessageBox.Show(ex.Message); }
        }
        //Metodo para Saber cuantas se le aplico Encuesta de CRIS
        private void tutorasBecasCris()
        {
            // MySqlConnection cnxx = new MySqlConnection();
            try
            {
                cnx = new ConexionBD();
                //cnx.GetConnection();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = cnx.GetConnection();
                comando.CommandText = "SELECT COUNT(FOLIO_ENCUESTA) as TOTALCRIS FROM nominainco WHERE CR_CRIS='SE APLICO LA ENCUESTA'";
                MySqlDataReader mdr = comando.ExecuteReader();
                //se comprueba si hay algun dato dispobible en la base de datos 
                if (mdr.Read() == true)
                {
                    glblEncuestas.Text = mdr["TOTALCRIS"].ToString();
                }
                else
                {
                    MessageBox.Show("Datos no Encontrados");
                }
            }
            catch (MySqlException ex) { MessageBox.Show(ex.Message); }
        }
        //Metodo para saber cuantas se les aplico Notificacion de Incorporacion
        private void tutorasBecasNoti()
        {
            // MySqlConnection cnxx = new MySqlConnection();
            try
            {
                cnx = new ConexionBD();
                //cnx.GetConnection();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = cnx.GetConnection();
                comando.CommandText = "SELECT COUNT(FAMILIA_ID) as TOTALINCO FROM nominainco WHERE CR_NOTIFICACION='ENTREGADO'";
                MySqlDataReader mdr = comando.ExecuteReader();
                //se comprueba si hay algun dato dispobible en la base de datos 
                if (mdr.Read() == true)
                {
                   glblIncorporacion.Text = mdr["TOTALINCO"].ToString();
                }
                else
                {
                    MessageBox.Show("Datos no Encontrados");
                }
            }
            catch (MySqlException ex) { MessageBox.Show(ex.Message); }
        }
        //Metodo para saber cuantas se les Entrego su Aviso de Cobro
        private void tutorasBecasAviso()
        {
            // MySqlConnection cnxx = new MySqlConnection();
            try
            {
                cnx = new ConexionBD();
                //cnx.GetConnection();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = cnx.GetConnection();
                comando.CommandText = "SELECT count(AVISO_COBRO)as TOTALAVISO FROM nominainco where CR_AVISO_COBRO='ENTREGADO'";
                MySqlDataReader mdr = comando.ExecuteReader();
                //se comprueba si hay algun dato dispobible en la base de datos 
                if (mdr.Read() == true)
                {
                   glblAvisosCobro.Text = mdr["TOTALAVISO"].ToString();
                }
                else
                {
                    MessageBox.Show("Datos no Encontrados");
                }
            }
            catch (MySqlException ex) { MessageBox.Show(ex.Message); }
        }
        #endregion


        private void Metas_Load(object sender, EventArgs e)
        {
            tutorasBecas();
            tutorasBecasCris();
            tutorasBecasNoti();
            tutorasBecasAviso();
        }

        private void gGpoIncorporacion_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gBtnDetallesRegion_Click(object sender, EventArgs e)
        {
            cnx = new ConexionBD();
            try
            {
                //cnx.GetConnection(path);
                string sql = "select region as 'REGION ID',nom_reg as 'NOMBRE REGION'," +
                            "case when cr_cris = 'SE APLICO LA ENCUESTA' then count(folio_encuesta) else 0 end as 'SE APLICO LA ENCUESTA'," +
                            " case when cr_cris = 'NADIE EN CASA' then count(folio_encuesta) else 0 end as 'NADIE EN CASA'," +
                            " case when cr_cris = 'NO LOCALIZADAS' then count(folio_encuesta) else 0 end as 'NO LOCALIZADAS'," +
                            " case when cr_cris = 'DEFUNCION DEL UNICO INTEGRANTE' then count(folio_encuesta) else 0 end as 'DEFUNCION DEL UNICO INTEGRANTE'," +
                            " case when cr_cris = 'SE NEGO A DAR INFORMACION' then count(folio_encuesta) else 0 end as 'SE NEGO A DAR INFORMACION'," +
                            " case when cr_cris = 'SIN LOTIFICAR' then count(folio_encuesta) else 0 end as 'SIN LOTIFICAR'" +
                            "from nominainco group by region, nom_reg; ";
                var data = cnx.GetDataTabla(sql);
                gDtgvDetallesRegion.DataSource = data;
                //gdtgvDetallesS3db.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
