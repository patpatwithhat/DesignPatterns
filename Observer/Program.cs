using Observer.Entities;
using Observer.Observers;

WeatherStation weatherStation = new WeatherStation();
WeatherDisplay display = new WeatherDisplay();

weatherStation.RegisterObserver(display);

weatherStation.SetMeasurements(23.4f, 65.0f);
weatherStation.SetMeasurements(25.2f, 70.0f);

weatherStation.RemoveObserver(display);

weatherStation.SetMeasurements(22.1f, 60.0f); // Keine Ausgabe, da der Observer entfernt wurde.
