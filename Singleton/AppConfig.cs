namespace Singleton
{
    public class AppConfig
    {
        private static AppConfig? _instance;
        private Dictionary<string, string> _configuration;

        private AppConfig()
        {
            _configuration = new Dictionary<string, string>();
        }

        public static AppConfig GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppConfig();
            }

            return _instance;
        }

        public string? GetValue(string key)
        {
            if (_configuration.ContainsKey(key))
            {
                return _configuration[key];
            }

            return null;
        }

        public void SetValue(string key, string value)
        {
            if (_configuration.ContainsKey(key))
            {
                _configuration[key] = value;
            }
            else
            {
                _configuration.Add(key, value);
            }
        }
    }
}
