using System;

namespace CourseProject_MVC
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
    
    public class ViewEventArgs : EventArgs
    {
        public int index;
        public ViewEventArgs(int v) { index = v; }
    }

    public interface IView
    {
        event ViewHandler<IView> changed;
        void setController(IController cont);
    }
}
