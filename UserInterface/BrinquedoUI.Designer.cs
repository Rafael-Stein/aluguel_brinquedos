namespace aluguel_brinquedos.UserInterface
{
    partial class BrinquedoUI
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
            this.groupBoxBrinquedos = new System.Windows.Forms.GroupBox();
            this.dataGridViewBrinquedos = new System.Windows.Forms.DataGridView();
            this.groupBoxDadosBrinquedo = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxBrinquedos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrinquedos)).BeginInit();
            this.groupBoxDadosBrinquedo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBrinquedos
            // 
            this.groupBoxBrinquedos.Controls.Add(this.dataGridViewBrinquedos);
            this.groupBoxBrinquedos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBrinquedos.Location = new System.Drawing.Point(15, 140);
            this.groupBoxBrinquedos.Name = "groupBoxBrinquedos";
            this.groupBoxBrinquedos.Size = new System.Drawing.Size(755, 410);
            this.groupBoxBrinquedos.TabIndex = 0;
            this.groupBoxBrinquedos.TabStop = false;
            this.groupBoxBrinquedos.Text = "  Brinquedos  ";
            // 
            // dataGridViewBrinquedos
            // 
            this.dataGridViewBrinquedos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrinquedos.Location = new System.Drawing.Point(15, 25);
            this.dataGridViewBrinquedos.Name = "dataGridViewBrinquedos";
            this.dataGridViewBrinquedos.RowTemplate.Height = 25;
            this.dataGridViewBrinquedos.Size = new System.Drawing.Size(725, 370);
            this.dataGridViewBrinquedos.TabIndex = 0;
            // 
            // groupBoxDadosBrinquedo
            // 
            this.groupBoxDadosBrinquedo.Controls.Add(this.buttonCancelar);
            this.groupBoxDadosBrinquedo.Controls.Add(this.buttonSalvar);
            this.groupBoxDadosBrinquedo.Controls.Add(this.buttonExcluir);
            this.groupBoxDadosBrinquedo.Controls.Add(this.buttonEditar);
            this.groupBoxDadosBrinquedo.Controls.Add(this.buttonNovo);
            this.groupBoxDadosBrinquedo.Controls.Add(this.textBoxQuantidade);
            this.groupBoxDadosBrinquedo.Controls.Add(this.labelQuantidade);
            this.groupBoxDadosBrinquedo.Controls.Add(this.textBoxNome);
            this.groupBoxDadosBrinquedo.Controls.Add(this.labelNome);
            this.groupBoxDadosBrinquedo.Controls.Add(this.textBoxID);
            this.groupBoxDadosBrinquedo.Controls.Add(this.labelID);
            this.groupBoxDadosBrinquedo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDadosBrinquedo.Location = new System.Drawing.Point(15, 10);
            this.groupBoxDadosBrinquedo.Name = "groupBoxDadosBrinquedo";
            this.groupBoxDadosBrinquedo.Size = new System.Drawing.Size(755, 125);
            this.groupBoxDadosBrinquedo.TabIndex = 1;
            this.groupBoxDadosBrinquedo.TabStop = false;
            this.groupBoxDadosBrinquedo.Text = "  Dados do Brinquedo  ";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Silver;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(540, 85);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(328, 85);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Firebrick;
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(434, 85);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 23);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Silver;
            this.buttonEditar.Enabled = false;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(222, 85);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 23);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonNovo.FlatAppearance.BorderSize = 0;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Location = new System.Drawing.Point(116, 85);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(100, 23);
            this.buttonNovo.TabIndex = 6;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Enabled = false;
            this.textBoxQuantidade.Location = new System.Drawing.Point(560, 22);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(50, 22);
            this.textBoxQuantidade.TabIndex = 5;
            this.textBoxQuantidade.Text = "0";
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(475, 25);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(77, 16);
            this.labelQuantidade.TabIndex = 4;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Location = new System.Drawing.Point(200, 22);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(250, 22);
            this.textBoxNome.TabIndex = 3;
            this.textBoxNome.Text = "Nome do brinquedo...";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(150, 25);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 16);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(75, 22);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(50, 22);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.Text = "0";
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(15, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 16);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Código:";
            // 
            // BrinquedosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxDadosBrinquedo);
            this.Controls.Add(this.groupBoxBrinquedos);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BrinquedosUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Brinquedos - Aluguel de Brinquedos";
            this.groupBoxBrinquedos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrinquedos)).EndInit();
            this.groupBoxDadosBrinquedo.ResumeLayout(false);
            this.groupBoxDadosBrinquedo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxBrinquedos;
        private DataGridView dataGridViewBrinquedos;
        private GroupBox groupBoxDadosBrinquedo;
        private Button buttonSalvar;
        private Button buttonExcluir;
        private Button buttonEditar;
        private Button buttonNovo;
        private TextBox textBoxQuantidade;
        private Label labelQuantidade;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxID;
        private Label labelID;
        private Button buttonCancelar;
    }
}