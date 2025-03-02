using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            PanelSeleccion.Visible = false;
        }

        private void btnOcultarMenu_Click(object sender, EventArgs e)
        {
            if(PanelMenu.Width==200)
            {
                PanelMenu.Width = 40;
            }
            else
            {
                PanelMenu.Width=200;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            PanelSeleccion.Top = btnClientes.Top; // Ajustar la posición de altura
            PanelSeleccion.Height = btnClientes.Height; // Ajustar el tamaño
            PanelSeleccion.Visible=true; // hacer visible el boton

            Formulario1 frm1 = new Formulario1();
            if(this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
                frm1.TopLevel = false;
                frm1.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(frm1);
                this.PanelContenedor.Tag = frm1;
                frm1.Show();
            }

            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //PanelSeleccion.Top = btnClientes.Top; // Ajustar la posición de altura
            //PanelSeleccion.Height = btnClientes.Height; // Ajustar el tamaño
            //PanelSeleccion.Visible = true; // hacer visible el boton

            //FrmCuentas frmCue = new FrmCuentas();
            //if (this.PanelContenedor.Controls.Count > 0)
            //{
            //    this.PanelContenedor.Controls.RemoveAt(0);
            //    frmCue.TopLevel = false;
            //    frmCue.Dock = DockStyle.Fill;
            //    this.PanelContenedor.Controls.Add(frmCue);
            //    this.PanelContenedor.Tag = frmCue;
            //    frmCue.Show();
            //}


        }
    }
}
