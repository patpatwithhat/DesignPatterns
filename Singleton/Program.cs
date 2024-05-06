

using Singleton;

AppConfig.GetInstance().SetValue("DatabaseConnectionString", "Server=myServerAddress;Database=myDataBase;");
AppConfig.GetInstance().SetValue("ApiKey", "12345-abcdef");

// Abrufen und Ausgeben von Werten
Console.WriteLine("Database Connection String: " + AppConfig.GetInstance().GetValue("DatabaseConnectionString"));
Console.WriteLine("API Key: " + AppConfig.GetInstance().GetValue("ApiKey"));

// Erneuter Zugriff auf die Singleton-Instanz in einer neuen Variable
var config = AppConfig.GetInstance();
Console.WriteLine("API Key from new reference: " + config.GetValue("ApiKey"));

// Demonstration, dass beide Referenzen auf dasselbe Objekt zeigen
Console.WriteLine("Are both references the same? " + (AppConfig.GetInstance() == config));
