using ObserverSample.models;

namespace ObserverSample.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
