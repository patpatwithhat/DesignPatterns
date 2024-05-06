﻿using Observer.Observers;

namespace Observer.Entities
{
    public class WeatherStation
    {
        private float _temperature;
        private float _humidity;
        private List<IObserver> _observers;

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity);
            }
        }

        public void SetMeasurements(float temperature, float humidity)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            NotifyObservers();
        }
    }

}
