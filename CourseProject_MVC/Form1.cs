using System;
using System.Windows.Forms;

namespace CourseProject_MVC
{
    public partial class Form1 : Form, IView, IModelObserver
    {
        IController controller;
        public event ViewHandler<IView> changed;

        public void setController(IController cont)
        {
            controller = cont;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void indexFunctioned(IModel m, ModelEventArgs e)
        {
            textBox1.Text = "Вопрос номер " + e.newindex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.model_work();
        }
    }
}
