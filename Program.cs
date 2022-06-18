using aluguel_brinquedos.UserInterface;

namespace aluguel_brinquedos;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new PrincipalUI());
    }    
}