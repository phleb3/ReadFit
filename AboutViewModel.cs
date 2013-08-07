using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using ReadFit.FileModel;

namespace ReadFit
{

    class AboutViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get { return "About"; }
        }

        MsgBoxService msgBoxobj;

        public AboutViewModel()
        {
            msgBoxobj = new MsgBoxService();
        }
    }
}
