namespace DesarrolloLAP_SYSTEMS
{
    partial class frm_modUsuarios
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
            this.rbtn_InactivoMod = new System.Windows.Forms.RadioButton();
            this.rbtn_ActivoMod = new System.Windows.Forms.RadioButton();
            this.btn_regresarModUsuarios = new System.Windows.Forms.Button();
            this.btn_modificarUsuarios = new System.Windows.Forms.Button();
            this.Txt_TelefonoMod = new System.Windows.Forms.TextBox();
            this.Txt_EmailMod = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoMod = new System.Windows.Forms.TextBox();
            this.Txt_NombreMod = new System.Windows.Forms.TextBox();
            this.lbl_EstadoModUsuarios = new System.Windows.Forms.Label();
            this.lbl_telefonoModUsuarios = new System.Windows.Forms.Label();
            this.lbl_emailModUsuarios = new System.Windows.Forms.Label();
            this.lbl_cuilModUsuarios = new System.Windows.Forms.Label();
            this.lbl_apellidoModUsuarios = new System.Windows.Forms.Label();
            this.lbl_nombreModUsuarios = new System.Windows.Forms.Label();
            this.lbl_tituloModUsuarios = new System.Windows.Forms.Label();
            this.lbl_usernameModUsuarios = new System.Windows.Forms.Label();
            this.Txt_usernameMod = new System.Windows.Forms.TextBox();
            this.mtxt_CuitMod = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // rbtn_InactivoMod
            // 
            this.rbtn_InactivoMod.AutoSize = true;
            this.rbtn_InactivoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_InactivoMod.Location = new System.Drawing.Point(498, 293);
            this.rbtn_InactivoMod.Name = "rbtn_InactivoMod";
            this.rbtn_InactivoMod.Size = new System.Drawing.Size(91, 28);
            this.rbtn_InactivoMod.TabIndex = 7;
            this.rbtn_InactivoMod.Text = "Inactivo";
            this.rbtn_InactivoMod.UseVisualStyleBackColor = true;
            // 
            // rbtn_ActivoMod
            // 
            this.rbtn_ActivoMod.AutoSize = true;
            this.rbtn_ActivoMod.Checked = true;
            this.rbtn_ActivoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_ActivoMod.Location = new System.Drawing.Point(346, 293);
            this.rbtn_ActivoMod.Name = "rbtn_ActivoMod";
            this.rbtn_ActivoMod.Size = new System.Drawing.Size(79, 28);
            this.rbtn_ActivoMod.TabIndex = 6;
            this.rbtn_ActivoMod.TabStop = true;
            this.rbtn_ActivoMod.Text = "Activo";
            this.rbtn_ActivoMod.UseVisualStyleBackColor = true;
            // 
            // btn_regresarModUsuarios
            // 
            this.btn_regresarModUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_regresarModUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresarModUsuarios.Image = global::DesarrolloLAP_SYSTEMS.Properties.Resources.Flecha_izquierda;
            this.btn_regresarModUsuarios.Location = new System.Drawing.Point(24, 527);
            this.btn_regresarModUsuarios.Name = "btn_regresarModUsuarios";
            this.btn_regresarModUsuarios.Size = new System.Drawing.Size(160, 64);
            this.btn_regresarModUsuarios.TabIndex = 9;
            this.btn_regresarModUsuarios.UseVisualStyleBackColor = false;
            this.btn_regresarModUsuarios.Click += new System.EventHandler(this.btn_regresarModUsuarios_Click);
            // 
            // btn_modificarUsuarios
            // 
            this.btn_modificarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_modificarUsuarios.Location = new System.Drawing.Point(346, 347);
            this.btn_modificarUsuarios.Name = "btn_modificarUsuarios";
            this.btn_modificarUsuarios.Size = new System.Drawing.Size(243, 64);
            this.btn_modificarUsuarios.TabIndex = 8;
            this.btn_modificarUsuarios.Text = "Actualizar";
            this.btn_modificarUsuarios.UseVisualStyleBackColor = true;
            this.btn_modificarUsuarios.Click += new System.EventHandler(this.btn_modificarUsuarios_Click);
            // 
            // Txt_TelefonoMod
            // 
            this.Txt_TelefonoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TelefonoMod.Location = new System.Drawing.Point(346, 214);
            this.Txt_TelefonoMod.Name = "Txt_TelefonoMod";
            this.Txt_TelefonoMod.Size = new System.Drawing.Size(243, 26);
            this.Txt_TelefonoMod.TabIndex = 5;
            this.Txt_TelefonoMod.Tag = "Telefono";
            this.Txt_TelefonoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TelefonoMod_KeyPress);
            // 
            // Txt_EmailMod
            // 
            this.Txt_EmailMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailMod.Location = new System.Drawing.Point(24, 385);
            this.Txt_EmailMod.Name = "Txt_EmailMod";
            this.Txt_EmailMod.Size = new System.Drawing.Size(243, 26);
            this.Txt_EmailMod.TabIndex = 3;
            this.Txt_EmailMod.Tag = "Email";
            this.Txt_EmailMod.Leave += new System.EventHandler(this.Txt_EmailMod_Leave);
            // 
            // Txt_ApellidoMod
            // 
            this.Txt_ApellidoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ApellidoMod.Location = new System.Drawing.Point(24, 214);
            this.Txt_ApellidoMod.Name = "Txt_ApellidoMod";
            this.Txt_ApellidoMod.Size = new System.Drawing.Size(243, 26);
            this.Txt_ApellidoMod.TabIndex = 1;
            this.Txt_ApellidoMod.Tag = "Apellido";
            this.Txt_ApellidoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ApellidoMod_KeyPress);
            // 
            // Txt_NombreMod
            // 
            this.Txt_NombreMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreMod.Location = new System.Drawing.Point(24, 135);
            this.Txt_NombreMod.Name = "Txt_NombreMod";
            this.Txt_NombreMod.Size = new System.Drawing.Size(243, 26);
            this.Txt_NombreMod.TabIndex = 0;
            this.Txt_NombreMod.Tag = "Nombre";
            this.Txt_NombreMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NombreMod_KeyPress);
            // 
            // lbl_EstadoModUsuarios
            // 
            this.lbl_EstadoModUsuarios.AutoSize = true;
            this.lbl_EstadoModUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstadoModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_EstadoModUsuarios.Location = new System.Drawing.Point(340, 259);
            this.lbl_EstadoModUsuarios.Name = "lbl_EstadoModUsuarios";
            this.lbl_EstadoModUsuarios.Size = new System.Drawing.Size(273, 31);
            this.lbl_EstadoModUsuarios.TabIndex = 84;
            this.lbl_EstadoModUsuarios.Text = "Estado de Actividad";
            // 
            // lbl_telefonoModUsuarios
            // 
            this.lbl_telefonoModUsuarios.AutoSize = true;
            this.lbl_telefonoModUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefonoModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_telefonoModUsuarios.Location = new System.Drawing.Point(340, 180);
            this.lbl_telefonoModUsuarios.Name = "lbl_telefonoModUsuarios";
            this.lbl_telefonoModUsuarios.Size = new System.Drawing.Size(128, 31);
            this.lbl_telefonoModUsuarios.TabIndex = 83;
            this.lbl_telefonoModUsuarios.Text = "Teléfono";
            // 
            // lbl_emailModUsuarios
            // 
            this.lbl_emailModUsuarios.AutoSize = true;
            this.lbl_emailModUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_emailModUsuarios.Location = new System.Drawing.Point(18, 351);
            this.lbl_emailModUsuarios.Name = "lbl_emailModUsuarios";
            this.lbl_emailModUsuarios.Size = new System.Drawing.Size(86, 31);
            this.lbl_emailModUsuarios.TabIndex = 82;
            this.lbl_emailModUsuarios.Text = "Email";
            // 
            // lbl_cuilModUsuarios
            // 
            this.lbl_cuilModUsuarios.AutoSize = true;
            this.lbl_cuilModUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuilModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cuilModUsuarios.Location = new System.Drawing.Point(20, 265);
            this.lbl_cuilModUsuarios.Name = "lbl_cuilModUsuarios";
            this.lbl_cuilModUsuarios.Size = new System.Drawing.Size(83, 31);
            this.lbl_cuilModUsuarios.TabIndex = 81;
            this.lbl_cuilModUsuarios.Text = "CUIT";
            // 
            // lbl_apellidoModUsuarios
            // 
            this.lbl_apellidoModUsuarios.AutoSize = true;
            this.lbl_apellidoModUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_apellidoModUsuarios.Location = new System.Drawing.Point(18, 180);
            this.lbl_apellidoModUsuarios.Name = "lbl_apellidoModUsuarios";
            this.lbl_apellidoModUsuarios.Size = new System.Drawing.Size(118, 31);
            this.lbl_apellidoModUsuarios.TabIndex = 80;
            this.lbl_apellidoModUsuarios.Text = "Apellido";
            // 
            // lbl_nombreModUsuarios
            // 
            this.lbl_nombreModUsuarios.AutoSize = true;
            this.lbl_nombreModUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreModUsuarios.Location = new System.Drawing.Point(18, 101);
            this.lbl_nombreModUsuarios.Name = "lbl_nombreModUsuarios";
            this.lbl_nombreModUsuarios.Size = new System.Drawing.Size(116, 31);
            this.lbl_nombreModUsuarios.TabIndex = 79;
            this.lbl_nombreModUsuarios.Text = "Nombre";
            // 
            // lbl_tituloModUsuarios
            // 
            this.lbl_tituloModUsuarios.AutoSize = true;
            this.lbl_tituloModUsuarios.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tituloModUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lbl_tituloModUsuarios.Name = "lbl_tituloModUsuarios";
            this.lbl_tituloModUsuarios.Size = new System.Drawing.Size(593, 68);
            this.lbl_tituloModUsuarios.TabIndex = 78;
            this.lbl_tituloModUsuarios.Text = "Modificación Usuarios";
            // 
            // lbl_usernameModUsuarios
            // 
            this.lbl_usernameModUsuarios.AutoSize = true;
            this.lbl_usernameModUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameModUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_usernameModUsuarios.Location = new System.Drawing.Point(340, 101);
            this.lbl_usernameModUsuarios.Name = "lbl_usernameModUsuarios";
            this.lbl_usernameModUsuarios.Size = new System.Drawing.Size(265, 31);
            this.lbl_usernameModUsuarios.TabIndex = 79;
            this.lbl_usernameModUsuarios.Text = "Nombre de Usuario";
            // 
            // Txt_usernameMod
            // 
            this.Txt_usernameMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usernameMod.Location = new System.Drawing.Point(346, 135);
            this.Txt_usernameMod.Name = "Txt_usernameMod";
            this.Txt_usernameMod.Size = new System.Drawing.Size(243, 26);
            this.Txt_usernameMod.TabIndex = 4;
            this.Txt_usernameMod.Tag = "Nombre";
            this.Txt_usernameMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_usernameMod_KeyPress);
            // 
            // mtxt_CuitMod
            // 
            this.mtxt_CuitMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_CuitMod.Location = new System.Drawing.Point(24, 299);
            this.mtxt_CuitMod.Mask = "00-00000000-0";
            this.mtxt_CuitMod.Name = "mtxt_CuitMod";
            this.mtxt_CuitMod.PromptChar = '#';
            this.mtxt_CuitMod.Size = new System.Drawing.Size(243, 26);
            this.mtxt_CuitMod.TabIndex = 85;
            // 
            // frm_modUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.mtxt_CuitMod);
            this.Controls.Add(this.rbtn_InactivoMod);
            this.Controls.Add(this.rbtn_ActivoMod);
            this.Controls.Add(this.btn_regresarModUsuarios);
            this.Controls.Add(this.btn_modificarUsuarios);
            this.Controls.Add(this.Txt_TelefonoMod);
            this.Controls.Add(this.Txt_EmailMod);
            this.Controls.Add(this.Txt_ApellidoMod);
            this.Controls.Add(this.Txt_usernameMod);
            this.Controls.Add(this.Txt_NombreMod);
            this.Controls.Add(this.lbl_EstadoModUsuarios);
            this.Controls.Add(this.lbl_telefonoModUsuarios);
            this.Controls.Add(this.lbl_emailModUsuarios);
            this.Controls.Add(this.lbl_cuilModUsuarios);
            this.Controls.Add(this.lbl_apellidoModUsuarios);
            this.Controls.Add(this.lbl_usernameModUsuarios);
            this.Controls.Add(this.lbl_nombreModUsuarios);
            this.Controls.Add(this.lbl_tituloModUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_modUsuarios";
            this.Text = "frm_modUsuarios";
            this.Load += new System.EventHandler(this.frm_modUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_InactivoMod;
        private System.Windows.Forms.RadioButton rbtn_ActivoMod;
        private System.Windows.Forms.Button btn_regresarModUsuarios;
        private System.Windows.Forms.Button btn_modificarUsuarios;
        private System.Windows.Forms.TextBox Txt_TelefonoMod;
        private System.Windows.Forms.TextBox Txt_EmailMod;
        private System.Windows.Forms.TextBox Txt_ApellidoMod;
        private System.Windows.Forms.TextBox Txt_NombreMod;
        private System.Windows.Forms.Label lbl_EstadoModUsuarios;
        private System.Windows.Forms.Label lbl_telefonoModUsuarios;
        private System.Windows.Forms.Label lbl_emailModUsuarios;
        private System.Windows.Forms.Label lbl_cuilModUsuarios;
        private System.Windows.Forms.Label lbl_apellidoModUsuarios;
        private System.Windows.Forms.Label lbl_nombreModUsuarios;
        private System.Windows.Forms.Label lbl_tituloModUsuarios;
        private System.Windows.Forms.Label lbl_usernameModUsuarios;
        private System.Windows.Forms.TextBox Txt_usernameMod;
        private System.Windows.Forms.MaskedTextBox mtxt_CuitMod;
    }
}