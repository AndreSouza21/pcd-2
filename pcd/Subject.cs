using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcd
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string tipoDado)
        {
            foreach (var obs in observers)
            {
                // esse "codigo antigo" decide decide
                // o momento de disparar o metodo update de cada observer "codigo novo"

                obs.Update(this, tipoDado);
            }
        }
    }
}
