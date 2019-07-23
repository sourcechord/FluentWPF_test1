using SourceChord.FluentWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FluentWPFTest
{
    public class Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            System.Windows.Application app = new System.Windows.Application();
            app.Run(new MainWindow());
        }
    }

    public class MainWindow : AcrylicWindow
    {
    }
}
