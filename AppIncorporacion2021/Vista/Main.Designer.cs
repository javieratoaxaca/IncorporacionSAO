namespace AppIncorporacion2021
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnMin = new Guna.UI.WinForms.GunaButton();
            this.btnMax = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 25;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(35, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(210, 23);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Incorporacion 2021";
            // 
            // btnMin
            // 
            this.btnMin.AnimationHoverSpeed = 0.07F;
            this.btnMin.AnimationSpeed = 0.03F;
            this.btnMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.btnMin.BorderColor = System.Drawing.Color.Black;
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FocusedColor = System.Drawing.Color.Empty;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Image = global::AppIncorporacion2021.Properties.Resources.min_64px;
            this.btnMin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMin.Location = new System.Drawing.Point(853, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMin.OnHoverImage = null;
            this.btnMin.OnPressedColor = System.Drawing.Color.Black;
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnMin.Size = new System.Drawing.Size(50, 39);
            this.btnMin.TabIndex = 2;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.AnimationHoverSpeed = 0.07F;
            this.btnMax.AnimationSpeed = 0.03F;
            this.btnMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(154)))));
            this.btnMax.BorderColor = System.Drawing.Color.Black;
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FocusedColor = System.Drawing.Color.Empty;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Image = global::AppIncorporacion2021.Properties.Resources.max_64px;
            this.btnMax.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMax.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMax.Location = new System.Drawing.Point(903, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMax.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMax.OnHoverImage = null;
            this.btnMax.OnPressedColor = System.Drawing.Color.Black;
            this.btnMax.Size = new System.Drawing.Size(50, 39);
            this.btnMax.TabIndex = 3;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::AppIncorporacion2021.Properties.Resources.icons8_cancel_64px;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(953, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(50, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnMin;
        private Guna.UI.WinForms.GunaButton btnMax;
        private Guna.UI.WinForms.GunaButton btnClose;
    }
}

