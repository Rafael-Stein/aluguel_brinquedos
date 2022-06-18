
namespace aluguel_brinquedos.UserInterface
{

    public partial class PrincipalUI : Form
    {

        private BrinquedosUI brinquedosUI;

        public PrincipalUI()
        {
            this.InitializeComponent();
        }

        private void menuItemCadastrosBrinquedos_Click(object sender, EventArgs e)
        {
            if(this.brinquedosUI == null)
            {
                this.brinquedosUI = new BrinquedosUI();
                this.brinquedosUI.Show();
            }
            else
            {
                this.brinquedosUI.BringToFront();
            }

            this.brinquedosUI.Location = new Point(this.Location.X + 150, this.Location.Y + 50);

        }
    }

}
