using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTDFFB_20220318_CompStore
{
    public static class Global
    {
        public static FormControl formControl;

        public static FormCart formCart;

        public static String itemType = "Összes";

        public static List<Item> shoppingCart = new List<Item>();
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Global.formControl = new FormControl();
            Application.Run(Global.formControl);
        }
    }
}
