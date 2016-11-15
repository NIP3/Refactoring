using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKW.App.Presenters;
using PKW.Contracts;

namespace PKW.App.Views
{
    public interface ILoginView
    {
        event EventHandler CancelClicked;

        event EventHandler<int> LoginClicked;

        void LoadConstituencies(IEnumerable<Constituency> constituencies);

        void Exit();

        void ShowForm();
    }
}