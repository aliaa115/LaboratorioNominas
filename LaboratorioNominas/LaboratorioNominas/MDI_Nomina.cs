using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LaboratorioNominas.Mantenimientos.Forms;
using CapaDiseno;

namespace LaboratorioNominas
{
    public partial class MDI_Nomina : Form
    {
        string usuario; 
        public MDI_Nomina()
        {
            InitializeComponent();
        }
        /*
        private void mant(int tabla)
        {
            Mantenimiento mantenimiento = new Mantenimiento(usuario, tabla);
            mantenimiento.Show();
            mantenimiento.TopLevel = false;
            mantenimiento.TopMost = true;
            panel1.Controls.Add(mantenimiento);
        }
        */
        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad("");
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }

        private void MDI_Nomina_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuario = Lbl_usuario.Text;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mant(1);
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mant(2);
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mant(5);
        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mant(4);
        }
    }
}
