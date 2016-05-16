using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using Octokit.Helpers;
using Octokit.Internal;

namespace repo_checker
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

        public void repAddressesFunctioned(IModel m, ModelEventArgs e)
        {
            usersRepositoriesListBox.Items.Add("Название репозитория" + e.newrepAddresses);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public ListBox GetUserRepositoriesListBox()
        {
            return this.usersRepositoriesListBox;
        }

        private void showRepositoriesButton_Click(object sender, EventArgs e)
        {
            controller.model_work();
        }

        private void usersRepositoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
