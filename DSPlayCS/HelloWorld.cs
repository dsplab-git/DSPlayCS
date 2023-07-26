using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// for Print Form 
using static System.Console;

namespace DSPlayCS
{
    static class HelloWorld
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args) // (svm + tab + tab)
        {
            // Full Name  (Namespace.Class.Method)
            System.Console.WriteLine("HelloWorld0");

            // Basis Print Form (cw + tab + tab)
            Console.WriteLine("Hello World");

            // Print Form
            WriteLine("Hello World2");

            Console.WriteLine("{0}, {0}","Hello");

            Console.WriteLine("{1},{0},{1},{0}", "첫째", "둘째");
            

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

        }



    }
}
