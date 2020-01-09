using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Observable
    {
        protected string acao;
        protected List<IObserver> listObserver = new List<IObserver>();


        public void addObserver(object arg)
        {
            listObserver.Add(arg as IObserver);
        }

        public void setChanged(object arg)
        {
            this.acao = arg.ToString();

        }

        public void notifyObservers()
        {
            listObserver.ForEach(o =>
            {
                o.update(this as Observable, acao);
            });
        }


    }
}
