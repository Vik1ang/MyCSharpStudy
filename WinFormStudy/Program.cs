using System;
using System.Windows.Forms;
using WinFormStudy.MyForm;

namespace WinFormStudy
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MyForm2_3 myForm2_3 = new MyForm2_3();
            //MyForm3_1 myForm3_1 = new MyForm3_1();
            //MyForm3_2 myForm3_2 = new MyForm3_2();

            //var myForm = new MyForm4_1();
            //var myForm = new MyForm4_2();
            //var myForm = new MyForm4_3();

            //var myForm = new MyForm5_1();
            //var myForm = new MyForm5_2();
            //var myForm = new MyForm5_3();
            //var myForm = new MyForm5_4();

            var myForm = new MyForm6_2();
            Application.Run(myForm);
        }
    }
}