using CoreProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoreProject.ViewModel
{
    public abstract class ViewModelBase : IViewModel, IDisposable
    {
        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual bool Setproperty<T>(ref T storage,T value,[CallerMemberName]string propertyName=null )
        {
            if (object.Equals(storage, value)) return false;
            storage = value;
            OnPrpertyChanged(propertyName);
            return true;
        }

        private void OnPrpertyChanged([CallerMemberName]string propertyName = null)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void NavigatedFrom()
        {
            throw new NotImplementedException();
        }

        public void NavigatedTo()
        {
            throw new NotImplementedException();
        }
    }
}
