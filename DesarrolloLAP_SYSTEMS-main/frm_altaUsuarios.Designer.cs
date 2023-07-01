namespace DesarrolloLAP_SYSTEMS
{
    partial class frm_altaUsuarios
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
            this.btn_darAltaUsuarios = new System.Windows.Forms.Button();
            this.Txt_TelefonoAlta = new System.Windows.Forms.TextBox();
            this.Txt_EmailAlta = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoAlta = new System.Windows.Forms.TextBox();
            this.Txt_NombreAlta = new System.Windows.Forms.TextBox();
            this.lbl_EstadoAltaUsuarios = new System.Windows.Forms.Label();
            this.lbl_telefonoAltaUsuarios = new System.Windows.Forms.Label();
            this.lbl_emailAltaUsuarios = new System.Windows.Forms.Label();
            this.lbl_cuilAltaUsuarios = new System.Windows.Forms.Label();
            this.lbl_apellidoAltaUsuarios = new System.Windows.Forms.Label();
            this.lbl_nombreAltaUsuarios = new System.Windows.Forms.Label();
            this.lbl_tituloAltaUsuarios = new System.Windows.Forms.Label();
            this.btn_regresarAltaUsuarios = new System.Windows.Forms.Button();
            this.rbtn_ActivoAlta = new System.Windows.Forms.RadioButton();
            this.rbtn_InactivoAlta = new System.Windows.Forms.RadioButton();
            this.mtxt_CuitAlta = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_darAltaUsuarios
            // 
            this.btn_darAltaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_darAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_darAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_darAltaUsuarios.Location = new System.Drawing.Point(346, 347);
            this.btn_darAltaUsuarios.Name = "btn_darAltaUsuarios";
            this.btn_darAltaUsuarios.Size = new System.Drawing.Size(243, 64);
            this.btn_darAltaUsuarios.TabIndex = 6;
            this.btn_darAltaUsuarios.Text = "Dar Alta";
            this.btn_darAltaUsuarios.UseVisualStyleBackColor = true;
            this.btn_darAltaUsuarios.Click += new System.EventHandler(this.btn_darAltaUsuarios_Click);
            // 
            // Txt_TelefonoAlta
            // 
            this.Txt_TelefonoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TelefonoAlta.Location = new System.Drawing.Point(346, 131);
            this.Txt_TelefonoAlta.Name = "Txt_TelefonoAlta";
            this.Txt_TelefonoAlta.Size = new System.Drawing.Size(243, 26);
            this.Txt_TelefonoAlta.TabIndex = 4;
            this.Txt_TelefonoAlta.Tag = "Telefono";
            this.Txt_TelefonoAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TelefonoAlta_KeyPress);
            // 
            // Txt_EmailAlta
            // 
            this.Txt_EmailAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailAlta.Location = new System.Drawing.Point(24, 385);
            this.Txt_EmailAlta.Name = "Txt_EmailAlta";
            this.Txt_EmailAlta.Size = new System.Drawing.Size(243, 26);
            this.Txt_EmailAlta.TabIndex = 3;
            this.Txt_EmailAlta.Tag = "Email";
            this.Txt_EmailAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_EmailAlta_KeyPress);
            this.Txt_EmailAlta.Leave += new System.EventHandler(this.Txt_EmailAlta_Leave);
            // 
            // Txt_ApellidoAlta
            // 
            this.Txt_ApellidoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ApellidoAlta.Location = new System.Drawing.Point(24, 214);
            this.Txt_ApellidoAlta.Name = "Txt_ApellidoAlta";
            this.Txt_ApellidoAlta.Size = new System.Drawing.Size(243, 26);
            this.Txt_ApellidoAlta.TabIndex = 1;
            this.Txt_ApellidoAlta.Tag = "Apellido";
            this.Txt_ApellidoAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ApellidoAlta_KeyPress);
            // 
            // Txt_NombreAlta
            // 
            this.Txt_NombreAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreAlta.Location = new System.Drawing.Point(24, 135);
            this.Txt_NombreAlta.Name = "Txt_NombreAlta";
            this.Txt_NombreAlta.Size = new System.Drawing.Size(243, 26);
            this.Txt_NombreAlta.TabIndex = 0;
            this.Txt_NombreAlta.Tag = "Nombre";
            this.Txt_NombreAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NombreAlta_KeyPress);
            // 
            // lbl_EstadoAltaUsuarios
            // 
            this.lbl_EstadoAltaUsuarios.AutoSize = true;
            this.lbl_EstadoAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstadoAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_EstadoAltaUsuarios.Location = new System.Drawing.Point(340, 176);
            this.lbl_EstadoAltaUsuarios.Name = "lbl_EstadoAltaUsuarios";
            this.lbl_EstadoAltaUsuarios.Size = new System.Drawing.Size(273, 31);
            this.lbl_EstadoAltaUsuarios.TabIndex = 68;
            this.lbl_EstadoAltaUsuarios.Text = "Estado de Actividad";
            // 
            // lbl_telefonoAltaUsuarios
            // 
            this.lbl_telefonoAltaUsuarios.AutoSize = true;
            this.lbl_telefonoAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefonoAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_telefonoAltaUsuarios.Location = new System.Drawing.Point(340, 97);
            this.lbl_telefonoAltaUsuarios.Name = "lbl_telefonoAltaUsuarios";
            this.lbl_telefonoAltaUsuarios.Size = new System.Drawing.Size(128, 31);
            this.lbl_telefonoAltaUsuarios.TabIndex = 66;
            this.lbl_telefonoAltaUsuarios.Text = "Teléfono";
            // 
            // lbl_emailAltaUsuarios
            // 
            this.lbl_emailAltaUsuarios.AutoSize = true;
            this.lbl_emailAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_emailAltaUsuarios.Location = new System.Drawing.Point(18, 351);
            this.lbl_emailAltaUsuarios.Name = "lbl_emailAltaUsuarios";
            this.lbl_emailAltaUsuarios.Size = new System.Drawing.Size(86, 31);
            this.lbl_emailAltaUsuarios.TabIndex = 64;
            this.lbl_emailAltaUsuarios.Text = "Email";
            // 
            // lbl_cuilAltaUsuarios
            // 
            this.lbl_cuilAltaUsuarios.AutoSize = true;
            this.lbl_cuilAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuilAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cuilAltaUsuarios.Location = new System.Drawing.Point(20, 265);
            this.lbl_cuilAltaUsuarios.Name = "lbl_cuilAltaUsuarios";
            this.lbl_cuilAltaUsuarios.Size = new System.Drawing.Size(83, 31);
            this.lbl_cuilAltaUsuarios.TabIndex = 62;
            this.lbl_cuilAltaUsuarios.Text = "CUIT";
            // 
            // lbl_apellidoAltaUsuarios
            // 
            this.lbl_apellidoAltaUsuarios.AutoSize = true;
            this.lbl_apellidoAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_apellidoAltaUsuarios.Location = new System.Drawing.Point(18, 180);
            this.lbl_apellidoAltaUsuarios.Name = "lbl_apellidoAltaUsuarios";
            this.lbl_apellidoAltaUsuarios.Size = new System.Drawing.Size(118, 31);
            this.lbl_apellidoAltaUsuarios.TabIndex = 60;
            this.lbl_apellidoAltaUsuarios.Text = "Apellido";
            // 
            // lbl_nombreAltaUsuarios
            // 
            this.lbl_nombreAltaUsuarios.AutoSize = true;
            this.lbl_nombreAltaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreAltaUsuarios.Location = new System.Drawing.Point(18, 101);
            this.lbl_nombreAltaUsuarios.Name = "lbl_nombreAltaUsuarios";
            this.lbl_nombreAltaUsuarios.Size = new System.Drawing.Size(116, 31);
            this.lbl_nombreAltaUsuarios.TabIndex = 58;
            this.lbl_nombreAltaUsuarios.Text = "Nombre";
            // 
            // lbl_tituloAltaUsuarios
            // 
            this.lbl_tituloAltaUsuarios.AutoSize = true;
            this.lbl_tituloAltaUsuarios.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloAltaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tituloAltaUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lbl_tituloAltaUsuarios.Name = "lbl_tituloAltaUsuarios";
            this.lbl_tituloAltaUsuarios.Size = new System.Drawing.Size(365, 68);
            this.lbl_tituloAltaUsuarios.TabIndex = 57;
            this.lbl_tituloAltaUsuarios.Text = "Alta Usuarios";
            // 
            // btn_regresarAltaUsuarios
            // 
            this.btn_regresarAltaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_regresarAltaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresarAltaUsuarios.Image = global::DesarrolloLAP_SYSTEMS.Properties.Resources.Flecha_izquierda;
            this.btn_regresarAltaUsuarios.Location = new System.Drawing.Point(24, 527);
            this.btn_regresarAltaUsuarios.Name = "btn_regresarAltaUsuarios";
            this.btn_regresarAltaUsuarios.Size = new System.Drawing.Size(160, 64);
            this.btn_regresarAltaUsuarios.TabIndex = 7;
            this.btn_regresarAltaUsuarios.UseVisualStyleBackColor = false;
            this.btn_regresarAltaUsuarios.Click += new System.EventHandler(this.btn_regresarAltaUsuarios_Click);
            // 
            // rbtn_ActivoAlta
            // 
            this.rbtn_ActivoAlta.AutoSize = true;
            this.rbtn_ActivoAlta.Checked = true;
            this.rbtn_ActivoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_ActivoAlta.Location = new System.Drawing.Point(346, 210);
            this.rbtn_ActivoAlta.Name = "rbtn_ActivoAlta";
            this.rbtn_ActivoAlta.Size = new System.Drawing.Size(79, 28);
            this.rbtn_ActivoAlta.TabIndex = 5;
            this.rbtn_ActivoAlta.TabStop = true;
            this.rbtn_ActivoAlta.Text = "Activo";
            this.rbtn_ActivoAlta.UseVisualStyleBackColor = true;
            // 
            // rbtn_InactivoAlta
            // 
            this.rbtn_InactivoAlta.AutoSize = true;
            this.rbtn_InactivoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_InactivoAlta.Location = new System.Drawing.Point(498, 210);
            this.rbtn_InactivoAlta.Name = "rbtn_InactivoAlta";
            this.rbtn_InactivoAlta.Size = new System.Drawing.Size(91, 28);
            this.rbtn_InactivoAlta.TabIndex = 6;
            this.rbtn_InactivoAlta.Text = "Inactivo";
            this.rbtn_InactivoAlta.UseVisualStyleBackColor = true;
            // 
            // mtxt_CuitAlta
            // 
            this.mtxt_CuitAlta.BeepOnError = true;
            this.mtxt_CuitAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_CuitAlta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxt_CuitAlta.Location = new System.Drawing.Point(24, 299);
            this.mtxt_CuitAlta.Mask = "00-00000000-0";
            this.mtxt_CuitAlta.Name = "mtxt_CuitAlta";
            this.mtxt_CuitAlta.PromptChar = '#';
            this.mtxt_CuitAlta.Size = new System.Drawing.Size(243, 26);
            this.mtxt_CuitAlta.TabIndex = 2;
            // 
            // frm_altaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.mtxt_CuitAlta);
            this.Controls.Add(this.rbtn_InactivoAlta);
            this.Controls.Add(this.rbtn_ActivoAlta);
            this.Controls.Add(this.btn_regresarAltaUsuarios);
            this.Controls.Add(this.btn_darAltaUsuarios);
            this.Controls.Add(this.Txt_TelefonoAlta);
            this.Controls.Add(this.Txt_EmailAlta);
            this.Controls.Add(this.Txt_ApellidoAlta);
            this.Controls.Add(this.Txt_NombreAlta);
            this.Controls.Add(this.lbl_EstadoAltaUsuarios);
            this.Controls.Add(this.lbl_telefonoAltaUsuarios);
            this.Controls.Add(this.lbl_emailAltaUsuarios);
            this.Controls.Add(this.lbl_cuilAltaUsuarios);
            this.Controls.Add(this.lbl_apellidoAltaUsuarios);
            this.Controls.Add(this.lbl_nombreAltaUsuarios);
            this.Controls.Add(this.lbl_tituloAltaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_altaUsuarios";
            this.Tag = "Nombre";
            this.Text = "frm_altaUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_darAltaUsuarios;
        private System.Windows.Forms.TextBox Txt_TelefonoAlta;
        private System.Windows.Forms.TextBox Txt_EmailAlta;
        private System.Windows.Forms.TextBox Txt_ApellidoAlta;
        private System.Windows.Forms.TextBox Txt_NombreAlta;
        private System.Windows.Forms.Label lbl_EstadoAltaUsuarios;
        private System.Windows.Forms.Label lbl_telefonoAltaUsuarios;
        private System.Windows.Forms.Label lbl_emailAltaUsuarios;
        private System.Windows.Forms.Label lbl_cuilAltaUsuarios;
        private System.Windows.Forms.Label lbl_apellidoAltaUsuarios;
        private System.Windows.Forms.Label lbl_nombreAltaUsuarios;
        private System.Windows.Forms.Label lbl_tituloAltaUsuarios;
        private System.Windows.Forms.Button btn_regresarAltaUsuarios;
        private System.Windows.Forms.RadioButton rbtn_ActivoAlta;
        private System.Windows.Forms.RadioButton rbtn_InactivoAlta;
        private System.Windows.Forms.MaskedTextBox mtxt_CuitAlta;
    }
}