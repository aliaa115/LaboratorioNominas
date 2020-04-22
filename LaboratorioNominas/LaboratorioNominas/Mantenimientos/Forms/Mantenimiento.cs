using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratorioNominas.Mantenimientos.Procesos;

namespace LaboratorioNominas.Mantenimientos.Forms
{
    public partial class Mantenimiento : Form
    {
        string usuario;
        int noTabla;
        int noForaneas;

        public Mantenimiento(string user, int tbl)
        {
            InitializeComponent();

            noTabla = tbl;
            usuario = user;

            Lbl_usuario.Text = user;

            Cls_Mantenimientos Mant = new Cls_Mantenimientos();

            // Arreglo de nombres para campos
            Nav_Mantenimiento.asignarAlias(Mant.datos(tbl).Item1); // Asignar nombres
            Nav_Mantenimiento.asignarSalida(this); // Asignar form de salida

            Nav_Mantenimiento.asignarColorFuente(Color.Black);
            Nav_Mantenimiento.asignarAyuda(Mant.datos(tbl).Item2); // asignar 1 por defecto 
                                                                   // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
                                                                   //navegador1.asignarComboConTabla("tabla", "campo", 0); // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id

            noForaneas = Mant.datos(tbl).Item6;
            if (noForaneas != 0)
            {
                int i = noForaneas;
                while (i != 0)
                {
                    Mant.foraneas(tbl, i);
                    Nav_Mantenimiento.asignarComboConTabla(
                        Mant.foraneas(tbl, i).Item1,
                        Mant.foraneas(tbl, i).Item2,
                        Mant.foraneas(tbl, i).Item3
                        );
                    i--;
                }
            }

            Nav_Mantenimiento.asignarTabla(Mant.datos(tbl).Item3); // tabla principal
            Nav_Mantenimiento.asignarNombreForm(" "); // Titulo y nombre del form

            //establecer nombre del form y lable
            Text = Text + Mant.datos(tbl).Item4;
            Lbl_titulo.Text = Mant.datos(tbl).Item5;
        }

        private void Nav_Mantenimiento_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1001";
            Nav_Mantenimiento.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            Nav_Mantenimiento.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            Nav_Mantenimiento.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }

    }
}
