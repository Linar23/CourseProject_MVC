using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repo_checker
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public int newrepAddresses;

        public ModelEventArgs(int repAddresses)
        {
            newrepAddresses = repAddresses;
        }
    }

    public interface IModelObserver
    {
        void repAddressesFunctioned(IModel model, ModelEventArgs e);
    }

    public interface IModel
    {
        void attach(IModelObserver imo);
        void function_repAddresses();
        void setrepAddresses(int i);
    }

    public class Model : IModel
    {
        public event ModelHandler<Model> changed;
        int repAddresses;

        public Model()
        {
            repAddresses = 0;
        }

        public void setrepAddresses(int i)
        {
            repAddresses = i;
        }

        // Функция,которая вставляет список репозиториев в usersRepositoriesListBox
        public void function_repAddresses()
        {
            repAddresses++;
            changed.Invoke(this, new ModelEventArgs(repAddresses));
        }

        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<Model>(imo.repAddressesFunctioned);
        }
    }
}
