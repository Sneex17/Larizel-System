using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.InterfacesUI.Plantillas;

namespace CPresentacion.InterfacesUI.UserControls
{
    public partial class ucClientes : ucGestion
    {
        public ucClientes()
        {
            InitializeComponent();
            CargarComponentes();
        }

        private void CargarComponentes()
        {
            cbxOpcionesFiltro.Items.Add("Hola");
            cbxOpcionesFiltro.Items.Add("adios");
            cbxOpcionesFiltro.Items.Add("queso");
        }
    }
}
