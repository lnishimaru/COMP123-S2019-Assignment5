using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Assignment 5 - COMP123 - Summer 2019
/// name: Lilian Nishimaru de Souza
/// id  : 301044056
/// date: 07/24/2019   
/// </summary>
namespace DollarComputers
{
    public static class Program
    {
        public static Computers computers;
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // create an instance of the Forms Dictionary 
            computers = new Computers();

            Forms = new Dictionary<FormName, Form>();

            Forms.Add(FormName.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());

            Application.Run(Forms[FormName.SPLASH_SCREEN]);

        }
    }
}
