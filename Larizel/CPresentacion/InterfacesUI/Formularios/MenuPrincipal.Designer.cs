namespace CPresentacion.InterfacesUI.Formularios
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            ControlSubmenu = new MaterialSkin.Controls.MaterialTabControl();
            tabHome = new TabPage();
            tabProductos = new TabPage();
            tabCategorias = new TabPage();
            tabClientes = new TabPage();
            tabVentas = new TabPage();
            tabEmpleados = new TabPage();
            tabUsuarios = new TabPage();
            tabPagos = new TabPage();
            tabReportes = new TabPage();
            imageList = new ImageList(components);
            ControlSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // ControlSubmenu
            // 
            ControlSubmenu.Controls.Add(tabHome);
            ControlSubmenu.Controls.Add(tabProductos);
            ControlSubmenu.Controls.Add(tabCategorias);
            ControlSubmenu.Controls.Add(tabClientes);
            ControlSubmenu.Controls.Add(tabVentas);
            ControlSubmenu.Controls.Add(tabEmpleados);
            ControlSubmenu.Controls.Add(tabUsuarios);
            ControlSubmenu.Controls.Add(tabPagos);
            ControlSubmenu.Controls.Add(tabReportes);
            ControlSubmenu.Depth = 0;
            ControlSubmenu.Dock = DockStyle.Fill;
            ControlSubmenu.ImageList = imageList;
            ControlSubmenu.Location = new Point(3, 48);
            ControlSubmenu.Margin = new Padding(3, 2, 3, 2);
            ControlSubmenu.MouseState = MaterialSkin.MouseState.HOVER;
            ControlSubmenu.Multiline = true;
            ControlSubmenu.Name = "ControlSubmenu";
            ControlSubmenu.SelectedIndex = 0;
            ControlSubmenu.Size = new Size(994, 600);
            ControlSubmenu.TabIndex = 0;
            ControlSubmenu.SelectedIndexChanged += ControlSubmenu_SelectedIndexChanged;
            // 
            // tabHome
            // 
            tabHome.ImageKey = "Home.png";
            tabHome.Location = new Point(4, 39);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(986, 557);
            tabHome.TabIndex = 7;
            tabHome.Text = "Inicio";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // tabProductos
            // 
            tabProductos.ImageKey = "Productos.png";
            tabProductos.Location = new Point(4, 74);
            tabProductos.Margin = new Padding(3, 2, 3, 2);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(3, 2, 3, 2);
            tabProductos.Size = new Size(886, 472);
            tabProductos.TabIndex = 0;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // tabCategorias
            // 
            tabCategorias.ImageKey = "Categorias.png";
            tabCategorias.Location = new Point(4, 74);
            tabCategorias.Margin = new Padding(3, 2, 3, 2);
            tabCategorias.Name = "tabCategorias";
            tabCategorias.Padding = new Padding(3, 2, 3, 2);
            tabCategorias.Size = new Size(886, 472);
            tabCategorias.TabIndex = 1;
            tabCategorias.Text = "Categorías";
            tabCategorias.UseVisualStyleBackColor = true;
            // 
            // tabClientes
            // 
            tabClientes.ImageKey = "Clientes.png";
            tabClientes.Location = new Point(4, 74);
            tabClientes.Margin = new Padding(3, 2, 3, 2);
            tabClientes.Name = "tabClientes";
            tabClientes.Size = new Size(886, 472);
            tabClientes.TabIndex = 2;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabVentas
            // 
            tabVentas.ImageKey = "Ventas.png";
            tabVentas.Location = new Point(4, 74);
            tabVentas.Name = "tabVentas";
            tabVentas.Size = new Size(886, 472);
            tabVentas.TabIndex = 5;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // tabEmpleados
            // 
            tabEmpleados.ImageKey = "Empleados.png";
            tabEmpleados.Location = new Point(4, 74);
            tabEmpleados.Name = "tabEmpleados";
            tabEmpleados.Size = new Size(886, 472);
            tabEmpleados.TabIndex = 3;
            tabEmpleados.Text = "Empleados";
            tabEmpleados.UseVisualStyleBackColor = true;
            // 
            // tabUsuarios
            // 
            tabUsuarios.ImageKey = "Usuarios.png";
            tabUsuarios.Location = new Point(4, 74);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Size = new Size(886, 472);
            tabUsuarios.TabIndex = 4;
            tabUsuarios.Text = "Usuarios";
            tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabPagos
            // 
            tabPagos.ImageKey = "Creditos.png";
            tabPagos.Location = new Point(4, 74);
            tabPagos.Name = "tabPagos";
            tabPagos.Size = new Size(886, 472);
            tabPagos.TabIndex = 6;
            tabPagos.Text = "Pagos de ventas";
            tabPagos.UseVisualStyleBackColor = true;
            // 
            // tabReportes
            // 
            tabReportes.ImageKey = "Reportes.png";
            tabReportes.Location = new Point(4, 74);
            tabReportes.Name = "tabReportes";
            tabReportes.Size = new Size(886, 472);
            tabReportes.TabIndex = 8;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "Home.png");
            imageList.Images.SetKeyName(1, "Categorias.png");
            imageList.Images.SetKeyName(2, "Clientes.png");
            imageList.Images.SetKeyName(3, "Creditos.png");
            imageList.Images.SetKeyName(4, "Empleados.png");
            imageList.Images.SetKeyName(5, "Productos.png");
            imageList.Images.SetKeyName(6, "Usuarios.png");
            imageList.Images.SetKeyName(7, "Ventas.png");
            imageList.Images.SetKeyName(8, "Reportes.png");
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(ControlSubmenu);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = ControlSubmenu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Larizel - Menu pricipal";
            ControlSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl ControlSubmenu;
        private TabPage tabProductos;
        private TabPage tabCategorias;
        private TabPage tabClientes;
        private TabPage tabEmpleados;
        private TabPage tabVentas;
        private TabPage tabUsuarios;
        private TabPage tabPagos;
        private TabPage tabHome;
        private ImageList imageList;
        private TabPage tabReportes;
    }
}