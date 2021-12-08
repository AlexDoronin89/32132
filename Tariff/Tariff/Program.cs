using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tariff.model;
using Tariff.Presenter;
using Tariff.View;

namespace Tariff
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormSigningUp formMain = new FormSigningUp();
            TariffData financeData = new TariffData();
            SignUpPresenter presenter = new SignUpPresenter(financeData, formMain);
            Application.Run(formMain);
        }
    }
}
