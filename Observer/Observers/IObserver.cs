﻿namespace Observer.Observers
{
    public interface IObserver
    {
        void Update(float temperature, float humidity);
    }
}
