using MaterialSkin;
using MaterialSkin.Controls;
using System.Security.Cryptography;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CPresentacion.InterfacesUI.Formularios;

namespace CPresentacion
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            CargarComponentes();
        }
        private void CargarComponentes()
        {
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Color.FromArgb(0x4D, 0xB6, 0xC6),  // Primary       #4F52BA
            //    Color.FromArgb(0x3D, 0x3D, 0x8F),  // Dark Primary  #3D3D8F
            //    Color.FromArgb(0xF4, 0xF6, 0xFB),  // Light Primary #F4F6FB
            //    Color.FromArgb(0x42, 0xA5, 0xF5),  // Accent        #42A5F5
            //    TextShade.WHITE
            //);

            textbPassword.UseSystemPasswordChar = true;
        }
        

        private void BuAcceder_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void BuVerPassword_Click(object sender, EventArgs e)
        {
            if(BuVerPassword.IconChar == IconChar.Eye)
            {
                textbPassword.UseSystemPasswordChar = false;
                BuVerPassword.IconChar = IconChar.EyeSlash;
            }
            else
            {
                textbPassword.UseSystemPasswordChar = true;
                BuVerPassword.IconChar = IconChar.Eye;
            }
        }
    }
}
