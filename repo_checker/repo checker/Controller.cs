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
    public interface IController
    {
        void model_work();
    }

    public class Controller : IController
    {
        IView view;
        IModel model;

        public Controller(IView v, IModel m)
        {
            view = v;
            model = m;
            view.setController(this);
            model.attach((IModelObserver)view);
            view.changed += new ViewHandler<IView>(this.view_changed);
        }

        public void view_changed(IView v, ViewEventArgs e)
        {
            model.setrepAddresses(e.repAddresses);
        }

        public void model_work()
        {
            model.function_repAddresses();
        }
    }
}

