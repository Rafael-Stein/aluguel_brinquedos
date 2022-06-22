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
            this.menuItemCadastrosBrinquedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrosCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrosItensContrato = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContratos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReceita = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
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
            this.menuItemCadastrosBrinquedo,
            this.menuItemCadastrosCliente,
            this.menuItemCadastrosItensContrato});
            this.menuItemCadastros.Name = "menuItemCadastros";
            this.menuItemCadastros.Padding = new System.Windows.Forms.Padding(5);
            this.menuItemCadastros.Size = new System.Drawing.Size(113, 30);
            this.menuItemCadastros.Text = "Cadastros";
            this.menuItemCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuItemCadastrosBrinquedo
            // 
            this.menuItemCadastrosBrinquedo.Name = "menuItemCadastrosBrinquedo";
            this.menuItemCadastrosBrinquedo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.menuItemCadastrosBrinquedo.Size = new System.Drawing.Size(190, 25);
            this.menuItemCadastrosBrinquedo.Text = "Brinquedo";
            this.menuItemCadastrosBrinquedo.Click += new System.EventHandler(this.menuItemCadastrosBrinquedo_Click);
            // 
            // menuItemCadastrosCliente
            // 
            this.menuItemCadastrosCliente.Name = "menuItemCadastrosCliente";
            this.menuItemCadastrosCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.menuItemCadastrosCliente.Size = new System.Drawing.Size(190, 25);
            this.menuItemCadastrosCliente.Text = "Cliente";
            this.menuItemCadastrosCliente.Click += new System.EventHandler(this.menuItemCadastrosCliente_Click);
            // 
            // menuItemCadastrosItensContrato
            // 
            this.menuItemCadastrosItensContrato.Name = "menuItemCadastrosItensContrato";
            this.menuItemCadastrosItensContrato.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.menuItemCadastrosItensContrato.Size = new System.Drawing.Size(190, 25);
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
            // PrincipalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuBar;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "PrincipalUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel de Brinquedos";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem menuItemCadastros;
        private ToolStripMenuItem menuItemCadastrosBrinquedo;
        private ToolStripMenuItem menuItemCadastrosCliente;
        private ToolStripMenuItem menuItemCadastrosItensContrato;
        private ToolStripMenuItem menuItemContratos;
        private ToolStripMenuItem menuItemReceita;
    }
}