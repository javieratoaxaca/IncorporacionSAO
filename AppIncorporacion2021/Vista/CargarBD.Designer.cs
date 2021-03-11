namespace AppIncorporacion2021
{
    partial class CargarDB
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gBtnCloseForm = new Guna.UI.WinForms.GunaButton();
            this.gbtnBuscarDB = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtBuscarDB = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gdtgvDetalles = new Guna.UI.WinForms.GunaDataGridView();
            this.panel3.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdtgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.gBtnCloseForm);
            this.panel3.Controls.Add(this.gbtnBuscarDB);
            this.panel3.Controls.Add(this.gunaLabel2);
            this.panel3.Controls.Add(this.gTxtBuscarDB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 82);
            this.panel3.TabIndex = 2;
            // 
            // gBtnCloseForm
            // 
            this.gBtnCloseForm.AnimationHoverSpeed = 0.07F;
            this.gBtnCloseForm.AnimationSpeed = 0.03F;
            this.gBtnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.gBtnCloseForm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnCloseForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnCloseForm.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnCloseForm.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnCloseForm.Image = global::AppIncorporacion2021.Properties.Resources.icons8_cancel_64px;
            this.gBtnCloseForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnCloseForm.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnCloseForm.Location = new System.Drawing.Point(1, 3);
            this.gBtnCloseForm.Name = "gBtnCloseForm";
            this.gBtnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnCloseForm.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnCloseForm.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnCloseForm.OnHoverImage = null;
            this.gBtnCloseForm.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnCloseForm.Radius = 20;
            this.gBtnCloseForm.Size = new System.Drawing.Size(37, 32);
            this.gBtnCloseForm.TabIndex = 11;
            // 
            // gbtnBuscarDB
            // 
            this.gbtnBuscarDB.AnimationHoverSpeed = 0.07F;
            this.gbtnBuscarDB.AnimationSpeed = 0.03F;
            this.gbtnBuscarDB.BackColor = System.Drawing.Color.Transparent;
            this.gbtnBuscarDB.BaseColor = System.Drawing.Color.White;
            this.gbtnBuscarDB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnBuscarDB.BorderSize = 2;
            this.gbtnBuscarDB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnBuscarDB.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnBuscarDB.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnBuscarDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBuscarDB.Image = global::AppIncorporacion2021.Properties.Resources.icons8_google_web_search_60px;
            this.gbtnBuscarDB.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnBuscarDB.Location = new System.Drawing.Point(827, 21);
            this.gbtnBuscarDB.Name = "gbtnBuscarDB";
            this.gbtnBuscarDB.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnBuscarDB.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBuscarDB.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnBuscarDB.OnHoverImage = null;
            this.gbtnBuscarDB.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnBuscarDB.Radius = 10;
            this.gbtnBuscarDB.Size = new System.Drawing.Size(159, 46);
            this.gbtnBuscarDB.TabIndex = 6;
            this.gbtnBuscarDB.Text = "Buscar";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel2.Location = new System.Drawing.Point(118, 33);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 23);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Buscar :";
            // 
            // gTxtBuscarDB
            // 
            this.gTxtBuscarDB.BackColor = System.Drawing.Color.Transparent;
            this.gTxtBuscarDB.BaseColor = System.Drawing.Color.White;
            this.gTxtBuscarDB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtBuscarDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtBuscarDB.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtBuscarDB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtBuscarDB.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscarDB.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtBuscarDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscarDB.Location = new System.Drawing.Point(237, 21);
            this.gTxtBuscarDB.Name = "gTxtBuscarDB";
            this.gTxtBuscarDB.PasswordChar = '\0';
            this.gTxtBuscarDB.Radius = 15;
            this.gTxtBuscarDB.SelectedText = "";
            this.gTxtBuscarDB.Size = new System.Drawing.Size(573, 46);
            this.gTxtBuscarDB.TabIndex = 0;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.gdtgvDetalles);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 82);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1003, 525);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // gdtgvDetalles
            // 
            this.gdtgvDetalles.AllowUserToAddRows = false;
            this.gdtgvDetalles.AllowUserToDeleteRows = false;
            this.gdtgvDetalles.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdtgvDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdtgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdtgvDetalles.BackgroundColor = System.Drawing.Color.Black;
            this.gdtgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdtgvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gdtgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdtgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdtgvDetalles.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdtgvDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdtgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdtgvDetalles.EnableHeadersVisualStyles = false;
            this.gdtgvDetalles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.gdtgvDetalles.Name = "gdtgvDetalles";
            this.gdtgvDetalles.ReadOnly = true;
            this.gdtgvDetalles.RowHeadersVisible = false;
            this.gdtgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdtgvDetalles.Size = new System.Drawing.Size(1003, 525);
            this.gdtgvDetalles.TabIndex = 0;
            this.gdtgvDetalles.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdtgvDetalles.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.gdtgvDetalles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.Height = 45;
            this.gdtgvDetalles.ThemeStyle.ReadOnly = true;
            this.gdtgvDetalles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gdtgvDetalles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.Height = 22;
            this.gdtgvDetalles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            // 
            // CargarDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 607);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CargarDB";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdtgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton gbtnBuscarDB;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox gTxtBuscarDB;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaDataGridView gdtgvDetalles;
        private Guna.UI.WinForms.GunaButton gBtnCloseForm;
    }
}

