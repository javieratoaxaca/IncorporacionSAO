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
        private void tutorasBecas()
        {
            cnx = new ConexionBD();
            try
            {
               
                
                string sql ="SELECT COUNT(FAMILIA_ID) FROM nominainco WHERE CR_CRIS='SE APLICO LA ENCUESTA'";
                glblEncuestas.Text = Convert.ToString(cnx.ExecuteQuery(sql)); 
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Metas_Load(object sender, EventArgs e)
        {
           tutorasBecas();
        }
    }
}
