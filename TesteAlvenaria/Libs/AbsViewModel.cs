using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlvenaria.Libs
{
    internal class AbsViewModel : INotifyPropertyChanged
    {
        #region Variables and Properties

        #endregion

        #region Constructors

        protected AbsViewModel()
        { }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }
}
