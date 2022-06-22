namespace aluguel_brinquedos.UserInterface
{
    partial class ClienteUI
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
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.groupBoxDadosCliente.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.Controls.Add(this.labelEndereco);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxEndereco);
            this.groupBoxDadosCliente.Controls.Add(this.buttonCancelar);
            this.groupBoxDadosCliente.Controls.Add(this.buttonSalvar);
            this.groupBoxDadosCliente.Controls.Add(this.buttonExcluir);
            this.groupBoxDadosCliente.Controls.Add(this.buttonEditar);
            this.groupBoxDadosCliente.Controls.Add(this.buttonNovo);
            this.groupBoxDadosCliente.Controls.Add(this.textBox2);
            this.groupBoxDadosCliente.Controls.Add(this.labelTelefone);
            this.groupBoxDadosCliente.Controls.Add(this.textBox1);
            this.groupBoxDadosCliente.Controls.Add(this.labelNome);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxID);
            this.groupBoxDadosCliente.Controls.Add(this.labelID);
            this.groupBoxDadosCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(15, 10);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(755, 125);
            this.groupBoxDadosCliente.TabIndex = 3;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "  Dados do Cliente  ";
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
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(560, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "(51) 99999-9999";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(496, 25);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(58, 16);
            this.labelTelefone.TabIndex = 4;
            this.labelTelefone.Text = "Telefone:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(222, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Nome do cliente...";
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
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.dataGridViewClientes);
            this.groupBoxClientes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxClientes.Location = new System.Drawing.Point(15, 140);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(755, 410);
            this.groupBoxClientes.TabIndex = 2;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "  Clientes  ";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(15, 25);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowTemplate.Height = 25;
            this.dataGridViewClientes.Size = new System.Drawing.Size(725, 370);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Enabled = false;
            this.textBoxEndereco.Location = new System.Drawing.Point(222, 50);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(250, 22);
            this.textBoxEndereco.TabIndex = 11;
            this.textBoxEndereco.Text = "Endereço...";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(150, 53);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(66, 16);
            this.labelEndereco.TabIndex = 12;
            this.labelEndereco.Text = "Endereço:";
            // 
            // ClienteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxDadosCliente);
            this.Controls.Add(this.groupBoxClientes);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ClienteUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clientes - Aluguel de Brinquedos";
            this.groupBoxDadosCliente.ResumeLayout(false);
            this.groupBoxDadosCliente.PerformLayout();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxDadosCliente;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonExcluir;
        private Button buttonEditar;
        private Button buttonNovo;
        private TextBox textBox2;
        private Label labelTelefone;
        private TextBox textBox1;
        private Label labelNome;
        private TextBox textBoxID;
        private Label labelID;
        private GroupBox groupBoxClientes;
        private DataGridView dataGridViewClientes;
        private Label labelEndereco;
        private TextBox textBoxEndereco;
    }
}