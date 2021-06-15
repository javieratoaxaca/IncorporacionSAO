﻿namespace AppIncorporacion2021.Vista
{
    partial class OrdenPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenPago));
            this.panel3 = new System.Windows.Forms.Panel();
            this.gBtnImportarBD = new Guna.UI.WinForms.GunaButton();
            this.gBtnExcel = new Guna.UI.WinForms.GunaButton();
            this.gBtnLimpiarCajas = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtDirectorio = new Guna.UI.WinForms.GunaTextBox();
            this.gBtnCloseForm = new Guna.UI.WinForms.GunaButton();
            this.gbtnDirectorio = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtFiltro = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.dtgvArchivos = new System.Windows.Forms.DataGridView();
            this.rTxtboxMostrarArchivos = new System.Windows.Forms.RichTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblTotalArchivos = new Guna.UI.WinForms.GunaLabel();
            this.ltbArchivos = new System.Windows.Forms.ListBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel3.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.gBtnImportarBD);
            this.panel3.Controls.Add(this.gBtnExcel);
            this.panel3.Controls.Add(this.gBtnLimpiarCajas);
            this.panel3.Controls.Add(this.gunaLabel1);
            this.panel3.Controls.Add(this.gTxtDirectorio);
            this.panel3.Controls.Add(this.gBtnCloseForm);
            this.panel3.Controls.Add(this.gbtnDirectorio);
            this.panel3.Controls.Add(this.gunaLabel2);
            this.panel3.Controls.Add(this.gTxtFiltro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1930, 249);
            this.panel3.TabIndex = 4;
            // 
            // gBtnImportarBD
            // 
            this.gBtnImportarBD.AnimationHoverSpeed = 0.07F;
            this.gBtnImportarBD.AnimationSpeed = 0.03F;
            this.gBtnImportarBD.BackColor = System.Drawing.Color.Transparent;
            this.gBtnImportarBD.BaseColor = System.Drawing.Color.White;
            this.gBtnImportarBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnImportarBD.BorderSize = 2;
            this.gBtnImportarBD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnImportarBD.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnImportarBD.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnImportarBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnImportarBD.Image = ((System.Drawing.Image)(resources.GetObject("gBtnImportarBD.Image")));
            this.gBtnImportarBD.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnImportarBD.Location = new System.Drawing.Point(1518, 128);
            this.gBtnImportarBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBtnImportarBD.Name = "gBtnImportarBD";
            this.gBtnImportarBD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnImportarBD.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnImportarBD.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnImportarBD.OnHoverImage = null;
            this.gBtnImportarBD.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnImportarBD.Radius = 10;
            this.gBtnImportarBD.Size = new System.Drawing.Size(360, 111);
            this.gBtnImportarBD.TabIndex = 16;
            this.gBtnImportarBD.Text = "Importar a BD";
            this.gBtnImportarBD.Click += new System.EventHandler(this.gBtnImportarBD_Click);
            // 
            // gBtnExcel
            // 
            this.gBtnExcel.AnimationHoverSpeed = 0.07F;
            this.gBtnExcel.AnimationSpeed = 0.03F;
            this.gBtnExcel.BackColor = System.Drawing.Color.Transparent;
            this.gBtnExcel.BaseColor = System.Drawing.Color.White;
            this.gBtnExcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnExcel.BorderSize = 2;
            this.gBtnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnExcel.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnExcel.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("gBtnExcel.Image")));
            this.gBtnExcel.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnExcel.Location = new System.Drawing.Point(1084, 128);
            this.gBtnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBtnExcel.Name = "gBtnExcel";
            this.gBtnExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnExcel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnExcel.OnHoverImage = null;
            this.gBtnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnExcel.Radius = 10;
            this.gBtnExcel.Size = new System.Drawing.Size(360, 111);
            this.gBtnExcel.TabIndex = 15;
            this.gBtnExcel.Text = "Exportar Excel";
            this.gBtnExcel.Click += new System.EventHandler(this.gBtnExcel_Click);
            // 
            // gBtnLimpiarCajas
            // 
            this.gBtnLimpiarCajas.AnimationHoverSpeed = 0.07F;
            this.gBtnLimpiarCajas.AnimationSpeed = 0.03F;
            this.gBtnLimpiarCajas.BackColor = System.Drawing.Color.Transparent;
            this.gBtnLimpiarCajas.BaseColor = System.Drawing.Color.White;
            this.gBtnLimpiarCajas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnLimpiarCajas.BorderSize = 2;
            this.gBtnLimpiarCajas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnLimpiarCajas.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnLimpiarCajas.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnLimpiarCajas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnLimpiarCajas.Image = ((System.Drawing.Image)(resources.GetObject("gBtnLimpiarCajas.Image")));
            this.gBtnLimpiarCajas.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnLimpiarCajas.Location = new System.Drawing.Point(1518, 8);
            this.gBtnLimpiarCajas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBtnLimpiarCajas.Name = "gBtnLimpiarCajas";
            this.gBtnLimpiarCajas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnLimpiarCajas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnLimpiarCajas.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnLimpiarCajas.OnHoverImage = null;
            this.gBtnLimpiarCajas.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnLimpiarCajas.Radius = 10;
            this.gBtnLimpiarCajas.Size = new System.Drawing.Size(360, 111);
            this.gBtnLimpiarCajas.TabIndex = 14;
            this.gBtnLimpiarCajas.Text = "Limpiar Cajas";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 168);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(234, 37);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "DIRECTORIO:";
            // 
            // gTxtDirectorio
            // 
            this.gTxtDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.gTxtDirectorio.BaseColor = System.Drawing.Color.White;
            this.gTxtDirectorio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtDirectorio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtDirectorio.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtDirectorio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtDirectorio.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtDirectorio.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtDirectorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtDirectorio.Location = new System.Drawing.Point(275, 131);
            this.gTxtDirectorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtDirectorio.Name = "gTxtDirectorio";
            this.gTxtDirectorio.PasswordChar = '\0';
            this.gTxtDirectorio.Radius = 15;
            this.gTxtDirectorio.SelectedText = "";
            this.gTxtDirectorio.Size = new System.Drawing.Size(668, 74);
            this.gTxtDirectorio.TabIndex = 12;
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
            this.gBtnCloseForm.Location = new System.Drawing.Point(2, 5);
            this.gBtnCloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBtnCloseForm.Name = "gBtnCloseForm";
            this.gBtnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnCloseForm.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnCloseForm.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnCloseForm.OnHoverImage = null;
            this.gBtnCloseForm.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnCloseForm.Radius = 20;
            this.gBtnCloseForm.Size = new System.Drawing.Size(56, 49);
            this.gBtnCloseForm.TabIndex = 11;
            // 
            // gbtnDirectorio
            // 
            this.gbtnDirectorio.AnimationHoverSpeed = 0.07F;
            this.gbtnDirectorio.AnimationSpeed = 0.03F;
            this.gbtnDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.gbtnDirectorio.BaseColor = System.Drawing.Color.White;
            this.gbtnDirectorio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnDirectorio.BorderSize = 2;
            this.gbtnDirectorio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnDirectorio.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnDirectorio.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnDirectorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnDirectorio.Image = global::AppIncorporacion2021.Properties.Resources.icons8_google_web_search_60px;
            this.gbtnDirectorio.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnDirectorio.Location = new System.Drawing.Point(1084, 8);
            this.gbtnDirectorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnDirectorio.Name = "gbtnDirectorio";
            this.gbtnDirectorio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnDirectorio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnDirectorio.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnDirectorio.OnHoverImage = null;
            this.gbtnDirectorio.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnDirectorio.Radius = 10;
            this.gbtnDirectorio.Size = new System.Drawing.Size(360, 111);
            this.gbtnDirectorio.TabIndex = 6;
            this.gbtnDirectorio.Text = "Examinar Directorio";
            this.gbtnDirectorio.Click += new System.EventHandler(this.gbtnDirectorio_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel2.Location = new System.Drawing.Point(81, 52);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(146, 37);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "FILTRO:";
            // 
            // gTxtFiltro
            // 
            this.gTxtFiltro.BackColor = System.Drawing.Color.Transparent;
            this.gTxtFiltro.BaseColor = System.Drawing.Color.White;
            this.gTxtFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtFiltro.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtFiltro.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtFiltro.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtFiltro.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtFiltro.Location = new System.Drawing.Point(269, 28);
            this.gTxtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtFiltro.Name = "gTxtFiltro";
            this.gTxtFiltro.PasswordChar = '\0';
            this.gTxtFiltro.Radius = 15;
            this.gTxtFiltro.SelectedText = "";
            this.gTxtFiltro.Size = new System.Drawing.Size(668, 74);
            this.gTxtFiltro.TabIndex = 0;
            this.gTxtFiltro.Text = "*.txt";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.AntiqueWhite;
            this.gunaElipsePanel1.Controls.Add(this.dtgvArchivos);
            this.gunaElipsePanel1.Controls.Add(this.rTxtboxMostrarArchivos);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel5);
            this.gunaElipsePanel1.Controls.Add(this.lblTotalArchivos);
            this.gunaElipsePanel1.Controls.Add(this.ltbArchivos);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1930, 1072);
            this.gunaElipsePanel1.TabIndex = 5;
            // 
            // dtgvArchivos
            // 
            this.dtgvArchivos.AllowUserToAddRows = false;
            this.dtgvArchivos.AllowUserToDeleteRows = false;
            this.dtgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArchivos.Location = new System.Drawing.Point(854, 632);
            this.dtgvArchivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvArchivos.Name = "dtgvArchivos";
            this.dtgvArchivos.ReadOnly = true;
            this.dtgvArchivos.Size = new System.Drawing.Size(1024, 366);
            this.dtgvArchivos.TabIndex = 11;
            // 
            // rTxtboxMostrarArchivos
            // 
            this.rTxtboxMostrarArchivos.Location = new System.Drawing.Point(854, 312);
            this.rTxtboxMostrarArchivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rTxtboxMostrarArchivos.Name = "rTxtboxMostrarArchivos";
            this.rTxtboxMostrarArchivos.Size = new System.Drawing.Size(1022, 307);
            this.rTxtboxMostrarArchivos.TabIndex = 10;
            this.rTxtboxMostrarArchivos.Text = "";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel5.Location = new System.Drawing.Point(848, 272);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(306, 37);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Contenido Archivo:";
            // 
            // lblTotalArchivos
            // 
            this.lblTotalArchivos.AutoSize = true;
            this.lblTotalArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.lblTotalArchivos.Location = new System.Drawing.Point(18, 1023);
            this.lblTotalArchivos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalArchivos.Name = "lblTotalArchivos";
            this.lblTotalArchivos.Size = new System.Drawing.Size(494, 37);
            this.lblTotalArchivos.TabIndex = 8;
            this.lblTotalArchivos.Text = "Total de Archivos Encontrados:";
            // 
            // ltbArchivos
            // 
            this.ltbArchivos.FormattingEnabled = true;
            this.ltbArchivos.ItemHeight = 20;
            this.ltbArchivos.Location = new System.Drawing.Point(87, 312);
            this.ltbArchivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbArchivos.Name = "ltbArchivos";
            this.ltbArchivos.Size = new System.Drawing.Size(718, 684);
            this.ltbArchivos.TabIndex = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel3.Location = new System.Drawing.Point(33, 272);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(222, 37);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Ruta Archivo:";
            // 
            // OrdenPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 1072);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdenPago";
            this.Text = "OrdenPago";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArchivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton gBtnCloseForm;
        private Guna.UI.WinForms.GunaButton gbtnDirectorio;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox gTxtFiltro;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox gTxtDirectorio;
        private Guna.UI.WinForms.GunaButton gBtnExcel;
        private Guna.UI.WinForms.GunaButton gBtnLimpiarCajas;
        private Guna.UI.WinForms.GunaButton gBtnImportarBD;
        private System.Windows.Forms.DataGridView dtgvArchivos;
        private System.Windows.Forms.RichTextBox rTxtboxMostrarArchivos;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lblTotalArchivos;
        private System.Windows.Forms.ListBox ltbArchivos;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}