using System;
using AppIncorporacion2021.Config;
using System.Windows.Forms;


namespace AppIncorporacion2021
{
    public partial class CargarDB : Form
    {

        //Modelo.ModeloBecarios smBecarios;
        ConexionSQLite cnx=null;

        public CargarDB()
        {
            InitializeComponent();
          //  smBecarios = new Modelo.ModeloBecarios();
        }

        private void gBtnCloseFormDB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Sirvara para obtener el tipo de base de datos a cargar
        private void gBtnExaminar_Click(object sender, EventArgs e)
        {
            //gTxtFiltro.Text = "*.S3DB";
            OpenFileDialog fBrowDialog = new OpenFileDialog();

            string path = fBrowDialog.ShowDialog() == DialogResult.OK ? fBrowDialog.FileName : "";
            gTxtDitectorio.Text = path;
            cnx = new ConexionSQLite();
            try
            {
                cnx.GetConnection(path);
                string sql = "select * from becarios";
                var data=cnx.GetData(sql);
                gdtgvDetallesS3db.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            //MessageBox.Show("" + cnx.GetConnection(gTxtDitectorio.Text));
        }

        private void gBtnBuscarDB_Click(object sender, EventArgs e)
        {
            //smBecarios.CargarGrid(gdtgvDetallesS3db);
        }
        private void cargarDB()
        {
            


            //if (this.gTxtDitectorio.Text != "")
            //{
            //    MessageBox.Show("" + cnx.GetConnection(gTxtDitectorio.Text));
            //}
            //else
            //    MessageBox.Show("Seleccione un Directorio");
        }
    }
}
