using JnrOvb.Demos.Management.WindowsForms.Views;

namespace JnrOvb.Demos.Management.WindowsForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormInitial());
    }
}