using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CPresentacion.InterfacesUI.UserControls;

namespace CPresentacion.InterfacesUI.Formularios
{
    public partial class MenuPrincipal : MaterialForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            CargarComponentes();
        }

        private void CargarComponentes()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Color.FromArgb(0x4D, 0xB6, 0xC6),  // Primary       #4DB6C6
                Color.FromArgb(0x2A, 0x8F, 0xA8),  // Dark Primary  #2A8FA8
                Color.FromArgb(0xF4, 0xF6, 0xFB),  // Light Primary #F4F6FB
                Color.FromArgb(0x42, 0xA5, 0xF5),  // Accent        #42A5F5
                TextShade.WHITE
            );
        }

        private void ControlSubmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ControlSubmenu.SelectedTab == tabClientes 
                && tabClientes.Controls.Count == 0)
            {
                ucClientes clientes = new ucClientes();
                clientes.Dock = DockStyle.Fill;
                tabClientes.Controls.Add(clientes);
            }
        }
    }
}
