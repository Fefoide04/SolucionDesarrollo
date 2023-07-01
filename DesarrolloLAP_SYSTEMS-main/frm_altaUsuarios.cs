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
    public partial class frm_altaUsuarios : Form
    {
        comandosBD BD = new comandosBD();

        frm_admUsuarios formAdministracion;
        frm_principal formPrincipal;

        public frm_altaUsuarios(frm_admUsuarios formPadre, frm_principal formularioPrincipal)
        {
            InitializeComponent();

            formAdministracion = formPadre;

            formPrincipal = formularioPrincipal;
        }

        private void btn_regresarAltaUsuarios_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(formAdministracion, formPrincipal.pnl_displayFormsPrincipal);

            formAdministracion.actualizarDTG();

            this.Close();
        }

        private void btn_darAltaUsuarios_Click(object sender, EventArgs e)
        {

            if (Txt_NombreAlta.Text.Trim() == "" || Txt_ApellidoAlta.Text.Trim() == "" || mtxt_CuitAlta.Text.Trim() == "" || Txt_EmailAlta.Text.Trim() == "" || Txt_TelefonoAlta.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Genero la clave antes de dar de alta, esto es para despues poder compararla con todas las demas claves
            //y estar seguro de que no haya repetidas

            string clave = metodos.generarClave();

            //Verifico mediante un metodo si la clave existe
            //Si da true, itera hasta encontrar una clave inexistente

            //El problema con esto es que puede ser que todas las claves esten usadas, cosa que seria muy improbable
            //Pero sumaria puntos comprender una excepcion de bucle infinito

            while (metodos.verificarExistencia(clave, "usuarios", "clave", BD))
            {
                clave = metodos.generarClave();
            }

            if(metodos.verificarExistencia(mtxt_CuitAlta.Text, "usuarios", "CUIT", BD))
            {
                MessageBox.Show("El CUIL ingresado ya existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BD.ABM("INSERT into personas (CUIL_CUIT, nombre, apellido) " +
            "VALUES(" + "'" + mtxt_CuitAlta.Text + "'" + "," + "'" + Txt_NombreAlta.Text + "'" + "," + "'" + Txt_ApellidoAlta.Text + "'" + ")") &&

            //Cuando se inserta el usuario se genera el nombre de usuario concatenando nombre y apellido
            BD.ABM("INSERT into usuarios (nomUsuario, CUIT, activo, clave, email, telefono) " +
            "VALUES(" + "'" + Txt_ApellidoAlta.Text.Trim() + Txt_NombreAlta.Text.Trim() + "'" + "," + "'" + mtxt_CuitAlta.Text + "'" + "," + metodos.boolANumero(rbtn_ActivoAlta.Checked) + "," + "'" + clave + "'" + "," + "'" + Txt_EmailAlta.Text + "'" + "," + "'" + Txt_TelefonoAlta.Text + "'" + ")"))
            {
                MessageBox.Show("Se ha dado de alta al usuario " + Txt_NombreAlta.Text + " " + Txt_ApellidoAlta.Text + " de forma correcta", "Alta usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_ApellidoAlta.Clear();
                mtxt_CuitAlta.Clear();
                Txt_EmailAlta.Clear();
                Txt_NombreAlta.Clear();
                Txt_TelefonoAlta.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxt_CuitAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoNumerico(e);
        }

        private void Txt_TelefonoAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoNumerico(e);
        }

        private void Txt_EmailAlta_Leave(object sender, EventArgs e)
        {
            if(metodos.validarEmail(Txt_EmailAlta.Text) == false && Txt_EmailAlta.Text != "")
            {
                MessageBox.Show("Verifique el formato del EMAIL ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_NombreAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoTexto(e);
        }

        private void Txt_ApellidoAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoTexto(e);
        }

        private void Txt_EmailAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }
    }
}
