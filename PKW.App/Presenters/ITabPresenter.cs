using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PKW.App.Models;

namespace PKW.App.Presenters
{
    public interface ITabPresenter
    {
        bool HasViewOfType(Type type);

        void Initialize<T>(IConstituencyModel model, T view);
    }
}