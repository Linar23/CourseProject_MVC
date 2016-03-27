using System;
using System.Windows.Forms;

namespace CourseProject_MVC
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

            Form1 view = new Form1();
            IModel model = new Model();
            IController controller = new Controller(view, model);
            Application.Run(view);
        }
    }
}
