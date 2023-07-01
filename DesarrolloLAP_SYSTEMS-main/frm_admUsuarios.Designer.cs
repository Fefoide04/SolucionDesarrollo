namespace DesarrolloLAP_SYSTEMS
{
    partial class frm_admUsuarios
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
            this.btn_altaUsuarios = new System.Windows.Forms.Button();
            this.lbl_tituloAdmUsuarios = new System.Windows.Forms.Label();
            this.txt_busquedaAdmUsuarios = new System.Windows.Forms.TextBox();
            this.cmb_filtroAdmUsuarios = new System.Windows.Forms.ComboBox();
            this.dtg_admUsuarios = new System.Windows.Forms.DataGridView();
            this.pic_buscarAdmUsuarios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_admUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_buscarAdmUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_altaUsuarios
            // 
            this.btn_altaUsuarios.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_altaUsuarios.Location = new System.Drawing.Point(44, 554);
            this.btn_altaUsuarios.Name = "btn_altaUsuarios";
            this.btn_altaUsuarios.Size = new System.Drawing.Size(160, 38);
            this.btn_altaUsuarios.TabIndex = 3;
            this.btn_altaUsuarios.Text = "Alta Usuarios";
            this.btn_altaUsuarios.UseVisualStyleBackColor = true;
            this.btn_altaUsuarios.Click += new System.EventHandler(this.btn_altaUsuarios_Click);
            // 
            // lbl_tituloAdmUsuarios
            // 
            this.lbl_tituloAdmUsuarios.AutoSize = true;
            this.lbl_tituloAdmUsuarios.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloAdmUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tituloAdmUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lbl_tituloAdmUsuarios.Name = "lbl_tituloAdmUsuarios";
            this.lbl_tituloAdmUsuarios.Size = new System.Drawing.Size(724, 68);
            this.lbl_tituloAdmUsuarios.TabIndex = 22;
            this.lbl_tituloAdmUsuarios.Text = "Administracion de Usuarios";
            // 
            // txt_busquedaAdmUsuarios
            // 
            this.txt_busquedaAdmUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaAdmUsuarios.Location = new System.Drawing.Point(44, 99);
            this.txt_busquedaAdmUsuarios.Name = "txt_busquedaAdmUsuarios";
            this.txt_busquedaAdmUsuarios.Size = new System.Drawing.Size(852, 31);
            this.txt_busquedaAdmUsuarios.TabIndex = 0;
            // 
            // cmb_filtroAdmUsuarios
            // 
            this.cmb_filtroAdmUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtroAdmUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filtroAdmUsuarios.FormattingEnabled = true;
            this.cmb_filtroAdmUsuarios.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Nom. Usuario",
            "Grupo Usuario",
            "CUIT"});
            this.cmb_filtroAdmUsuarios.Location = new System.Drawing.Point(902, 99);
            this.cmb_filtroAdmUsuarios.Name = "cmb_filtroAdmUsuarios";
            this.cmb_filtroAdmUsuarios.Size = new System.Drawing.Size(110, 28);
            this.cmb_filtroAdmUsuarios.TabIndex = 1;
            // 
            // dtg_admUsuarios
            // 
            this.dtg_admUsuarios.AllowUserToAddRows = false;
            this.dtg_admUsuarios.AllowUserToDeleteRows = false;
            this.dtg_admUsuarios.AllowUserToResizeColumns = false;
            this.dtg_admUsuarios.AllowUserToResizeRows = false;
            this.dtg_admUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_admUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_admUsuarios.Location = new System.Drawing.Point(44, 136);
            this.dtg_admUsuarios.MultiSelect = false;
            this.dtg_admUsuarios.Name = "dtg_admUsuarios";
            this.dtg_admUsuarios.ReadOnly = true;
            this.dtg_admUsuarios.RowHeadersVisible = false;
            this.dtg_admUsuarios.Size = new System.Drawing.Size(968, 412);
            this.dtg_admUsuarios.TabIndex = 2;
            this.dtg_admUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_admUsuarios_CellDoubleClick);
            // 
            // pic_buscarAdmUsuarios
            // 
            this.pic_buscarAdmUsuarios.BackgroundImage = global::DesarrolloLAP_SYSTEMS.Properties.Resources.busqueda;
            this.pic_buscarAdmUsuarios.Location = new System.Drawing.Point(7, 102);
            this.pic_buscarAdmUsuarios.Name = "pic_buscarAdmUsuarios";
            this.pic_buscarAdmUsuarios.Size = new System.Drawing.Size(31, 28);
            this.pic_buscarAdmUsuarios.TabIndex = 21;
            this.pic_buscarAdmUsuarios.TabStop = false;
            // 
            // frm_admUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.btn_altaUsuarios);
            this.Controls.Add(this.lbl_tituloAdmUsuarios);
            this.Controls.Add(this.pic_buscarAdmUsuarios);
            this.Controls.Add(this.txt_busquedaAdmUsuarios);
            this.Controls.Add(this.cmb_filtroAdmUsuarios);
            this.Controls.Add(this.dtg_admUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_admUsuarios";
            this.Text = "frm_admUsuarios";
            this.Load += new System.EventHandler(this.frm_admUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_admUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_buscarAdmUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_altaUsuarios;
        private System.Windows.Forms.Label lbl_tituloAdmUsuarios;
        private System.Windows.Forms.PictureBox pic_buscarAdmUsuarios;
        private System.Windows.Forms.TextBox txt_busquedaAdmUsuarios;
        private System.Windows.Forms.ComboBox cmb_filtroAdmUsuarios;
        private System.Windows.Forms.DataGridView dtg_admUsuarios;
    }
}