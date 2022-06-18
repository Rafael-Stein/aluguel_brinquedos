namespace aluguel_brinquedos.UserInterface
{
    partial class PrincipalUI
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuItemCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrosBrinquedos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrosClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrosItensContrato = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContratos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReceita = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLogotipo = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadastros,
            this.menuItemContratos,
            this.menuItemReceita});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(5);
            this.menuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuBar.Size = new System.Drawing.Size(124, 729);
            this.menuBar.TabIndex = 0;
            // 
            // menuItemCadastros
            // 
            this.menuItemCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadastrosBrinquedos,
            this.menuItemCadastrosClientes,
            this.menuItemCadastrosItensContrato});
            this.menuItemCadastros.Name = "menuItemCadastros";
            this.menuItemCadastros.Padding = new System.Windows.Forms.Padding(5);
            this.menuItemCadastros.Size = new System.Drawing.Size(113, 30);
            this.menuItemCadastros.Text = "Cadastros";
            this.menuItemCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuItemCadastrosBrinquedos
            // 
            this.menuItemCadastrosBrinquedos.Name = "menuItemCadastrosBrinquedos";
            this.menuItemCadastrosBrinquedos.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.menuItemCadastrosBrinquedos.Size = new System.Drawing.Size(183, 25);
            this.menuItemCadastrosBrinquedos.Text = "Brinquedos";
            // 
            // menuItemCadastrosClientes
            // 
            this.menuItemCadastrosClientes.Name = "menuItemCadastrosClientes";
            this.menuItemCadastrosClientes.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.menuItemCadastrosClientes.Size = new System.Drawing.Size(183, 25);
            this.menuItemCadastrosClientes.Text = "Clientes";
            // 
            // menuItemCadastrosItensContrato
            // 
            this.menuItemCadastrosItensContrato.Name = "menuItemCadastrosItensContrato";
            this.menuItemCadastrosItensContrato.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.menuItemCadastrosItensContrato.Size = new System.Drawing.Size(183, 25);
            this.menuItemCadastrosItensContrato.Text = "Itens do Contrato";
            // 
            // menuItemContratos
            // 
            this.menuItemContratos.Name = "menuItemContratos";
            this.menuItemContratos.Padding = new System.Windows.Forms.Padding(5);
            this.menuItemContratos.Size = new System.Drawing.Size(113, 30);
            this.menuItemContratos.Text = "Contratos";
            this.menuItemContratos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuItemReceita
            // 
            this.menuItemReceita.Name = "menuItemReceita";
            this.menuItemReceita.Padding = new System.Windows.Forms.Padding(5);
            this.menuItemReceita.Size = new System.Drawing.Size(113, 30);
            this.menuItemReceita.Text = "Receita";
            this.menuItemReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxLogotipo
            // 
            this.pictureBoxLogotipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxLogotipo.Location = new System.Drawing.Point(424, 234);
            this.pictureBoxLogotipo.MaximumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxLogotipo.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxLogotipo.Name = "pictureBoxLogotipo";
            this.pictureBoxLogotipo.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxLogotipo.TabIndex = 1;
            this.pictureBoxLogotipo.TabStop = false;
            // 
            // PrincipalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBoxLogotipo);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuBar;
            this.Name = "PrincipalUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel de Brinquedos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem menuItemCadastros;
        private ToolStripMenuItem menuItemCadastrosBrinquedos;
        private ToolStripMenuItem menuItemCadastrosClientes;
        private ToolStripMenuItem menuItemCadastrosItensContrato;
        private ToolStripMenuItem menuItemContratos;
        private ToolStripMenuItem menuItemReceita;
        private PictureBox pictureBoxLogotipo;
    }
}