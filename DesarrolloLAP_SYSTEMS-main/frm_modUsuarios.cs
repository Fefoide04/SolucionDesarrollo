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
    public partial class frm_modUsuarios : Form
    {
        comandosBD BD = new comandosBD();

        frm_admUsuarios formAdministracion;
        frm_principal formPrincipal;

        DataTable registroUsuario = new DataTable();

        DataTable registroPersona = new DataTable();

        int id;

        string cuilPersona, emailUsuario, nombreUsuario, telefonoUsuario;
  
        public frm_modUsuarios(frm_admUsuarios formPadre, frm_principal formularioPrincipal, int idUsuario)
        {
            InitializeComponent();

            formAdministracion = formPadre;

            formPrincipal = formularioPrincipal;

            id = idUsuario;
        }

        private void Txt_NombreMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoTexto(e);
        }

        private void Txt_ApellidoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoTexto(e);
        }

        private void mtxt_CuitMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoNumerico(e);
        }

        private void Txt_EmailMod_Leave(object sender, EventArgs e)
        {
            if (metodos.validarEmail(Txt_EmailMod.Text) == false)
            {
                MessageBox.Show("Verifique el formato del EMAIL ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_TelefonoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoNumerico(e);
        }

        private void btn_regresarModUsuarios_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(formAdministracion, formPrincipal.pnl_displayFormsPrincipal);

            formAdministracion.actualizarDTG();

            this.Close();
        }

        private void frm_modUsuarios_Load(object sender, EventArgs e)
        {
            registroUsuario.Load(BD.consulta("SELECT * from usuarios where id_usuario = " + id));

            BD.desconectar();

            registroPersona.Load(BD.consulta("SELECT * from personas where CUIL_CUIT = " + "'" + registroUsuario.Rows[0][2].ToString() + "'"));

            BD.desconectar();

            cuilPersona = registroPersona.Rows[0][1].ToString();
            emailUsuario = registroUsuario.Rows[0][5].ToString();
            telefonoUsuario = registroUsuario.Rows[0][6].ToString();
            nombreUsuario = registroUsuario.Rows[0][1].ToString();

            Txt_NombreMod.Text = registroPersona.Rows[0][2].ToString();
            Txt_ApellidoMod.Text = registroPersona.Rows[0][3].ToString();

            mtxt_CuitMod.Text = cuilPersona;
            Txt_EmailMod.Text = emailUsuario;
            Txt_TelefonoMod.Text = telefonoUsuario;
            Txt_usernameMod.Text = nombreUsuario;

            rbtn_ActivoMod.Checked = metodos.numeroABool(Convert.ToInt32(registroUsuario.Rows[0][3]));
            rbtn_InactivoMod.Checked = !(metodos.numeroABool(Convert.ToInt32(registroUsuario.Rows[0][3])));
        }

        private void btn_modificarUsuarios_Click(object sender, EventArgs e)
        {
            if (Txt_NombreMod.Text.Trim() == "" || Txt_ApellidoMod.Text.Trim() == "" || mtxt_CuitMod.Text.Trim() == ""
                || Txt_EmailMod.Text.Trim() == "" || Txt_TelefonoMod.Text.Trim() == "" || Txt_usernameMod.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (metodos.verificarExistencia(mtxt_CuitMod.Text, "usuarios", "CUIT", BD) && mtxt_CuitMod.Text != cuilPersona)
            {
                MessageBox.Show("El CUIL ingresado ya existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(metodos.verificarExistencia(Txt_usernameMod.Text, "usuarios", "nomUsuario", BD) && Txt_usernameMod.Text != nombreUsuario)
            {
                MessageBox.Show("El nombre de usuario ingresado ya existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BD.ABM("UPDATE usuarios SET nomUsuario = " + "'" + Txt_usernameMod.Text + "'" + ", " + "CUIT = " + "'" + mtxt_CuitMod.Text + "'" + ", " + 
                "activo = " + metodos.boolANumero(rbtn_ActivoMod.Checked) +
                ", " + "email = " + "'" + Txt_EmailMod.Text + "'" + ", " + "telefono = " + "'" + Txt_TelefonoMod.Text + "'" +
                " WHERE id_usuario = " + id)
                &&
                BD.ABM("UPDATE personas SET CUIL_CUIT = " + mtxt_CuitMod.Text + ", " + "nombre = " + "'" + Txt_NombreMod.Text + "'" + ", " + "apellido = " + "'" + Txt_ApellidoMod.Text + "'" +
                "WHERE CUIL_CUIT = " + cuilPersona))
            {
                MessageBox.Show("Se ha modificado al usuario " + Txt_usernameMod.Text + " de forma correcta", "Modificación usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_regresarModUsuarios_Click(null, null);
            }
        }

        private void Txt_usernameMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = metodos.validacionCampoTextoDigitos(e);
        }
    }
}
