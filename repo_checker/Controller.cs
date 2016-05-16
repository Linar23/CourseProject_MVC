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
    class Controller
    {
        private Form1 _view;

        public Controller(Form1 view)
        {
            this._view = view;
            this._view.PrintRepositoriesByUser += GetRepositoriesByUser;
        }

        private async void GetRepositoriesByUser()
        {
            var ghe = new Uri("https://github.com/");
            var client = new GitHubClient(new ProductHeaderValue(_view.GetUsername()), ghe);
            var test = await client.Repository.Content.GetAllContents(_view.GetUsername(), ghe);

            var repos = await client.Repository.GetAllForUser(_view.GetUsername());

            //DateTimeOffset data;
            foreach (var repository in repos)
            {
                _view.GetUserRepositoriesListBox().Items.Add(repository.Name);
            }
        }
    }
}

