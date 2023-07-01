using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesarrolloLAP_SYSTEMS
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();

            lbl_horaPrincipal.Text = DateTime.Now.ToString("HH:mm");
            lbl_fechaPrincipal.Text = DateTime.Now.ToString("dd/MM/yy");

            tim_horaFechaActuales.Interval = 1000;
            tim_horaFechaActuales.Start();
        }

        private void btn_admUsr_Click(object sender, EventArgs e)
        {
            frm_admUsuarios formAdministracionUsr = new frm_admUsuarios(this);

            metodos.cambiarFormulario(formAdministracionUsr, pnl_displayFormsPrincipal);
        }

        private void pic_cerrarPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_maximizarPrincipal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            pic_maximizarPrincipal.Visible = false;
            pic_modoVentanaPrincipal.Visible = true;
        }

        private void pic_modoVentanaPrincipal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            pic_maximizarPrincipal.Visible = true;
            pic_modoVentanaPrincipal.Visible = false;
        }

        private void pic_minimizarPrincipal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tim_horaFechaActuales_Tick(object sender, EventArgs e)
        {
            lbl_horaPrincipal.Text = DateTime.Now.ToString("HH:mm");
            lbl_fechaPrincipal.Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void pnl_displayFormsPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
