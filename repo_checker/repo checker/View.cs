using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repo_checker
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public class ViewEventArgs : EventArgs
    {
        public int repAddresses;
        public ViewEventArgs(int v) { repAddresses = v; }
    }

    public interface IView
    {
        event ViewHandler<IView> changed;
        void setController(IController cont);
    }
}
