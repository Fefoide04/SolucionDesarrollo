using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Data;

namespace DesarrolloLAP_SYSTEMS
{
    class metodos
    {
        public static void cambiarFormulario(Form formulario, Panel panel)
        {
            formulario.TopLevel = false;

            panel.Controls.Clear();

            panel.Controls.Add(formulario);

            formulario.Show();
        }

        //Metodo en el que puedo meter una tecla y recuperar un booleano que me devuelve
        //false si es un numero, espacio, tecla suprimir o tecla borrar.
        //Devuele true si la tecla es cualquier otra cosa
        public static bool validacionCampoNumerico(KeyPressEventArgs e)
        {
            return !(char.IsNumber(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == 127 || e.KeyChar == 08);
        }

        //El mismo metodo que antes, pero en vez de permitir numeros permito letras
        public static bool validacionCampoTexto(KeyPressEventArgs e)
        {
            return !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == 127 || e.KeyChar == 08);
        }

        //Ahora solo permite letras y numeros, este se va a usar para los nombres de usuario
        public static bool validacionCampoTextoDigitos(KeyPressEventArgs e)
        {
            return !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == 127 || e.KeyChar == 08);
        }

        //Este metodo recorre un string y se asegura de que haya solo una arroba y un punto
        public static bool validarEmail(string cadena)
        {
            int c = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '@' || cadena[i] == '.')
                    c++;
            }

            return c == 2;
        }

        //Este codigo recibe un bool para devolver 1 o 0
        //Se usa porque los booleanos en la BD están como INTEGER para trabajar con 1 y 0 en vez de "True o False"
        public static int boolANumero(bool chequeado)
        {
            if (chequeado)
                return 1;
            else
                return 0;
        }


        //Este codigo funciona de forma inversa
        //Recibe un bool y lo convierte a numero
        public static bool numeroABool(int chequeado)
        {
            if (chequeado == 1)
                return true;
            else
                return false;
        }

        //Genera una clave de 6 digitos usando un random y un for, despues la devuelve en forma de string
        public static string generarClave()
        {
            Random ran = new Random();

            string contraseña = "";

            int ascci = 0;

            for (int i = 0; i < 7; i++)
			{
                if (ran.Next(0, 99) <= 68)
                    contraseña = contraseña + ran.Next(0, 10);
                else
                {
                    ascci = ran.Next('a', 'z');

                    string letra = Convert.ToChar(ascci).ToString();

                    contraseña = contraseña + letra;
                }
			}

            return contraseña;
        }

        //Recibe un dato, una tabla a recorrer, una columna y una conexion con una BD
        public static bool verificarExistencia(string dato, string tabla, string nombreColumna, comandosBD BD)
        {
            DataTable tablaDatos = new DataTable();

            tablaDatos.Load(BD.consulta("SELECT * from " + tabla));

            for (int i = 0; i < tablaDatos.Rows.Count; i++)
            {
                //Compara el dato con todos los registros y si encuentra uno igual, devuelve verdadero
                if (dato == tablaDatos.Rows[i][nombreColumna].ToString())
                {
                    BD.desconectar();
                    return true;
                }
            }

            //Si consigue salir del for significa que no hubo nada identico, por lo que devuelve falso
            BD.desconectar();
            return false;
        }
    }
}
