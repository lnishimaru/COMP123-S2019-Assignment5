﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    static class Program
    {
        public static Computers computers;
        public static ComputersFields computerFields;
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

            Application.Run(Forms[FormName.SPLASH_SCREEN]);

        }
    }
}
