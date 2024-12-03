using cs1;
using Application = System.Windows.Application;

class Program
{
    [STAThread]
    static void Main()
    {
        Application app = new();
        Window1 window = new();
        app.Run(window);
    }
}
