using aluguel_brinquedos.UserInterface;

namespace aluguel_brinquedos;

public static class Program
{

    [STAThread]
    public static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new PrincipalUI());
    }

}