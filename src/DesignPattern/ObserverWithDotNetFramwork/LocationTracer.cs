using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverWithDotNetFramwork
{
    class LocationTracer : IObservable<Location>
    {
        List<IObserver<Location>> Observers;

        public LocationTracer()
        {
            Observers = new List<IObserver<Location>>();
        }
        public IDisposable Subscribe(IObserver<Location> observer)
        {
            
        }
    }
}
