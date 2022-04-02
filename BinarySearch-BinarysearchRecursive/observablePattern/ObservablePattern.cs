using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_BinarysearchRecursive
{
    internal class ObservablePattern : IObservable<string>
    {
        public ObservablePattern()
        {
            observers = new List<IObserver<string>>();
        }

        private List<IObserver<string>> observers;

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<string>> _observers;
            private IObserver<string> _observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        //public void TrackLocation(Nullable<string> loc)
        //{
        //    foreach (var observer in observers)
        //    {
        //        if (!loc.HasValue)
        //            observer.OnError(new LocationUnknownException());
        //        else
        //            observer.OnNext(loc.Value);
        //    }
        //}

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
