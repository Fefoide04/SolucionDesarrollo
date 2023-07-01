using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DesarrolloLAP_SYSTEMS;

namespace DesarrolloLAP_SYSTEMS
{
    public partial class frm_admUsuarios : Form
    {
        //Instancia de los comandos de conexion a la base de datos
        comandosBD BD = new comandosBD();

        //Tabla en la cual vamos a guardar los resultados de las consultas
        DataTable tabla = new DataTable();

        frm_principal formPrincipal;

        public frm_admUsuarios(frm_principal formPadre)
        {
            InitializeComponent();

            formPrincipal = formPadre; 
        }

        private void btn_altaUsuarios_Click(object sender, EventArgs e)
        {
            frm_altaUsuarios formAlta = new frm_altaUsuarios(this, formPrincipal);

            metodos.cambiarFormulario(formAlta, formPrincipal.pnl_displayFormsPrincipal);
        }

        private void frm_admUsuarios_Load(object sender, EventArgs e)
        {
            actualizarDTG();
        }

        public void actualizarDTG()
        {
            //Limpio la tabla para que se refresque en vez de mostrar datos previos
            tabla.Clear();

            //Cargo la tabla con el resultado de consultar la tabla usuarios
            tabla.Load(BD.consulta("SELECT usuarios.id_usuario, usuarios.nomUsuario, personas.nombre, personas.apellido, usuarios.activo from usuarios inner join personas on usuarios.CUIT = personas.CUIL_CUIT"));

            /*Aca falta:
            1-Que la actividad se vea como un check box en vez de como un 1/0
            2-Que los nombres de las columnas no sean los default sino unos mas esteticos
            3-Cambiar la fuente del dtg
            4-Que las columnas no se puedan ordenar al clickear el encabezado*/

            //Establezco la tabla como origen de datos para el data grid
            dtg_admUsuarios.DataSource = tabla;

            //Cierro la conexion una vez terminada correctamente la consulta
            BD.desconectar();
        }

        private void dtg_admUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_modUsuarios formModificacion = new frm_modUsuarios(this, formPrincipal, Convert.ToInt32(dtg_admUsuarios[0, dtg_admUsuarios.SelectedCells[0].RowIndex].Value));

            metodos.cambiarFormulario(formModificacion, formPrincipal.pnl_displayFormsPrincipal);
        }
    }
}
