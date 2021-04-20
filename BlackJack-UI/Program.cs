using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ServiceProvider provedor { get; private set; }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ConfigureInjection());
        }

        private static Form ConfigureInjection()
        {
            provedor = new ServiceCollection()
                .AddScoped<JuegoWPF>()
                .AddScoped<ConfiguracionWPF>()
                .BuildServiceProvider();
            
            return provedor.GetService<JuegoWPF>();
        }
    }
}
