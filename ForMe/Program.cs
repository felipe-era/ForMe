namespace ForMe;

internal static class Program
{
    /// <summary>
    ///  Inicializa a thread.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmMenuMain());
    }
}