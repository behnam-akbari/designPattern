﻿using ObserverSample.Observer;

namespace ObserverSample.models
{
    public interface ISubject
    {
        void Attach(IObserver observer);

        // Detach an observer from the subject.
        void Detach(IObserver observer);

        // Notify all observers about an event.
        void Notify();
    }
}
