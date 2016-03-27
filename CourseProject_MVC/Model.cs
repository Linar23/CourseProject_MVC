using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_MVC
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public int newindex;

        public ModelEventArgs(int i)
        {
            newindex = i;
        }
    }

    public interface IModelObserver
    {
        void indexFunctioned(IModel model, ModelEventArgs e);
    }

    public interface IModel
    {
        void attach(IModelObserver imo);
        void function_index();
        void setindex(int i);
    }

    public class Model : IModel
    {
        public event ModelHandler<Model> changed;
        int index;

        public Model()
        {
            index = 0;
        }

        public void setindex(int i)
        {
            index = i;
        }

        // Функция перехода к следующему вопросу согласно работе модели
        // Пока что это просто инкримент
        public void function_index()
        {
            index++;
            changed.Invoke(this, new ModelEventArgs(index));
        }

        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<Model>(imo.indexFunctioned);
        }
    }
}
