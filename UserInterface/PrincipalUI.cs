
namespace aluguel_brinquedos.UserInterface
{

    public partial class PrincipalUI : Form
    {
        
        //Atributos
        private BrinquedoUI brinquedoUI;
        private ClienteUI clienteUI;

        public PrincipalUI()
        {
            this.InitializeComponent();
        }

        private void menuItemCadastrosBrinquedo_Click(object sender, EventArgs e)
        {

            //Verificar se já existe uma instância da User Interface para não gerar multiplas telas
            if(this.brinquedoUI == null)
            {
                this.brinquedoUI = new BrinquedoUI();
                this.brinquedoUI.Show();
            }
            else
            {
                this.brinquedoUI.BringToFront();
            }

            this.brinquedoUI.Location = new Point(this.Location.X + 150, this.Location.Y + 50);

        }

        private void menuItemCadastrosCliente_Click(object sender, EventArgs e)
        {

            //Verificar se já existe uma instância da User Interface para não gerar multiplas telas
            if (this.clienteUI == null)
            {
                this.clienteUI = new ClienteUI();
                this.clienteUI.Show();
            }
            else
            {
                this.clienteUI.BringToFront();
            }

            this.clienteUI.Location = new Point(this.Location.X + 150, this.Location.Y + 50);

        }

    }

}
