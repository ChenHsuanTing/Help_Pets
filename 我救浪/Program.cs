using PetAdopt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 我救浪
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormPetAdopt());
            //Application.Run(new 後臺_Frm訂單管理());
            //Application.Run(new Frm_Shopping());
            Application.Run(new Frm浪浪管理());
        }
    }
}
