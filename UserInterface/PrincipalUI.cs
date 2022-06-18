
namespace aluguel_brinquedos.UserInterface
{

    public partial class PrincipalUI : Form
    {

        public PrincipalUI()
        {
            this.InitializeComponent();

            //Centralizar a PictureBox do logotipo
            int height = ((this.Size.Height / 2) - this.pictureBoxLogotipo.Height) + 124;
            int width = (this.Size.Width - this.pictureBoxLogotipo.Width) / 2;

            this.pictureBoxLogotipo.Location = new Point(width, height);
        }

    }

}
