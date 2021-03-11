using System;
using AppIncorporacion2021.Config;
using System.Windows.Forms;


namespace AppIncorporacion2021
{
    public partial class CargarDB : Form
    {

        //Modelo.ModeloBecarios smBecarios;
        ConexionSQLite cnx;

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
            cargarDB();
            cnx.GetConnection(gTxtDitectorio.Text);
        }

        private void gBtnBuscarDB_Click(object sender, EventArgs e)
        {
            //smBecarios.CargarGrid(gdtgvDetallesS3db);
        }
        private void cargarDB()
        {
            gTxtFiltro.Text = "*.S3DB";
            OpenFileDialog fBrowDialog = new OpenFileDialog();

            if (fBrowDialog.ShowDialog() == DialogResult.OK)
                this.gTxtDitectorio.Text = fBrowDialog.FileName;
            else
                gTxtDitectorio.Text = "";

            //if (this.gTxtDitectorio.Text != "")
            //{
            //    MessageBox.Show("" + cnx.GetConnection(gTxtDitectorio.Text));
            //}
            //else
            //    MessageBox.Show("Seleccione un Directorio");
        }
    }
}
