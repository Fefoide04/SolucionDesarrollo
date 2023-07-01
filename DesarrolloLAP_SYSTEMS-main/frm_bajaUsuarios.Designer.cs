namespace DesarrolloLAP_SYSTEMS
{
    partial class frm_bajaUsuarios
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
            this.Txt_NombreUserBaja = new System.Windows.Forms.TextBox();
            this.Btn_BajaUser = new System.Windows.Forms.Button();
            this.Cmb_TiempoBaja = new System.Windows.Forms.ComboBox();
            this.Lbl_MensajeBaja = new System.Windows.Forms.Label();
            this.Lbl_InformacionBaja = new System.Windows.Forms.Label();
            this.Lbl_TituloBaja = new System.Windows.Forms.Label();
            this.Pic_LogoBaja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LogoBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_NombreUserBaja
            // 
            this.Txt_NombreUserBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreUserBaja.Location = new System.Drawing.Point(43, 130);
            this.Txt_NombreUserBaja.Name = "Txt_NombreUserBaja";
            this.Txt_NombreUserBaja.Size = new System.Drawing.Size(363, 38);
            this.Txt_NombreUserBaja.TabIndex = 48;
            // 
            // Btn_BajaUser
            // 
            this.Btn_BajaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BajaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BajaUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BajaUser.Location = new System.Drawing.Point(43, 349);
            this.Btn_BajaUser.Name = "Btn_BajaUser";
            this.Btn_BajaUser.Size = new System.Drawing.Size(243, 50);
            this.Btn_BajaUser.TabIndex = 47;
            this.Btn_BajaUser.Text = "Dar baja usuario\r\n";
            this.Btn_BajaUser.UseVisualStyleBackColor = true;
            // 
            // Cmb_TiempoBaja
            // 
            this.Cmb_TiempoBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TiempoBaja.FormattingEnabled = true;
            this.Cmb_TiempoBaja.Items.AddRange(new object[] {
            "Permanente",
            "Momentanea"});
            this.Cmb_TiempoBaja.Location = new System.Drawing.Point(43, 289);
            this.Cmb_TiempoBaja.Name = "Cmb_TiempoBaja";
            this.Cmb_TiempoBaja.Size = new System.Drawing.Size(363, 39);
            this.Cmb_TiempoBaja.TabIndex = 46;
            // 
            // Lbl_MensajeBaja
            // 
            this.Lbl_MensajeBaja.AutoSize = true;
            this.Lbl_MensajeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MensajeBaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_MensajeBaja.Location = new System.Drawing.Point(37, 89);
            this.Lbl_MensajeBaja.Name = "Lbl_MensajeBaja";
            this.Lbl_MensajeBaja.Size = new System.Drawing.Size(389, 248);
            this.Lbl_MensajeBaja.TabIndex = 45;
            this.Lbl_MensajeBaja.Text = "Se enviara un correo a \r\n\r\n\r\nde que su cuenta en la \r\naplicacion de LAP_Systems\r\n" +
                "a sido dada de baja de forma\r\n\r\n\r\n";
            // 
            // Lbl_InformacionBaja
            // 
            this.Lbl_InformacionBaja.AutoSize = true;
            this.Lbl_InformacionBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InformacionBaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_InformacionBaja.Location = new System.Drawing.Point(642, 171);
            this.Lbl_InformacionBaja.Name = "Lbl_InformacionBaja";
            this.Lbl_InformacionBaja.Size = new System.Drawing.Size(416, 217);
            this.Lbl_InformacionBaja.TabIndex = 44;
            this.Lbl_InformacionBaja.Text = "         Bajas de usuarios\r\nPantalla donde se dara de baja\r\na los usuarios ingres" +
                "ados de \r\nmanera momentanea (Por\r\nlicencia,vacaciones, etc) o\r\nde forma permanen" +
                "te (Por\r\nfallecimiento, renuncia, etc )";
            // 
            // Lbl_TituloBaja
            // 
            this.Lbl_TituloBaja.AutoSize = true;
            this.Lbl_TituloBaja.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloBaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_TituloBaja.Location = new System.Drawing.Point(12, 9);
            this.Lbl_TituloBaja.Name = "Lbl_TituloBaja";
            this.Lbl_TituloBaja.Size = new System.Drawing.Size(370, 68);
            this.Lbl_TituloBaja.TabIndex = 42;
            this.Lbl_TituloBaja.Text = "Baja Usuarios";
            // 
            // Pic_LogoBaja
            // 
            this.Pic_LogoBaja.BackgroundImage = global::DesarrolloLAP_SYSTEMS.Properties.Resources.Logo_LAP;
            this.Pic_LogoBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_LogoBaja.Location = new System.Drawing.Point(648, 76);
            this.Pic_LogoBaja.Name = "Pic_LogoBaja";
            this.Pic_LogoBaja.Size = new System.Drawing.Size(399, 92);
            this.Pic_LogoBaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_LogoBaja.TabIndex = 43;
            this.Pic_LogoBaja.TabStop = false;
            // 
            // frm_bajaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.Txt_NombreUserBaja);
            this.Controls.Add(this.Btn_BajaUser);
            this.Controls.Add(this.Cmb_TiempoBaja);
            this.Controls.Add(this.Lbl_MensajeBaja);
            this.Controls.Add(this.Lbl_InformacionBaja);
            this.Controls.Add(this.Pic_LogoBaja);
            this.Controls.Add(this.Lbl_TituloBaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_bajaUsuarios";
            this.Text = "frm_bajaUsuarios";
            this.Load += new System.EventHandler(this.frm_bajaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LogoBaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_NombreUserBaja;
        private System.Windows.Forms.Button Btn_BajaUser;
        private System.Windows.Forms.ComboBox Cmb_TiempoBaja;
        private System.Windows.Forms.Label Lbl_MensajeBaja;
        private System.Windows.Forms.Label Lbl_InformacionBaja;
        private System.Windows.Forms.PictureBox Pic_LogoBaja;
        private System.Windows.Forms.Label Lbl_TituloBaja;
    }
}