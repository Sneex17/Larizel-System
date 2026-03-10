namespace CPresentacion.InterfacesUI.UserControls
{
    partial class ucClientes
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
            textbCodigoCliente = new ReaLTaiizor.Controls.DungeonTextBox();
            label2 = new Label();
            label3 = new Label();
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            label4 = new Label();
            dungeonTextBox2 = new ReaLTaiizor.Controls.DungeonTextBox();
            label5 = new Label();
            dungeonTextBox3 = new ReaLTaiizor.Controls.DungeonTextBox();
            label6 = new Label();
            dungeonTextBox4 = new ReaLTaiizor.Controls.DungeonTextBox();
            label7 = new Label();
            dungeonTextBox5 = new ReaLTaiizor.Controls.DungeonTextBox();
            panelInfo.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(label5);
            panelContainer.Controls.Add(dungeonTextBox3);
            panelContainer.Controls.Add(label6);
            panelContainer.Controls.Add(dungeonTextBox4);
            panelContainer.Controls.Add(label7);
            panelContainer.Controls.Add(dungeonTextBox5);
            panelContainer.Controls.Add(label4);
            panelContainer.Controls.Add(dungeonTextBox2);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(dungeonTextBox1);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(textbCodigoCliente);
            panelContainer.Controls.SetChildIndex(textbCodigoCliente, 0);
            panelContainer.Controls.SetChildIndex(label2, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox1, 0);
            panelContainer.Controls.SetChildIndex(label3, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox2, 0);
            panelContainer.Controls.SetChildIndex(label4, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox5, 0);
            panelContainer.Controls.SetChildIndex(label7, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox4, 0);
            panelContainer.Controls.SetChildIndex(label6, 0);
            panelContainer.Controls.SetChildIndex(dungeonTextBox3, 0);
            panelContainer.Controls.SetChildIndex(label5, 0);
            // 
            // label1
            // 
            label1.Size = new Size(201, 26);
            label1.Text = "Gestión de clientes";
            // 
            // textbCodigoCliente
            // 
            textbCodigoCliente.BackColor = Color.Transparent;
            textbCodigoCliente.BorderColor = Color.FromArgb(180, 180, 180);
            textbCodigoCliente.EdgeColor = Color.White;
            textbCodigoCliente.Enabled = false;
            textbCodigoCliente.Font = new Font("Tahoma", 11F);
            textbCodigoCliente.ForeColor = Color.DimGray;
            textbCodigoCliente.Location = new Point(64, 55);
            textbCodigoCliente.MaxLength = 32767;
            textbCodigoCliente.Multiline = false;
            textbCodigoCliente.Name = "textbCodigoCliente";
            textbCodigoCliente.ReadOnly = false;
            textbCodigoCliente.Size = new Size(186, 28);
            textbCodigoCliente.TabIndex = 2;
            textbCodigoCliente.TextAlignment = HorizontalAlignment.Left;
            textbCodigoCliente.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(64, 31);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 5;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(278, 31);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Font = new Font("Tahoma", 11F);
            dungeonTextBox1.ForeColor = Color.DimGray;
            dungeonTextBox1.Location = new Point(278, 55);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(186, 28);
            dungeonTextBox1.TabIndex = 6;
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(493, 31);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 9;
            label4.Text = "Teléfono";
            // 
            // dungeonTextBox2
            // 
            dungeonTextBox2.BackColor = Color.Transparent;
            dungeonTextBox2.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox2.EdgeColor = Color.White;
            dungeonTextBox2.Font = new Font("Tahoma", 11F);
            dungeonTextBox2.ForeColor = Color.DimGray;
            dungeonTextBox2.Location = new Point(493, 55);
            dungeonTextBox2.MaxLength = 32767;
            dungeonTextBox2.Multiline = false;
            dungeonTextBox2.Name = "dungeonTextBox2";
            dungeonTextBox2.ReadOnly = false;
            dungeonTextBox2.Size = new Size(186, 28);
            dungeonTextBox2.TabIndex = 8;
            dungeonTextBox2.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox2.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(493, 98);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 15;
            label5.Text = "Límite de crédito";
            // 
            // dungeonTextBox3
            // 
            dungeonTextBox3.BackColor = Color.Transparent;
            dungeonTextBox3.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox3.EdgeColor = Color.White;
            dungeonTextBox3.Font = new Font("Tahoma", 11F);
            dungeonTextBox3.ForeColor = Color.DimGray;
            dungeonTextBox3.Location = new Point(493, 122);
            dungeonTextBox3.MaxLength = 32767;
            dungeonTextBox3.Multiline = false;
            dungeonTextBox3.Name = "dungeonTextBox3";
            dungeonTextBox3.ReadOnly = false;
            dungeonTextBox3.Size = new Size(186, 28);
            dungeonTextBox3.TabIndex = 14;
            dungeonTextBox3.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox3.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(278, 98);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 13;
            label6.Text = "Dirección";
            // 
            // dungeonTextBox4
            // 
            dungeonTextBox4.BackColor = Color.Transparent;
            dungeonTextBox4.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox4.EdgeColor = Color.White;
            dungeonTextBox4.Font = new Font("Tahoma", 11F);
            dungeonTextBox4.ForeColor = Color.DimGray;
            dungeonTextBox4.Location = new Point(278, 122);
            dungeonTextBox4.MaxLength = 32767;
            dungeonTextBox4.Multiline = false;
            dungeonTextBox4.Name = "dungeonTextBox4";
            dungeonTextBox4.ReadOnly = false;
            dungeonTextBox4.Size = new Size(186, 28);
            dungeonTextBox4.TabIndex = 12;
            dungeonTextBox4.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox4.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(64, 98);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // dungeonTextBox5
            // 
            dungeonTextBox5.BackColor = Color.Transparent;
            dungeonTextBox5.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox5.EdgeColor = Color.White;
            dungeonTextBox5.Font = new Font("Tahoma", 11F);
            dungeonTextBox5.ForeColor = Color.DimGray;
            dungeonTextBox5.Location = new Point(64, 122);
            dungeonTextBox5.MaxLength = 32767;
            dungeonTextBox5.Multiline = false;
            dungeonTextBox5.Name = "dungeonTextBox5";
            dungeonTextBox5.ReadOnly = false;
            dungeonTextBox5.Size = new Size(186, 28);
            dungeonTextBox5.TabIndex = 10;
            dungeonTextBox5.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox5.UseSystemPasswordChar = false;
            // 
            // ucClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ucClientes";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox textbCodigoCliente;
        private Label label2;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox3;
        private Label label6;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox4;
        private Label label7;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox5;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox2;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
    }
}
