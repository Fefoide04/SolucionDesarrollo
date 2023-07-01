namespace DesarrolloLAP_SYSTEMS
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            this.pnl_superiorPrincipal = new System.Windows.Forms.Panel();
            this.pic_maximizarPrincipal = new System.Windows.Forms.PictureBox();
            this.pic_modoVentanaPrincipal = new System.Windows.Forms.PictureBox();
            this.pic_minimizarPrincipal = new System.Windows.Forms.PictureBox();
            this.pic_cerrarPrincipal = new System.Windows.Forms.PictureBox();
            this.pnl_columnaPrincipal = new System.Windows.Forms.Panel();
            this.btn_Compras = new System.Windows.Forms.Button();
            this.pic_logoPrincipal = new System.Windows.Forms.PictureBox();
            this.lbl_fechaPrincipal = new System.Windows.Forms.Label();
            this.lbl_horaPrincipal = new System.Windows.Forms.Label();
            this.btn_admUsuarios = new System.Windows.Forms.Button();
            this.pnl_displayFormsPrincipal = new System.Windows.Forms.Panel();
            this.tim_horaFechaActuales = new System.Windows.Forms.Timer(this.components);
            this.pnl_superiorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizarPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_modoVentanaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizarPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrarPrincipal)).BeginInit();
            this.pnl_columnaPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_superiorPrincipal
            // 
            this.pnl_superiorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnl_superiorPrincipal.Controls.Add(this.pic_maximizarPrincipal);
            this.pnl_superiorPrincipal.Controls.Add(this.pic_modoVentanaPrincipal);
            this.pnl_superiorPrincipal.Controls.Add(this.pic_minimizarPrincipal);
            this.pnl_superiorPrincipal.Controls.Add(this.pic_cerrarPrincipal);
            this.pnl_superiorPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_superiorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnl_superiorPrincipal.Name = "pnl_superiorPrincipal";
            this.pnl_superiorPrincipal.Size = new System.Drawing.Size(1300, 35);
            this.pnl_superiorPrincipal.TabIndex = 1;
            // 
            // pic_maximizarPrincipal
            // 
            this.pic_maximizarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_maximizarPrincipal.BackgroundImage = global::DesarrolloLAP_SYSTEMS.Properties.Resources.maximizar;
            this.pic_maximizarPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_maximizarPrincipal.Location = new System.Drawing.Point(1231, 2);
            this.pic_maximizarPrincipal.Name = "pic_maximizarPrincipal";
            this.pic_maximizarPrincipal.Size = new System.Drawing.Size(30, 30);
            this.pic_maximizarPrincipal.TabIndex = 3;
            this.pic_maximizarPrincipal.TabStop = false;
            this.pic_maximizarPrincipal.Click += new System.EventHandler(this.pic_maximizarPrincipal_Click);
            // 
            // pic_modoVentanaPrincipal
            // 
            this.pic_modoVentanaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_modoVentanaPrincipal.BackgroundImage = global::DesarrolloLAP_SYSTEMS.Properties.Resources.ventana;
            this.pic_modoVentanaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_modoVentanaPrincipal.Location = new System.Drawing.Point(1231, 3);
            this.pic_modoVentanaPrincipal.Name = "pic_modoVentanaPrincipal";
            this.pic_modoVentanaPrincipal.Size = new System.Drawing.Size(30, 30);
            this.pic_modoVentanaPrincipal.TabIndex = 3;
            this.pic_modoVentanaPrincipal.TabStop = false;
            this.pic_modoVentanaPrincipal.Visible = false;
            this.pic_modoVentanaPrincipal.Click += new System.EventHandler(this.pic_modoVentanaPrincipal_Click);
            // 
            // pic_minimizarPrincipal
            // 
            this.pic_minimizarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minimizarPrincipal.BackgroundImage = global::DesarrolloLAP_SYSTEMS.Properties.Resources.minimizar;
            this.pic_minimizarPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimizarPrincipal.Location = new System.Drawing.Point(1195, 3);
            this.pic_minimizarPrincipal.Name = "pic_minimizarPrincipal";
            this.pic_minimizarPrincipal.Size = new System.Drawing.Size(30, 30);
            this.pic_minimizarPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimizarPrincipal.TabIndex = 2;
            this.pic_minimizarPrincipal.TabStop = false;
            this.pic_minimizarPrincipal.Click += new System.EventHandler(this.pic_minimizarPrincipal_Click);
            // 
            // pic_cerrarPrincipal
            // 
            this.pic_cerrarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_cerrarPrincipal.BackgroundImage = global::DesarrolloLAP_SYSTEMS.Properties.Resources.cerrar;
            this.pic_cerrarPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cerrarPrincipal.Location = new System.Drawing.Point(1267, 3);
            this.pic_cerrarPrincipal.Name = "pic_cerrarPrincipal";
            this.pic_cerrarPrincipal.Size = new System.Drawing.Size(30, 30);
            this.pic_cerrarPrincipal.TabIndex = 0;
            this.pic_cerrarPrincipal.TabStop = false;
            this.pic_cerrarPrincipal.Click += new System.EventHandler(this.pic_cerrarPrincipal_Click);
            // 
            // pnl_columnaPrincipal
            // 
            this.pnl_columnaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnl_columnaPrincipal.Controls.Add(this.btn_Compras);
            this.pnl_columnaPrincipal.Controls.Add(this.pic_logoPrincipal);
            this.pnl_columnaPrincipal.Controls.Add(this.lbl_fechaPrincipal);
            this.pnl_columnaPrincipal.Controls.Add(this.lbl_horaPrincipal);
            this.pnl_columnaPrincipal.Controls.Add(this.btn_admUsuarios);
            this.pnl_columnaPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_columnaPrincipal.Location = new System.Drawing.Point(0, 35);
            this.pnl_columnaPrincipal.Name = "pnl_columnaPrincipal";
            this.pnl_columnaPrincipal.Size = new System.Drawing.Size(220, 615);
            this.pnl_columnaPrincipal.TabIndex = 2;
            // 
            // btn_Compras
            // 
            this.btn_Compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compras.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compras.ForeColor = System.Drawing.Color.White;
            this.btn_Compras.Location = new System.Drawing.Point(0, 220);
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.Size = new System.Drawing.Size(220, 64);
            this.btn_Compras.TabIndex = 5;
            this.btn_Compras.Text = "Compras";
            this.btn_Compras.UseVisualStyleBackColor = false;
            // 
            // pic_logoPrincipal
            // 
            this.pic_logoPrincipal.BackgroundImage = global::DesarrolloLAP_SYSTEMS.Properties.Resources.Logo_LAP;
            this.pic_logoPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_logoPrincipal.Location = new System.Drawing.Point(3, 38);
            this.pic_logoPrincipal.Name = "pic_logoPrincipal";
            this.pic_logoPrincipal.Size = new System.Drawing.Size(217, 75);
            this.pic_logoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logoPrincipal.TabIndex = 4;
            this.pic_logoPrincipal.TabStop = false;
            // 
            // lbl_fechaPrincipal
            // 
            this.lbl_fechaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fechaPrincipal.AutoSize = true;
            this.lbl_fechaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaPrincipal.ForeColor = System.Drawing.Color.White;
            this.lbl_fechaPrincipal.Location = new System.Drawing.Point(21, 560);
            this.lbl_fechaPrincipal.Name = "lbl_fechaPrincipal";
            this.lbl_fechaPrincipal.Size = new System.Drawing.Size(182, 46);
            this.lbl_fechaPrincipal.TabIndex = 3;
            this.lbl_fechaPrincipal.Text = "00/00/00";
            // 
            // lbl_horaPrincipal
            // 
            this.lbl_horaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_horaPrincipal.AutoSize = true;
            this.lbl_horaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaPrincipal.ForeColor = System.Drawing.Color.White;
            this.lbl_horaPrincipal.Location = new System.Drawing.Point(46, 514);
            this.lbl_horaPrincipal.Name = "lbl_horaPrincipal";
            this.lbl_horaPrincipal.Size = new System.Drawing.Size(124, 46);
            this.lbl_horaPrincipal.TabIndex = 2;
            this.lbl_horaPrincipal.Text = "00:00";
            // 
            // btn_admUsuarios
            // 
            this.btn_admUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_admUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_admUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admUsuarios.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admUsuarios.ForeColor = System.Drawing.Color.White;
            this.btn_admUsuarios.Location = new System.Drawing.Point(0, 150);
            this.btn_admUsuarios.Name = "btn_admUsuarios";
            this.btn_admUsuarios.Size = new System.Drawing.Size(220, 64);
            this.btn_admUsuarios.TabIndex = 0;
            this.btn_admUsuarios.Text = "Adm. Usuarios";
            this.btn_admUsuarios.UseVisualStyleBackColor = false;
            this.btn_admUsuarios.Click += new System.EventHandler(this.btn_admUsr_Click);
            // 
            // pnl_displayFormsPrincipal
            // 
            this.pnl_displayFormsPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnl_displayFormsPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_displayFormsPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_displayFormsPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_displayFormsPrincipal.Location = new System.Drawing.Point(220, 35);
            this.pnl_displayFormsPrincipal.Name = "pnl_displayFormsPrincipal";
            this.pnl_displayFormsPrincipal.Size = new System.Drawing.Size(1080, 615);
            this.pnl_displayFormsPrincipal.TabIndex = 3;
            this.pnl_displayFormsPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_displayFormsPrincipal_Paint);
            // 
            // tim_horaFechaActuales
            // 
            this.tim_horaFechaActuales.Tick += new System.EventHandler(this.tim_horaFechaActuales_Tick);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnl_displayFormsPrincipal);
            this.Controls.Add(this.pnl_columnaPrincipal);
            this.Controls.Add(this.pnl_superiorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.pnl_superiorPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizarPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_modoVentanaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizarPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrarPrincipal)).EndInit();
            this.pnl_columnaPrincipal.ResumeLayout(false);
            this.pnl_columnaPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_superiorPrincipal;
        private System.Windows.Forms.PictureBox pic_modoVentanaPrincipal;
        private System.Windows.Forms.PictureBox pic_minimizarPrincipal;
        private System.Windows.Forms.PictureBox pic_cerrarPrincipal;
        private System.Windows.Forms.Panel pnl_columnaPrincipal;
        private System.Windows.Forms.PictureBox pic_logoPrincipal;
        private System.Windows.Forms.Label lbl_fechaPrincipal;
        private System.Windows.Forms.Label lbl_horaPrincipal;
        private System.Windows.Forms.Button btn_admUsuarios;
        internal System.Windows.Forms.Panel pnl_displayFormsPrincipal;
        private System.Windows.Forms.PictureBox pic_maximizarPrincipal;
        private System.Windows.Forms.Timer tim_horaFechaActuales;
        private System.Windows.Forms.Button btn_Compras;
    }
}