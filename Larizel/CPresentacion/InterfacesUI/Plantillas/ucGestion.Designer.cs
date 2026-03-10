namespace CPresentacion.InterfacesUI.Plantillas
{
    partial class ucGestion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelInfo = new Panel();
            label1 = new Label();
            panelContainer = new Panel();
            viewData = new DataGridView();
            label7 = new Label();
            textboxFiltro = new ReaLTaiizor.Controls.DungeonTextBox();
            cbxOpcionesFiltro = new ReaLTaiizor.Controls.AloneComboBox();
            panelInfo.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewData).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(77, 182, 198);
            panelInfo.Controls.Add(label1);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(986, 63);
            panelInfo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 26);
            label1.TabIndex = 5;
            label1.Text = "Text";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(250, 248, 240);
            panelContainer.Controls.Add(cbxOpcionesFiltro);
            panelContainer.Controls.Add(label7);
            panelContainer.Controls.Add(textboxFiltro);
            panelContainer.Controls.Add(viewData);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 63);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(986, 494);
            panelContainer.TabIndex = 1;
            // 
            // viewData
            // 
            viewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewData.Location = new Point(30, 242);
            viewData.Name = "viewData";
            viewData.Size = new Size(882, 249);
            viewData.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(30, 208);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 13;
            label7.Text = "Filtro de busqueda";
            // 
            // textboxFiltro
            // 
            textboxFiltro.BackColor = Color.Transparent;
            textboxFiltro.BorderColor = Color.FromArgb(180, 180, 180);
            textboxFiltro.EdgeColor = Color.White;
            textboxFiltro.Font = new Font("Tahoma", 11F);
            textboxFiltro.ForeColor = Color.DimGray;
            textboxFiltro.Location = new Point(189, 208);
            textboxFiltro.MaxLength = 32767;
            textboxFiltro.Multiline = false;
            textboxFiltro.Name = "textboxFiltro";
            textboxFiltro.ReadOnly = false;
            textboxFiltro.Size = new Size(465, 28);
            textboxFiltro.TabIndex = 12;
            textboxFiltro.TextAlignment = HorizontalAlignment.Left;
            textboxFiltro.UseSystemPasswordChar = false;
            // 
            // cbxOpcionesFiltro
            // 
            cbxOpcionesFiltro.DrawMode = DrawMode.OwnerDrawFixed;
            cbxOpcionesFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOpcionesFiltro.EnabledCalc = true;
            cbxOpcionesFiltro.FormattingEnabled = true;
            cbxOpcionesFiltro.ItemHeight = 20;
            cbxOpcionesFiltro.Location = new Point(683, 208);
            cbxOpcionesFiltro.Name = "cbxOpcionesFiltro";
            cbxOpcionesFiltro.Size = new Size(229, 26);
            cbxOpcionesFiltro.TabIndex = 15;
            // 
            // ucGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Controls.Add(panelInfo);
            Name = "ucGestion";
            Size = new Size(986, 557);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelInfo;
        public Panel panelContainer;
        public Label label1;
        public DataGridView viewData;
        public ReaLTaiizor.Controls.AloneComboBox cbxOpcionesFiltro;
        private Label label7;
        public ReaLTaiizor.Controls.DungeonTextBox textboxFiltro;
    }
}
