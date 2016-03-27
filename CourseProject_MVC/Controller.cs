namespace CourseProject_MVC
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
            model.setindex(e.index);
        }

        public void model_work()
        {
            model.function_index();
        }
    }
}
